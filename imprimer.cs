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
    public partial class imprimer : Form
    {
        public imprimer()
        {
            InitializeComponent();
        }

        private void imprimer_Load(object sender, EventArgs e)
        {
            if (Program.cin != "")
            {
                CrystalReport1 cr = new CrystalReport1();
                cr.SetParameterValue("@cin",Program.cin.ToString());
                crystalReportViewer1.ReportSource = cr;
                crystalReportViewer1.Refresh();
            }
        }

        private void imprimer_Load_1(object sender, EventArgs e)
        {

        }
    }
}
