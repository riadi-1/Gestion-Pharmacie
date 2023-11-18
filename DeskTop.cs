using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace Gestion_de_pharmacie
{
    public partial class DeskTop : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        Timer t = new Timer();
        internal object passobj;
        internal EventArgs passeargs;

        //Constructor

        public DeskTop()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        #region Load
        private void DeskTop_Load(object sender, EventArgs e)
        {
            #region Date & time
            label_date.Text = DateTime.Now.ToString("dd-MM-yyyy");

            // timer interval
            t.Interval = 1000;// in milliseconds
            t.Tick += new EventHandler(this.t_Tick);

            //start timer when form loads
            t.Start();// this willl use t_Tick() method 
            #endregion

        } 
        #endregion

        #region Method
        private void t_Tick(object sender, EventArgs e)
        {
            //get current time 
            int hh = DateTime.Now.Hour, mm = DateTime.Now.Minute, ss = DateTime.Now.Second;

            // time 
            string time = "";

            // padding loading zero 

            if (hh < 10) { time += "0" + hh; }
            else { time += hh; }

            time += ":";

            if (mm < 10) { time += "0" + mm; }
            else { time += mm; }

            time += ":";

            if (ss < 10) { time += "0" + ss; }
            else { time += ss; }

            // update label_time
            label_time.Text = time;


        } 
        #endregion


        //Structs
        private struct RGBColors
        {
           public static Color color1 = Color.FromArgb(128, 0, 0);
           public static Color color2 = Color.FromArgb(85, 107, 47);
           public static Color color3 = Color.FromArgb(75, 0, 130);
           public static Color color4 = Color.FromArgb(199, 21, 133);
           public static Color color5 = Color.FromArgb(139, 69, 19);
           public static Color color6 = Color.FromArgb(220, 20, 60);
           public static Color color7 = Color.FromArgb(128, 0, 128);
           public static Color color8 = Color.FromArgb(218, 165, 32);
           public static Color color9 = Color.FromArgb(255, 182, 193);
        }
        
        //Methods
        private void activateButton(object senderBtn , Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(62, 158, 255);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //icon current child form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;

            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(190, 222, 255);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.DarkOliveGreen;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                // open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            // childForm.TopMost = true;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        //button click
        private void bnt_Clt_Click(object sender, EventArgs e)
        {
            activateButton(sender , RGBColors.color1);
            OpenChildForm(new Client());
        }

        private void btn_FlMed_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color2);
            OpenChildForm(new fam_Medic());
        }

        private void btn_med_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color3);
            OpenChildForm(new medicam());

        }

        private void bnt_Four_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color4);
            OpenChildForm(new fourinisseur());

        }

        private void btn_vente_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color5);
            OpenChildForm(new Vente());

        }

        private void btn_Cmd_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color6);
            OpenChildForm(new Commande());

        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color7);
            OpenChildForm(new stock());

        }

        private void btn_imprimer_Click(object sender, EventArgs e)
        {
           /* this.passobj = sender;
            this.passeargs = e;*/

            activateButton(sender, RGBColors.color8);
            OpenChildForm(new imprimer());
        }
        private void btn_archive_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color9);
            OpenChildForm(new Archive());
        }
        private void btn_Home_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                // open only form
                currentChildForm.Close();
            }
            Reste();
        }

        private void Reste()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.DarkGreen;
            lblTitleChildForm.Text = "Home";
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
        #region Buttons Exite& Maximize & Minimize
        private void btnExite_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Maximiez_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        } 
        #endregion

        

        



    }
}
