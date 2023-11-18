using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gestion_de_pharmacie
{
    public partial class Vente1 : Form
    {
        public Vente1()
        {
            InitializeComponent();
        }

        private void Vente1_Load(object sender, EventArgs e)
        {
            
            chargeLisBox();
            charg();
        }

        SqlDataAdapter ad = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dtQuan = new DataTable();
        DataTable dt1 = new DataTable();



        public void charg()
        {


            if (Program.cn.State != ConnectionState.Open) { Program.cn.Open(); }
            ad.SelectCommand = new SqlCommand("select  SUM(quantite) as  qun ,m.codeM as 'codeM'  from Medicament m inner join stock s on(m.codeM = s.codeM)where s.date_ex >=GETDATE()  group by  s.codeM,m.codeM ", Program.cn);
            ad.Fill(ds, "quantite");
            dtQuan = ds.Tables["quantite"];
            dtQuan.PrimaryKey = new DataColumn[] { dtQuan.Columns["codeM"] };
            //  if (dtQuan.Rows.Find(1070) == null) { MessageBox.Show("ce numero n'exist pas"); }
        }

        private void chargeLisBox()
        {
            if (Program.cn.State != ConnectionState.Open) { Program.cn.Open(); }
            SqlCommand cm1 = new SqlCommand("select CAST(codeM as varchar)+'- | -'+nom  from  Medicament", Program.cn);
            SqlDataReader dr1 = cm1.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(dr1);
            listBox1.Items.Clear();
            foreach (DataRow d in dt1.Rows)
            {
                listBox1.Items.Add(d[0]);
            }
            dr1.Close();
            Program.cn.Close();
        }
        int quan = 0;
        int codeQ = 0;
        string nomM = "";

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != null)
            {
                int code = int.Parse(string.Format("{0}", listBox1.SelectedItem.ToString().Split(new string[] { "- | -" }, StringSplitOptions.None)[0]));

                DataRow row = dtQuan.Rows.Find(code);
                codeQ = code;
                quan = int.Parse(row["qun"].ToString());
                nomM = string.Format("{0}", listBox1.SelectedItem.ToString().Split(new string[] { "- | -" }, StringSplitOptions.None)[1]);
                numericUpDown1.Minimum = 0;
                numericUpDown1.Maximum = quan;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //listBox2.Items.Add(codeQ + "- | -" + nomM + "- | -" + numericUpDown1.Text.ToString());

            DataRow row = dtQuan.Rows.Find(codeQ);
            row["qun"] = (quan - int.Parse(numericUpDown1.Text.ToString())).ToString();
            quan = int.Parse(row["qun"].ToString());

            if (listBox2.Items.Count !=0)
            {
                int ex = -1 , indice =-2;
               
                string nom ="";
                int code = 0;
                int quant = 0;
                foreach (string item in listBox2.Items)
                {

                    nom = string.Format("{0}", listBox1.SelectedItem.ToString().Split(new string[] { "- | -" }, StringSplitOptions.None)[1]);
                    code = int.Parse(string.Format("{0}", listBox1.SelectedItem.ToString().Split(new string[] { "- | -" }, StringSplitOptions.None)[0]));
                    quant = int.Parse(string.Format("{0}", item.Split(new string[] { "- | -" }, StringSplitOptions.None)[2]));
                   if (int.Parse(string.Format("{0}", item.Split(new string[] { "- | -" }, StringSplitOptions.None)[0])) == code)
                   {
                       indice = ex;
                       ex++;
                       break;
                   }
                   ex++;

                }
                if (indice != -2)
                {
                    
                    quant +=int.Parse( numericUpDown1.Text);
                    MessageBox.Show("Test"+quant);
                    listBox2.Items.RemoveAt(ex);
                    listBox2.Items.Insert(ex, code.ToString() + "- | -" + nom + "- | -" + quant);
                }
                else
                {
                    listBox2.Items.Add(codeQ + "- | -" + nomM + "- | -" + numericUpDown1.Text.ToString());
                    ex++;
                }
                

            }
            else
	        {
                listBox2.Items.Add(codeQ + "- | -" + nomM + "- | -" + numericUpDown1.Text.ToString());
	        }

            
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = int.Parse(row["qun"].ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {

                DataRow row = dtQuan.Rows.Find(codeList2);
                row["qun"] = int.Parse(row["qun"].ToString()) + quantList2;
                numericUpDown1.Minimum = 0;
                numericUpDown1.Maximum = int.Parse(row["qun"].ToString());
                int ind = listBox2.SelectedIndex;
                listBox2.Items.RemoveAt(ind);
                quantList2 -= int.Parse(numericUpDown1.Text.ToString());
                if (quantList2 != 0)
                {
                    listBox2.Items.Insert(ind, codeList2.ToString() + "- | -" + nomList2 + "- | -" + quantList2.ToString());
                }
            }
        }

        int codeList2, quantList2;
        string nomList2 = "";
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox2.SelectedItem != null)
            {
                nomList2 = string.Format("{0}", listBox2.SelectedItem.ToString().Split(new string[] { "- | -" }, StringSplitOptions.None)[1]);
                codeList2 = int.Parse(string.Format("{0}", listBox2.SelectedItem.ToString().Split(new string[] { "- | -" }, StringSplitOptions.None)[0]));
                quantList2 = int.Parse(string.Format("{0}", listBox2.SelectedItem.ToString().Split(new string[] { "- | -" }, StringSplitOptions.None)[2]));
            
                numericUpDown1.Minimum = 0;
                numericUpDown1.Maximum = quantList2;
            }
        

        }






    }
}
