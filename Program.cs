using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;


namespace Gestion_de_pharmacie
{
    static class Program
    {


        public static SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=GESTION_PHARMACIE;Integrated Security=True");
       
        #region noveau
        public static void nv(TextBox t,string cmd)
        {
            if (cn.State != ConnectionState.Open) { cn.Open(); }

            SqlCommand cm = new SqlCommand(cmd, cn);
            t.Text = cm.ExecuteScalar().ToString();
         /*   SqlDataReader dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
               while(dr.Read())
                { }
            }
            dr.Close();*/
            cn.Close();
           
        }
        #endregion

        public static string cin = "";


        #region verifie despo
        public static  bool Ver(string cmd)
        { bool ver = false;
            if (cn.State != ConnectionState.Open) { cn.Open(); }

            SqlCommand cm = new SqlCommand(cmd, cn);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                ver = true;
            }
            dr.Close();
            cn.Close();
            return ver;
        }
        #endregion

        #region remplisage gridview
        public static void remlis_Gried(DataGridView dtg, string cmd)
        {
            if (Program.cn.State != ConnectionState.Open) { Program.cn.Open(); }

            SqlCommand cm = new SqlCommand(cmd, cn);
            SqlDataReader dr = cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dtg.DataSource = null;
            dtg.DataSource = dt;
            dr.Close();
            Program.cn.Close();
        }
        #endregion

        #region remplisage combobxe
        public static void remlis_comb(ComboBox cmb, string cmd, string valueMem, string displayMem)
        {
            if (Program.cn.State != ConnectionState.Open) { Program.cn.Open(); }

            SqlCommand cm = new SqlCommand(cmd, cn);
            SqlDataReader dr = cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmb.DataSource = null;
            cmb.DataSource = dt;
            cmb.DisplayMember = displayMem;
            cmb.ValueMember = valueMem;
            dr.Close();
            Program.cn.Close();
        }

        #endregion

        # region button ajouter
        public static void btn_ajouter(string cmd)
        {
            if (Program.cn.State != ConnectionState.Open) { Program.cn.Open(); }

            SqlCommand cm = new SqlCommand(cmd, Program.cn);
            int a = cm.ExecuteNonQuery();
            if (a != 0) { MessageBox.Show("bien ajouter"); }
            else
            {
                MessageBox.Show("problem d'ajouter");
            }
            Program.cn.Close();

        }

        #endregion

        #region button modifier
        public static void btn_mdf(string cmd)
        {
            if (Program.cn.State != ConnectionState.Open) { Program.cn.Open(); }

            SqlCommand cm = new SqlCommand(cmd, Program.cn);
            DialogResult result = MessageBox.Show("vous voulez vraiment  fait ce modification ?", "Confirmé", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                int a = cm.ExecuteNonQuery();
                if (a != 0) { MessageBox.Show("bien modifier", "MODIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else
                {
                    MessageBox.Show("Probleme de modification","Erreur",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Program.cn.Close();
            }
        }
        #endregion

        # region button suprimmer
        public static void btn_suprm(string cmd)
        {
            if (Program.cn.State != ConnectionState.Open) { Program.cn.Open(); }

            SqlCommand cm = new SqlCommand(cmd, Program.cn);
            DialogResult result = MessageBox.Show("vous voulez vraiment  faire ce supprision  ?", "Confirmé", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                int a = cm.ExecuteNonQuery();
                if (a != 0) { MessageBox.Show("bien suprision","SUPPRISION",MessageBoxButtons.OK); }
                else
                {
                    MessageBox.Show("Probleme de la supprision", "Erreur!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            Program.cn.Close();

        }
        #endregion

        #region button rechercher
        public static void btn_recher(DataGridView dtg, string cmd)
        {
            if (Program.cn.State != ConnectionState.Open) { Program.cn.Open(); }

            SqlCommand cm = new SqlCommand(cmd, cn);
            SqlDataReader dr = cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dtg.DataSource = null;
            dtg.DataSource = dt;
            dr.Close();
            Program.cn.Close();
        }
        #endregion

        #region form
        public static void frm(Form f, int a, int b)
        {
            f.Size = new Size(a, b);

            f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f.StartPosition = FormStartPosition.CenterScreen;


        }
        #endregion

        #region Format de  DataGridView
        public static void Format_datagrie(DataGridView dataGridView1)
        {

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;



        }
        #endregion;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DeskTop());
        }
    }
}
