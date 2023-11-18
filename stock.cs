using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestion_de_pharmacie
{
    public partial class stock : Form
    {
        public stock()
        {
            InitializeComponent();
        }
        public void selectQuan()
        {
            if (Program.cn.State != ConnectionState.Open) { Program.cn.Open(); }

            SqlCommand cm = new SqlCommand("select quantite from stock where codeM='" + comboBox1.SelectedValue + "'", Program.cn);
            //int a = int.Parse(cm.ExecuteScalar().ToString());

        }
        private void stock_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            Grid();
            Program.Format_datagrie(dataGridView1);
            /*for (int i=1;i<=5000;i++)
            domainUpDown1.Items.Add(i);
            domainUpDown1.SelectedIndex = 0;*/
            Program.remlis_comb(comboBox1, "select * from Medicament", "codeM", "nom");
            selectQuan();
        }

        #region Remplier dataGrid
        private void Grid() { Program.remlis_Gried(dataGridView1, "select idS as'Numéro STK', quantite as'Qauntité', m.nom as'Nom MD', date_ex as'D.Experation' from stock s inner join Medicament m on(s.codeM = m.codeM) where quantite <> 0"); }
        #endregion

        #region Button ajouter
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || numericUpDown1.Value == 0)
            {
                MessageBox.Show("champs vide!!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Program.Ver("select* from  stock where date_ex='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and codeM='" + comboBox1.SelectedValue + "'"))
            {
                MessageBox.Show("Le medicament deja existe dans le stock  !!!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Program.btn_ajouter("insert into stock values (" + int.Parse(numericUpDown1.Text) + "," + comboBox1.SelectedValue + ",'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "')");
                    Grid();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region Button supprimer
        private void btn_sup_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Selection le stock dans la liste que vous voulez supprimer!!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Program.btn_suprm("delete from  stock where ids=" + int.Parse(textBox1.Text) + "");
                    Grid();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region Button modofier par quantite
        private void btn_mdfQ_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == string.Empty || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show(" Selection le stock dans la liste que vous voulez modifier !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (Program.Ver("select *  from  stock where ids=" + int.Parse(textBox1.Text) + " and codeM=" + comboBox1.SelectedValue + ""))
                    {
                        Program.btn_mdf("update stock set quantite=" + int.Parse(numericUpDown1.Text) + " where ids=" + int.Parse(textBox1.Text) + " and codeM=" + comboBox1.SelectedValue + "");
                        Grid();
                    }
                    else
                    {
                        MessageBox.Show(" id que  vous avez saisie incorrecte  verfie  id  de stock !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region Button modifier par date
        private void btn_mdfD_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == string.Empty || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show(" Selection le stock dans la liste que vous voulez modifier !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (Program.Ver("select *  from  stock where ids=" + int.Parse(textBox1.Text) + " and codeM=" + comboBox1.SelectedValue + ""))
                    {
                        Program.btn_mdf("update stock set date_ex='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' where ids=" + int.Parse(textBox1.Text) + " and codeM=" + comboBox1.SelectedValue + "");
                        Grid();

                    }
                    else
                    {
                        MessageBox.Show(" id que  vous avez saisie incorrecte  verfie  id  de stock !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region Button recherch par medicament
        private void btn_medicament_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show(" choisie un medicament !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Program.remlis_Gried(dataGridView1, "select idS as'Numéro STK', quantite as'Qauntité', codeM as'Numéro MD', date_ex as'D.Experation' from stock where codeM=" + comboBox1.SelectedValue + "");
                //Grid();
            }
        }
        #endregion

        #region Button recherhe par date
        private void btn_date_Click(object sender, EventArgs e)
        {
            Program.remlis_Gried(dataGridView1, "select idS as'Numéro STK', quantite as'Qauntité', codeM as'Numéro MD', date_ex as'D.Experation' from stock where date_ex='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'");
            //Grid();
        }
        #endregion

        #region Remplie les champs
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                numericUpDown1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            }
        }
        #endregion


        #region Function return nom de medicament
        public string Nom_Medicament(int b)
        {
            if (Program.cn.State != ConnectionState.Open) { Program.cn.Open(); }
            SqlCommand cm = new SqlCommand("select nom from  Medicament where codeM=" + b + "", Program.cn);
            string a = cm.ExecuteScalar().ToString();
            Program.cn.Close();
            return a;
        }
        #endregion

        #region Gere la quantite et la date de stock avec les coleur
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[3].Value != null && row.Cells[1].Value != null)
                {
                    string date = row.Cells[3].Value.ToString();
                    DateTime date1 = DateTime.Parse(date.ToString());
                    //stock betwenn 1--10
                    if ((Convert.ToInt32(row.Cells[1].Value) > 1 && Convert.ToInt32(row.Cells[1].Value) <= 10))
                    {
                        // stock 1---10 and date exp 
                        if (DateTime.Parse(DateTime.Now.AddDays(15).ToString("dd/MM/yyyy")) >= DateTime.Parse(date1.ToString("dd/MM/yyyy")) && DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy")) >= DateTime.Parse(date1.ToString("dd/MM/yyyy")))
                        {
                            row.DefaultCellStyle.ForeColor = Color.Black;
                            row.DefaultCellStyle.BackColor = Color.Blue;

                            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor;

                        }
                        else
                        {
                            row.DefaultCellStyle.ForeColor = Color.Black;
                            row.DefaultCellStyle.BackColor = Color.Red;

                            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor;
                        }
                    }
                    //ba9i lih 15 jours 
                    if (DateTime.Parse(DateTime.Now.AddDays(15).ToString("dd/MM/yyyy")) >= DateTime.Parse(date1.ToString("dd/MM/yyyy")) && DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy")) <= DateTime.Parse(date1.ToString("dd/MM/yyyy")))
                    {
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        row.DefaultCellStyle.BackColor = Color.Green;

                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor;
                    }
                    //date exper
                    if (DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy")) > DateTime.Parse(date1.ToString("dd/MM/yyyy")) && !(Convert.ToInt32(row.Cells[1].Value) > 1 && Convert.ToInt32(row.Cells[1].Value) <= 10))
                    {
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        row.DefaultCellStyle.BackColor = Color.Yellow;

                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor;
                    }

                }
            }


        } 
        #endregion


    }
}