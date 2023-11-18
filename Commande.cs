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
    public partial class Commande : Form
    {
        public Commande()
        {
            InitializeComponent();
        }

        #region Load
        private void Commande_Load(object sender, EventArgs e)
        {
            txt_MontantTotal.Enabled = false;
            txt_CodeC.Enabled = false;
            Program.Format_datagrie(dataGridView1);
            Program.remlis_Gried(dataGridView1, "select codeC as'Numéro CMD', dateC as'Date CMD', codeM as'Numéro MD', codeFo as'Numéro FS', qnt as'Quantité CMD', montnatTotal as'M.T CMD (DH)'from commande");
            #region charge les combobox
            Program.remlis_comb(cmbx_Medicament, "select * from  Medicament", "codeM", "nom");
            Program.remlis_comb(cmbx_Fournisseur, "select * from  fournisseur", "codeFo", "nom");
            #endregion
        } 
        #endregion

        #region INFO pour Archive

        public string info_archive()
        {
            string chaine = "";
            string nomF = "", adresseF = "", villeF = "", telF = "", emailF = "";
            DateTime dateC = DateTime.Now;
            if (Program.cn.State != ConnectionState.Open) { Program.cn.Open(); }
            SqlCommand cm = new SqlCommand("select nom ,adresse,ville,tel ,email from fournisseur  where codeFo=" +cmbx_Fournisseur.SelectedValue+ "", Program.cn);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();

                nomF = dr[0].ToString();
                adresseF = dr[1].ToString();
                villeF = dr[2].ToString();
                telF = dr[3].ToString();
                emailF = dr[4].ToString();
                dr.Close();
            }
            else { dr.Close(); }

            string nomM="";
            int codeM = 0;
            SqlCommand cm1 = new SqlCommand("select codeM, nom from  Medicament where codeM=" + cmbx_Medicament.SelectedValue + "", Program.cn);
            SqlDataReader dr1 = cm1.ExecuteReader();
            if (dr1.HasRows)
            {
                dr1.Read();
                codeM = int.Parse(dr1[0].ToString());
                nomM = dr1[1].ToString();
                dr1.Close();
            }
            else { dr1.Close(); }

            SqlCommand cm2 = new SqlCommand("select MAX(codeC) from commande", Program.cn);
            int codeC =int.Parse( cm2.ExecuteScalar().ToString());

            Program.cn.Close();

            chaine = "insert into ArchiveCMD values(" + codeC + ",'" + Date_commande.Value.ToString("yyyy-MM-dd") + "','" + nomF + "','" + adresseF + "','" + villeF + "','" + telF + "','" + emailF + "'," + codeM + ",'" + nomM + "'," + prix().ToString().Replace(",", ".") + "," + numericUpDown1.Value.ToString() + "," + txt_MontantTotal.Text + ")";
            return chaine;
        }
        
        #endregion

        #region button ajouter
        private void btn_ajtr_Click(object sender, EventArgs e)
        {
            if (cmbx_Medicament.SelectedIndex == -1)
            {
                MessageBox.Show("Choisie le medicament!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (cmbx_Fournisseur.SelectedIndex==-1)
            {
                MessageBox.Show("Choisie le fournisseur!","Error!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else if (txt_MontantTotal.Text == string.Empty)
            {
                MessageBox.Show("saisie le montant total!","Error!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numericUpDown1.Text.Equals("0"))
            {
                MessageBox.Show("Choisie la quantite!","Error!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Program.btn_ajouter("insert into commande values('" + Date_commande.Value.ToString("yyyy-MM-dd") + "','" + cmbx_Medicament.SelectedValue + "', '" + cmbx_Fournisseur.SelectedValue + "'," + int.Parse(numericUpDown1.Text) + ", " + txt_MontantTotal.Text + ")");

                    if (Program.cn.State != ConnectionState.Open) { Program.cn.Open(); }
                    SqlCommand cm = new SqlCommand(info_archive(), Program.cn);
                    int a = cm.ExecuteNonQuery();
                    Program.cn.Close();

                    Program.remlis_Gried(dataGridView1, "select codeC as'Numéro CMD', dateC as'Date CMD', codeM as'Numéro MD', codeFo as'Numéro FS', qnt as'Quantité CMD', montnatTotal as'M.T CMD (DH)' from commande");

                }
                catch (Exception ex )
                {

                    MessageBox.Show(ex.Message);
                }
            }
        } 
        #endregion

        #region button modifier
        private void btn_mdf_Click(object sender, EventArgs e)
        {
            if (txt_CodeC.Text == string.Empty)
            {
                MessageBox.Show("Selectionne la  commande dans la liste  que  vous avez modifie!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbx_Medicament.SelectedIndex == -1)
            {
                MessageBox.Show("Choisie le medicament!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (cmbx_Fournisseur.SelectedIndex == -1)
            {
                MessageBox.Show("Choisie le fournisseur!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (numericUpDown1.Text.Equals("0"))
            {
                MessageBox.Show("Choisie la quantite!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_MontantTotal.Text == string.Empty)
            {
                MessageBox.Show("saisie le montant total!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Program.Ver("select * from commande where codeC='" + txt_CodeC.Text + "'")==false)
            {
                MessageBox.Show("le  code de ce  commande n'existe  pas", "Error! verification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Program.btn_mdf("update commande set dateC='" + Date_commande.Value.ToString("yyyy-MM-dd") + "',codeM='" + cmbx_Medicament.SelectedValue + "', codeFo='" + cmbx_Fournisseur.SelectedValue + "',qnt="+int.Parse(numericUpDown1.Text)+", montnatTotal=" +txt_MontantTotal.Text + " where codeC='"+txt_CodeC.Text+"'");
                Program.remlis_Gried(dataGridView1, "select codeC as'Numéro CMD', dateC as'Date CMD', codeM as'Numéro MD', codeFo as'Numéro FS', qnt as'Quantité CMD', montnatTotal as'M.T CMD (DH)' from commande");
            }
        } 
        #endregion

        #region button supprimer
        private void btn_sprm_Click(object sender, EventArgs e)
        {
            if (txt_CodeC.Text == string.Empty)
            {
                MessageBox.Show("Selectionne la  commande dans la liste  que  vous avez supprimer!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Program.Ver("select * from commande where codeC='" + txt_CodeC.Text + "'") == false)
            {
                MessageBox.Show("le  code de ce  commande n'existe  pas", "Error! verification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Program.btn_suprm("delete from commande  where codeC=" + txt_CodeC.Text + "");
                Program.remlis_Gried(dataGridView1, "select codeC as'Numéro CMD', dateC as'Date CMD', codeM as'Numéro MD', codeFo as'Numéro FS', qnt as'Quantité CMD', montnatTotal as'M.T CMD (DH)' from commande");
            }
        } 
        #endregion

        #region button recherche par fournisseur
        private void btn_fournisseur_Click(object sender, EventArgs e)
        {
            if (cmbx_Fournisseur.SelectedIndex == -1)
            {
                MessageBox.Show("Choisie le fournisseur!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Program.remlis_Gried(dataGridView1, "select codeC as'Numéro CMD', dateC as'Date CMD', codeM as'Numéro MD', codeFo as'Numéro FS', qnt as'Quantité CMD', montnatTotal as'M.T CMD (DH)' from commande where codeFo=" + cmbx_Fournisseur.SelectedValue + "");
            }
        } 
        #endregion

        #region button recherche par medicament
        private void btn_medicament_Click(object sender, EventArgs e)
        {
            if (cmbx_Medicament.SelectedIndex == -1)
            {
                MessageBox.Show("Choisie le medicament!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Program.remlis_Gried(dataGridView1, "select codeC as'Numéro CMD', dateC as'Date CMD', codeM as'Numéro MD', codeFo as'Numéro FS', qnt as'Quantité CMD', montnatTotal as'M.T CMD (DH)' from commande where codeM=" + cmbx_Medicament.SelectedValue + "");
            }
        } 
        #endregion

        #region button recherche par date
        private void btn_date_Click(object sender, EventArgs e)
        {
            Program.remlis_Gried(dataGridView1, "select codeC as'Numéro CMD', dateC as'Date CMD', codeM as'Numéro MD', codeFo as'Numéro FS', qnt as'Quantité CMD', montnatTotal as'M.T CMD (DH)' from commande where dateC='" + Date_commande.Value.ToString("yyyy-MM-dd") + "'");
        } 
        #endregion

        #region Remplie les champs
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                txt_CodeC.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Date_commande.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                cmbx_Medicament.Text = Nom_Medicament(int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()));
                cmbx_Fournisseur.Text = Nom_Fournisseur(int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()));
                numericUpDown1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                string mtn = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt_MontantTotal.Text = mtn.Replace(",", ".");

            }
        } 
        #endregion

        #region Two function  return name of fournisseur  and mdicament
        public string Nom_Medicament(int b)
        {
            if (Program.cn.State != ConnectionState.Open) { Program.cn.Open(); }
            SqlCommand cm = new SqlCommand("select nom from  Medicament where codeM="+b+"", Program.cn);
            string a = cm.ExecuteScalar().ToString();
            Program.cn.Close();
            return a;
        }
        public string Nom_Fournisseur(int b)
        {
            if (Program.cn.State != ConnectionState.Open) { Program.cn.Open(); }
            SqlCommand cm = new SqlCommand("select nom from fournisseur  where codeFo="+b+"", Program.cn);
            string a = cm.ExecuteScalar().ToString();
            Program.cn.Close();
            return a;
        } 
        #endregion

        #region Fonction return le prix  d'une medicament
        private decimal prix()
        {

            if (Program.cn.State != System.Data.ConnectionState.Open) { Program.cn.Open(); }
            SqlCommand cm = new SqlCommand("select prix from  Medicament where  codeM=" + cmbx_Medicament.SelectedValue + "", Program.cn);
            decimal prixS = decimal.Parse(cm.ExecuteScalar().ToString());
            return prixS;
        } 
        #endregion

        #region function & method  & event for count(montant total)
        private void Calcul()
        {
            if (cmbx_Medicament.SelectedValue != null && numericUpDown1.Value != null)
            {
                int vl = int.Parse(numericUpDown1.Value.ToString());
                decimal rslt = prix() * vl;
                string mtn = rslt.ToString();
                txt_MontantTotal.Text = mtn.Replace(",", ".");
            }
        }
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Calcul();
        } 
        
        private void cmbx_Medicament_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Calcul();
        }
        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
