namespace LogiS
{
    partial class FormClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSolde = new System.Windows.Forms.Button();
            this.btnPayement = new System.Windows.Forms.Button();
            this.btnFacture = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFacturer = new System.Windows.Forms.Button();
            this.btnPayer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.idclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montant_reste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetClient = new LogiS.DataSetClient();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clientTableAdapter = new LogiS.DataSetClientTableAdapters.ClientTableAdapter();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnBanque = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClient)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(363, 71);
            this.txtMontant.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtMontant.MaxLength = 75;
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(117, 28);
            this.txtMontant.TabIndex = 854;
            this.txtMontant.TextChanged += new System.EventHandler(this.txtMontant_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(302, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 852;
            this.label1.Text = "Montant :";
            // 
            // cbo
            // 
            this.cbo.DropDownHeight = 200;
            this.cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo.FormattingEnabled = true;
            this.cbo.IntegralHeight = false;
            this.cbo.Items.AddRange(new object[] {
            "Max",
            "Min"});
            this.cbo.Location = new System.Drawing.Point(483, 71);
            this.cbo.MaxDropDownItems = 10;
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(89, 30);
            this.cbo.Sorted = true;
            this.cbo.TabIndex = 850;
            this.cbo.SelectedIndexChanged += new System.EventHandler(this.cbo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(8, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 853;
            this.label3.Text = "Client :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.btnSolde);
            this.panel1.Controls.Add(this.btnPayement);
            this.panel1.Controls.Add(this.btnFacture);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnFacturer);
            this.panel1.Controls.Add(this.btnPayer);
            this.panel1.Controls.Add(this.btnBanque);
            this.panel1.Controls.Add(this.btnSupprimer);
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Controls.Add(this.btnNouveau);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 30);
            this.panel1.TabIndex = 849;
            // 
            // btnSolde
            // 
            this.btnSolde.BackColor = System.Drawing.Color.Transparent;
            this.btnSolde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSolde.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSolde.Enabled = false;
            this.btnSolde.FlatAppearance.BorderSize = 0;
            this.btnSolde.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSolde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSolde.Image = ((System.Drawing.Image)(resources.GetObject("btnSolde.Image")));
            this.btnSolde.Location = new System.Drawing.Point(591, 0);
            this.btnSolde.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSolde.Name = "btnSolde";
            this.btnSolde.Size = new System.Drawing.Size(30, 30);
            this.btnSolde.TabIndex = 854;
            this.toolTip1.SetToolTip(this.btnSolde, "Solde");
            this.btnSolde.UseVisualStyleBackColor = false;
            this.btnSolde.Click += new System.EventHandler(this.btnSolde_Click);
            // 
            // btnPayement
            // 
            this.btnPayement.BackColor = System.Drawing.Color.Transparent;
            this.btnPayement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPayement.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPayement.Enabled = false;
            this.btnPayement.FlatAppearance.BorderSize = 0;
            this.btnPayement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPayement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPayement.Image = ((System.Drawing.Image)(resources.GetObject("btnPayement.Image")));
            this.btnPayement.Location = new System.Drawing.Point(561, 0);
            this.btnPayement.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPayement.Name = "btnPayement";
            this.btnPayement.Size = new System.Drawing.Size(30, 30);
            this.btnPayement.TabIndex = 853;
            this.toolTip1.SetToolTip(this.btnPayement, "Payements");
            this.btnPayement.UseVisualStyleBackColor = false;
            this.btnPayement.Click += new System.EventHandler(this.btnPayement_Click);
            // 
            // btnFacture
            // 
            this.btnFacture.BackColor = System.Drawing.Color.Transparent;
            this.btnFacture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFacture.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFacture.Enabled = false;
            this.btnFacture.FlatAppearance.BorderSize = 0;
            this.btnFacture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFacture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFacture.Image = ((System.Drawing.Image)(resources.GetObject("btnFacture.Image")));
            this.btnFacture.Location = new System.Drawing.Point(531, 0);
            this.btnFacture.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnFacture.Name = "btnFacture";
            this.btnFacture.Size = new System.Drawing.Size(30, 30);
            this.btnFacture.TabIndex = 852;
            this.btnFacture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnFacture, "Factures");
            this.btnFacture.UseVisualStyleBackColor = false;
            this.btnFacture.Click += new System.EventHandler(this.btnFacture_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(530, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 30);
            this.panel3.TabIndex = 847;
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
            // btnFacturer
            // 
            this.btnFacturer.BackColor = System.Drawing.Color.Transparent;
            this.btnFacturer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFacturer.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFacturer.Enabled = false;
            this.btnFacturer.FlatAppearance.BorderSize = 0;
            this.btnFacturer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFacturer.Image = ((System.Drawing.Image)(resources.GetObject("btnFacturer.Image")));
            this.btnFacturer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturer.Location = new System.Drawing.Point(440, 0);
            this.btnFacturer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnFacturer.Name = "btnFacturer";
            this.btnFacturer.Size = new System.Drawing.Size(90, 30);
            this.btnFacturer.TabIndex = 855;
            this.btnFacturer.Text = "Facturer";
            this.btnFacturer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnFacturer, "Facturer ce client");
            this.btnFacturer.UseVisualStyleBackColor = false;
            this.btnFacturer.Click += new System.EventHandler(this.btnFacturer_Click);
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
            this.btnPayer.Location = new System.Drawing.Point(350, 0);
            this.btnPayer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPayer.Name = "btnPayer";
            this.btnPayer.Size = new System.Drawing.Size(90, 30);
            this.btnPayer.TabIndex = 839;
            this.btnPayer.Text = "Percevoir";
            this.btnPayer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnPayer, "Percevoir le cash");
            this.btnPayer.UseVisualStyleBackColor = false;
            this.btnPayer.Click += new System.EventHandler(this.btnPayer_Click);
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
            this.btnSupprimer.Location = new System.Drawing.Point(165, 0);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(95, 30);
            this.btnSupprimer.TabIndex = 856;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnSupprimer, "Supprimer ce client");
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
            this.btnModifier.Location = new System.Drawing.Point(85, 0);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(80, 30);
            this.btnModifier.TabIndex = 839;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnModifier, "Modifier ce client");
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
            this.btnNouveau.Size = new System.Drawing.Size(85, 30);
            this.btnNouveau.TabIndex = 839;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnNouveau, "Nouveau client");
            this.btnNouveau.UseVisualStyleBackColor = false;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.AllowUserToDeleteRows = false;
            this.dgvClient.AllowUserToResizeColumns = false;
            this.dgvClient.AllowUserToResizeRows = false;
            this.dgvClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClient.AutoGenerateColumns = false;
            this.dgvClient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclientDataGridViewTextBoxColumn,
            this.Montant_reste,
            this.nomclientDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvClient.DataSource = this.clientBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClient.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvClient.EnableHeadersVisualStyles = false;
            this.dgvClient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.dgvClient.Location = new System.Drawing.Point(12, 107);
            this.dgvClient.MultiSelect = false;
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            this.dgvClient.RowHeadersVisible = false;
            this.dgvClient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClient.Size = new System.Drawing.Size(679, 332);
            this.dgvClient.TabIndex = 848;
            this.dgvClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClient_CellClick);
            // 
            // idclientDataGridViewTextBoxColumn
            // 
            this.idclientDataGridViewTextBoxColumn.DataPropertyName = "idclient";
            this.idclientDataGridViewTextBoxColumn.HeaderText = "N°";
            this.idclientDataGridViewTextBoxColumn.Name = "idclientDataGridViewTextBoxColumn";
            this.idclientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Montant_reste
            // 
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.Montant_reste.DefaultCellStyle = dataGridViewCellStyle5;
            this.Montant_reste.HeaderText = "M. reste $";
            this.Montant_reste.MinimumWidth = 110;
            this.Montant_reste.Name = "Montant_reste";
            this.Montant_reste.ReadOnly = true;
            this.Montant_reste.Width = 110;
            // 
            // nomclientDataGridViewTextBoxColumn
            // 
            this.nomclientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomclientDataGridViewTextBoxColumn.DataPropertyName = "nomclient";
            this.nomclientDataGridViewTextBoxColumn.HeaderText = "Nom client";
            this.nomclientDataGridViewTextBoxColumn.MinimumWidth = 250;
            this.nomclientDataGridViewTextBoxColumn.Name = "nomclientDataGridViewTextBoxColumn";
            this.nomclientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Téléphone";
            this.telephoneDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            this.telephoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telephoneDataGridViewTextBoxColumn.Width = 120;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Contact mail";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.dataSetClient;
            // 
            // dataSetClient
            // 
            this.dataSetClient.DataSetName = "DataSetClient";
            this.dataSetClient.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 27);
            this.panel2.TabIndex = 847;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(57, 71);
            this.txtNom.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNom.MaxLength = 75;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(201, 28);
            this.txtNom.TabIndex = 855;
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
            this.btnAfficher.Location = new System.Drawing.Point(258, 71);
            this.btnAfficher.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(30, 21);
            this.btnAfficher.TabIndex = 856;
            this.toolTip1.SetToolTip(this.btnAfficher, "Afficher");
            this.btnAfficher.UseVisualStyleBackColor = false;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
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
            this.btnBanque.Location = new System.Drawing.Point(260, 0);
            this.btnBanque.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnBanque.Name = "btnBanque";
            this.btnBanque.Size = new System.Drawing.Size(90, 30);
            this.btnBanque.TabIndex = 857;
            this.btnBanque.Text = "Percevoir";
            this.btnBanque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnBanque, "Percevoir par baque");
            this.btnBanque.UseVisualStyleBackColor = false;
            this.btnBanque.Click += new System.EventHandler(this.btnBanque_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(703, 451);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.Shown += new System.EventHandler(this.FormClient_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnPayer;
        public System.Windows.Forms.Button btnModifier;
        public System.Windows.Forms.Button btnNouveau;
        public System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.Panel panel2;
        private DataSetClient dataSetClient;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DataSetClientTableAdapters.ClientTableAdapter clientTableAdapter;
        public System.Windows.Forms.TextBox txtNom;
        public System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montant_reste;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Button btnSolde;
        public System.Windows.Forms.Button btnPayement;
        public System.Windows.Forms.Button btnFacture;
        public System.Windows.Forms.Button btnFacturer;
        public System.Windows.Forms.Button btnSupprimer;
        public System.Windows.Forms.Button btnBanque;

    }
}