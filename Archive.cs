using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Microsoft.Office.Interop.Excel;


namespace Gestion_de_pharmacie
{
    public partial class Archive : Form
    {
        public Archive()
        {
            InitializeComponent();
        }

        #region Load
        private void Archive_Load(object sender, EventArgs e)
        {
            Program.Format_datagrie(dataGridView1);
            panelVente.Hide();
            panelDemande.Hide();

            RadioB_Vente.Checked = true;
            RadioB_V_tous.Checked = true;
            RadioB_D_Tous.Checked = true;

            panelDV();
            panelVenteSize();
            panelDemendeSize();

            remplieFornisseur();
            remplieClient();
        } 
        #endregion

        #region Remplie COMBOXBOX
        public void remplieFornisseur()
        {
            Program.remlis_comb(cmbx_fournisseur,"select * from fournisseur","nom","nom");
        }
        public void remplieClient()
        {
            Program.remlis_comb(cmbx_client, "select * from Client where LEFT(cin,1)<>'@'", "cin", "nom");
        }
        #endregion

        #region Charger Archive de comande et vente 
        public void repmlieTous()
        {
            if (RadioB_demande.Checked)
            {
                Program.remlis_Gried(dataGridView1, "select codeAr as'Num Ar',numC as'Num CMD', dateC as'Date CMD' , nomF as'Nom Fs', adresseF as'Adresse Fs', villeF as'Ville Fs', telF as'Téléphone Fs',emailF as'Email Fs', numM as'Num MD', nomM as'Nom MD', prixM as'Prix MD (DH)', qnt as'Qauntité CMD', montant as'M.T CMD (DH)' from ArchiveCMD");
            }
            else if(RadioB_Vente.Checked)
            {
                Program.remlis_Gried(dataGridView1, "select codeArV as'Num Ar', cin as'CIN CLT', nomC as'Nom CLT', teleC as'Téléphone CLT', numM as'Num MD', nomM as'Nom MD', prixM as'Prix MD(DH)', qnt as'Qauntité MD', montantTOtal as'M.T vente (DH)', datev as'Date vente' from ArchiveVT order by datev");
            }
        }
        #endregion

        #region Charger Archive commande par fournisseur
        public void remplierParFournisseur()
        {
            Program.remlis_Gried(dataGridView1, "select codeAr as'Num Ar',numC as'Num CMD', dateC as'Date CMD' , nomF as'Nom Fs', adresseF as'Adresse Fs', villeF as'Ville Fs', telF as'Téléphone Fs',emailF as'Email Fs', numM as'Num MD', nomM as'Nom MD', prixM as'Prix MD (DH)', qnt as'Qauntité CMD', montant as'M.T CMD (DH)' from ArchiveCMD where nomF='"+cmbx_fournisseur.SelectedValue+"' order by dateC"); 
        }
        #endregion

        #region Charger Archive vente par client certifie
        public void remplierParClient()
        {
            Program.remlis_Gried(dataGridView1, "select codeArV as'Num Ar', cin as'CIN CLT', nomC as'Nom CLT', teleC as'Téléphone CLT', numM as'Num MD', nomM as'Nom MD', prixM as'Prix MD(DH)', qnt as'Qauntité MD', montantTOtal as'M.T vente (DH)', datev as'Date vente' from ArchiveVT where cin='" + cmbx_client.SelectedValue + "' order by datev"); 
        }
        #endregion

        #region PANEL vente & demande
        public void panelDV()
        {
            if (RadioB_Vente.Checked)
            {
                panelDemande.Hide();
                panelDemande.Location = new Point(757, 8);

                panelVente.Location = new Point(470, 8);
                panelVente.Show(); 
            }
            else if(RadioB_demande.Checked)
            {
                panelVente.Hide();
                panelVente.Location = new Point(757, 8);

                panelDemande.Location = new Point(470, 8);
                panelDemande.Show();
            }
        }
	    #endregion

        #region PANEL vent size
        public void panelVenteSize()
        {
            if (RadioB_V_client.Checked)
            {
                panelVente.Size = new System.Drawing.Size(232,119);
                panelClient.Show();
            }
            else if (RadioB_V_tous.Checked)
            {
                panelClient.Hide();
                panelVente.Size = new System.Drawing.Size(232, 55);
            }
        }
        #endregion

        #region PANEL demande size
        public void panelDemendeSize()
        {
            if (RadioB_D_fournisseur.Checked)
            {
                panelDemande.Size = new System.Drawing.Size(232, 119);
                panelFornisseur.Show();
            }
            else if(RadioB_D_Tous.Checked)
            {
                panelFornisseur.Hide();
                panelDemande.Size = new System.Drawing.Size(232, 55);
            }
        }
        #endregion


        #region Archive pour vente
        private void RadioB_Vente_CheckedChanged(object sender, EventArgs e)
        {
            panelDV();
            repmlieTous();
        }
        private void RadioB_V_client_CheckedChanged(object sender, EventArgs e)
        {
            panelVenteSize();
            if (RadioB_V_client.Checked) { remplierParClient(); } else { repmlieTous(); }
        }

        private void RadioB_V_tous_CheckedChanged(object sender, EventArgs e)
        {
            panelVenteSize();
            if (RadioB_V_client.Checked) { remplierParClient(); } else { repmlieTous(); }

        } 
        private void cmbx_client_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (RadioB_V_client.Checked) { remplierParClient(); } else { repmlieTous(); }
        }
        #endregion

        #region Archive pour demande
        private void RadioB_demande_CheckedChanged(object sender, EventArgs e)
        {
            panelDV();
            repmlieTous();
        }
        private void RadioB_D_fournisseur_CheckedChanged(object sender, EventArgs e)
        {
            panelDemendeSize();
            if (RadioB_D_Tous.Checked) { repmlieTous(); } else { remplierParFournisseur(); }
        }

        private void RadioB_D_Tous_CheckedChanged(object sender, EventArgs e)
        {
            panelDemendeSize();
            if (RadioB_D_Tous.Checked) { repmlieTous(); } else { remplierParFournisseur(); }
        } 
        private void cmbx_fournisseur_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (RadioB_D_Tous.Checked) { repmlieTous(); } else { remplierParFournisseur(); }
        }
        #endregion

        #region Button exporter
        private void btn_Exporter_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                int totalrow = dataGridView1.Rows.Count;//-1
                for (int i = 0; i < totalrow; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
            else
            {
                MessageBox.Show("Liste vide!!!", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        private void panelMenuRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
