namespace Gestion_de_pharmacie
{
    partial class Archive
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
            this.btn_Exporter = new FontAwesome.Sharp.IconButton();
            this.panelMenuRight = new System.Windows.Forms.Panel();
            this.panelDemande = new System.Windows.Forms.Panel();
            this.panelFornisseur = new System.Windows.Forms.Panel();
            this.cmbx_fournisseur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RadioB_D_Tous = new System.Windows.Forms.RadioButton();
            this.RadioB_D_fournisseur = new System.Windows.Forms.RadioButton();
            this.panelVente = new System.Windows.Forms.Panel();
            this.panelClient = new System.Windows.Forms.Panel();
            this.cmbx_client = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RadioB_V_tous = new System.Windows.Forms.RadioButton();
            this.RadioB_V_client = new System.Windows.Forms.RadioButton();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioB_demande = new System.Windows.Forms.RadioButton();
            this.RadioB_Vente = new System.Windows.Forms.RadioButton();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelDemande.SuspendLayout();
            this.panelFornisseur.SuspendLayout();
            this.panelVente.SuspendLayout();
            this.panelClient.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Exporter
            // 
            this.btn_Exporter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Exporter.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_Exporter.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Exporter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exporter.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.btn_Exporter.IconColor = System.Drawing.Color.Black;
            this.btn_Exporter.IconSize = 40;
            this.btn_Exporter.Location = new System.Drawing.Point(575, 7);
            this.btn_Exporter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exporter.Name = "btn_Exporter";
            this.btn_Exporter.Rotation = 0D;
            this.btn_Exporter.Size = new System.Drawing.Size(187, 49);
            this.btn_Exporter.TabIndex = 0;
            this.btn_Exporter.Text = "Exporter";
            this.btn_Exporter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Exporter.UseVisualStyleBackColor = false;
            this.btn_Exporter.Click += new System.EventHandler(this.btn_Exporter_Click);
            // 
            // panelMenuRight
            // 
            this.panelMenuRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelMenuRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenuRight.Location = new System.Drawing.Point(1385, 0);
            this.panelMenuRight.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenuRight.Name = "panelMenuRight";
            this.panelMenuRight.Size = new System.Drawing.Size(43, 556);
            this.panelMenuRight.TabIndex = 2;
            this.panelMenuRight.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenuRight_Paint);
            // 
            // panelDemande
            // 
            this.panelDemande.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelDemande.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDemande.Controls.Add(this.panelFornisseur);
            this.panelDemande.Controls.Add(this.RadioB_D_Tous);
            this.panelDemande.Controls.Add(this.RadioB_D_fournisseur);
            this.panelDemande.Location = new System.Drawing.Point(1009, 10);
            this.panelDemande.Margin = new System.Windows.Forms.Padding(4);
            this.panelDemande.Name = "panelDemande";
            this.panelDemande.Size = new System.Drawing.Size(309, 146);
            this.panelDemande.TabIndex = 1;
            // 
            // panelFornisseur
            // 
            this.panelFornisseur.Controls.Add(this.cmbx_fournisseur);
            this.panelFornisseur.Controls.Add(this.label2);
            this.panelFornisseur.Location = new System.Drawing.Point(21, 50);
            this.panelFornisseur.Margin = new System.Windows.Forms.Padding(4);
            this.panelFornisseur.Name = "panelFornisseur";
            this.panelFornisseur.Size = new System.Drawing.Size(267, 81);
            this.panelFornisseur.TabIndex = 8;
            // 
            // cmbx_fournisseur
            // 
            this.cmbx_fournisseur.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbx_fournisseur.FormattingEnabled = true;
            this.cmbx_fournisseur.Location = new System.Drawing.Point(20, 43);
            this.cmbx_fournisseur.Margin = new System.Windows.Forms.Padding(4);
            this.cmbx_fournisseur.Name = "cmbx_fournisseur";
            this.cmbx_fournisseur.Size = new System.Drawing.Size(227, 24);
            this.cmbx_fournisseur.TabIndex = 7;
            this.cmbx_fournisseur.SelectionChangeCommitted += new System.EventHandler(this.cmbx_fournisseur_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choisie un fournisseur  ";
            // 
            // RadioB_D_Tous
            // 
            this.RadioB_D_Tous.AutoSize = true;
            this.RadioB_D_Tous.Location = new System.Drawing.Point(45, 16);
            this.RadioB_D_Tous.Margin = new System.Windows.Forms.Padding(4);
            this.RadioB_D_Tous.Name = "RadioB_D_Tous";
            this.RadioB_D_Tous.Size = new System.Drawing.Size(59, 20);
            this.RadioB_D_Tous.TabIndex = 5;
            this.RadioB_D_Tous.TabStop = true;
            this.RadioB_D_Tous.Text = "Tous";
            this.RadioB_D_Tous.UseVisualStyleBackColor = true;
            this.RadioB_D_Tous.CheckedChanged += new System.EventHandler(this.RadioB_D_Tous_CheckedChanged);
            // 
            // RadioB_D_fournisseur
            // 
            this.RadioB_D_fournisseur.AutoSize = true;
            this.RadioB_D_fournisseur.Location = new System.Drawing.Point(143, 16);
            this.RadioB_D_fournisseur.Margin = new System.Windows.Forms.Padding(4);
            this.RadioB_D_fournisseur.Name = "RadioB_D_fournisseur";
            this.RadioB_D_fournisseur.Size = new System.Drawing.Size(117, 20);
            this.RadioB_D_fournisseur.TabIndex = 4;
            this.RadioB_D_fournisseur.TabStop = true;
            this.RadioB_D_fournisseur.Text = "Par fournisseur";
            this.RadioB_D_fournisseur.UseVisualStyleBackColor = true;
            this.RadioB_D_fournisseur.CheckedChanged += new System.EventHandler(this.RadioB_D_fournisseur_CheckedChanged);
            // 
            // panelVente
            // 
            this.panelVente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelVente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVente.Controls.Add(this.panelClient);
            this.panelVente.Controls.Add(this.RadioB_V_tous);
            this.panelVente.Controls.Add(this.RadioB_V_client);
            this.panelVente.Location = new System.Drawing.Point(627, 10);
            this.panelVente.Margin = new System.Windows.Forms.Padding(4);
            this.panelVente.Name = "panelVente";
            this.panelVente.Size = new System.Drawing.Size(309, 146);
            this.panelVente.TabIndex = 0;
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.cmbx_client);
            this.panelClient.Controls.Add(this.label1);
            this.panelClient.Location = new System.Drawing.Point(21, 53);
            this.panelClient.Margin = new System.Windows.Forms.Padding(4);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(267, 78);
            this.panelClient.TabIndex = 4;
            // 
            // cmbx_client
            // 
            this.cmbx_client.FormattingEnabled = true;
            this.cmbx_client.Location = new System.Drawing.Point(21, 39);
            this.cmbx_client.Margin = new System.Windows.Forms.Padding(4);
            this.cmbx_client.Name = "cmbx_client";
            this.cmbx_client.Size = new System.Drawing.Size(227, 24);
            this.cmbx_client.TabIndex = 3;
            this.cmbx_client.SelectionChangeCommitted += new System.EventHandler(this.cmbx_client_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choisie un client ";
            // 
            // RadioB_V_tous
            // 
            this.RadioB_V_tous.AutoSize = true;
            this.RadioB_V_tous.Location = new System.Drawing.Point(49, 17);
            this.RadioB_V_tous.Margin = new System.Windows.Forms.Padding(4);
            this.RadioB_V_tous.Name = "RadioB_V_tous";
            this.RadioB_V_tous.Size = new System.Drawing.Size(59, 20);
            this.RadioB_V_tous.TabIndex = 1;
            this.RadioB_V_tous.TabStop = true;
            this.RadioB_V_tous.Text = "Tous";
            this.RadioB_V_tous.UseVisualStyleBackColor = true;
            this.RadioB_V_tous.CheckedChanged += new System.EventHandler(this.RadioB_V_tous_CheckedChanged);
            // 
            // RadioB_V_client
            // 
            this.RadioB_V_client.AutoSize = true;
            this.RadioB_V_client.Location = new System.Drawing.Point(159, 17);
            this.RadioB_V_client.Margin = new System.Windows.Forms.Padding(4);
            this.RadioB_V_client.Name = "RadioB_V_client";
            this.RadioB_V_client.Size = new System.Drawing.Size(85, 20);
            this.RadioB_V_client.TabIndex = 0;
            this.RadioB_V_client.TabStop = true;
            this.RadioB_V_client.Text = "Par Client";
            this.RadioB_V_client.UseVisualStyleBackColor = true;
            this.RadioB_V_client.CheckedChanged += new System.EventHandler(this.RadioB_V_client_CheckedChanged);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelHeader.Controls.Add(this.panelDemande);
            this.panelHeader.Controls.Add(this.groupBox1);
            this.panelHeader.Controls.Add(this.panelVente);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1385, 164);
            this.panelHeader.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.Controls.Add(this.RadioB_demande);
            this.groupBox1.Controls.Add(this.RadioB_Vente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(160, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(340, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Choisie le type d\'archive";
            // 
            // RadioB_demande
            // 
            this.RadioB_demande.AutoSize = true;
            this.RadioB_demande.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioB_demande.Location = new System.Drawing.Point(32, 85);
            this.RadioB_demande.Margin = new System.Windows.Forms.Padding(4);
            this.RadioB_demande.Name = "RadioB_demande";
            this.RadioB_demande.Size = new System.Drawing.Size(263, 29);
            this.RadioB_demande.TabIndex = 1;
            this.RadioB_demande.TabStop = true;
            this.RadioB_demande.Text = "Archive  des  comandes";
            this.RadioB_demande.UseVisualStyleBackColor = true;
            this.RadioB_demande.CheckedChanged += new System.EventHandler(this.RadioB_demande_CheckedChanged);
            // 
            // RadioB_Vente
            // 
            this.RadioB_Vente.AutoSize = true;
            this.RadioB_Vente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioB_Vente.Location = new System.Drawing.Point(32, 47);
            this.RadioB_Vente.Margin = new System.Windows.Forms.Padding(4);
            this.RadioB_Vente.Name = "RadioB_Vente";
            this.RadioB_Vente.Size = new System.Drawing.Size(194, 29);
            this.RadioB_Vente.TabIndex = 0;
            this.RadioB_Vente.TabStop = true;
            this.RadioB_Vente.Text = "Archive de vente";
            this.RadioB_Vente.UseVisualStyleBackColor = true;
            this.RadioB_Vente.CheckedChanged += new System.EventHandler(this.RadioB_Vente_CheckedChanged);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelFooter.Controls.Add(this.btn_Exporter);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 494);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(4);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1385, 62);
            this.panelFooter.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(0, 164);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1385, 330);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1428, 556);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenuRight);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Archive";
            this.Text = "Archive";
            this.Load += new System.EventHandler(this.Archive_Load);
            this.panelDemande.ResumeLayout(false);
            this.panelDemande.PerformLayout();
            this.panelFornisseur.ResumeLayout(false);
            this.panelFornisseur.PerformLayout();
            this.panelVente.ResumeLayout(false);
            this.panelVente.PerformLayout();
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_Exporter;
        private System.Windows.Forms.Panel panelMenuRight;
        private System.Windows.Forms.Panel panelDemande;
        private System.Windows.Forms.Panel panelFornisseur;
        private System.Windows.Forms.ComboBox cmbx_fournisseur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RadioB_D_Tous;
        private System.Windows.Forms.RadioButton RadioB_D_fournisseur;
        private System.Windows.Forms.Panel panelVente;
        private System.Windows.Forms.Panel panelClient;
        private System.Windows.Forms.ComboBox cmbx_client;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RadioB_V_tous;
        private System.Windows.Forms.RadioButton RadioB_V_client;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioB_demande;
        private System.Windows.Forms.RadioButton RadioB_Vente;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}