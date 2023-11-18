namespace Gestion_de_pharmacie
{
    partial class Vente
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbx_client = new System.Windows.Forms.ComboBox();
            this.radioB_non = new System.Windows.Forms.RadioButton();
            this.radioB_oui = new System.Windows.Forms.RadioButton();
            this.cmbx_medicament = new System.Windows.Forms.ComboBox();
            this.label_PrixTotal = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_add = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_left = new FontAwesome.Sharp.IconButton();
            this.btn_right = new FontAwesome.Sharp.IconButton();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Client : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Famille de medicament :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(443, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Montant : ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.radioB_non);
            this.panel1.Controls.Add(this.radioB_oui);
            this.panel1.Location = new System.Drawing.Point(164, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 84);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "S\'agit-il d\'un acheteur certifié?";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbx_client);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(161, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(317, 37);
            this.panel3.TabIndex = 9;
            // 
            // cmbx_client
            // 
            this.cmbx_client.FormattingEnabled = true;
            this.cmbx_client.Location = new System.Drawing.Point(89, 6);
            this.cmbx_client.Name = "cmbx_client";
            this.cmbx_client.Size = new System.Drawing.Size(200, 25);
            this.cmbx_client.TabIndex = 8;
            // 
            // radioB_non
            // 
            this.radioB_non.AutoSize = true;
            this.radioB_non.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioB_non.Location = new System.Drawing.Point(445, 10);
            this.radioB_non.Name = "radioB_non";
            this.radioB_non.Size = new System.Drawing.Size(52, 21);
            this.radioB_non.TabIndex = 13;
            this.radioB_non.TabStop = true;
            this.radioB_non.Text = "Non";
            this.radioB_non.UseVisualStyleBackColor = true;
            this.radioB_non.CheckedChanged += new System.EventHandler(this.radioB_non_CheckedChanged);
            // 
            // radioB_oui
            // 
            this.radioB_oui.AutoSize = true;
            this.radioB_oui.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioB_oui.Location = new System.Drawing.Point(391, 10);
            this.radioB_oui.Name = "radioB_oui";
            this.radioB_oui.Size = new System.Drawing.Size(48, 21);
            this.radioB_oui.TabIndex = 12;
            this.radioB_oui.TabStop = true;
            this.radioB_oui.Text = "Oui";
            this.radioB_oui.UseVisualStyleBackColor = true;
            this.radioB_oui.CheckedChanged += new System.EventHandler(this.radioB_oui_CheckedChanged);
            // 
            // cmbx_medicament
            // 
            this.cmbx_medicament.FormattingEnabled = true;
            this.cmbx_medicament.Location = new System.Drawing.Point(470, 129);
            this.cmbx_medicament.Name = "cmbx_medicament";
            this.cmbx_medicament.Size = new System.Drawing.Size(200, 21);
            this.cmbx_medicament.TabIndex = 9;
            this.cmbx_medicament.SelectionChangeCommitted += new System.EventHandler(this.cmbx_medicament_SelectionChangeCommitted);
            // 
            // label_PrixTotal
            // 
            this.label_PrixTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_PrixTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PrixTotal.ForeColor = System.Drawing.Color.Blue;
            this.label_PrixTotal.Location = new System.Drawing.Point(520, 230);
            this.label_PrixTotal.Name = "label_PrixTotal";
            this.label_PrixTotal.Size = new System.Drawing.Size(163, 23);
            this.label_PrixTotal.TabIndex = 6;
            this.label_PrixTotal.Text = "0";
            this.label_PrixTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.btn_add);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label_PrixTotal);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.btn_left);
            this.panel4.Controls.Add(this.btn_right);
            this.panel4.Controls.Add(this.listBox2);
            this.panel4.Controls.Add(this.listBox1);
            this.panel4.Controls.Add(this.numericUpDown1);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(164, 156);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(722, 335);
            this.panel4.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(450, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 34);
            this.label8.TabIndex = 12;
            this.label8.Text = "Liste des médicaments  que vous avez \r\nchoiser :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Liste des médicaments : ";
            // 
            // btn_add
            // 
            this.btn_add.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btn_add.IconColor = System.Drawing.Color.MediumBlue;
            this.btn_add.IconSize = 40;
            this.btn_add.Location = new System.Drawing.Point(287, 275);
            this.btn_add.Name = "btn_add";
            this.btn_add.Rotation = 0D;
            this.btn_add.Size = new System.Drawing.Size(151, 40);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Acheter";
            this.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(648, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "DH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quantité";
            // 
            // btn_left
            // 
            this.btn_left.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_left.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.btn_left.IconColor = System.Drawing.Color.Black;
            this.btn_left.IconSize = 16;
            this.btn_left.Location = new System.Drawing.Point(352, 151);
            this.btn_left.Name = "btn_left";
            this.btn_left.Rotation = 0D;
            this.btn_left.Size = new System.Drawing.Size(75, 23);
            this.btn_left.TabIndex = 7;
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_right
            // 
            this.btn_right.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_right.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.btn_right.IconColor = System.Drawing.Color.Black;
            this.btn_right.IconSize = 16;
            this.btn_right.Location = new System.Drawing.Point(352, 113);
            this.btn_right.Name = "btn_right";
            this.btn_right.Rotation = 0D;
            this.btn_right.Size = new System.Drawing.Size(75, 23);
            this.btn_right.TabIndex = 6;
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.White;
            this.listBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(451, 44);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(232, 164);
            this.listBox2.TabIndex = 5;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(34, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(232, 164);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(352, 77);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 23);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Vente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1050, 503);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbx_medicament);
            this.Controls.Add(this.label4);
            this.Name = "Vente";
            this.Text = "Vente";
            this.Load += new System.EventHandler(this.Vente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbx_medicament;
        private System.Windows.Forms.ComboBox cmbx_client;
        private System.Windows.Forms.RadioButton radioB_non;
        private System.Windows.Forms.RadioButton radioB_oui;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label_PrixTotal;
        private FontAwesome.Sharp.IconButton btn_left;
        private FontAwesome.Sharp.IconButton btn_right;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btn_add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}