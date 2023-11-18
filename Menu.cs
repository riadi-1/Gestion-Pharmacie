using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestion_de_pharmacie
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        

        private void rbtn_client_Click(object sender, EventArgs e)
        {
            Client clt = new Client() {Dock  = DockStyle.Fill, TopLevel = false, TopMost= true };
            clt.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.panel1.Controls.Add(clt);
            clt.Show();
           // clt.ShowDialog();
        }

        private void rbtn_Commande_Click(object sender, EventArgs e)
        {
            Commande cm = new Commande() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            cm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.panel1.Controls.Add(cm);
            cm.Show();
            //cm.ShowDialog();
        }

        private void rbtn_famMed_Click(object sender, EventArgs e)
        {
            fam_Medic fm = new fam_Medic() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.panel1.Controls.Add(fm);
            fm.Show();
            //fm.ShowDialog();
        }

        private void rbtn_Medicament_Click(object sender, EventArgs e)
        {
            medicam med = new medicam() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            med.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.panel1.Controls.Add(med);
            med.Show();
            //med.ShowDialog();
        }

        private void rbtn_stock_Click(object sender, EventArgs e)
        {
            stock st = new stock() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            st.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.panel1.Controls.Add(st);
            st.Show();
           // st.ShowDialog();
        }

        private void rbtn_fornissuer_Click(object sender, EventArgs e)
        {
            fourinisseur fr = new fourinisseur() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.panel1.Controls.Add(fr);
            fr.Show();
            //fr.ShowDialog();
        }

        private void rbtn_vente_Click(object sender, EventArgs e)
        {
            Vente vt = new Vente() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            vt.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.panel1.Controls.Add(vt);
            vt.Show();
            //vt.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
