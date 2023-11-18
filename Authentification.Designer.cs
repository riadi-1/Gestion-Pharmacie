namespace Gestion_de_pharmacie
{
    partial class Authentification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cnx = new FontAwesome.Sharp.IconButton();
            this.btn_close = new FontAwesome.Sharp.IconPictureBox();
            this.txt_motP = new System.Windows.Forms.TextBox();
            this.txt_cin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Cnx);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.txt_motP);
            this.panel1.Controls.Add(this.txt_cin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 291);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_Cnx
            // 
            this.btn_Cnx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Cnx.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Cnx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cnx.ForeColor = System.Drawing.Color.Black;
            this.btn_Cnx.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btn_Cnx.IconColor = System.Drawing.Color.Green;
            this.btn_Cnx.IconSize = 32;
            this.btn_Cnx.Location = new System.Drawing.Point(219, 182);
            this.btn_Cnx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Cnx.Name = "btn_Cnx";
            this.btn_Cnx.Rotation = 0D;
            this.btn_Cnx.Size = new System.Drawing.Size(211, 39);
            this.btn_Cnx.TabIndex = 7;
            this.btn_Cnx.Text = "Se connecter";
            this.btn_Cnx.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Cnx.UseVisualStyleBackColor = false;
            this.btn_Cnx.Click += new System.EventHandler(this.btn_Cnx_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.ForeColor = System.Drawing.Color.Red;
            this.btn_close.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btn_close.IconColor = System.Drawing.Color.Red;
            this.btn_close.IconSize = 39;
            this.btn_close.Location = new System.Drawing.Point(609, -2);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(43, 39);
            this.btn_close.TabIndex = 6;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_motP
            // 
            this.txt_motP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_motP.Location = new System.Drawing.Point(219, 122);
            this.txt_motP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_motP.Name = "txt_motP";
            this.txt_motP.Size = new System.Drawing.Size(209, 27);
            this.txt_motP.TabIndex = 3;
            this.txt_motP.UseSystemPasswordChar = true;
            this.txt_motP.TextChanged += new System.EventHandler(this.txt_motP_TextChanged);
            // 
            // txt_cin
            // 
            this.txt_cin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cin.Location = new System.Drawing.Point(219, 85);
            this.txt_cin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cin.Name = "txt_cin";
            this.txt_cin.Size = new System.Drawing.Size(209, 27);
            this.txt_cin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(40, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(75, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utilisateur : ";
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Gestion_de_pharmacie.Properties.Resources.tmp_1592834223236;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(656, 297);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Authentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentification";
            this.Load += new System.EventHandler(this.Authentification_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_motP;
        private System.Windows.Forms.TextBox txt_cin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox btn_close;
        private FontAwesome.Sharp.IconButton btn_Cnx;
    }
}