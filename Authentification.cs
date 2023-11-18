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
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }

        private void Authentification_Load(object sender, EventArgs e)
        {
            
        }

        
        #region button close
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
        #endregion

        #region Button connecter
        private void btn_Cnx_Click(object sender, EventArgs e)
        {
            if (txt_cin.Text.Trim() == "")
            {
                MessageBox.Show("saissie votre cin! ", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_motP.Text.Trim() == "")
            {
                MessageBox.Show("saissie votre mot de passe! ", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Program.Ver("select * from  Utilisateur where cin='" + txt_cin.Text + "'"))
            {
                try
                {
                    if (Program.cn.State != ConnectionState.Open) { Program.cn.Open(); }
                    SqlCommand cm = new SqlCommand("select * from  Utilisateur where cin=@l and pass=@p ", Program.cn);
                    cm.Parameters.AddWithValue("@l", txt_cin.Text.Trim());
                    cm.Parameters.AddWithValue("@p", txt_motP.Text.Trim());
                    SqlDataReader dr = cm.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Close();
                        Program.cn.Close();
                        this.Hide();
                        DeskTop ds = new DeskTop();
                        ds.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        dr.Close();
                        Program.cn.Close();
                        MessageBox.Show("votre mot de passe incorrecte!", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                Program.cn.Close();
                MessageBox.Show("votre cin n'existe pas! ", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        #endregion

        private void txt_motP_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
