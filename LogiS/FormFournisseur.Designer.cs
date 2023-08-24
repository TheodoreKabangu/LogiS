namespace LogiS
{
    partial class FormFournisseur
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFournisseur));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFour = new System.Windows.Forms.DataGridView();
            this.fournisseurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetFour = new LogiS.DataSetFour();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPayer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnFacture = new System.Windows.Forms.Button();
            this.btnPayement = new System.Windows.Forms.Button();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnSolde = new System.Windows.Forms.Button();
            this.btnBanque = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.txtNomFour = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fournisseurTableAdapter = new LogiS.DataSetFourTableAdapters.FournisseurTableAdapter();
            this.idfourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomfourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personcontactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numcompteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intituleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeswiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nompaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFour)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFour
            // 
            this.dgvFour.AllowUserToAddRows = false;
            this.dgvFour.AllowUserToDeleteRows = false;
            this.dgvFour.AllowUserToResizeColumns = false;
            this.dgvFour.AllowUserToResizeRows = false;
            this.dgvFour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFour.AutoGenerateColumns = false;
            this.dgvFour.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvFour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFour.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFour.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfourDataGridViewTextBoxColumn,
            this.Column2,
            this.nomfourDataGridViewTextBoxColumn,
            this.personcontactDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.numcompteDataGridViewTextBoxColumn,
            this.intituleDataGridViewTextBoxColumn,
            this.codeswiftDataGridViewTextBoxColumn,
            this.banqueDataGridViewTextBoxColumn,
            this.nompaysDataGridViewTextBoxColumn,
            this.idpaysDataGridViewTextBoxColumn});
            this.dgvFour.DataSource = this.fournisseurBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFour.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFour.EnableHeadersVisualStyles = false;
            this.dgvFour.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.dgvFour.Location = new System.Drawing.Point(12, 107);
            this.dgvFour.MultiSelect = false;
            this.dgvFour.Name = "dgvFour";
            this.dgvFour.ReadOnly = true;
            this.dgvFour.RowHeadersVisible = false;
            this.dgvFour.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFour.Size = new System.Drawing.Size(679, 332);
            this.dgvFour.TabIndex = 842;
            this.dgvFour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFour_CellClick);
            // 
            // fournisseurBindingSource
            // 
            this.fournisseurBindingSource.DataMember = "Fournisseur";
            this.fournisseurBindingSource.DataSource = this.dataSetFour;
            // 
            // dataSetFour
            // 
            this.dataSetFour.DataSetName = "DataSetFour";
            this.dataSetFour.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 27);
            this.panel2.TabIndex = 841;
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
            this.toolTip1.SetToolTip(this.btnExit, "Close");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPayer
            // 
            this.btnPayer.BackColor = System.Drawing.Color.Transparent;
            this.btnPayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPayer.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPayer.Enabled = false;
            this.btnPayer.FlatAppearance.BorderSize = 0;
            this.btnPayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPayer.Image = ((System.Drawing.Image)(resources.GetObject("btnPayer.Image")));
            this.btnPayer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayer.Location = new System.Drawing.Point(400, 0);
            this.btnPayer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPayer.Name = "btnPayer";
            this.btnPayer.Size = new System.Drawing.Size(80, 30);
            this.btnPayer.TabIndex = 839;
            this.btnPayer.Text = "Pay";
            this.btnPayer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnPayer, "Pay with cash");
            this.btnPayer.UseVisualStyleBackColor = false;
            this.btnPayer.Click += new System.EventHandler(this.btnPayer_Click);
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
            this.btnModifier.Location = new System.Drawing.Point(80, 0);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(80, 30);
            this.btnModifier.TabIndex = 839;
            this.btnModifier.Text = "Edit";
            this.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnModifier, "Edit this supplier");
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
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
            this.btnNouveau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNouveau.Location = new System.Drawing.Point(0, 0);
            this.btnNouveau.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(80, 30);
            this.btnNouveau.TabIndex = 839;
            this.btnNouveau.Text = "New";
            this.btnNouveau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnNouveau, "Add a new supplier");
            this.btnNouveau.UseVisualStyleBackColor = false;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnFacture
            // 
            this.btnFacture.BackColor = System.Drawing.Color.Transparent;
            this.btnFacture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFacture.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFacture.FlatAppearance.BorderSize = 0;
            this.btnFacture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFacture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFacture.Image = ((System.Drawing.Image)(resources.GetObject("btnFacture.Image")));
            this.btnFacture.Location = new System.Drawing.Point(481, 0);
            this.btnFacture.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnFacture.Name = "btnFacture";
            this.btnFacture.Size = new System.Drawing.Size(30, 30);
            this.btnFacture.TabIndex = 848;
            this.btnFacture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnFacture, "Invoices list");
            this.btnFacture.UseVisualStyleBackColor = false;
            this.btnFacture.Click += new System.EventHandler(this.btnFacture_Click);
            // 
            // btnPayement
            // 
            this.btnPayement.BackColor = System.Drawing.Color.Transparent;
            this.btnPayement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPayement.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPayement.FlatAppearance.BorderSize = 0;
            this.btnPayement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPayement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPayement.Image = ((System.Drawing.Image)(resources.GetObject("btnPayement.Image")));
            this.btnPayement.Location = new System.Drawing.Point(511, 0);
            this.btnPayement.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPayement.Name = "btnPayement";
            this.btnPayement.Size = new System.Drawing.Size(30, 30);
            this.btnPayement.TabIndex = 849;
            this.toolTip1.SetToolTip(this.btnPayement, "Payements list");
            this.btnPayement.UseVisualStyleBackColor = false;
            this.btnPayement.Click += new System.EventHandler(this.btnPayement_Click);
            // 
            // btnAfficher
            // 
            this.btnAfficher.BackColor = System.Drawing.Color.Transparent;
            this.btnAfficher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAfficher.FlatAppearance.BorderSize = 0;
            this.btnAfficher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAfficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAfficher.Image = ((System.Drawing.Image)(resources.GetObject("btnAfficher.Image")));
            this.btnAfficher.Location = new System.Drawing.Point(338, 65);
            this.btnAfficher.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(30, 21);
            this.btnAfficher.TabIndex = 857;
            this.toolTip1.SetToolTip(this.btnAfficher, "Search");
            this.btnAfficher.UseVisualStyleBackColor = false;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
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
            this.btnSupprimer.Location = new System.Drawing.Point(160, 0);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(80, 30);
            this.btnSupprimer.TabIndex = 850;
            this.btnSupprimer.Text = "Delete";
            this.btnSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnSupprimer, "Delete this supplier");
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnSolde
            // 
            this.btnSolde.BackColor = System.Drawing.Color.Transparent;
            this.btnSolde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSolde.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSolde.FlatAppearance.BorderSize = 0;
            this.btnSolde.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSolde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSolde.Image = ((System.Drawing.Image)(resources.GetObject("btnSolde.Image")));
            this.btnSolde.Location = new System.Drawing.Point(541, 0);
            this.btnSolde.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSolde.Name = "btnSolde";
            this.btnSolde.Size = new System.Drawing.Size(30, 30);
            this.btnSolde.TabIndex = 851;
            this.toolTip1.SetToolTip(this.btnSolde, "Balance");
            this.btnSolde.UseVisualStyleBackColor = false;
            this.btnSolde.Click += new System.EventHandler(this.btnSolde_Click);
            // 
            // btnBanque
            // 
            this.btnBanque.BackColor = System.Drawing.Color.Transparent;
            this.btnBanque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBanque.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBanque.Enabled = false;
            this.btnBanque.FlatAppearance.BorderSize = 0;
            this.btnBanque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBanque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBanque.Image = ((System.Drawing.Image)(resources.GetObject("btnBanque.Image")));
            this.btnBanque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanque.Location = new System.Drawing.Point(320, 0);
            this.btnBanque.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnBanque.Name = "btnBanque";
            this.btnBanque.Size = new System.Drawing.Size(80, 30);
            this.btnBanque.TabIndex = 852;
            this.btnBanque.Text = "Pay";
            this.btnBanque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnBanque, "Pay with bank");
            this.btnBanque.UseVisualStyleBackColor = false;
            this.btnBanque.Click += new System.EventHandler(this.btnBanque_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.Color.Transparent;
            this.btnInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInvoice.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInvoice.Enabled = false;
            this.btnInvoice.FlatAppearance.BorderSize = 0;
            this.btnInvoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnInvoice.Image")));
            this.btnInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoice.Location = new System.Drawing.Point(240, 0);
            this.btnInvoice.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(80, 30);
            this.btnInvoice.TabIndex = 853;
            this.btnInvoice.Text = "Invoice";
            this.btnInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnInvoice, "Invoice from this supplier");
            this.btnInvoice.UseVisualStyleBackColor = false;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.btnSolde);
            this.panel1.Controls.Add(this.btnPayement);
            this.panel1.Controls.Add(this.btnFacture);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnPayer);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnBanque);
            this.panel1.Controls.Add(this.btnInvoice);
            this.panel1.Controls.Add(this.btnSupprimer);
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Controls.Add(this.btnNouveau);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 30);
            this.panel1.TabIndex = 843;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(480, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 30);
            this.panel3.TabIndex = 847;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 200;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Items.AddRange(new object[] {
            "Max",
            "Min"});
            this.comboBox1.Location = new System.Drawing.Point(569, 65);
            this.comboBox1.MaxDropDownItems = 10;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(69, 30);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 844;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(385, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 845;
            this.label1.Text = "Amount :";
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(451, 65);
            this.txtMontant.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtMontant.MaxLength = 75;
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(117, 28);
            this.txtMontant.TabIndex = 846;
            // 
            // txtNomFour
            // 
            this.txtNomFour.Location = new System.Drawing.Point(69, 65);
            this.txtNomFour.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNomFour.MaxLength = 75;
            this.txtNomFour.Name = "txtNomFour";
            this.txtNomFour.Size = new System.Drawing.Size(268, 28);
            this.txtNomFour.TabIndex = 848;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(8, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 847;
            this.label2.Text = "Supplier :";
            // 
            // fournisseurTableAdapter
            // 
            this.fournisseurTableAdapter.ClearBeforeFill = true;
            // 
            // idfourDataGridViewTextBoxColumn
            // 
            this.idfourDataGridViewTextBoxColumn.DataPropertyName = "idfour";
            this.idfourDataGridViewTextBoxColumn.HeaderText = "N°";
            this.idfourDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.idfourDataGridViewTextBoxColumn.Name = "idfourDataGridViewTextBoxColumn";
            this.idfourDataGridViewTextBoxColumn.ReadOnly = true;
            this.idfourDataGridViewTextBoxColumn.Width = 50;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Rest";
            this.Column2.MinimumWidth = 100;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // nomfourDataGridViewTextBoxColumn
            // 
            this.nomfourDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomfourDataGridViewTextBoxColumn.DataPropertyName = "nomfour";
            this.nomfourDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.nomfourDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.nomfourDataGridViewTextBoxColumn.Name = "nomfourDataGridViewTextBoxColumn";
            this.nomfourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personcontactDataGridViewTextBoxColumn
            // 
            this.personcontactDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.personcontactDataGridViewTextBoxColumn.DataPropertyName = "person_contact";
            this.personcontactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.personcontactDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.personcontactDataGridViewTextBoxColumn.Name = "personcontactDataGridViewTextBoxColumn";
            this.personcontactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            this.telephoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telephoneDataGridViewTextBoxColumn.Width = 120;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 200;
            // 
            // numcompteDataGridViewTextBoxColumn
            // 
            this.numcompteDataGridViewTextBoxColumn.DataPropertyName = "numcompte";
            this.numcompteDataGridViewTextBoxColumn.HeaderText = "Account #";
            this.numcompteDataGridViewTextBoxColumn.MinimumWidth = 130;
            this.numcompteDataGridViewTextBoxColumn.Name = "numcompteDataGridViewTextBoxColumn";
            this.numcompteDataGridViewTextBoxColumn.ReadOnly = true;
            this.numcompteDataGridViewTextBoxColumn.Width = 130;
            // 
            // intituleDataGridViewTextBoxColumn
            // 
            this.intituleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.intituleDataGridViewTextBoxColumn.DataPropertyName = "intitule";
            this.intituleDataGridViewTextBoxColumn.HeaderText = "Account name";
            this.intituleDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.intituleDataGridViewTextBoxColumn.Name = "intituleDataGridViewTextBoxColumn";
            this.intituleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeswiftDataGridViewTextBoxColumn
            // 
            this.codeswiftDataGridViewTextBoxColumn.DataPropertyName = "code_swift";
            this.codeswiftDataGridViewTextBoxColumn.HeaderText = "Swift";
            this.codeswiftDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.codeswiftDataGridViewTextBoxColumn.Name = "codeswiftDataGridViewTextBoxColumn";
            this.codeswiftDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // banqueDataGridViewTextBoxColumn
            // 
            this.banqueDataGridViewTextBoxColumn.DataPropertyName = "banque";
            this.banqueDataGridViewTextBoxColumn.HeaderText = "Bank";
            this.banqueDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.banqueDataGridViewTextBoxColumn.Name = "banqueDataGridViewTextBoxColumn";
            this.banqueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nompaysDataGridViewTextBoxColumn
            // 
            this.nompaysDataGridViewTextBoxColumn.DataPropertyName = "nompays";
            this.nompaysDataGridViewTextBoxColumn.HeaderText = "Country";
            this.nompaysDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.nompaysDataGridViewTextBoxColumn.Name = "nompaysDataGridViewTextBoxColumn";
            this.nompaysDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idpaysDataGridViewTextBoxColumn
            // 
            this.idpaysDataGridViewTextBoxColumn.DataPropertyName = "idpays";
            this.idpaysDataGridViewTextBoxColumn.HeaderText = "idpays";
            this.idpaysDataGridViewTextBoxColumn.Name = "idpaysDataGridViewTextBoxColumn";
            this.idpaysDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpaysDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(703, 451);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.txtNomFour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvFour);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFournisseur";
            this.Text = "FormFournisseur";
            this.Shown += new System.EventHandler(this.FormFournisseur_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFour)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.DataGridView dgvFour;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnPayer;
        public System.Windows.Forms.Button btnModifier;
        public System.Windows.Forms.Button btnNouveau;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btnPayement;
        public System.Windows.Forms.Button btnFacture;
        public System.Windows.Forms.TextBox txtNomFour;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnAfficher;
        private DataSetFour dataSetFour;
        private System.Windows.Forms.BindingSource fournisseurBindingSource;
        private DataSetFourTableAdapters.FournisseurTableAdapter fournisseurTableAdapter;
        public System.Windows.Forms.Button btnSupprimer;
        public System.Windows.Forms.Button btnSolde;
        public System.Windows.Forms.Button btnBanque;
        public System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomfourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personcontactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcompteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intituleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeswiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn banqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nompaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpaysDataGridViewTextBoxColumn;
    }
}