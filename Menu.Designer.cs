namespace Gestion_de_pharmacie
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtn_vente = new Gestion_de_pharmacie.RoundButton();
            this.rbtn_fornissuer = new Gestion_de_pharmacie.RoundButton();
            this.rbtn_stock = new Gestion_de_pharmacie.RoundButton();
            this.rbtn_Medicament = new Gestion_de_pharmacie.RoundButton();
            this.rbtn_famMed = new Gestion_de_pharmacie.RoundButton();
            this.rbtn_Commande = new Gestion_de_pharmacie.RoundButton();
            this.rbtn_client = new Gestion_de_pharmacie.RoundButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1136, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Menu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(95, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 564);
            this.panel1.TabIndex = 16;
            // 
            // rbtn_vente
            // 
            this.rbtn_vente.FlatAppearance.BorderSize = 0;
            this.rbtn_vente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_vente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbtn_vente.Location = new System.Drawing.Point(345, 7);
            this.rbtn_vente.Name = "rbtn_vente";
            this.rbtn_vente.Size = new System.Drawing.Size(111, 87);
            this.rbtn_vente.TabIndex = 14;
            this.rbtn_vente.Text = "Vente";
            this.rbtn_vente.UseVisualStyleBackColor = true;
            this.rbtn_vente.Click += new System.EventHandler(this.rbtn_vente_Click);
            // 
            // rbtn_fornissuer
            // 
            this.rbtn_fornissuer.FlatAppearance.BorderSize = 0;
            this.rbtn_fornissuer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_fornissuer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbtn_fornissuer.Location = new System.Drawing.Point(998, 7);
            this.rbtn_fornissuer.Name = "rbtn_fornissuer";
            this.rbtn_fornissuer.Size = new System.Drawing.Size(111, 87);
            this.rbtn_fornissuer.TabIndex = 13;
            this.rbtn_fornissuer.Text = "Fournisseur";
            this.rbtn_fornissuer.UseVisualStyleBackColor = true;
            this.rbtn_fornissuer.Click += new System.EventHandler(this.rbtn_fornissuer_Click);
            // 
            // rbtn_stock
            // 
            this.rbtn_stock.FlatAppearance.BorderSize = 0;
            this.rbtn_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbtn_stock.Location = new System.Drawing.Point(462, 7);
            this.rbtn_stock.Name = "rbtn_stock";
            this.rbtn_stock.Size = new System.Drawing.Size(111, 87);
            this.rbtn_stock.TabIndex = 12;
            this.rbtn_stock.Text = "Stock";
            this.rbtn_stock.UseVisualStyleBackColor = true;
            this.rbtn_stock.Click += new System.EventHandler(this.rbtn_stock_Click);
            // 
            // rbtn_Medicament
            // 
            this.rbtn_Medicament.FlatAppearance.BorderSize = 0;
            this.rbtn_Medicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Medicament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbtn_Medicament.Location = new System.Drawing.Point(881, 6);
            this.rbtn_Medicament.Name = "rbtn_Medicament";
            this.rbtn_Medicament.Size = new System.Drawing.Size(111, 87);
            this.rbtn_Medicament.TabIndex = 11;
            this.rbtn_Medicament.Text = "Medicament ";
            this.rbtn_Medicament.UseVisualStyleBackColor = true;
            this.rbtn_Medicament.Click += new System.EventHandler(this.rbtn_Medicament_Click);
            // 
            // rbtn_famMed
            // 
            this.rbtn_famMed.FlatAppearance.BorderSize = 0;
            this.rbtn_famMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_famMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbtn_famMed.Location = new System.Drawing.Point(764, 6);
            this.rbtn_famMed.Name = "rbtn_famMed";
            this.rbtn_famMed.Size = new System.Drawing.Size(111, 87);
            this.rbtn_famMed.TabIndex = 10;
            this.rbtn_famMed.Text = "Famille medicament";
            this.rbtn_famMed.UseVisualStyleBackColor = true;
            this.rbtn_famMed.Click += new System.EventHandler(this.rbtn_famMed_Click);
            // 
            // rbtn_Commande
            // 
            this.rbtn_Commande.FlatAppearance.BorderSize = 0;
            this.rbtn_Commande.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Commande.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbtn_Commande.Location = new System.Drawing.Point(228, 6);
            this.rbtn_Commande.Name = "rbtn_Commande";
            this.rbtn_Commande.Size = new System.Drawing.Size(111, 87);
            this.rbtn_Commande.TabIndex = 9;
            this.rbtn_Commande.Text = "Commande";
            this.rbtn_Commande.UseVisualStyleBackColor = true;
            this.rbtn_Commande.Click += new System.EventHandler(this.rbtn_Commande_Click);
            // 
            // rbtn_client
            // 
            this.rbtn_client.FlatAppearance.BorderSize = 0;
            this.rbtn_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_client.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbtn_client.Location = new System.Drawing.Point(647, 7);
            this.rbtn_client.Name = "rbtn_client";
            this.rbtn_client.Size = new System.Drawing.Size(111, 83);
            this.rbtn_client.TabIndex = 8;
            this.rbtn_client.Text = "Client";
            this.rbtn_client.UseVisualStyleBackColor = true;
            this.rbtn_client.Click += new System.EventHandler(this.rbtn_client_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 668);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtn_vente);
            this.Controls.Add(this.rbtn_fornissuer);
            this.Controls.Add(this.rbtn_stock);
            this.Controls.Add(this.rbtn_Medicament);
            this.Controls.Add(this.rbtn_famMed);
            this.Controls.Add(this.rbtn_Commande);
            this.Controls.Add(this.rbtn_client);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton rbtn_client;
        private RoundButton rbtn_Commande;
        private RoundButton rbtn_famMed;
        private RoundButton rbtn_Medicament;
        private RoundButton rbtn_stock;
        private RoundButton rbtn_fornissuer;
        private RoundButton rbtn_vente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}