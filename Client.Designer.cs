namespace Gestion_de_pharmacie
{
    partial class Client
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
            this.txt_adresse = new System.Windows.Forms.TextBox();
            this.txt_tele = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_cin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Rechercher = new System.Windows.Forms.Button();
            this.btn_spr = new System.Windows.Forms.Button();
            this.btn_mdf = new System.Windows.Forms.Button();
            this.btn_ajtr = new System.Windows.Forms.Button();
            this.btn_nv = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_adresse);
            this.panel1.Controls.Add(this.txt_tele);
            this.panel1.Controls.Add(this.txt_nom);
            this.panel1.Controls.Add(this.txt_cin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(69, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 111);
            this.panel1.TabIndex = 0;
            // 
            // txt_adresse
            // 
            this.txt_adresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adresse.Location = new System.Drawing.Point(458, 59);
            this.txt_adresse.Name = "txt_adresse";
            this.txt_adresse.Size = new System.Drawing.Size(191, 23);
            this.txt_adresse.TabIndex = 7;
            // 
            // txt_tele
            // 
            this.txt_tele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tele.Location = new System.Drawing.Point(458, 30);
            this.txt_tele.Name = "txt_tele";
            this.txt_tele.Size = new System.Drawing.Size(191, 23);
            this.txt_tele.TabIndex = 6;
            this.txt_tele.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tele_KeyPress);
            // 
            // txt_nom
            // 
            this.txt_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom.Location = new System.Drawing.Point(123, 59);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(191, 23);
            this.txt_nom.TabIndex = 5;
            // 
            // txt_cin
            // 
            this.txt_cin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cin.Location = new System.Drawing.Point(123, 30);
            this.txt_cin.Name = "txt_cin";
            this.txt_cin.Size = new System.Drawing.Size(191, 23);
            this.txt_cin.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(369, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ADRESSE :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TELEPHONE :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOM :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CIN :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_Rechercher);
            this.panel2.Controls.Add(this.btn_spr);
            this.panel2.Controls.Add(this.btn_mdf);
            this.panel2.Controls.Add(this.btn_ajtr);
            this.panel2.Controls.Add(this.btn_nv);
            this.panel2.Location = new System.Drawing.Point(760, 50);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(196, 354);
            this.panel2.TabIndex = 1;
            // 
            // btn_Rechercher
            // 
            this.btn_Rechercher.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_Rechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rechercher.Location = new System.Drawing.Point(8, 286);
            this.btn_Rechercher.Name = "btn_Rechercher";
            this.btn_Rechercher.Size = new System.Drawing.Size(179, 53);
            this.btn_Rechercher.TabIndex = 4;
            this.btn_Rechercher.Text = "Recherche par  CIN";
            this.btn_Rechercher.UseVisualStyleBackColor = false;
            this.btn_Rechercher.Click += new System.EventHandler(this.btn_Rechercher_Click);
            // 
            // btn_spr
            // 
            this.btn_spr.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_spr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_spr.Location = new System.Drawing.Point(8, 220);
            this.btn_spr.Name = "btn_spr";
            this.btn_spr.Size = new System.Drawing.Size(179, 45);
            this.btn_spr.TabIndex = 3;
            this.btn_spr.Text = "Supprimer";
            this.btn_spr.UseVisualStyleBackColor = false;
            this.btn_spr.Click += new System.EventHandler(this.btn_spr_Click);
            // 
            // btn_mdf
            // 
            this.btn_mdf.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_mdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mdf.Location = new System.Drawing.Point(8, 154);
            this.btn_mdf.Name = "btn_mdf";
            this.btn_mdf.Size = new System.Drawing.Size(179, 45);
            this.btn_mdf.TabIndex = 2;
            this.btn_mdf.Text = "Modifier";
            this.btn_mdf.UseVisualStyleBackColor = false;
            this.btn_mdf.Click += new System.EventHandler(this.btn_mdf_Click);
            // 
            // btn_ajtr
            // 
            this.btn_ajtr.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_ajtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajtr.Location = new System.Drawing.Point(8, 88);
            this.btn_ajtr.Name = "btn_ajtr";
            this.btn_ajtr.Size = new System.Drawing.Size(179, 45);
            this.btn_ajtr.TabIndex = 1;
            this.btn_ajtr.Text = "Ajouter";
            this.btn_ajtr.UseVisualStyleBackColor = false;
            this.btn_ajtr.Click += new System.EventHandler(this.btn_ajtr_Click);
            // 
            // btn_nv
            // 
            this.btn_nv.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_nv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nv.Location = new System.Drawing.Point(8, 22);
            this.btn_nv.Name = "btn_nv";
            this.btn_nv.Size = new System.Drawing.Size(179, 45);
            this.btn_nv.TabIndex = 0;
            this.btn_nv.Text = "Vide les champs";
            this.btn_nv.UseVisualStyleBackColor = false;
            this.btn_nv.Click += new System.EventHandler(this.btn_nv_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(685, 237);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(981, 431);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_adresse;
        private System.Windows.Forms.TextBox txt_tele;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_cin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_spr;
        private System.Windows.Forms.Button btn_mdf;
        private System.Windows.Forms.Button btn_ajtr;
        private System.Windows.Forms.Button btn_nv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Rechercher;
    }
}