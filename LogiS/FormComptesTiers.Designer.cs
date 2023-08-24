namespace LogiS
{
    partial class FormComptesTiers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComptesTiers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOperation = new System.Windows.Forms.Button();
            this.btnVoirDetails = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDette = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreance = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.dgvTiers = new System.Windows.Forms.DataGridView();
            this.idtiersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montant_reste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomtiersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTiers = new LogiS.DataSetTiers();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tiersTableAdapter = new LogiS.DataSetTiersTableAdapters.TiersTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTiers)).BeginInit();
            this.SuspendLayout();
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
            this.btnAfficher.TabIndex = 865;
            this.toolTip1.SetToolTip(this.btnAfficher, "Afficher");
            this.btnAfficher.UseVisualStyleBackColor = false;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(57, 71);
            this.txtNom.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNom.MaxLength = 75;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(201, 28);
            this.txtNom.TabIndex = 864;
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(363, 71);
            this.txtMontant.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtMontant.MaxLength = 75;
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(117, 28);
            this.txtMontant.TabIndex = 863;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(302, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 861;
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
            this.cbo.TabIndex = 860;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(8, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 862;
            this.label3.Text = "Nom :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.btnOperation);
            this.panel1.Controls.Add(this.btnVoirDetails);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnDette);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnCreance);
            this.panel1.Controls.Add(this.btnSupprimer);
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Controls.Add(this.btnNouveau);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 30);
            this.panel1.TabIndex = 859;
            // 
            // btnOperation
            // 
            this.btnOperation.BackColor = System.Drawing.Color.Transparent;
            this.btnOperation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOperation.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOperation.FlatAppearance.BorderSize = 0;
            this.btnOperation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnOperation.Image = ((System.Drawing.Image)(resources.GetObject("btnOperation.Image")));
            this.btnOperation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOperation.Location = new System.Drawing.Point(531, 0);
            this.btnOperation.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(95, 30);
            this.btnOperation.TabIndex = 849;
            this.btnOperation.Text = "Opérations";
            this.btnOperation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnOperation, "Toutes les opérations");
            this.btnOperation.UseVisualStyleBackColor = false;
            this.btnOperation.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // btnVoirDetails
            // 
            this.btnVoirDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnVoirDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVoirDetails.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVoirDetails.Enabled = false;
            this.btnVoirDetails.FlatAppearance.BorderSize = 0;
            this.btnVoirDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnVoirDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoirDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnVoirDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnVoirDetails.Image")));
            this.btnVoirDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoirDetails.Location = new System.Drawing.Point(441, 0);
            this.btnVoirDetails.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnVoirDetails.Name = "btnVoirDetails";
            this.btnVoirDetails.Size = new System.Drawing.Size(90, 30);
            this.btnVoirDetails.TabIndex = 848;
            this.btnVoirDetails.Text = "Journal";
            this.btnVoirDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnVoirDetails, "Opérations pour ce tiers");
            this.btnVoirDetails.UseVisualStyleBackColor = false;
            this.btnVoirDetails.Click += new System.EventHandler(this.btnVoirDetails_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(440, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 30);
            this.panel3.TabIndex = 847;
            // 
            // btnDette
            // 
            this.btnDette.BackColor = System.Drawing.Color.Transparent;
            this.btnDette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDette.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDette.Enabled = false;
            this.btnDette.FlatAppearance.BorderSize = 0;
            this.btnDette.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDette.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDette.Image = ((System.Drawing.Image)(resources.GetObject("btnDette.Image")));
            this.btnDette.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDette.Location = new System.Drawing.Point(350, 0);
            this.btnDette.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDette.Name = "btnDette";
            this.btnDette.Size = new System.Drawing.Size(90, 30);
            this.btnDette.TabIndex = 850;
            this.btnDette.Text = "Dette";
            this.btnDette.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnDette, "Ajouter une dette");
            this.btnDette.UseVisualStyleBackColor = false;
            this.btnDette.Click += new System.EventHandler(this.btnDette_Click);
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
            // btnCreance
            // 
            this.btnCreance.BackColor = System.Drawing.Color.Transparent;
            this.btnCreance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCreance.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCreance.Enabled = false;
            this.btnCreance.FlatAppearance.BorderSize = 0;
            this.btnCreance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCreance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCreance.Image = ((System.Drawing.Image)(resources.GetObject("btnCreance.Image")));
            this.btnCreance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreance.Location = new System.Drawing.Point(260, 0);
            this.btnCreance.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCreance.Name = "btnCreance";
            this.btnCreance.Size = new System.Drawing.Size(90, 30);
            this.btnCreance.TabIndex = 839;
            this.btnCreance.Text = "Créance";
            this.btnCreance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnCreance, "Ajouter une créance");
            this.btnCreance.UseVisualStyleBackColor = false;
            this.btnCreance.Click += new System.EventHandler(this.btnCreance_Click);
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
            this.btnSupprimer.TabIndex = 851;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnSupprimer, "Supprimer ce tiers");
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
            this.toolTip1.SetToolTip(this.btnModifier, "Modifier ce tiers");
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
            // dgvTiers
            // 
            this.dgvTiers.AllowUserToAddRows = false;
            this.dgvTiers.AllowUserToDeleteRows = false;
            this.dgvTiers.AllowUserToResizeColumns = false;
            this.dgvTiers.AllowUserToResizeRows = false;
            this.dgvTiers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTiers.AutoGenerateColumns = false;
            this.dgvTiers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvTiers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTiers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTiers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvTiers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtiersDataGridViewTextBoxColumn,
            this.Montant_reste,
            this.nomtiersDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn});
            this.dgvTiers.DataSource = this.tiersBindingSource;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTiers.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgvTiers.EnableHeadersVisualStyles = false;
            this.dgvTiers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.dgvTiers.Location = new System.Drawing.Point(12, 107);
            this.dgvTiers.MultiSelect = false;
            this.dgvTiers.Name = "dgvTiers";
            this.dgvTiers.ReadOnly = true;
            this.dgvTiers.RowHeadersVisible = false;
            this.dgvTiers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTiers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTiers.Size = new System.Drawing.Size(679, 332);
            this.dgvTiers.TabIndex = 858;
            this.dgvTiers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTiers_CellClick);
            // 
            // idtiersDataGridViewTextBoxColumn
            // 
            this.idtiersDataGridViewTextBoxColumn.DataPropertyName = "idtiers";
            this.idtiersDataGridViewTextBoxColumn.HeaderText = "N°";
            this.idtiersDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.idtiersDataGridViewTextBoxColumn.Name = "idtiersDataGridViewTextBoxColumn";
            this.idtiersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Montant_reste
            // 
            this.Montant_reste.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle20.Format = "N2";
            dataGridViewCellStyle20.NullValue = null;
            this.Montant_reste.DefaultCellStyle = dataGridViewCellStyle20;
            this.Montant_reste.HeaderText = "M. reste $";
            this.Montant_reste.MinimumWidth = 110;
            this.Montant_reste.Name = "Montant_reste";
            this.Montant_reste.ReadOnly = true;
            // 
            // nomtiersDataGridViewTextBoxColumn
            // 
            this.nomtiersDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomtiersDataGridViewTextBoxColumn.DataPropertyName = "nomtiers";
            this.nomtiersDataGridViewTextBoxColumn.HeaderText = "Nom tiers";
            this.nomtiersDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.nomtiersDataGridViewTextBoxColumn.Name = "nomtiersDataGridViewTextBoxColumn";
            this.nomtiersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Téléphone";
            this.telephoneDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            this.telephoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tiersBindingSource
            // 
            this.tiersBindingSource.DataMember = "Tiers";
            this.tiersBindingSource.DataSource = this.dataSetTiers;
            // 
            // dataSetTiers
            // 
            this.dataSetTiers.DataSetName = "DataSetTiers";
            this.dataSetTiers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 27);
            this.panel2.TabIndex = 857;
            // 
            // tiersTableAdapter
            // 
            this.tiersTableAdapter.ClearBeforeFill = true;
            // 
            // FormComptesTiers
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
            this.Controls.Add(this.dgvTiers);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormComptesTiers";
            this.Text = "FormComptesTiers";
            this.Load += new System.EventHandler(this.FormComptesTiers_Load);
            this.Shown += new System.EventHandler(this.FormComptesTiers_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTiers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.TextBox txtNom;
        public System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnOperation;
        public System.Windows.Forms.Button btnVoirDetails;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnCreance;
        public System.Windows.Forms.Button btnModifier;
        public System.Windows.Forms.Button btnNouveau;
        public System.Windows.Forms.DataGridView dgvTiers;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnDette;
        private DataSetTiers dataSetTiers;
        private System.Windows.Forms.BindingSource tiersBindingSource;
        private DataSetTiersTableAdapters.TiersTableAdapter tiersTableAdapter;
        public System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtiersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montant_reste;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomtiersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
    }
}