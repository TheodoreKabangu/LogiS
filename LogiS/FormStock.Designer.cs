namespace LogiS
{
    partial class FormStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStock));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.idstockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteinitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numlotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coutachatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixventeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomdepot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produitStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetStockProduit = new LogiS.DataSetStockProduit();
            this.dgvProduit = new System.Windows.Forms.DataGridView();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetProduit = new LogiS.DataSetProduit();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.txtProduit = new System.Windows.Forms.TextBox();
            this.lblPays = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMajProduit = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnDepot = new System.Windows.Forms.Button();
            this.produitTableAdapter = new LogiS.DataSetProduitTableAdapters.ProduitTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.produitStockTableAdapter = new LogiS.DataSetStockProduitTableAdapters.ProduitStockTableAdapter();
            this.cboDepot = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.idproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomcommercialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poidsunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetStockProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProduit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 27);
            this.panel2.TabIndex = 850;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idstockDataGridViewTextBoxColumn,
            this.qteinitDataGridViewTextBoxColumn,
            this.numlotDataGridViewTextBoxColumn,
            this.expirationDataGridViewTextBoxColumn,
            this.coutachatDataGridViewTextBoxColumn,
            this.prixventeDataGridViewTextBoxColumn,
            this.nomdepot});
            this.dgvStock.DataSource = this.produitStockBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStock.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStock.EnableHeadersVisualStyles = false;
            this.dgvStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.dgvStock.Location = new System.Drawing.Point(248, 94);
            this.dgvStock.MultiSelect = false;
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvStock.Size = new System.Drawing.Size(443, 345);
            this.dgvStock.TabIndex = 868;
            this.dgvStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellClick);
            // 
            // idstockDataGridViewTextBoxColumn
            // 
            this.idstockDataGridViewTextBoxColumn.DataPropertyName = "idstock";
            this.idstockDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idstockDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.idstockDataGridViewTextBoxColumn.Name = "idstockDataGridViewTextBoxColumn";
            this.idstockDataGridViewTextBoxColumn.Width = 40;
            // 
            // qteinitDataGridViewTextBoxColumn
            // 
            this.qteinitDataGridViewTextBoxColumn.DataPropertyName = "qteinit";
            this.qteinitDataGridViewTextBoxColumn.HeaderText = "Qté";
            this.qteinitDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.qteinitDataGridViewTextBoxColumn.Name = "qteinitDataGridViewTextBoxColumn";
            // 
            // numlotDataGridViewTextBoxColumn
            // 
            this.numlotDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numlotDataGridViewTextBoxColumn.DataPropertyName = "numlot";
            this.numlotDataGridViewTextBoxColumn.HeaderText = "N° lot";
            this.numlotDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.numlotDataGridViewTextBoxColumn.Name = "numlotDataGridViewTextBoxColumn";
            // 
            // expirationDataGridViewTextBoxColumn
            // 
            this.expirationDataGridViewTextBoxColumn.DataPropertyName = "expiration";
            this.expirationDataGridViewTextBoxColumn.HeaderText = "Expiration";
            this.expirationDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.expirationDataGridViewTextBoxColumn.Name = "expirationDataGridViewTextBoxColumn";
            // 
            // coutachatDataGridViewTextBoxColumn
            // 
            this.coutachatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coutachatDataGridViewTextBoxColumn.DataPropertyName = "cout_achat";
            this.coutachatDataGridViewTextBoxColumn.HeaderText = "Coût achat";
            this.coutachatDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.coutachatDataGridViewTextBoxColumn.Name = "coutachatDataGridViewTextBoxColumn";
            // 
            // prixventeDataGridViewTextBoxColumn
            // 
            this.prixventeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prixventeDataGridViewTextBoxColumn.DataPropertyName = "prix_vente";
            this.prixventeDataGridViewTextBoxColumn.HeaderText = "Prix vente";
            this.prixventeDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.prixventeDataGridViewTextBoxColumn.Name = "prixventeDataGridViewTextBoxColumn";
            // 
            // nomdepot
            // 
            this.nomdepot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomdepot.DataPropertyName = "nomdepot";
            this.nomdepot.HeaderText = "Dépôt";
            this.nomdepot.MinimumWidth = 100;
            this.nomdepot.Name = "nomdepot";
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproduitDataGridViewTextBoxColumn,
            this.nomproduitDataGridViewTextBoxColumn,
            this.nomcommercialDataGridViewTextBoxColumn,
            this.uniteDataGridViewTextBoxColumn,
            this.poidsunitDataGridViewTextBoxColumn,
            this.volumeunitDataGridViewTextBoxColumn});
            this.dgvProduit.DataSource = this.produitBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduit.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProduit.EnableHeadersVisualStyles = false;
            this.dgvProduit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.dgvProduit.Location = new System.Drawing.Point(12, 94);
            this.dgvProduit.MultiSelect = false;
            this.dgvProduit.Name = "dgvProduit";
            this.dgvProduit.ReadOnly = true;
            this.dgvProduit.RowHeadersVisible = false;
            this.dgvProduit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProduit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProduit.Size = new System.Drawing.Size(230, 345);
            this.dgvProduit.TabIndex = 869;
            this.dgvProduit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduit_CellClick);
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataMember = "Produit";
            this.produitBindingSource.DataSource = this.dataSetProduit;
            // 
            // dataSetProduit
            // 
            this.dataSetProduit.DataSetName = "DataSetProduit";
            this.dataSetProduit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAfficher
            // 
            this.btnAfficher.BackColor = System.Drawing.Color.Transparent;
            this.btnAfficher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAfficher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAfficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAfficher.Image = ((System.Drawing.Image)(resources.GetObject("btnAfficher.Image")));
            this.btnAfficher.Location = new System.Drawing.Point(254, 66);
            this.btnAfficher.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(30, 21);
            this.btnAfficher.TabIndex = 890;
            this.toolTip1.SetToolTip(this.btnAfficher, "Rechercher");
            this.btnAfficher.UseVisualStyleBackColor = false;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // txtProduit
            // 
            this.txtProduit.Location = new System.Drawing.Point(62, 66);
            this.txtProduit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtProduit.MaxLength = 75;
            this.txtProduit.Name = "txtProduit";
            this.txtProduit.Size = new System.Drawing.Size(192, 28);
            this.txtProduit.TabIndex = 889;
            // 
            // lblPays
            // 
            this.lblPays.AutoSize = true;
            this.lblPays.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPays.Location = new System.Drawing.Point(8, 69);
            this.lblPays.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPays.Name = "lblPays";
            this.lblPays.Size = new System.Drawing.Size(77, 22);
            this.lblPays.TabIndex = 888;
            this.lblPays.Text = "Produit :";
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
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 838;
            this.toolTip1.SetToolTip(this.btnExit, "Fermer");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMajProduit
            // 
            this.btnMajProduit.BackColor = System.Drawing.Color.Transparent;
            this.btnMajProduit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMajProduit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMajProduit.FlatAppearance.BorderSize = 0;
            this.btnMajProduit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMajProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMajProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnMajProduit.Image = ((System.Drawing.Image)(resources.GetObject("btnMajProduit.Image")));
            this.btnMajProduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMajProduit.Location = new System.Drawing.Point(85, 0);
            this.btnMajProduit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnMajProduit.Name = "btnMajProduit";
            this.btnMajProduit.Size = new System.Drawing.Size(90, 30);
            this.btnMajProduit.TabIndex = 839;
            this.btnMajProduit.Text = "Produit";
            this.btnMajProduit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnMajProduit, "Produits en stock");
            this.btnMajProduit.UseVisualStyleBackColor = false;
            this.btnMajProduit.Click += new System.EventHandler(this.btnMajProduit_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Transparent;
            this.btnSupprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSupprimer.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSupprimer.Enabled = false;
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("btnSupprimer.Image")));
            this.btnSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimer.Location = new System.Drawing.Point(356, 0);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(95, 30);
            this.btnSupprimer.TabIndex = 848;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnSupprimer, "Supprimer ce stock");
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Transparent;
            this.btnModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModifier.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModifier.Enabled = false;
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnModifier.Image = ((System.Drawing.Image)(resources.GetObject("btnModifier.Image")));
            this.btnModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifier.Location = new System.Drawing.Point(266, 0);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(90, 30);
            this.btnModifier.TabIndex = 849;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnModifier, "Modifier ce stock");
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Transparent;
            this.btnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAjouter.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAjouter.Enabled = false;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAjouter.Image = ((System.Drawing.Image)(resources.GetObject("btnAjouter.Image")));
            this.btnAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouter.Location = new System.Drawing.Point(176, 0);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(90, 30);
            this.btnAjouter.TabIndex = 850;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnAjouter, "Ajouter un stock du produit");
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnDepot
            // 
            this.btnDepot.BackColor = System.Drawing.Color.Transparent;
            this.btnDepot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDepot.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDepot.FlatAppearance.BorderSize = 0;
            this.btnDepot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDepot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDepot.Image = ((System.Drawing.Image)(resources.GetObject("btnDepot.Image")));
            this.btnDepot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepot.Location = new System.Drawing.Point(0, 0);
            this.btnDepot.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDepot.Name = "btnDepot";
            this.btnDepot.Size = new System.Drawing.Size(85, 30);
            this.btnDepot.TabIndex = 851;
            this.btnDepot.Text = "Dépôt";
            this.btnDepot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnDepot, " Dépôt de stocks");
            this.btnDepot.UseVisualStyleBackColor = false;
            this.btnDepot.Click += new System.EventHandler(this.btnDepot_Click);
            // 
            // produitTableAdapter
            // 
            this.produitTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.btnSupprimer);
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnMajProduit);
            this.panel1.Controls.Add(this.btnDepot);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 30);
            this.panel1.TabIndex = 891;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(175, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 30);
            this.panel3.TabIndex = 847;
            // 
            // produitStockTableAdapter
            // 
            this.produitStockTableAdapter.ClearBeforeFill = true;
            // 
            // cboDepot
            // 
            this.cboDepot.DropDownHeight = 200;
            this.cboDepot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDepot.FormattingEnabled = true;
            this.cboDepot.IntegralHeight = false;
            this.cboDepot.Location = new System.Drawing.Point(348, 63);
            this.cboDepot.MaxDropDownItems = 10;
            this.cboDepot.Name = "cboDepot";
            this.cboDepot.Size = new System.Drawing.Size(343, 30);
            this.cboDepot.Sorted = true;
            this.cboDepot.TabIndex = 892;
            this.cboDepot.DropDown += new System.EventHandler(this.cboDepot_DropDown);
            this.cboDepot.SelectedIndexChanged += new System.EventHandler(this.cboDepot_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(289, 66);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 22);
            this.label8.TabIndex = 893;
            this.label8.Text = "Dépôt :";
            // 
            // idproduitDataGridViewTextBoxColumn
            // 
            this.idproduitDataGridViewTextBoxColumn.DataPropertyName = "idproduit";
            this.idproduitDataGridViewTextBoxColumn.HeaderText = "idproduit";
            this.idproduitDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.idproduitDataGridViewTextBoxColumn.Name = "idproduitDataGridViewTextBoxColumn";
            this.idproduitDataGridViewTextBoxColumn.ReadOnly = true;
            this.idproduitDataGridViewTextBoxColumn.Visible = false;
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
            this.nomcommercialDataGridViewTextBoxColumn.MinimumWidth = 200;
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
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(703, 451);
            this.Controls.Add(this.cboDepot);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.txtProduit);
            this.Controls.Add(this.lblPays);
            this.Controls.Add(this.dgvProduit);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStock";
            this.Text = "FormStock";
            this.Load += new System.EventHandler(this.FormStock_Load);
            this.Shown += new System.EventHandler(this.FormStock_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetStockProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProduit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dgvStock;
        public System.Windows.Forms.DataGridView dgvProduit;
        public System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.TextBox txtProduit;
        public System.Windows.Forms.Label lblPays;
        private DataSetProduit dataSetProduit;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private DataSetProduitTableAdapters.ProduitTableAdapter produitTableAdapter;
        private DataSetStockProduit dataSetStockProduit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnMajProduit;
        public System.Windows.Forms.Button btnSupprimer;
        public System.Windows.Forms.Button btnModifier;
        public System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.BindingSource produitStockBindingSource;
        private DataSetStockProduitTableAdapters.ProduitStockTableAdapter produitStockTableAdapter;
        public System.Windows.Forms.Button btnDepot;
        public System.Windows.Forms.ComboBox cboDepot;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteinitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numlotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coutachatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixventeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomdepot;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomcommercialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poidsunitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeunitDataGridViewTextBoxColumn;
    }
}