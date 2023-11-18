using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Gestion_de_pharmacie
{
    public partial class medicam : Form
    {
        public medicam()
        {
            InitializeComponent();
        }

        #region Load
        private void medicam_Load(object sender, EventArgs e)
        {
            Program.Format_datagrie(dataGridView1);
            Program.remlis_Gried(dataGridView1, "select codeM as 'Numéro MD', nom as 'Nom MD', code_f as 'Numéro F.MD', Rayon , prix as 'Prix' from Medicament ");
            #region remplisage Rayoun
            for (char x = 'A'; x <= 'Z'; x++)
            {
                cmb_ray.Items.Add(x);
            }
            #endregion

            #region remplisage medicament famille
            Program.remlis_comb(cmb_fam, "select * from famillMedic", "codeF", "nom");
            #endregion

        } 
        #endregion



        #region button ajouter
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_id.Text.Trim() == string.Empty || txt_nom.Text.Trim() == string.Empty || txt_prx.Text.Trim() == string.Empty || cmb_fam.SelectedIndex == -1 || cmb_ray.SelectedIndex == -1)
            {
                MessageBox.Show("champs vide!!" ,"Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                if (Program.Ver("select * from Medicament where codeM = " + int.Parse(txt_id.Text)))
                {
                    MessageBox.Show("Existe déjà!" ,"Erreur!",MessageBoxButtons.OK , MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        string prix = txt_prx.Text.ToString();
                        Program.btn_ajouter("insert into Medicament values (" + int.Parse(txt_id.Text) + ",'" + txt_nom.Text + "'," + cmb_fam.SelectedValue + ",'" + cmb_ray.SelectedItem + "'," + txt_prx.Text + ")");
                        Program.remlis_Gried(dataGridView1, "select codeM as 'Numéro MD', nom as 'Nom MD', code_f as 'Numéro F.MD', Rayon , prix as 'Prix' from Medicament ");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        #endregion

        #region button suprm
        private void btn_sup_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == string.Empty)
            {
                MessageBox.Show("champs vide!!","Erreur!",MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            else
            {
                if (!Program.Ver("select * from Medicament where codeM = " + int.Parse(txt_id.Text)))
                {
                    MessageBox.Show("numéro  de medicament  que vous aviez saisie introuvable!","Erreur!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {

                        Program.btn_suprm("delete from Medicament where codeM = " + int.Parse(txt_id.Text));
                        Program.remlis_Gried(dataGridView1, "select codeM as 'Numéro MD', nom as 'Nom MD', code_f as 'Numéro F.MD', Rayon , prix as 'Prix' from Medicament ");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        #endregion

        #region button modifier
        private void btn_mdf_Click(object sender, EventArgs e)
        {
            if (txt_id.Text.Trim() == string.Empty || txt_nom.Text.Trim() == string.Empty || txt_prx.Text.Trim() == string.Empty || cmb_fam.SelectedIndex == -1 || cmb_ray.SelectedIndex == -1)
            {
                MessageBox.Show("champs vide!!", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!Program.Ver("select * from Medicament where codeM = " + int.Parse(txt_id.Text)))
                {
                    MessageBox.Show("N'existe pas", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        Program.btn_mdf("update Medicament set nom='" + txt_nom.Text + "' , code_f ='" + cmb_fam.SelectedValue + "' , Rayon = '" + cmb_ray.SelectedItem + "' , prix =" + txt_prx.Text + "  where codeM =" + int.Parse(txt_id.Text) + "");
                        Program.remlis_Gried(dataGridView1, "select codeM as 'Numéro MD', nom as 'Nom MD', code_f as 'Numéro F.MD', Rayon , prix as 'Prix' from Medicament ");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        #endregion

        #region recherche par rayon
        private void btn_rech_byRay_Click(object sender, EventArgs e)
        {
            if (cmb_ray.SelectedIndex == -1)
            {
                MessageBox.Show("Merci! de  choisie un  rayon!!", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Program.btn_recher(dataGridView1, "select codeM as 'Numéro MD', nom as 'Nom MD', code_f as 'Numéro F.MD', Rayon , prix as 'Prix' from Medicament where Rayon = '" + cmb_ray.Text + "'");
            }
        }

        #endregion

        #region recherche bu nom
        private void btn_chByNom_Click(object sender, EventArgs e)
        {
            if (txt_nom.Text== string.Empty)
            {
                MessageBox.Show("MErci de saisie  le nom dans la  zone de  nom!!", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Program.btn_recher(dataGridView1, "select codeM as 'Numéro MD', nom as 'Nom MD', code_f as 'Numéro F.MD', Rayon , prix as 'Prix' from Medicament where nom = '" + txt_nom.Text + "'");
            }
        }
        #endregion

        #region recherch by faml
        private void btn_recherByFaml_Click(object sender, EventArgs e)
        {
            if (cmb_fam.SelectedIndex == -1)
            {
                MessageBox.Show("Merci! de  choisie un famille  de medicamnet !!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Program.btn_recher(dataGridView1, "select codeM as 'Numéro MD', nom as 'Nom MD', code_f as 'Numéro F.MD', Rayon , prix as 'Prix' from Medicament where code_f =" + cmb_fam.SelectedValue + "");
            }

        } 
        #endregion

        #region Remplie les chmaps
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_nom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                cmb_fam.Text = Nom_Famille_M(int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()));
                cmb_ray.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string prix = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_prx.Text = prix.Replace(",", ".");
            }
        } 
        #endregion

        #region function return nom  de famille de medicament
        public string Nom_Famille_M(int b)
        {
            if (Program.cn.State != ConnectionState.Open) { Program.cn.Open(); }
            SqlCommand cm = new SqlCommand("select nom from  famillMedic where codeF=" + b + "", Program.cn);
            string a = cm.ExecuteScalar().ToString();
            Program.cn.Close();
            return a;
        } 
        #endregion

        #region MAKE TEXTBOX FOR INTEGER  AND DECIMAL
        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txt_prx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.');
        } 
        #endregion
    }
}
