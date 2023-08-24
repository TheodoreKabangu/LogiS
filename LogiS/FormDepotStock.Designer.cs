namespace LogiS
{
    partial class FormDepotStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepotStock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.txtProduit = new System.Windows.Forms.TextBox();
            this.lblPays = new System.Windows.Forms.Label();
            this.dgvProduit = new System.Windows.Forms.DataGridView();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.idstockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteinitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numlotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixventeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coutachatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomdepotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produitStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetStockProduit = new LogiS.DataSetStockProduit();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnLivrer = new System.Windows.Forms.Button();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.produitStockTableAdapter = new LogiS.DataSetStockProduitTableAdapters.ProduitStockTableAdapter();
            this.dataSetProduit = new LogiS.DataSetProduit();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produitTableAdapter = new LogiS.DataSetProduitTableAdapters.ProduitTableAdapter();
            this.idproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomcommercialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poidsunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetStockProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAfficher
            // 
            this.btnAfficher.BackColor = System.Drawing.Color.Transparent;
            this.btnAfficher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAfficher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAfficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAfficher.Image = ((System.Drawing.Image)(resources.GetObject("btnAfficher.Image")));
            this.btnAfficher.Location = new System.Drawing.Point(254, 38);
            this.btnAfficher.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(30, 21);
            this.btnAfficher.TabIndex = 895;
            this.toolTip1.SetToolTip(this.btnAfficher, "Rechercher");
            this.btnAfficher.UseVisualStyleBackColor = false;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // txtProduit
            // 
            this.txtProduit.Location = new System.Drawing.Point(62, 38);
            this.txtProduit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtProduit.MaxLength = 75;
            this.txtProduit.Name = "txtProduit";
            this.txtProduit.Size = new System.Drawing.Size(192, 28);
            this.txtProduit.TabIndex = 894;
            // 
            // lblPays
            // 
            this.lblPays.AutoSize = true;
            this.lblPays.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPays.Location = new System.Drawing.Point(8, 41);
            this.lblPays.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPays.Name = "lblPays";
            this.lblPays.Size = new System.Drawing.Size(77, 22);
            this.lblPays.TabIndex = 893;
            this.lblPays.Text = "Produit :";
            // 
            // dgvProduit
            // 
            this.dgvProduit.AllowUserToAddRows = false;
            this.dgvProduit.AllowUserToDeleteRows = false;
            this.dgvProduit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvProduit.AutoGenerateColumns = false;
            this.dgvProduit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvProduit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproduitDataGridViewTextBoxColumn,
            this.nomproduitDataGridViewTextBoxColumn,
            this.nomcommercialDataGridViewTextBoxColumn,
            this.uniteDataGridViewTextBoxColumn,
            this.poidsunitDataGridViewTextBoxColumn,
            this.volumeunitDataGridViewTextBoxColumn});
            this.dgvProduit.DataSource = this.produitBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduit.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduit.EnableHeadersVisualStyles = false;
            this.dgvProduit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.dgvProduit.Location = new System.Drawing.Point(12, 71);
            this.dgvProduit.MultiSelect = false;
            this.dgvProduit.Name = "dgvProduit";
            this.dgvProduit.ReadOnly = true;
            this.dgvProduit.RowHeadersVisible = false;
            this.dgvProduit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProduit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduit.Size = new System.Drawing.Size(230, 368);
            this.dgvProduit.TabIndex = 892;
            this.dgvProduit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduit_CellClick);
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStock.AutoGenerateColumns = false;
            this.dgvStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idstockDataGridViewTextBoxColumn,
            this.qteinitDataGridViewTextBoxColumn,
            this.numlotDataGridViewTextBoxColumn,
            this.expirationDataGridViewTextBoxColumn,
            this.prixventeDataGridViewTextBoxColumn,
            this.coutachatDataGridViewTextBoxColumn,
            this.nomdepotDataGridViewTextBoxColumn});
            this.dgvStock.DataSource = this.produitStockBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStock.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStock.EnableHeadersVisualStyles = false;
            this.dgvStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.dgvStock.Location = new System.Drawing.Point(248, 71);
            this.dgvStock.MultiSelect = false;
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(443, 368);
            this.dgvStock.TabIndex = 891;
            this.dgvStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellClick);
            // 
            // idstockDataGridViewTextBoxColumn
            // 
            this.idstockDataGridViewTextBoxColumn.DataPropertyName = "idstock";
            this.idstockDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idstockDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.idstockDataGridViewTextBoxColumn.Name = "idstockDataGridViewTextBoxColumn";
            this.idstockDataGridViewTextBoxColumn.ReadOnly = true;
            this.idstockDataGridViewTextBoxColumn.Width = 50;
            // 
            // qteinitDataGridViewTextBoxColumn
            // 
            this.qteinitDataGridViewTextBoxColumn.DataPropertyName = "qteinit";
            this.qteinitDataGridViewTextBoxColumn.HeaderText = "Qté";
            this.qteinitDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.qteinitDataGridViewTextBoxColumn.Name = "qteinitDataGridViewTextBoxColumn";
            this.qteinitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numlotDataGridViewTextBoxColumn
            // 
            this.numlotDataGridViewTextBoxColumn.DataPropertyName = "numlot";
            this.numlotDataGridViewTextBoxColumn.HeaderText = "N° lot";
            this.numlotDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.numlotDataGridViewTextBoxColumn.Name = "numlotDataGridViewTextBoxColumn";
            this.numlotDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expirationDataGridViewTextBoxColumn
            // 
            this.expirationDataGridViewTextBoxColumn.DataPropertyName = "expiration";
            this.expirationDataGridViewTextBoxColumn.HeaderText = "Expiration";
            this.expirationDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.expirationDataGridViewTextBoxColumn.Name = "expirationDataGridViewTextBoxColumn";
            this.expirationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixventeDataGridViewTextBoxColumn
            // 
            this.prixventeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prixventeDataGridViewTextBoxColumn.DataPropertyName = "prix_vente";
            this.prixventeDataGridViewTextBoxColumn.HeaderText = "Prix vente";
            this.prixventeDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.prixventeDataGridViewTextBoxColumn.Name = "prixventeDataGridViewTextBoxColumn";
            this.prixventeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coutachatDataGridViewTextBoxColumn
            // 
            this.coutachatDataGridViewTextBoxColumn.DataPropertyName = "cout_achat";
            this.coutachatDataGridViewTextBoxColumn.HeaderText = "cout_achat";
            this.coutachatDataGridViewTextBoxColumn.Name = "coutachatDataGridViewTextBoxColumn";
            this.coutachatDataGridViewTextBoxColumn.ReadOnly = true;
            this.coutachatDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomdepotDataGridViewTextBoxColumn
            // 
            this.nomdepotDataGridViewTextBoxColumn.DataPropertyName = "nomdepot";
            this.nomdepotDataGridViewTextBoxColumn.HeaderText = "Dépôt";
            this.nomdepotDataGridViewTextBoxColumn.Name = "nomdepotDataGridViewTextBoxColumn";
            this.nomdepotDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomdepotDataGridViewTextBoxColumn.Visible = false;
            // 
            // produitStockBindingSource
            // 
            this.produitStockBindingSource.DataMember = "ProduitStock";
            this.produitStockBindingSource.DataSource = this.dataSetStockProduit;
            // 
            // dataSetStockProduit
            // 
            this.dataSetStockProduit.DataSetName = "DataSetStockProduit";
            this.dataSetStockProduit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnLivrer
            // 
            this.btnLivrer.BackColor = System.Drawing.Color.Transparent;
            this.btnLivrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLivrer.Enabled = false;
            this.btnLivrer.FlatAppearance.BorderSize = 0;
            this.btnLivrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLivrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLivrer.Image = ((System.Drawing.Image)(resources.GetObject("btnLivrer.Image")));
            this.btnLivrer.Location = new System.Drawing.Point(296, 36);
            this.btnLivrer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLivrer.Name = "btnLivrer";
            this.btnLivrer.Size = new System.Drawing.Size(80, 26);
            this.btnLivrer.TabIndex = 897;
            this.btnLivrer.Text = "Livrer";
            this.btnLivrer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnLivrer, "Ajouter une livraison");
            this.btnLivrer.UseVisualStyleBackColor = false;
            this.btnLivrer.Click += new System.EventHandler(this.btnLivrer_Click);
            // 
            // btnImprimer
            // 
            this.btnImprimer.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImprimer.FlatAppearance.BorderSize = 0;
            this.btnImprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnImprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnImprimer.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimer.Image")));
            this.btnImprimer.Location = new System.Drawing.Point(480, 36);
            this.btnImprimer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(90, 26);
            this.btnImprimer.TabIndex = 898;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnImprimer, "Imprimer les stocks");
            this.btnImprimer.UseVisualStyleBackColor = false;
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Transparent;
            this.btnRetour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRetour.Enabled = false;
            this.btnRetour.FlatAppearance.BorderSize = 0;
            this.btnRetour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnRetour.Image = ((System.Drawing.Image)(resources.GetObject("btnRetour.Image")));
            this.btnRetour.Location = new System.Drawing.Point(388, 36);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(80, 26);
            this.btnRetour.TabIndex = 899;
            this.btnRetour.Text = "Retour";
            this.btnRetour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnRetour, "Retour en stock");
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 27);
            this.panel2.TabIndex = 896;
            // 
            // produitStockTableAdapter
            // 
            this.produitStockTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetProduit
            // 
            this.dataSetProduit.DataSetName = "DataSetProduit";
            this.dataSetProduit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataMember = "Produit";
            this.produitBindingSource.DataSource = this.dataSetProduit;
            // 
            // produitTableAdapter
            // 
            this.produitTableAdapter.ClearBeforeFill = true;
            // 
            // idproduitDataGridViewTextBoxColumn
            // 
            this.idproduitDataGridViewTextBoxColumn.DataPropertyName = "idproduit";
            this.idproduitDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idproduitDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.idproduitDataGridViewTextBoxColumn.Name = "idproduitDataGridViewTextBoxColumn";
            this.idproduitDataGridViewTextBoxColumn.ReadOnly = true;
            this.idproduitDataGridViewTextBoxColumn.Visible = false;
            this.idproduitDataGridViewTextBoxColumn.Width = 40;
            // 
            // nomproduitDataGridViewTextBoxColumn
            // 
            this.nomproduitDataGridViewTextBoxColumn.DataPropertyName = "nomproduit";
            this.nomproduitDataGridViewTextBoxColumn.HeaderText = "Désignation";
            this.nomproduitDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.nomproduitDataGridViewTextBoxColumn.Name = "nomproduitDataGridViewTextBoxColumn";
            this.nomproduitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomcommercialDataGridViewTextBoxColumn
            // 
            this.nomcommercialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomcommercialDataGridViewTextBoxColumn.DataPropertyName = "nomcommercial";
            this.nomcommercialDataGridViewTextBoxColumn.HeaderText = "Nom produit";
            this.nomcommercialDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.nomcommercialDataGridViewTextBoxColumn.Name = "nomcommercialDataGridViewTextBoxColumn";
            this.nomcommercialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uniteDataGridViewTextBoxColumn
            // 
            this.uniteDataGridViewTextBoxColumn.DataPropertyName = "unite";
            this.uniteDataGridViewTextBoxColumn.HeaderText = "Unité";
            this.uniteDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.uniteDataGridViewTextBoxColumn.Name = "uniteDataGridViewTextBoxColumn";
            this.uniteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // poidsunitDataGridViewTextBoxColumn
            // 
            this.poidsunitDataGridViewTextBoxColumn.DataPropertyName = "poidsunit";
            this.poidsunitDataGridViewTextBoxColumn.HeaderText = "Poids";
            this.poidsunitDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.poidsunitDataGridViewTextBoxColumn.Name = "poidsunitDataGridViewTextBoxColumn";
            this.poidsunitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // volumeunitDataGridViewTextBoxColumn
            // 
            this.volumeunitDataGridViewTextBoxColumn.DataPropertyName = "volumeunit";
            this.volumeunitDataGridViewTextBoxColumn.HeaderText = "Volume";
            this.volumeunitDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.volumeunitDataGridViewTextBoxColumn.Name = "volumeunitDataGridViewTextBoxColumn";
            this.volumeunitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormDepotStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(703, 451);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.btnLivrer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.txtProduit);
            this.Controls.Add(this.lblPays);
            this.Controls.Add(this.dgvProduit);
            this.Controls.Add(this.dgvStock);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDepotStock";
            this.Text = "FormDepotStock";
            this.Load += new System.EventHandler(this.FormDepotStock_Load);
            this.Shown += new System.EventHandler(this.FormDepotStock_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetStockProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.TextBox txtProduit;
        public System.Windows.Forms.Label lblPays;
        public System.Windows.Forms.DataGridView dgvProduit;
        public System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnLivrer;
        public System.Windows.Forms.Button btnImprimer;
        private DataSetStockProduit dataSetStockProduit;
        private System.Windows.Forms.BindingSource produitStockBindingSource;
        private DataSetStockProduitTableAdapters.ProduitStockTableAdapter produitStockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteinitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numlotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixventeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coutachatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomdepotDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button btnRetour;
        private DataSetProduit dataSetProduit;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private DataSetProduitTableAdapters.ProduitTableAdapter produitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomcommercialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poidsunitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeunitDataGridViewTextBoxColumn;
    }
}