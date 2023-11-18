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
    public partial class fam_Medic : Form
    {
        public fam_Medic()
        {
            InitializeComponent();
        }
        /* Event Load*/
        #region Load
        private void fam_Medic_Load(object sender, EventArgs e)
        {
            txt_id.Enabled = false;
            Program.Format_datagrie(dataGridView1);
            Program.remlis_Gried(dataGridView1, "select codeF as 'Num F.MD', nom as 'Nom F.MD' from famillsMedic");
        } 
        #endregion

        /*CRUD*/
        #region Button ajouter
        private void btn_ajt_Click(object sender, EventArgs e)
        {

            if (txt_des.Text.Trim() == string.Empty)
            {
                MessageBox.Show("la  zone de nom  vide !", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Program.Ver("select * from famillMedic where nom='"+txt_des.Text+"'"))
            {
                MessageBox.Show("Existe déjà!", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Program.btn_ajouter("insert into famillMedic values ('" + txt_des.Text + "')");
                    Program.remlis_Gried(dataGridView1, "select codeF as 'Num F.MD', nom as 'Nom F.MD' from famillMedic");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

        } 
        #endregion

        #region Button supprimer
        private void btn_sprm_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == string.Empty)
            {
                MessageBox.Show("Selectionne dans la liste la famille de medicament  que vous voulez suprimer !", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Program.Ver("select * from famillMedic where codeF = " + int.Parse(txt_id.Text)) == false)
            {
                MessageBox.Show("N'existe  pas", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Program.btn_suprm("delete from famillMedic where codeF = " + int.Parse(txt_id.Text));
                    Program.remlis_Gried(dataGridView1, "select codeF as 'Num F.MD', nom as 'Nom F.MD' from famillMedic");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        } 
        #endregion

        #region Button modifier
        private void btn_mdf_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == string.Empty)
            {
                MessageBox.Show("Selectionne la famille de medicament  que vous voulez modifier !", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_des.Text.Trim() == string.Empty)
            {
                MessageBox.Show("la  zone de nom  vide !", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Program.Ver("select * from famillMedic where codeF = " + int.Parse(txt_id.Text)) == false)
            {
                MessageBox.Show("N'existe  pas", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Program.btn_mdf("update famillMedic set nom ='" + txt_des.Text + "' where codeF=" + int.Parse(txt_id.Text));
                    Program.remlis_Gried(dataGridView1, "select codeF as 'Num F.MD', nom as 'Nom F.MD' from famillMedic");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

        } 
        #endregion

        /*Recherche*/

        #region Button recherche par nom
        private void btn_rechN_Click(object sender, EventArgs e)
        {
            if (txt_des.Text.Trim() !=  string.Empty)
            {
                Program.btn_recher(dataGridView1, "select codeF as 'Num F.MD', nom as 'Nom F.MD' from famillMedic where nom ='" + txt_des.Text + "'"); 
            }
            else
            {
                MessageBox.Show("Merci! de  saisie le nom de F.MD! ","Erreur&champ vide!" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        } 
        #endregion

        /*Chargie les champs*/
        #region Remplie les champs 
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {

                txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_des.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        } 
        #endregion


    }
}
