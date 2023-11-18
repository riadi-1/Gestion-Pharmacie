namespace Gestion_de_pharmacie
{
    partial class fam_Medic
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
            this.txt_des = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_rechN = new System.Windows.Forms.Button();
            this.btn_mdf = new System.Windows.Forms.Button();
            this.btn_sprm = new System.Windows.Forms.Button();
            this.btn_ajt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_des);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(219, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 120);
            this.panel1.TabIndex = 0;
            // 
            // txt_des
            // 
            this.txt_des.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_des.Location = new System.Drawing.Point(74, 57);
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(180, 23);
            this.txt_des.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom :";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(74, 11);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(180, 23);
            this.txt_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // btn_rechN
            // 
            this.btn_rechN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_rechN.Location = new System.Drawing.Point(165, 12);
            this.btn_rechN.Name = "btn_rechN";
            this.btn_rechN.Size = new System.Drawing.Size(182, 42);
            this.btn_rechN.TabIndex = 4;
            this.btn_rechN.Text = " Par nom";
            this.btn_rechN.UseVisualStyleBackColor = false;
            this.btn_rechN.Click += new System.EventHandler(this.btn_rechN_Click);
            // 
            // btn_mdf
            // 
            this.btn_mdf.BackColor = System.Drawing.Color.Pink;
            this.btn_mdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mdf.Location = new System.Drawing.Point(29, 82);
            this.btn_mdf.Name = "btn_mdf";
            this.btn_mdf.Size = new System.Drawing.Size(185, 30);
            this.btn_mdf.TabIndex = 2;
            this.btn_mdf.Text = "Modifier";
            this.btn_mdf.UseVisualStyleBackColor = false;
            this.btn_mdf.Click += new System.EventHandler(this.btn_mdf_Click);
            // 
            // btn_sprm
            // 
            this.btn_sprm.BackColor = System.Drawing.Color.Pink;
            this.btn_sprm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sprm.Location = new System.Drawing.Point(29, 45);
            this.btn_sprm.Name = "btn_sprm";
            this.btn_sprm.Size = new System.Drawing.Size(185, 30);
            this.btn_sprm.TabIndex = 1;
            this.btn_sprm.Text = "supprimer";
            this.btn_sprm.UseVisualStyleBackColor = false;
            this.btn_sprm.Click += new System.EventHandler(this.btn_sprm_Click);
            // 
            // btn_ajt
            // 
            this.btn_ajt.BackColor = System.Drawing.Color.Pink;
            this.btn_ajt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajt.Location = new System.Drawing.Point(29, 8);
            this.btn_ajt.Name = "btn_ajt";
            this.btn_ajt.Size = new System.Drawing.Size(185, 30);
            this.btn_ajt.TabIndex = 0;
            this.btn_ajt.Text = "Ajouter";
            this.btn_ajt.UseVisualStyleBackColor = false;
            this.btn_ajt.Click += new System.EventHandler(this.btn_ajt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(219, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(522, 220);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btn_ajt);
            this.panel3.Controls.Add(this.btn_sprm);
            this.panel3.Controls.Add(this.btn_mdf);
            this.panel3.Location = new System.Drawing.Point(497, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 120);
            this.panel3.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_rechN);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(219, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 68);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher : ";
            // 
            // fam_Medic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(981, 452);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "fam_Medic";
            this.Text = "Famille medicament";
            this.Load += new System.EventHandler(this.fam_Medic_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_des;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ajt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_mdf;
        private System.Windows.Forms.Button btn_sprm;
        private System.Windows.Forms.Button btn_rechN;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}