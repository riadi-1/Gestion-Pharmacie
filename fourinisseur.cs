using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;
namespace Gestion_de_pharmacie
{
    public partial class fourinisseur : Form
    {
        public fourinisseur()
        {
            InitializeComponent();
        }

        #region Load
        private void fourinisseur_Load(object sender, EventArgs e)
        {
            txt_codeF.Enabled = false;
            Program.Format_datagrie(dataGridView1);
            Program.remlis_Gried(dataGridView1, "select codeFo as'Numéro', nom as'Nom', adresse as'Adresse', ville as' Ville', tel as'Téléphone', email as'Email' from fournisseur");
        } 
        #endregion

        #region validation email 
        public bool IsValidEmail(string txt)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(txt_emailF.Text);
                return true;
            }
            catch
            {

                return false;
            }
        } 
        #endregion

        #region Pattren Email et tele
        string patternP = @"^[0]{1}[5-7]{1}[0-9]{8}$";
        string pattern= @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
        #endregion

        #region button ajouter
        private void btn_ajtr_Click(object sender, EventArgs e)
        {
            
            if (txt_nomF.Text == string.Empty)
            {
                MessageBox.Show("saisie nom  de fournisseur !", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_adresseF.Text == string.Empty)
            {
                MessageBox.Show("saisie adresse  de fournisseur !", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_villeF.Text == string.Empty)
            {
                MessageBox.Show("saisie ville  de fournisseur !", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_teleF.Text == string.Empty)
            {
                MessageBox.Show("saisie numéro de téléphone  de fournisseur !", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Regex.IsMatch(txt_teleF.Text, patternP, RegexOptions.IgnoreCase) == false)
            {
                MessageBox.Show("Verifier nombre de votre telephone !", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_emailF.Text == string.Empty)
            {
                MessageBox.Show("saisie email  de fournisseur !", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Regex.IsMatch(txt_emailF.Text,pattern, RegexOptions.IgnoreCase)==false)
            {
                MessageBox.Show("Verifier la format de votre email !", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Program.Ver("select * from fournisseur where nom='"+txt_nomF.Text+"'"))
            {
                MessageBox.Show("Existe deja !", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Program.btn_ajouter("insert into fournisseur values('" + txt_nomF.Text + "','" + txt_adresseF.Text + "','" + txt_villeF.Text + "','" + txt_teleF.Text + "','" + txt_emailF.Text + "')");
                    Program.remlis_Gried(dataGridView1, "select codeFo as'Numéro', nom as'Nom', adresse as'Adresse', ville as' Ville', tel as'Téléphone', email as'Email' from fournisseur");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        } 
        #endregion

        #region button modifier
        private void btn_mfd_Click(object sender, EventArgs e)
        {
            if (txt_codeF.Text == string.Empty)
            {
                MessageBox.Show("Selectionne le fournisseur que vous voulez modifier !", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_nomF.Text == string.Empty)
            {
                MessageBox.Show("saisie nom  de fournisseur !", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_adresseF.Text == string.Empty)
            {
                MessageBox.Show("saisie adresse  de fournisseur !", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_villeF.Text == string.Empty)
            {
                MessageBox.Show("saisie ville  de fournisseur !", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_teleF.Text == string.Empty)
            {
                MessageBox.Show("saisie numéro de téléphone  de fournisseur !", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Regex.IsMatch(txt_teleF.Text, patternP,RegexOptions.IgnoreCase)==false)
            {
                MessageBox.Show("Verifier nombre de votre telephone !", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_emailF.Text == string.Empty)
            {
                MessageBox.Show("saisie email  de fournisseur !", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Regex.IsMatch(txt_emailF.Text, pattern, RegexOptions.IgnoreCase) == false)
            {
                MessageBox.Show("Verifier la format de votre email !", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Program.Ver("select * from fournisseur where codeFo="+txt_codeF.Text+" ")==false)
            {
                MessageBox.Show("n'existe pas !", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    try
                    {
                        Program.btn_mdf("update fournisseur set nom='" + txt_nomF.Text + "', adresse='" + txt_adresseF.Text + "', ville='" + txt_villeF.Text + "', tel='" + txt_teleF.Text + "', email='" + txt_emailF.Text + "' where codeFo=" + int.Parse(txt_codeF.Text) + "");
                        Program.remlis_Gried(dataGridView1, "select codeFo as'Numéro', nom as'Nom', adresse as'Adresse', ville as' Ville', tel as'Téléphone', email as'Email' from fournisseur");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        } 
        #endregion

        #region button supprimer
        private void btn_spr_Click(object sender, EventArgs e)
        {
            if (txt_codeF.Text == string.Empty)
            {
                MessageBox.Show("Selectionne le fournisseur que vous voulez supprimer !", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Program.Ver("select * from fournisseur codeFo'" + txt_codeF.Text + "'") == false)
            {
                MessageBox.Show("n'existe pas !", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Program.btn_mdf("delete from fournisseur  where codeFo='" + txt_codeF.Text + "'");
                    Program.remlis_Gried(dataGridView1, "select codeFo as'Numéro', nom as'Nom', adresse as'Adresse', ville as' Ville', tel as'Téléphone', email as'Email' from fournisseur");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        } 
        #endregion

        #region Remplier les champs
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {

                txt_codeF.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_nomF.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_adresseF.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_villeF.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_teleF.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_emailF.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
        } 
        #endregion

        #region MAKE TEXT BOX PHONE INTEGER
        private void txt_teleF_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        } 
        #endregion


    }
}
