namespace LogiS
{
    partial class FormFactureRecherche
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFactureRecherche));
            this.dgvFournis = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPayer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemFacture = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPayement = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFacturePayement = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFournisseur = new System.Windows.Forms.TextBox();
            this.btnFournisseur = new System.Windows.Forms.Button();
            this.lblPays = new System.Windows.Forms.Label();
            this.btnTriDette = new System.Windows.Forms.Button();
            this.btnTriPayement = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemAfficher = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFournis)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFournis
            // 
            this.dgvFournis.AllowUserToAddRows = false;
            this.dgvFournis.AllowUserToDeleteRows = false;
            this.dgvFournis.AllowUserToResizeColumns = false;
            this.dgvFournis.AllowUserToResizeRows = false;
            this.dgvFournis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFournis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvFournis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFournis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFournis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFournis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFournis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column1,
            this.Column16,
            this.Column11,
            this.Column2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFournis.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFournis.EnableHeadersVisualStyles = false;
            this.dgvFournis.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.dgvFournis.Location = new System.Drawing.Point(12, 103);
            this.dgvFournis.MultiSelect = false;
            this.dgvFournis.Name = "dgvFournis";
            this.dgvFournis.ReadOnly = true;
            this.dgvFournis.RowHeadersVisible = false;
            this.dgvFournis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFournis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFournis.Size = new System.Drawing.Size(679, 336);
            this.dgvFournis.TabIndex = 838;
            this.dgvFournis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFournis_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "N°";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 40;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "idfournisseur";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column16
            // 
            this.Column16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column16.HeaderText = "Fournisseur";
            this.Column16.MinimumWidth = 150;
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.Column11.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column11.HeaderText = "Total à payer";
            this.Column11.MinimumWidth = 100;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Total payé";
            this.Column2.MinimumWidth = 100;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(673, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 35);
            this.btnExit.TabIndex = 840;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 27);
            this.panel2.TabIndex = 839;
            // 
            // btnPayer
            // 
            this.btnPayer.BackColor = System.Drawing.Color.Transparent;
            this.btnPayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPayer.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPayer.FlatAppearance.BorderSize = 0;
            this.btnPayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPayer.Image = ((System.Drawing.Image)(resources.GetObject("btnPayer.Image")));
            this.btnPayer.Location = new System.Drawing.Point(122, 0);
            this.btnPayer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPayer.Name = "btnPayer";
            this.btnPayer.Size = new System.Drawing.Size(142, 35);
            this.btnPayer.TabIndex = 841;
            this.btnPayer.Text = "Journal payements";
            this.btnPayer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayer.UseVisualStyleBackColor = false;
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Transparent;
            this.btnModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModifier.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnModifier.Image = ((System.Drawing.Image)(resources.GetObject("btnModifier.Image")));
            this.btnModifier.Location = new System.Drawing.Point(0, 0);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(122, 35);
            this.btnModifier.TabIndex = 842;
            this.btnModifier.Text = "Journal factures";
            this.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifier.UseVisualStyleBackColor = false;
            // 
            // btnNouveau
            // 
            this.btnNouveau.BackColor = System.Drawing.Color.Transparent;
            this.btnNouveau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNouveau.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNouveau.FlatAppearance.BorderSize = 0;
            this.btnNouveau.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNouveau.Image = ((System.Drawing.Image)(resources.GetObject("btnNouveau.Image")));
            this.btnNouveau.Location = new System.Drawing.Point(264, 0);
            this.btnNouveau.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(160, 35);
            this.btnNouveau.TabIndex = 843;
            this.btnNouveau.Text = "Factures et payements";
            this.btnNouveau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNouveau.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.btnNouveau);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnPayer);
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 35);
            this.panel1.TabIndex = 844;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAfficher,
            this.toolStripSeparator1,
            this.itemFacture,
            this.itemPayement,
            this.itemFacturePayement});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(388, 163);
            // 
            // itemFacture
            // 
            this.itemFacture.Image = ((System.Drawing.Image)(resources.GetObject("itemFacture.Image")));
            this.itemFacture.Name = "itemFacture";
            this.itemFacture.Size = new System.Drawing.Size(387, 30);
            this.itemFacture.Text = "Factures du fournisseur";
            // 
            // itemPayement
            // 
            this.itemPayement.Image = ((System.Drawing.Image)(resources.GetObject("itemPayement.Image")));
            this.itemPayement.Name = "itemPayement";
            this.itemPayement.Size = new System.Drawing.Size(387, 30);
            this.itemPayement.Text = "Payements au fournisseur";
            // 
            // itemFacturePayement
            // 
            this.itemFacturePayement.Image = ((System.Drawing.Image)(resources.GetObject("itemFacturePayement.Image")));
            this.itemFacturePayement.Name = "itemFacturePayement";
            this.itemFacturePayement.Size = new System.Drawing.Size(387, 30);
            this.itemFacturePayement.Text = "Factures et payements du fournisseur";
            // 
            // txtFournisseur
            // 
            this.txtFournisseur.Location = new System.Drawing.Point(85, 74);
            this.txtFournisseur.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtFournisseur.MaxLength = 75;
            this.txtFournisseur.Name = "txtFournisseur";
            this.txtFournisseur.Size = new System.Drawing.Size(129, 28);
            this.txtFournisseur.TabIndex = 847;
            // 
            // btnFournisseur
            // 
            this.btnFournisseur.BackColor = System.Drawing.Color.Transparent;
            this.btnFournisseur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFournisseur.FlatAppearance.BorderSize = 0;
            this.btnFournisseur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFournisseur.Image = ((System.Drawing.Image)(resources.GetObject("btnFournisseur.Image")));
            this.btnFournisseur.Location = new System.Drawing.Point(219, 74);
            this.btnFournisseur.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnFournisseur.Name = "btnFournisseur";
            this.btnFournisseur.Size = new System.Drawing.Size(30, 21);
            this.btnFournisseur.TabIndex = 846;
            this.toolTip1.SetToolTip(this.btnFournisseur, "Afficher");
            this.btnFournisseur.UseVisualStyleBackColor = false;
            // 
            // lblPays
            // 
            this.lblPays.AutoSize = true;
            this.lblPays.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPays.Location = new System.Drawing.Point(8, 77);
            this.lblPays.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPays.Name = "lblPays";
            this.lblPays.Size = new System.Drawing.Size(115, 22);
            this.lblPays.TabIndex = 845;
            this.lblPays.Text = "Fournisseur :";
            // 
            // btnTriDette
            // 
            this.btnTriDette.BackColor = System.Drawing.Color.Transparent;
            this.btnTriDette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTriDette.FlatAppearance.BorderSize = 0;
            this.btnTriDette.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTriDette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTriDette.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnTriDette.Image = ((System.Drawing.Image)(resources.GetObject("btnTriDette.Image")));
            this.btnTriDette.Location = new System.Drawing.Point(261, 74);
            this.btnTriDette.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnTriDette.Name = "btnTriDette";
            this.btnTriDette.Size = new System.Drawing.Size(30, 21);
            this.btnTriDette.TabIndex = 846;
            this.toolTip1.SetToolTip(this.btnTriDette, "Ordre croissant de dettes");
            this.btnTriDette.UseVisualStyleBackColor = false;
            this.btnTriDette.Click += new System.EventHandler(this.btnTriDette_Click);
            // 
            // btnTriPayement
            // 
            this.btnTriPayement.BackColor = System.Drawing.Color.Transparent;
            this.btnTriPayement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTriPayement.FlatAppearance.BorderSize = 0;
            this.btnTriPayement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTriPayement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTriPayement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnTriPayement.Image = ((System.Drawing.Image)(resources.GetObject("btnTriPayement.Image")));
            this.btnTriPayement.Location = new System.Drawing.Point(303, 74);
            this.btnTriPayement.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnTriPayement.Name = "btnTriPayement";
            this.btnTriPayement.Size = new System.Drawing.Size(30, 21);
            this.btnTriPayement.TabIndex = 846;
            this.toolTip1.SetToolTip(this.btnTriPayement, "Ordre croissant de payements");
            this.btnTriPayement.UseVisualStyleBackColor = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(384, 6);
            // 
            // itemAfficher
            // 
            this.itemAfficher.Image = ((System.Drawing.Image)(resources.GetObject("itemAfficher.Image")));
            this.itemAfficher.Name = "itemAfficher";
            this.itemAfficher.Size = new System.Drawing.Size(387, 30);
            this.itemAfficher.Text = "Afficher ce fournisseur";
            // 
            // FormFactureRecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(703, 451);
            this.Controls.Add(this.txtFournisseur);
            this.Controls.Add(this.btnTriPayement);
            this.Controls.Add(this.btnTriDette);
            this.Controls.Add(this.btnFournisseur);
            this.Controls.Add(this.lblPays);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvFournis);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFactureRecherche";
            this.Text = "FormRecherche";
            this.Shown += new System.EventHandler(this.FormFactureRecherche_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFournis)).EndInit();
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvFournis;
        public System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnPayer;
        public System.Windows.Forms.Button btnModifier;
        public System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemFacture;
        private System.Windows.Forms.ToolStripMenuItem itemPayement;
        private System.Windows.Forms.ToolStripMenuItem itemFacturePayement;
        public System.Windows.Forms.TextBox txtFournisseur;
        public System.Windows.Forms.Button btnFournisseur;
        public System.Windows.Forms.Label lblPays;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        public System.Windows.Forms.Button btnTriDette;
        public System.Windows.Forms.Button btnTriPayement;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem itemAfficher;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}