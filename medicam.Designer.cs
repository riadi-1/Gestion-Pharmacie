namespace Gestion_de_pharmacie
{
    partial class medicam
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.cmb_fam = new System.Windows.Forms.ComboBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_prx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_ray = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_sup = new System.Windows.Forms.Button();
            this.btn_mdf = new System.Windows.Forms.Button();
            this.btn_rech_byRay = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_chByNom = new System.Windows.Forms.Button();
            this.btn_recherByFaml = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro :";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(133, 12);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(188, 23);
            this.txt_id.TabIndex = 1;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // cmb_fam
            // 
            this.cmb_fam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_fam.FormattingEnabled = true;
            this.cmb_fam.Location = new System.Drawing.Point(261, 52);
            this.cmb_fam.Name = "cmb_fam";
            this.cmb_fam.Size = new System.Drawing.Size(188, 25);
            this.cmb_fam.TabIndex = 2;
            // 
            // txt_nom
            // 
            this.txt_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom.Location = new System.Drawing.Point(396, 13);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(188, 23);
            this.txt_nom.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Famille Medicament  :";
            // 
            // txt_prx
            // 
            this.txt_prx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prx.Location = new System.Drawing.Point(133, 94);
            this.txt_prx.Name = "txt_prx";
            this.txt_prx.Size = new System.Drawing.Size(188, 23);
            this.txt_prx.TabIndex = 8;
            this.txt_prx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_prx_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rayon :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Prix :";
            // 
            // cmb_ray
            // 
            this.cmb_ray.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ray.FormattingEnabled = true;
            this.cmb_ray.Location = new System.Drawing.Point(396, 92);
            this.cmb_ray.Name = "cmb_ray";
            this.cmb_ray.Size = new System.Drawing.Size(188, 25);
            this.cmb_ray.TabIndex = 12;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.LightYellow;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(61, 148);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(141, 38);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "Ajouter";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_sup
            // 
            this.btn_sup.BackColor = System.Drawing.Color.LightYellow;
            this.btn_sup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sup.Location = new System.Drawing.Point(252, 148);
            this.btn_sup.Name = "btn_sup";
            this.btn_sup.Size = new System.Drawing.Size(141, 38);
            this.btn_sup.TabIndex = 15;
            this.btn_sup.Text = "Suprimer";
            this.btn_sup.UseVisualStyleBackColor = false;
            this.btn_sup.Click += new System.EventHandler(this.btn_sup_Click);
            // 
            // btn_mdf
            // 
            this.btn_mdf.BackColor = System.Drawing.Color.LightYellow;
            this.btn_mdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mdf.Location = new System.Drawing.Point(443, 148);
            this.btn_mdf.Name = "btn_mdf";
            this.btn_mdf.Size = new System.Drawing.Size(141, 38);
            this.btn_mdf.TabIndex = 16;
            this.btn_mdf.Text = "Modifier";
            this.btn_mdf.UseVisualStyleBackColor = false;
            this.btn_mdf.Click += new System.EventHandler(this.btn_mdf_Click);
            // 
            // btn_rech_byRay
            // 
            this.btn_rech_byRay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rech_byRay.Location = new System.Drawing.Point(172, 266);
            this.btn_rech_byRay.Name = "btn_rech_byRay";
            this.btn_rech_byRay.Size = new System.Drawing.Size(197, 50);
            this.btn_rech_byRay.TabIndex = 17;
            this.btn_rech_byRay.Text = "Rech par rayon";
            this.btn_rech_byRay.UseVisualStyleBackColor = true;
            this.btn_rech_byRay.Click += new System.EventHandler(this.btn_rech_byRay_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(170, 352);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 215);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btn_chByNom
            // 
            this.btn_chByNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chByNom.Location = new System.Drawing.Point(398, 266);
            this.btn_chByNom.Name = "btn_chByNom";
            this.btn_chByNom.Size = new System.Drawing.Size(197, 50);
            this.btn_chByNom.TabIndex = 19;
            this.btn_chByNom.Text = "Rech par nom";
            this.btn_chByNom.UseVisualStyleBackColor = true;
            this.btn_chByNom.Click += new System.EventHandler(this.btn_chByNom_Click);
            // 
            // btn_recherByFaml
            // 
            this.btn_recherByFaml.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recherByFaml.Location = new System.Drawing.Point(623, 266);
            this.btn_recherByFaml.Name = "btn_recherByFaml";
            this.btn_recherByFaml.Size = new System.Drawing.Size(197, 50);
            this.btn_recherByFaml.TabIndex = 20;
            this.btn_recherByFaml.Text = "Rech par famille medicament";
            this.btn_recherByFaml.UseVisualStyleBackColor = true;
            this.btn_recherByFaml.Click += new System.EventHandler(this.btn_recherByFaml_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmb_fam);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_nom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_mdf);
            this.panel1.Controls.Add(this.txt_prx);
            this.panel1.Controls.Add(this.btn_sup);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.cmb_ray);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(172, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 206);
            this.panel1.TabIndex = 23;
            // 
            // medicam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1042, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_recherByFaml);
            this.Controls.Add(this.btn_chByNom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_rech_byRay);
            this.Name = "medicam";
            this.Text = "Medicament ";
            this.Load += new System.EventHandler(this.medicam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.ComboBox cmb_fam;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_prx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_ray;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_sup;
        private System.Windows.Forms.Button btn_mdf;
        private System.Windows.Forms.Button btn_rech_byRay;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_chByNom;
        private System.Windows.Forms.Button btn_recherByFaml;
        private System.Windows.Forms.Panel panel1;
    }
}