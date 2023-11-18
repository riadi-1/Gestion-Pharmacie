namespace Gestion_de_pharmacie
{
    partial class fourinisseur
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_spr = new System.Windows.Forms.Button();
            this.btn_mfd = new System.Windows.Forms.Button();
            this.btn_ajtr = new System.Windows.Forms.Button();
            this.txt_emailF = new System.Windows.Forms.TextBox();
            this.txt_teleF = new System.Windows.Forms.TextBox();
            this.txt_villeF = new System.Windows.Forms.TextBox();
            this.txt_adresseF = new System.Windows.Forms.TextBox();
            this.txt_nomF = new System.Windows.Forms.TextBox();
            this.txt_codeF = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code de fournissuer : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom de fournisseur  : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adresse : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(441, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ville : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(395, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Téléphione : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(432, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email : ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txt_emailF);
            this.panel1.Controls.Add(this.txt_teleF);
            this.panel1.Controls.Add(this.txt_villeF);
            this.panel1.Controls.Add(this.txt_adresseF);
            this.panel1.Controls.Add(this.txt_nomF);
            this.panel1.Controls.Add(this.txt_codeF);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(145, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 197);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_spr);
            this.panel2.Controls.Add(this.btn_mfd);
            this.panel2.Controls.Add(this.btn_ajtr);
            this.panel2.Location = new System.Drawing.Point(111, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 59);
            this.panel2.TabIndex = 7;
            // 
            // btn_spr
            // 
            this.btn_spr.BackColor = System.Drawing.Color.LightGreen;
            this.btn_spr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_spr.Location = new System.Drawing.Point(361, 12);
            this.btn_spr.Name = "btn_spr";
            this.btn_spr.Size = new System.Drawing.Size(129, 33);
            this.btn_spr.TabIndex = 2;
            this.btn_spr.Text = "Supprimer";
            this.btn_spr.UseVisualStyleBackColor = false;
            this.btn_spr.Click += new System.EventHandler(this.btn_spr_Click);
            // 
            // btn_mfd
            // 
            this.btn_mfd.BackColor = System.Drawing.Color.LightGreen;
            this.btn_mfd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mfd.Location = new System.Drawing.Point(191, 12);
            this.btn_mfd.Name = "btn_mfd";
            this.btn_mfd.Size = new System.Drawing.Size(129, 33);
            this.btn_mfd.TabIndex = 1;
            this.btn_mfd.Text = "Modifier";
            this.btn_mfd.UseVisualStyleBackColor = false;
            this.btn_mfd.Click += new System.EventHandler(this.btn_mfd_Click);
            // 
            // btn_ajtr
            // 
            this.btn_ajtr.BackColor = System.Drawing.Color.LightGreen;
            this.btn_ajtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajtr.Location = new System.Drawing.Point(12, 12);
            this.btn_ajtr.Name = "btn_ajtr";
            this.btn_ajtr.Size = new System.Drawing.Size(129, 33);
            this.btn_ajtr.TabIndex = 0;
            this.btn_ajtr.Text = "Ajouter";
            this.btn_ajtr.UseVisualStyleBackColor = false;
            this.btn_ajtr.Click += new System.EventHandler(this.btn_ajtr_Click);
            // 
            // txt_emailF
            // 
            this.txt_emailF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emailF.Location = new System.Drawing.Point(487, 79);
            this.txt_emailF.Name = "txt_emailF";
            this.txt_emailF.Size = new System.Drawing.Size(218, 23);
            this.txt_emailF.TabIndex = 11;
            // 
            // txt_teleF
            // 
            this.txt_teleF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_teleF.Location = new System.Drawing.Point(487, 42);
            this.txt_teleF.Name = "txt_teleF";
            this.txt_teleF.Size = new System.Drawing.Size(218, 23);
            this.txt_teleF.TabIndex = 10;
            this.txt_teleF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_teleF_KeyPress);
            // 
            // txt_villeF
            // 
            this.txt_villeF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_villeF.Location = new System.Drawing.Point(487, 6);
            this.txt_villeF.Name = "txt_villeF";
            this.txt_villeF.Size = new System.Drawing.Size(218, 23);
            this.txt_villeF.TabIndex = 9;
            // 
            // txt_adresseF
            // 
            this.txt_adresseF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adresseF.Location = new System.Drawing.Point(167, 80);
            this.txt_adresseF.Name = "txt_adresseF";
            this.txt_adresseF.Size = new System.Drawing.Size(218, 23);
            this.txt_adresseF.TabIndex = 8;
            // 
            // txt_nomF
            // 
            this.txt_nomF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomF.Location = new System.Drawing.Point(167, 44);
            this.txt_nomF.Name = "txt_nomF";
            this.txt_nomF.Size = new System.Drawing.Size(218, 23);
            this.txt_nomF.TabIndex = 7;
            // 
            // txt_codeF
            // 
            this.txt_codeF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codeF.Location = new System.Drawing.Point(167, 8);
            this.txt_codeF.Name = "txt_codeF";
            this.txt_codeF.Size = new System.Drawing.Size(218, 23);
            this.txt_codeF.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(145, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(730, 202);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // fourinisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1062, 439);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "fourinisseur";
            this.Text = "Fournisseur";
            this.Load += new System.EventHandler(this.fourinisseur_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_emailF;
        private System.Windows.Forms.TextBox txt_teleF;
        private System.Windows.Forms.TextBox txt_villeF;
        private System.Windows.Forms.TextBox txt_adresseF;
        private System.Windows.Forms.TextBox txt_nomF;
        private System.Windows.Forms.TextBox txt_codeF;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_spr;
        private System.Windows.Forms.Button btn_mfd;
        private System.Windows.Forms.Button btn_ajtr;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}