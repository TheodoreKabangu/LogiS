namespace LogiS
{
    partial class FormRecette
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecette));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSolde = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVoir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.dgvRecette = new System.Windows.Forms.DataGridView();
            this.idrecetteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datejourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomfichierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extfichierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recetteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRecette = new LogiS.DataSetRecette();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAfficher = new System.Windows.Forms.Button();
            this.btnMessage = new System.Windows.Forms.Button();
            this.dtpDateDe = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateA = new System.Windows.Forms.DateTimePicker();
            this.recetteTableAdapter = new LogiS.DataSetRecetteTableAdapters.RecetteTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRecette)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(415, 71);
            this.txtMontant.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtMontant.MaxLength = 75;
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(117, 28);
            this.txtMontant.TabIndex = 863;
            this.txtMontant.TextChanged += new System.EventHandler(this.txtMontant_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(354, 74);
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
            this.cbo.Location = new System.Drawing.Point(535, 71);
            this.cbo.MaxDropDownItems = 10;
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(89, 30);
            this.cbo.Sorted = true;
            this.cbo.TabIndex = 860;
            this.cbo.SelectedIndexChanged += new System.EventHandler(this.cbo_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.lblSolde);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnVoir);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSupprimer);
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Controls.Add(this.btnNouveau);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 30);
            this.panel1.TabIndex = 859;
            // 
            // lblSolde
            // 
            this.lblSolde.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSolde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolde.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblSolde.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSolde.Location = new System.Drawing.Point(426, 0);
            this.lblSolde.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSolde.Name = "lblSolde";
            this.lblSolde.Size = new System.Drawing.Size(150, 30);
            this.lblSolde.TabIndex = 876;
            this.lblSolde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(356, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 30);
            this.label4.TabIndex = 879;
            this.label4.Text = "Solde $ :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnVoir
            // 
            this.btnVoir.BackColor = System.Drawing.Color.Transparent;
            this.btnVoir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVoir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVoir.Enabled = false;
            this.btnVoir.FlatAppearance.BorderSize = 0;
            this.btnVoir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnVoir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnVoir.Image = ((System.Drawing.Image)(resources.GetObject("btnVoir.Image")));
            this.btnVoir.Location = new System.Drawing.Point(276, 0);
            this.btnVoir.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnVoir.Name = "btnVoir";
            this.btnVoir.Size = new System.Drawing.Size(80, 30);
            this.btnVoir.TabIndex = 848;
            this.btnVoir.Text = "Voir";
            this.btnVoir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnVoir, "Visualiser");
            this.btnVoir.UseVisualStyleBackColor = false;
            this.btnVoir.Click += new System.EventHandler(this.btnVoir_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(275, 0);
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
            this.btnSupprimer.Location = new System.Drawing.Point(180, 0);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(95, 30);
            this.btnSupprimer.TabIndex = 839;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnSupprimer, "Supprimer");
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
            this.btnModifier.Location = new System.Drawing.Point(90, 0);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(90, 30);
            this.btnModifier.TabIndex = 839;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnModifier, "Modifier");
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
            this.btnNouveau.Size = new System.Drawing.Size(90, 30);
            this.btnNouveau.TabIndex = 839;
            this.btnNouveau.Text = "Ajouter";
            this.btnNouveau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnNouveau, "Nouvelle recette");
            this.btnNouveau.UseVisualStyleBackColor = false;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // dgvRecette
            // 
            this.dgvRecette.AllowUserToAddRows = false;
            this.dgvRecette.AllowUserToDeleteRows = false;
            this.dgvRecette.AllowUserToResizeColumns = false;
            this.dgvRecette.AllowUserToResizeRows = false;
            this.dgvRecette.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecette.AutoGenerateColumns = false;
            this.dgvRecette.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvRecette.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecette.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecette.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecette.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecette.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idrecetteDataGridViewTextBoxColumn,
            this.datejourDataGridViewTextBoxColumn,
            this.montantDataGridViewTextBoxColumn,
            this.libelleDataGridViewTextBoxColumn,
            this.nomfichierDataGridViewTextBoxColumn,
            this.extfichierDataGridViewTextBoxColumn,
            this.idclientDataGridViewTextBoxColumn,
            this.statutDataGridViewTextBoxColumn});
            this.dgvRecette.DataSource = this.recetteBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecette.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecette.EnableHeadersVisualStyles = false;
            this.dgvRecette.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.dgvRecette.Location = new System.Drawing.Point(12, 107);
            this.dgvRecette.MultiSelect = false;
            this.dgvRecette.Name = "dgvRecette";
            this.dgvRecette.ReadOnly = true;
            this.dgvRecette.RowHeadersVisible = false;
            this.dgvRecette.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRecette.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecette.Size = new System.Drawing.Size(679, 332);
            this.dgvRecette.TabIndex = 858;
            this.dgvRecette.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecette_CellClick);
            // 
            // idrecetteDataGridViewTextBoxColumn
            // 
            this.idrecetteDataGridViewTextBoxColumn.DataPropertyName = "idrecette";
            this.idrecetteDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idrecetteDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.idrecetteDataGridViewTextBoxColumn.Name = "idrecetteDataGridViewTextBoxColumn";
            this.idrecetteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idrecetteDataGridViewTextBoxColumn.Width = 50;
            // 
            // datejourDataGridViewTextBoxColumn
            // 
            this.datejourDataGridViewTextBoxColumn.DataPropertyName = "date_jour";
            this.datejourDataGridViewTextBoxColumn.HeaderText = "Date";
            this.datejourDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.datejourDataGridViewTextBoxColumn.Name = "datejourDataGridViewTextBoxColumn";
            this.datejourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montantDataGridViewTextBoxColumn
            // 
            this.montantDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.montantDataGridViewTextBoxColumn.DataPropertyName = "montant";
            this.montantDataGridViewTextBoxColumn.HeaderText = "Montant";
            this.montantDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.montantDataGridViewTextBoxColumn.Name = "montantDataGridViewTextBoxColumn";
            this.montantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // libelleDataGridViewTextBoxColumn
            // 
            this.libelleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.libelleDataGridViewTextBoxColumn.DataPropertyName = "libelle";
            this.libelleDataGridViewTextBoxColumn.HeaderText = "Libellé";
            this.libelleDataGridViewTextBoxColumn.MinimumWidth = 250;
            this.libelleDataGridViewTextBoxColumn.Name = "libelleDataGridViewTextBoxColumn";
            this.libelleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomfichierDataGridViewTextBoxColumn
            // 
            this.nomfichierDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomfichierDataGridViewTextBoxColumn.DataPropertyName = "nomfichier";
            this.nomfichierDataGridViewTextBoxColumn.HeaderText = "Preuve";
            this.nomfichierDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.nomfichierDataGridViewTextBoxColumn.Name = "nomfichierDataGridViewTextBoxColumn";
            this.nomfichierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // extfichierDataGridViewTextBoxColumn
            // 
            this.extfichierDataGridViewTextBoxColumn.DataPropertyName = "extfichier";
            this.extfichierDataGridViewTextBoxColumn.HeaderText = "extfichier";
            this.extfichierDataGridViewTextBoxColumn.Name = "extfichierDataGridViewTextBoxColumn";
            this.extfichierDataGridViewTextBoxColumn.ReadOnly = true;
            this.extfichierDataGridViewTextBoxColumn.Visible = false;
            // 
            // idclientDataGridViewTextBoxColumn
            // 
            this.idclientDataGridViewTextBoxColumn.DataPropertyName = "idclient";
            this.idclientDataGridViewTextBoxColumn.HeaderText = "idclient";
            this.idclientDataGridViewTextBoxColumn.Name = "idclientDataGridViewTextBoxColumn";
            this.idclientDataGridViewTextBoxColumn.ReadOnly = true;
            this.idclientDataGridViewTextBoxColumn.Visible = false;
            // 
            // statutDataGridViewTextBoxColumn
            // 
            this.statutDataGridViewTextBoxColumn.DataPropertyName = "statut";
            this.statutDataGridViewTextBoxColumn.HeaderText = "Statut";
            this.statutDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.statutDataGridViewTextBoxColumn.Name = "statutDataGridViewTextBoxColumn";
            this.statutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recetteBindingSource
            // 
            this.recetteBindingSource.DataMember = "Recette";
            this.recetteBindingSource.DataSource = this.dataSetRecette;
            // 
            // dataSetRecette
            // 
            this.dataSetRecette.DataSetName = "DataSetRecette";
            this.dataSetRecette.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // btnAfficher
            // 
            this.btnAfficher.BackColor = System.Drawing.Color.Transparent;
            this.btnAfficher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAfficher.FlatAppearance.BorderSize = 0;
            this.btnAfficher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAfficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAfficher.Image = ((System.Drawing.Image)(resources.GetObject("btnAfficher.Image")));
            this.btnAfficher.Location = new System.Drawing.Point(305, 69);
            this.btnAfficher.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(30, 21);
            this.btnAfficher.TabIndex = 866;
            this.toolTip1.SetToolTip(this.btnAfficher, "Afficher");
            this.btnAfficher.UseVisualStyleBackColor = false;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // btnMessage
            // 
            this.btnMessage.BackColor = System.Drawing.Color.Transparent;
            this.btnMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMessage.Enabled = false;
            this.btnMessage.FlatAppearance.BorderSize = 0;
            this.btnMessage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnMessage.Image = ((System.Drawing.Image)(resources.GetObject("btnMessage.Image")));
            this.btnMessage.Location = new System.Drawing.Point(633, 71);
            this.btnMessage.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(30, 21);
            this.btnMessage.TabIndex = 879;
            this.toolTip1.SetToolTip(this.btnMessage, "Signaler à l\'admin");
            this.btnMessage.UseVisualStyleBackColor = false;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // dtpDateDe
            // 
            this.dtpDateDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDe.Location = new System.Drawing.Point(42, 69);
            this.dtpDateDe.Name = "dtpDateDe";
            this.dtpDateDe.Size = new System.Drawing.Size(108, 28);
            this.dtpDateDe.TabIndex = 865;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(8, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 22);
            this.label2.TabIndex = 864;
            this.label2.Text = "De :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(159, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 22);
            this.label3.TabIndex = 864;
            this.label3.Text = "à :";
            // 
            // dtpDateA
            // 
            this.dtpDateA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateA.Location = new System.Drawing.Point(193, 69);
            this.dtpDateA.Name = "dtpDateA";
            this.dtpDateA.Size = new System.Drawing.Size(108, 28);
            this.dtpDateA.TabIndex = 865;
            // 
            // recetteTableAdapter
            // 
            this.recetteTableAdapter.ClearBeforeFill = true;
            // 
            // FormRecette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(703, 451);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.dtpDateA);
            this.Controls.Add(this.dtpDateDe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvRecette);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRecette";
            this.Text = "FormRecette";
            this.Load += new System.EventHandler(this.FormRecette_Load);
            this.Shown += new System.EventHandler(this.FormRecette_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRecette)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbo;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnVoir;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnSupprimer;
        public System.Windows.Forms.Button btnModifier;
        public System.Windows.Forms.Button btnNouveau;
        public System.Windows.Forms.DataGridView dgvRecette;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DateTimePicker dtpDateDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dtpDateA;
        public System.Windows.Forms.Button btnAfficher;
        public System.Windows.Forms.Label lblSolde;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnMessage;
        private DataSetRecette dataSetRecette;
        private System.Windows.Forms.BindingSource recetteBindingSource;
        private DataSetRecetteTableAdapters.RecetteTableAdapter recetteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrecetteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datejourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomfichierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extfichierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statutDataGridViewTextBoxColumn;
    }
}