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
    public partial class Vente : Form
    {
        public Vente()
        {
            InitializeComponent();
        }
        int quan = 0;
        int codeQ = 0;
        string nomM = "";
        int codeList2, quantList2;
        string nomList2 = "";

        SqlDataAdapter ad = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dtQuan = new DataTable();
        DataTable dt1 = new DataTable();


        #region Load
        private void Vente_Load(object sender, EventArgs e)
        {
            chargCont();
            #region Charge ComboBox
            Program.remlis_comb(cmbx_client, "select * from Client where LEFT(cin,1)<>'@'", "cin", "nom");
            Program.remlis_comb(cmbx_medicament, "select * from famillMedic", "codeF", "nom");
            #endregion
            radioB_oui.Checked = true;
            Program.cin = "";
        } 
        #endregion

        #region Function pour info archive
        public void InfoArchive(string ch)
        {
            try
            {
                string nomC = "", teleC = "";

                if (Program.cn.State != ConnectionState.Open) { Program.cn.Open(); }
                SqlCommand cm = new SqlCommand("select nom, tele from Client where cin='" + ch + "'", Program.cn);
                SqlDataReader dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    nomC = dr[0].ToString();
                    teleC = dr[1].ToString();
                    dr.Close();
                }
                else { dr.Close(); }

                foreach (string item in listBox2.Items)
                {
                    int codeM = int.Parse(string.Format("{0}", item.ToString().Split(new string[] { "- | -" }, StringSplitOptions.None)[0]));
                    string nomM = string.Format("{0}", item.Split(new string[] { "- | -" }, StringSplitOptions.None)[1]);
                    int qnt = int.Parse(string.Format("{0}", item.Split(new string[] { "- | -" }, StringSplitOptions.None)[2]));

                    SqlCommand cmn = new SqlCommand("select prix from Medicament where codeM = " + codeM + "", Program.cn);
                    decimal prix = decimal.Parse(cmn.ExecuteScalar().ToString());
                    string chaine = "insert into ArchiveVT values('" + ch + "','" + nomC + "','" + teleC + "'," + codeM + ",'" + nomM + "'," + prix.ToString().Replace(",", ".") + "," + qnt + "," + label_PrixTotal.Text.ToString().Replace(",", ".") + ",CONVERT(date, GETDATE()))";
                    SqlCommand cmd = new SqlCommand(chaine, Program.cn);
                    int a = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region Button ajouter
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count >0)
            {
                SqlDataAdapter ad1 = new SqlDataAdapter();
                DataTable dtQauntiUp = new DataTable();
                string client = "";
                if (Program.cn.State != ConnectionState.Open) { Program.cn.Open(); }
                if (radioB_non.Checked)
                {
                    SqlCommand cmCl = new SqlCommand("SELECT max(SUBSTRING(cin, 2, 100)) from client where LEFT(cin, 1) = '@' ", Program.cn);
                    client = "@" + (int.Parse(cmCl.ExecuteScalar().ToString()) + 1).ToString();

                    SqlCommand cmCLie = new SqlCommand("insert into Client values( '" + client + "','Client non pris en charge','xxxxxxxxxx','xxxxxxx')", Program.cn);
                    cmCLie.ExecuteNonQuery();
                }
                else
                {
                    if (cmbx_client.Text != "")
                    {
                        client = cmbx_client.SelectedValue.ToString();
                    }
                }
                foreach (string item in listBox2.Items)
                {

                    int code = int.Parse(string.Format("{0}", item.ToString().Split(new string[] { "- | -" }, StringSplitOptions.None)[0]));
                    int quant = int.Parse(string.Format("{0}", item.Split(new string[] { "- | -" }, StringSplitOptions.None)[2]));
                    SqlCommand cmInser = new SqlCommand("insert into vente values('" + DateTime.Today.ToString("yyyy-MM-dd") + "', '" + client + "' , " + code + "," + quant + " , " + label_PrixTotal.Text.Replace(",", ".") + ")", Program.cn);
                    int a = cmInser.ExecuteNonQuery();
                    if (a != 0)
                    {
                        if (dtQauntiUp.Rows != null) { dtQauntiUp.Clear(); }
                        if (Program.cn.State != ConnectionState.Open) { Program.cn.Open(); }
                        #region deconecter
                        ad1.SelectCommand = new SqlCommand("select * from stock where codeM =" + code + " and date_ex >=DATEADD(DAY, 15, GETDATE()) and quantite <> 0 order by quantite desc", Program.cn);
                        ad1.Fill(ds, "st");
                        dtQauntiUp = ds.Tables["st"];
                        dtQauntiUp.PrimaryKey = new DataColumn[] { dtQauntiUp.Columns["idS"] };
                        #endregion
                        SqlCommand cm = new SqlCommand("select * from stock where codeM =" + code + " and date_ex >=DATEADD(DAY, 15, GETDATE()) and quantite <> 0 order by quantite desc", Program.cn);
                        SqlDataReader dr = cm.ExecuteReader();
                        if (dr.HasRows)
                        {
                            int cal = 0;
                            while (dr.Read())
                            {
                                int idS = int.Parse(dr[0].ToString());
                                int q = int.Parse(dr[1].ToString());
                                int rest = 0;
                                if (quant == 0)
                                {
                                    dr.Close();
                                    break;
                                }
                                else
                                {
                                    if (q >= quant)
                                    {
                                        dr.Close();
                                        #region
                                        DataRow row = dtQauntiUp.Rows.Find(idS);
                                        rest = (q - quant);
                                        row["quantite"] = rest;
                                        #endregion
                                        break;
                                    }
                                    else
                                    {
                                        cal = quant - q;
                                        DataRow row = dtQauntiUp.Rows.Find(idS);
                                        row["quantite"] = 0;
                                        quant = cal;
                                    }
                                }
                            }
                            SqlCommandBuilder cb = new SqlCommandBuilder(ad1);
                            ad1.Update(ds.Tables["st"]);
                        }
                        dr.Close();
                    }
                }
                InfoArchive(client);
                listBox2.Items.Clear();
                chargeLisBox();
                Program.cin = client;

                DeskTop dsk = (DeskTop)Application.OpenForms["DeskTop"];
                dsk.btn_imprimer.PerformClick();
                /*dsk.btn_imprimer_Click(dsk.passobj, dsk.passeargs);*/
                
            }
            
        }
        #endregion

        #region method charger lisbox1
        private void chargeLisBox()
        {
            if (Program.cn.State != ConnectionState.Open) { Program.cn.Open(); }
            SqlCommand cm1 = new SqlCommand(" select CAST(s.codeM as varchar)+'- | -'+nom  from  Medicament m inner join stock s on(m.codeM = s.codeM)where s.date_ex >=GETDATE() and code_f =" + cmbx_medicament.SelectedValue + " and s.quantite <>0 group by  s.codeM,nom ", Program.cn);
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
        #endregion

        #region Charge cont
        public void chargCont()
        {
            if (Program.cn.State != ConnectionState.Open) { Program.cn.Open(); }
            ad.SelectCommand = new SqlCommand("select  SUM(quantite) as  qun ,m.codeM as 'codeM'  from Medicament m inner join stock s on(m.codeM = s.codeM)where s.date_ex >=DATEADD(DAY,15,GETDATE())  group by  s.codeM,m.codeM ", Program.cn);
            ad.Fill(ds, "quantite");
            dtQuan = ds.Tables["quantite"];
            dtQuan.PrimaryKey = new DataColumn[] { dtQuan.Columns["codeM"] };
            //  if (dtQuan.Rows.Find(1070) == null) { MessageBox.Show("ce numero n'exist pas"); }
        } 
        #endregion

        #region checked si notre client ou  non
        private void radioB_oui_CheckedChanged(object sender, EventArgs e)
        {
            changeRadio();
        }

        private void radioB_non_CheckedChanged(object sender, EventArgs e)
        {
            changeRadio();
        }

        public void changeRadio()
        {
            if (radioB_non.Checked)
            {
                panel3.Hide();
            }
            else if (radioB_oui.Checked)
            {
                panel3.Show();
            }
            else
            {
                MessageBox.Show("cochée oui  ou non!", "erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        } 
        #endregion

        #region Charge lesbox1 par choisie un famille medicament
        private void cmbx_medicament_SelectionChangeCommitted(object sender, EventArgs e)
        {
            chargeLisBox();
        } 
        #endregion

        #region gere le medicament selectionne dans listebox1 
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int code = int.Parse(string.Format("{0}", listBox1.SelectedItem.ToString().Split(new string[] { "- | -" }, StringSplitOptions.None)[0]));
            DataRow row = dtQuan.Rows.Find(code);
            codeQ = code;
            quan = int.Parse(row["qun"].ToString());
            nomM = string.Format("{0}", listBox1.SelectedItem.ToString().Split(new string[] { "- | -" }, StringSplitOptions.None)[1]);
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = quan;
        } 
        #endregion

        #region gere les medicament dans lisbox2
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
        #endregion

        #region calcule le montant des medicament
        decimal prixTotal;
        public decimal calcul()
        {
            prixTotal = 0;
            if (Program.cn.State != ConnectionState.Open) { Program.cn.Open(); }
            foreach (string item in listBox2.Items)
            {
                decimal prix=0;
                int quant =0, code= 0;
                code = int.Parse(string.Format("{0}", item.Split(new string[] { "- | -" }, StringSplitOptions.None)[0]));
                quant = int.Parse(string.Format("{0}", item.Split(new string[] { "- | -" }, StringSplitOptions.None)[2]));
                SqlCommand cmn = new SqlCommand("select prix from Medicament where codeM = " + code+"", Program.cn);
                prix = decimal.Parse(cmn.ExecuteScalar().ToString());
                prixTotal = prixTotal+(prix * quant);
            }
            Program.cn.Close();
            return prixTotal;
        } 
        #endregion

        #region Button right
        private void btn_right_Click(object sender, EventArgs e)
        {
            
            if (numericUpDown1.Value != 0)
            {
                if (listBox1.SelectedIndex!=-1)
                {
                    DataRow row = dtQuan.Rows.Find(codeQ);
                    quan = int.Parse(row["qun"].ToString());
                    row["qun"] = (quan - int.Parse(numericUpDown1.Text.ToString())).ToString();
                    if (listBox2.Items.Count != 0)
                    {
                        int ex = -1, indice = -2;
                        string nom = "";
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
                            quant += int.Parse(numericUpDown1.Text);
                            listBox2.Items.RemoveAt(ex);
                            listBox2.Items.Insert(ex, code.ToString() + "- | -" + nom + "- | -" + quant);
                        }
                        else
                        {
                            listBox2.Items.Add(codeQ + "- | -" + nomM + "- | -" + numericUpDown1.Text.ToString());
                            ex++;
                        }
                        numericUpDown1.Value = 0;
                    }
                    else
                    {
                        listBox2.Items.Add(codeQ + "- | -" + nomM + "- | -" + numericUpDown1.Text.ToString());
                    }
                    numericUpDown1.Minimum = 0;
                    numericUpDown1.Maximum = int.Parse(row["qun"].ToString());

                    label_PrixTotal.Text = calcul().ToString();
                }
                else
                {
                    MessageBox.Show("choisie la  quntite !!", "Erreur!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
            else
            {
                MessageBox.Show(" Choisie la quantité ou selectionne un médicament dans la list a gauche!", "Erreur!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion

        #region Button left
        private void btn_left_Click(object sender, EventArgs e)
        {

            if (listBox2.SelectedIndex!=-1)
            {
                if (numericUpDown1.Value != 0)
                {
                    if (listBox2.SelectedItem != null)
                    {

                        DataRow row = dtQuan.Rows.Find(codeList2);
                        row["qun"] = int.Parse(row["qun"].ToString()) + int.Parse(numericUpDown1.Text.ToString());
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
                    numericUpDown1.Text = "0";
                    label_PrixTotal.Text = calcul().ToString();
                }
                else
                {
                    MessageBox.Show("choisie la  quntite !!", "Erreur!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
            else
            {
                MessageBox.Show("Selectionne un médicament dans la list a droit", "Erreur!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion

    }
}
