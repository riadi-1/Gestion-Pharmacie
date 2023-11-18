namespace Gestion_de_pharmacie
{
    partial class Commande
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_MontantTotal = new System.Windows.Forms.TextBox();
            this.txt_CodeC = new System.Windows.Forms.TextBox();
            this.Date_commande = new System.Windows.Forms.DateTimePicker();
            this.cmbx_Fournisseur = new System.Windows.Forms.ComboBox();
            this.cmbx_Medicament = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_sprm = new System.Windows.Forms.Button();
            this.btn_mdf = new System.Windows.Forms.Button();
            this.btn_ajtr = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_date = new Gestion_de_pharmacie.RoundButton();
            this.btn_medicament = new Gestion_de_pharmacie.RoundButton();
            this.btn_fournisseur = new Gestion_de_pharmacie.RoundButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_MontantTotal);
            this.panel1.Controls.Add(this.txt_CodeC);
            this.panel1.Controls.Add(this.Date_commande);
            this.panel1.Controls.Add(this.cmbx_Fournisseur);
            this.panel1.Controls.Add(this.cmbx_Medicament);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(157, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 208);
            this.panel1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(688, 87);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(312, 27);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(585, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Quantité :";
            // 
            // txt_MontantTotal
            // 
            this.txt_MontantTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MontantTotal.Location = new System.Drawing.Point(688, 133);
            this.txt_MontantTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MontantTotal.Name = "txt_MontantTotal";
            this.txt_MontantTotal.Size = new System.Drawing.Size(311, 27);
            this.txt_MontantTotal.TabIndex = 10;
            // 
            // txt_CodeC
            // 
            this.txt_CodeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodeC.Location = new System.Drawing.Point(227, 42);
            this.txt_CodeC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_CodeC.Name = "txt_CodeC";
            this.txt_CodeC.Size = new System.Drawing.Size(311, 27);
            this.txt_CodeC.TabIndex = 9;
            // 
            // Date_commande
            // 
            this.Date_commande.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_commande.Location = new System.Drawing.Point(227, 86);
            this.Date_commande.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Date_commande.Name = "Date_commande";
            this.Date_commande.Size = new System.Drawing.Size(311, 27);
            this.Date_commande.TabIndex = 8;
            // 
            // cmbx_Fournisseur
            // 
            this.cmbx_Fournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_Fournisseur.FormattingEnabled = true;
            this.cmbx_Fournisseur.Location = new System.Drawing.Point(688, 42);
            this.cmbx_Fournisseur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbx_Fournisseur.Name = "cmbx_Fournisseur";
            this.cmbx_Fournisseur.Size = new System.Drawing.Size(311, 28);
            this.cmbx_Fournisseur.TabIndex = 7;
            // 
            // cmbx_Medicament
            // 
            this.cmbx_Medicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_Medicament.FormattingEnabled = true;
            this.cmbx_Medicament.Location = new System.Drawing.Point(227, 132);
            this.cmbx_Medicament.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbx_Medicament.Name = "cmbx_Medicament";
            this.cmbx_Medicament.Size = new System.Drawing.Size(311, 28);
            this.cmbx_Medicament.TabIndex = 6;
            this.cmbx_Medicament.SelectionChangeCommitted += new System.EventHandler(this.cmbx_Medicament_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numéro  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(548, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Montant total :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(552, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fuornisseur  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Medicament :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_sprm);
            this.panel2.Controls.Add(this.btn_mdf);
            this.panel2.Controls.Add(this.btn_ajtr);
            this.panel2.Location = new System.Drawing.Point(281, 274);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 86);
            this.panel2.TabIndex = 1;
            // 
            // btn_sprm
            // 
            this.btn_sprm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sprm.Location = new System.Drawing.Point(641, 17);
            this.btn_sprm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sprm.Name = "btn_sprm";
            this.btn_sprm.Size = new System.Drawing.Size(183, 50);
            this.btn_sprm.TabIndex = 2;
            this.btn_sprm.Text = "Supprimer";
            this.btn_sprm.UseVisualStyleBackColor = true;
            this.btn_sprm.Click += new System.EventHandler(this.btn_sprm_Click);
            // 
            // btn_mdf
            // 
            this.btn_mdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mdf.Location = new System.Drawing.Point(331, 17);
            this.btn_mdf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_mdf.Name = "btn_mdf";
            this.btn_mdf.Size = new System.Drawing.Size(183, 50);
            this.btn_mdf.TabIndex = 1;
            this.btn_mdf.Text = "Modifier";
            this.btn_mdf.UseVisualStyleBackColor = true;
            this.btn_mdf.Click += new System.EventHandler(this.btn_mdf_Click);
            // 
            // btn_ajtr
            // 
            this.btn_ajtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajtr.Location = new System.Drawing.Point(20, 17);
            this.btn_ajtr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ajtr.Name = "btn_ajtr";
            this.btn_ajtr.Size = new System.Drawing.Size(183, 50);
            this.btn_ajtr.TabIndex = 0;
            this.btn_ajtr.Text = "Ajouter";
            this.btn_ajtr.UseVisualStyleBackColor = true;
            this.btn_ajtr.Click += new System.EventHandler(this.btn_ajtr_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.btn_date);
            this.groupBox1.Controls.Add(this.btn_medicament);
            this.groupBox1.Controls.Add(this.btn_fournisseur);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1011, 380);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(244, 292);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher";
            // 
            // btn_date
            // 
            this.btn_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_date.FlatAppearance.BorderSize = 0;
            this.btn_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_date.ForeColor = System.Drawing.Color.Black;
            this.btn_date.Location = new System.Drawing.Point(39, 199);
            this.btn_date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_date.Name = "btn_date";
            this.btn_date.Size = new System.Drawing.Size(164, 71);
            this.btn_date.TabIndex = 2;
            this.btn_date.Text = "Par date";
            this.btn_date.UseVisualStyleBackColor = false;
            this.btn_date.Click += new System.EventHandler(this.btn_date_Click);
            // 
            // btn_medicament
            // 
            this.btn_medicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_medicament.FlatAppearance.BorderSize = 0;
            this.btn_medicament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_medicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_medicament.ForeColor = System.Drawing.Color.Black;
            this.btn_medicament.Location = new System.Drawing.Point(39, 122);
            this.btn_medicament.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_medicament.Name = "btn_medicament";
            this.btn_medicament.Size = new System.Drawing.Size(161, 73);
            this.btn_medicament.TabIndex = 1;
            this.btn_medicament.Text = "Par medicament";
            this.btn_medicament.UseVisualStyleBackColor = false;
            this.btn_medicament.Click += new System.EventHandler(this.btn_medicament_Click);
            // 
            // btn_fournisseur
            // 
            this.btn_fournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_fournisseur.FlatAppearance.BorderSize = 0;
            this.btn_fournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fournisseur.ForeColor = System.Drawing.Color.Black;
            this.btn_fournisseur.Location = new System.Drawing.Point(39, 43);
            this.btn_fournisseur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_fournisseur.Name = "btn_fournisseur";
            this.btn_fournisseur.Size = new System.Drawing.Size(161, 74);
            this.btn_fournisseur.TabIndex = 0;
            this.btn_fournisseur.Text = "Par fournisseur";
            this.btn_fournisseur.UseVisualStyleBackColor = false;
            this.btn_fournisseur.Click += new System.EventHandler(this.btn_fournisseur_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(157, 380);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(845, 292);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1377, 687);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Commande";
            this.Text = "Commande";
            this.Load += new System.EventHandler(this.Commande_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MontantTotal;
        private System.Windows.Forms.TextBox txt_CodeC;
        private System.Windows.Forms.DateTimePicker Date_commande;
        private System.Windows.Forms.ComboBox cmbx_Fournisseur;
        private System.Windows.Forms.ComboBox cmbx_Medicament;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_sprm;
        private System.Windows.Forms.Button btn_mdf;
        private System.Windows.Forms.Button btn_ajtr;
        private System.Windows.Forms.GroupBox groupBox1;
        private RoundButton btn_date;
        private RoundButton btn_medicament;
        private RoundButton btn_fournisseur;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label7;
    }
}