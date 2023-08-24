namespace LogiS
{
    partial class FormFacturationNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacturationNew));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtRemise = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.dtpDateTerme = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFacture = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnService = new System.Windows.Forms.Button();
            this.lblPays = new System.Windows.Forms.Label();
            this.btnProforma = new System.Windows.Forms.Button();
            this.dgvFacture = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProduit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvProduit = new System.Windows.Forms.DataGridView();
            this.idproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomcommercialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poidsunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetProduit = new LogiS.DataSetProduit();
            this.produitTableAdapter = new LogiS.DataSetProduitTableAdapters.ProduitTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTypeFacture = new System.Windows.Forms.TextBox();
            this.chbService = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(211, 162);
            this.textBox4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox4.MaxLength = 10;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(35, 28);
            this.textBox4.TabIndex = 864;
            this.textBox4.Text = "USD";
            // 
            // txtRemise
            // 
            this.txtRemise.Location = new System.Drawing.Point(91, 162);
            this.txtRemise.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtRemise.MaxLength = 75;
            this.txtRemise.Name = "txtRemise";
            this.txtRemise.Size = new System.Drawing.Size(120, 28);
            this.txtRemise.TabIndex = 4;
            this.txtRemise.Text = "0";
            this.txtRemise.TextChanged += new System.EventHandler(this.txtRemise_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(14, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 860;
            this.label5.Text = "Remise :";
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(91, 130);
            this.txtLibelle.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtLibelle.MaxLength = 250;
            this.txtLibelle.Multiline = true;
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLibelle.Size = new System.Drawing.Size(542, 28);
            this.txtLibelle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(14, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 846;
            this.label1.Text = "Libellé :";
            // 
            // txtClient
            // 
            this.txtClient.Enabled = false;
            this.txtClient.Location = new System.Drawing.Point(91, 101);
            this.txtClient.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtClient.MaxLength = 75;
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(417, 28);
            this.txtClient.TabIndex = 1;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Transparent;
            this.btnAnnuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAnnuler.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.btnAnnuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAnnuler.Location = new System.Drawing.Point(91, 409);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(85, 25);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // dtpDateTerme
            // 
            this.dtpDateTerme.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTerme.Location = new System.Drawing.Point(295, 72);
            this.dtpDateTerme.Name = "dtpDateTerme";
            this.dtpDateTerme.Size = new System.Drawing.Size(120, 28);
            this.dtpDateTerme.TabIndex = 850;
            // 
            // dtpDateFacture
            // 
            this.dtpDateFacture.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFacture.Location = new System.Drawing.Point(91, 72);
            this.dtpDateFacture.Name = "dtpDateFacture";
            this.dtpDateFacture.Size = new System.Drawing.Size(120, 28);
            this.dtpDateFacture.TabIndex = 851;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(214, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 22);
            this.label6.TabIndex = 844;
            this.label6.Text = "Date terme :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(14, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 843;
            this.label3.Text = "Date :";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.Transparent;
            this.btnEnregistrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEnregistrer.Enabled = false;
            this.btnEnregistrer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.btnEnregistrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEnregistrer.Location = new System.Drawing.Point(188, 409);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(85, 25);
            this.btnEnregistrer.TabIndex = 7;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(653, 27);
            this.panel2.TabIndex = 842;
            // 
            // btnService
            // 
            this.btnService.BackColor = System.Drawing.Color.Transparent;
            this.btnService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnService.Enabled = false;
            this.btnService.FlatAppearance.BorderSize = 0;
            this.btnService.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnService.Image = ((System.Drawing.Image)(resources.GetObject("btnService.Image")));
            this.btnService.Location = new System.Drawing.Point(457, 41);
            this.btnService.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(30, 21);
            this.btnService.TabIndex = 889;
            this.toolTip1.SetToolTip(this.btnService, "Ajouter un service");
            this.btnService.UseVisualStyleBackColor = false;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // lblPays
            // 
            this.lblPays.AutoSize = true;
            this.lblPays.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPays.Location = new System.Drawing.Point(14, 104);
            this.lblPays.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPays.Name = "lblPays";
            this.lblPays.Size = new System.Drawing.Size(66, 22);
            this.lblPays.TabIndex = 847;
            this.lblPays.Text = "Client :";
            // 
            // btnProforma
            // 
            this.btnProforma.BackColor = System.Drawing.Color.Transparent;
            this.btnProforma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProforma.Enabled = false;
            this.btnProforma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.btnProforma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnProforma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnProforma.Location = new System.Drawing.Point(285, 409);
            this.btnProforma.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnProforma.Name = "btnProforma";
            this.btnProforma.Size = new System.Drawing.Size(85, 25);
            this.btnProforma.TabIndex = 8;
            this.btnProforma.Text = "Proforma";
            this.btnProforma.UseVisualStyleBackColor = false;
            this.btnProforma.Click += new System.EventHandler(this.btnProforma_Click);
            // 
            // dgvFacture
            // 
            this.dgvFacture.AllowUserToAddRows = false;
            this.dgvFacture.AllowUserToDeleteRows = false;
            this.dgvFacture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFacture.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvFacture.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFacture.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacture.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFacture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFacture.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFacture.EnableHeadersVisualStyles = false;
            this.dgvFacture.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.dgvFacture.Location = new System.Drawing.Point(91, 222);
            this.dgvFacture.MultiSelect = false;
            this.dgvFacture.Name = "dgvFacture";
            this.dgvFacture.ReadOnly = true;
            this.dgvFacture.RowHeadersVisible = false;
            this.dgvFacture.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFacture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacture.Size = new System.Drawing.Size(542, 179);
            this.dgvFacture.TabIndex = 866;
            this.dgvFacture.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacture_CellEndEdit);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 40;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Désignation";
            this.Column2.MinimumWidth = 200;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column4.HeaderText = "Prix";
            this.Column4.MinimumWidth = 100;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "Quantité";
            this.Column3.MinimumWidth = 100;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column5.HeaderText = "Total $";
            this.Column5.MinimumWidth = 100;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "idlignefacture";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // txtProduit
            // 
            this.txtProduit.Location = new System.Drawing.Point(91, 191);
            this.txtProduit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtProduit.MaxLength = 255;
            this.txtProduit.Name = "txtProduit";
            this.txtProduit.Size = new System.Drawing.Size(417, 28);
            this.txtProduit.TabIndex = 5;
            this.txtProduit.TextChanged += new System.EventHandler(this.txtProduit_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(14, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 22);
            this.label4.TabIndex = 867;
            this.label4.Text = "Produit :";
            // 
            // dgvProduit
            // 
            this.dgvProduit.AllowUserToAddRows = false;
            this.dgvProduit.AllowUserToDeleteRows = false;
            this.dgvProduit.AllowUserToResizeColumns = false;
            this.dgvProduit.AllowUserToResizeRows = false;
            this.dgvProduit.AutoGenerateColumns = false;
            this.dgvProduit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvProduit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduit.ColumnHeadersVisible = false;
            this.dgvProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproduitDataGridViewTextBoxColumn,
            this.nomproduitDataGridViewTextBoxColumn,
            this.nomcommercialDataGridViewTextBoxColumn,
            this.uniteDataGridViewTextBoxColumn,
            this.poidsunitDataGridViewTextBoxColumn,
            this.volumeunitDataGridViewTextBoxColumn});
            this.dgvProduit.DataSource = this.produitBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduit.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProduit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.dgvProduit.Location = new System.Drawing.Point(91, 221);
            this.dgvProduit.MultiSelect = false;
            this.dgvProduit.Name = "dgvProduit";
            this.dgvProduit.RowHeadersVisible = false;
            this.dgvProduit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProduit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduit.Size = new System.Drawing.Size(417, 209);
            this.dgvProduit.TabIndex = 869;
            this.dgvProduit.Visible = false;
            this.dgvProduit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduit_CellClick);
            // 
            // idproduitDataGridViewTextBoxColumn
            // 
            this.idproduitDataGridViewTextBoxColumn.DataPropertyName = "idproduit";
            this.idproduitDataGridViewTextBoxColumn.HeaderText = "idproduit";
            this.idproduitDataGridViewTextBoxColumn.Name = "idproduitDataGridViewTextBoxColumn";
            this.idproduitDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomproduitDataGridViewTextBoxColumn
            // 
            this.nomproduitDataGridViewTextBoxColumn.DataPropertyName = "nomproduit";
            this.nomproduitDataGridViewTextBoxColumn.HeaderText = "nomproduit";
            this.nomproduitDataGridViewTextBoxColumn.Name = "nomproduitDataGridViewTextBoxColumn";
            this.nomproduitDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomcommercialDataGridViewTextBoxColumn
            // 
            this.nomcommercialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomcommercialDataGridViewTextBoxColumn.DataPropertyName = "nomcommercial";
            this.nomcommercialDataGridViewTextBoxColumn.HeaderText = "nomcommercial";
            this.nomcommercialDataGridViewTextBoxColumn.MinimumWidth = 416;
            this.nomcommercialDataGridViewTextBoxColumn.Name = "nomcommercialDataGridViewTextBoxColumn";
            // 
            // uniteDataGridViewTextBoxColumn
            // 
            this.uniteDataGridViewTextBoxColumn.DataPropertyName = "unite";
            this.uniteDataGridViewTextBoxColumn.HeaderText = "unite";
            this.uniteDataGridViewTextBoxColumn.Name = "uniteDataGridViewTextBoxColumn";
            this.uniteDataGridViewTextBoxColumn.Visible = false;
            // 
            // poidsunitDataGridViewTextBoxColumn
            // 
            this.poidsunitDataGridViewTextBoxColumn.DataPropertyName = "poidsunit";
            this.poidsunitDataGridViewTextBoxColumn.HeaderText = "poidsunit";
            this.poidsunitDataGridViewTextBoxColumn.Name = "poidsunitDataGridViewTextBoxColumn";
            this.poidsunitDataGridViewTextBoxColumn.Visible = false;
            // 
            // volumeunitDataGridViewTextBoxColumn
            // 
            this.volumeunitDataGridViewTextBoxColumn.DataPropertyName = "volumeunit";
            this.volumeunitDataGridViewTextBoxColumn.HeaderText = "volumeunit";
            this.volumeunitDataGridViewTextBoxColumn.Name = "volumeunitDataGridViewTextBoxColumn";
            this.volumeunitDataGridViewTextBoxColumn.Visible = false;
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
            // produitTableAdapter
            // 
            this.produitTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(14, 45);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 22);
            this.label7.TabIndex = 885;
            this.label7.Text = "Type :";
            // 
            // txtTypeFacture
            // 
            this.txtTypeFacture.Enabled = false;
            this.txtTypeFacture.Location = new System.Drawing.Point(91, 42);
            this.txtTypeFacture.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTypeFacture.MaxLength = 75;
            this.txtTypeFacture.Name = "txtTypeFacture";
            this.txtTypeFacture.Size = new System.Drawing.Size(155, 28);
            this.txtTypeFacture.TabIndex = 887;
            // 
            // chbService
            // 
            this.chbService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chbService.AutoSize = true;
            this.chbService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.chbService.Location = new System.Drawing.Point(255, 37);
            this.chbService.Name = "chbService";
            this.chbService.Size = new System.Drawing.Size(197, 26);
            this.chbService.TabIndex = 888;
            this.chbService.Text = "Facturer les services";
            this.chbService.UseVisualStyleBackColor = true;
            this.chbService.Click += new System.EventHandler(this.chbService_Click);
            // 
            // FormFacturationNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(653, 451);
            this.Controls.Add(this.btnService);
            this.Controls.Add(this.chbService);
            this.Controls.Add(this.txtTypeFacture);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProduit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvFacture);
            this.Controls.Add(this.btnProforma);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtRemise);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.dtpDateTerme);
            this.Controls.Add(this.dtpDateFacture);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblPays);
            this.Controls.Add(this.dgvProduit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(675, 507);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(675, 507);
            this.Name = "FormFacturationNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouvelle facture - LogiS";
            this.Load += new System.EventHandler(this.FormFacturationNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtRemise;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.TextBox txtClient;
        public System.Windows.Forms.Button btnAnnuler;
        public System.Windows.Forms.DateTimePicker dtpDateTerme;
        public System.Windows.Forms.DateTimePicker dtpDateFacture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblPays;
        private System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.Button btnProforma;
        public System.Windows.Forms.DataGridView dgvFacture;
        public System.Windows.Forms.TextBox txtProduit;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dgvProduit;
        private DataSetProduit dataSetProduit;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private DataSetProduitTableAdapters.ProduitTableAdapter produitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomcommercialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poidsunitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeunitDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtTypeFacture;
        public System.Windows.Forms.CheckBox chbService;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        public System.Windows.Forms.Button btnService;
    }
}