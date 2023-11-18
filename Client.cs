using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Gestion_de_pharmacie
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        #region LAOD
        private void Client_Load(object sender, EventArgs e)
        {
            #region DATAGRIDVIE
            Program.Format_datagrie(dataGridView1);
            chargeGrd();
            #endregion
        } 
        #endregion

        #region CHARGE DATAGRIDVIEW
        public void chargeGrd()
        {
            Program.remlis_Gried(dataGridView1, "select cin as 'CIN', nom as 'Nom&Prénom',tele as 'Téléphone', adress as 'Adresse' from Client where LEFT(cin,1)<>'@'"); 
        }
        #endregion

        #region Pattren  tele & cin 
        string patternP = @"^[0]{1}[5-7]{1}[0-9]{8}$";
        string patternCin = @"^[A-Za-z]{1,2}[0-9]{5,6}$";

        #endregion

        #region Button vide les champs
        private void btn_nv_Click(object sender, EventArgs e)
        {
            txt_cin.Text = string.Empty;
            txt_nom.Text = string.Empty;
            txt_tele.Text = string.Empty;
            txt_adresse.Text = string.Empty;
        } 
        #endregion

        #region Button ajouter
        private void btn_ajtr_Click(object sender, EventArgs e)
        {
            if (txt_cin.Text == string.Empty || txt_nom.Text == string.Empty || txt_tele.Text == string.Empty || txt_adresse.Text == string.Empty)
            {
                MessageBox.Show("Champs  vide !!!!!", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Regex.IsMatch(txt_cin.Text,patternCin, RegexOptions.IgnoreCase)==false)
            {
                MessageBox.Show("Verifier votre cin !", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            else if (Regex.IsMatch(txt_tele.Text, patternP, RegexOptions.IgnoreCase) == false)
            {
                MessageBox.Show("Verifier nombre de votre telephone !", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Program.Ver("select * from client where cin='" + txt_cin.Text + "'") == false)
            {
                try
                {
                    Program.btn_ajouter("insert into client values('" + txt_cin.Text + "','" + txt_nom.Text + "','" + txt_tele.Text + "','" + txt_adresse.Text + "')");
                    chargeGrd();

                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Existe déjà","Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion

        #region Button modifier
        private void btn_mdf_Click(object sender, EventArgs e)
        {
            if (txt_cin.Text == string.Empty || txt_nom.Text == string.Empty || txt_tele.Text == string.Empty || txt_adresse.Text == string.Empty)
            {
                MessageBox.Show("champs vide!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Regex.IsMatch(txt_cin.Text, patternCin, RegexOptions.IgnoreCase) == false)
            {
                MessageBox.Show("Verifier votre cin !", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Regex.IsMatch(txt_tele.Text, patternP, RegexOptions.IgnoreCase) == false)
            {
                MessageBox.Show("Verifier nombre de votre telephone !", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Program.Ver("select * from client where cin='" + txt_cin.Text + "'"))
            {
                try
                {
                    Program.btn_mdf("update client set nom='" + txt_nom.Text + "' ,tele='" + txt_tele.Text + "' , adress='" + txt_adresse.Text + "' where cin='" + txt_cin.Text + "'");
                    chargeGrd();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("n'existe pas");
            }
        } 
        #endregion

        #region Button supprimer
        private void btn_spr_Click(object sender, EventArgs e)
        {
            if (txt_cin.Text == string.Empty || txt_nom.Text == string.Empty || txt_tele.Text == string.Empty || txt_adresse.Text == string.Empty)
            {
                MessageBox.Show("champs vide!!!", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Program.Ver("select * from client where cin='" + txt_cin.Text + "'"))
            {
                try
                {
                    Program.btn_suprm("delete from  client where cin='" + txt_cin.Text + "'");
                    chargeGrd();

                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("N'existe pas", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion

        #region Remplie les champs
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {

                txt_cin.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_nom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_tele.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_adresse.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
        } 
        #endregion

        #region Button rechercher par  cin
        private void btn_Rechercher_Click(object sender, EventArgs e)
        {
            if (txt_cin.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Champs vide !!! Saisie votre CIN dans la zone de CIN", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Regex.IsMatch(txt_cin.Text, patternCin, RegexOptions.IgnoreCase) == false)
            {
                MessageBox.Show("Verfier  votre CIN", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    Program.remlis_Gried(dataGridView1, "select cin as 'CIN', nom as 'Nom&Prénom',tele as 'Téléphone', adress as 'Adresse' from Client where LEFT(cin,1)<>'@' and cin='" + txt_cin.Text + "'");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

        } 
        #endregion

        #region MAKE TAEXT BOX FOR INTEGRT
        private void txt_tele_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        } 
        #endregion

    }
}
