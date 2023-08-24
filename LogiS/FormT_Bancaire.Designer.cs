namespace LogiS
{
    partial class FormT_Bancaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormT_Bancaire));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVoir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSortie = new System.Windows.Forms.Button();
            this.btnEntree = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAfficher = new System.Windows.Forms.Button();
            this.btnMessage = new System.Windows.Forms.Button();
            this.dgvTransact = new System.Windows.Forms.DataGridView();
            this.dtpDateA = new System.Windows.Forms.DateTimePicker();
            this.dtpDateDe = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo = new System.Windows.Forms.ComboBox();
            this.cboCompte = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idtransactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datejourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomfichierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extfichierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numcompteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTransact = new LogiS.DataSetTransact();
            this.transactionBTableAdapter = new LogiS.DataSetTransactTableAdapters.TransactionBTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTransact)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 27);
            this.panel1.TabIndex = 850;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.panel2.Controls.Add(this.btnVoir);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnSupprimer);
            this.panel2.Controls.Add(this.btnModifier);
            this.panel2.Controls.Add(this.btnSortie);
            this.panel2.Controls.Add(this.btnEntree);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 30);
            this.panel2.TabIndex = 860;
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
            this.btnVoir.Location = new System.Drawing.Point(366, 0);
            this.btnVoir.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnVoir.Name = "btnVoir";
            this.btnVoir.Size = new System.Drawing.Size(80, 30);
            this.btnVoir.TabIndex = 848;
            this.btnVoir.Text = "Voir";
            this.btnVoir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoir.UseVisualStyleBackColor = false;
            this.btnVoir.Click += new System.EventHandler(this.btnVoir_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(365, 0);
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
            this.btnSupprimer.Location = new System.Drawing.Point(270, 0);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(95, 30);
            this.btnSupprimer.TabIndex = 839;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.btnModifier.Location = new System.Drawing.Point(180, 0);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(90, 30);
            this.btnModifier.TabIndex = 839;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSortie
            // 
            this.btnSortie.BackColor = System.Drawing.Color.Transparent;
            this.btnSortie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSortie.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSortie.FlatAppearance.BorderSize = 0;
            this.btnSortie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSortie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSortie.Image = ((System.Drawing.Image)(resources.GetObject("btnSortie.Image")));
            this.btnSortie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSortie.Location = new System.Drawing.Point(90, 0);
            this.btnSortie.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSortie.Name = "btnSortie";
            this.btnSortie.Size = new System.Drawing.Size(90, 30);
            this.btnSortie.TabIndex = 849;
            this.btnSortie.Text = "Sortie";
            this.btnSortie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnSortie, "Ajouter une entrée");
            this.btnSortie.UseVisualStyleBackColor = false;
            this.btnSortie.Click += new System.EventHandler(this.btnSortie_Click);
            // 
            // btnEntree
            // 
            this.btnEntree.BackColor = System.Drawing.Color.Transparent;
            this.btnEntree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEntree.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEntree.FlatAppearance.BorderSize = 0;
            this.btnEntree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEntree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEntree.Image = ((System.Drawing.Image)(resources.GetObject("btnEntree.Image")));
            this.btnEntree.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntree.Location = new System.Drawing.Point(0, 0);
            this.btnEntree.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEntree.Name = "btnEntree";
            this.btnEntree.Size = new System.Drawing.Size(90, 30);
            this.btnEntree.TabIndex = 839;
            this.btnEntree.Text = "Entrée";
            this.btnEntree.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnEntree, "Ajouter une entrée");
            this.btnEntree.UseVisualStyleBackColor = false;
            this.btnEntree.Click += new System.EventHandler(this.btnEntree_Click);
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
            this.btnAfficher.Location = new System.Drawing.Point(323, 95);
            this.btnAfficher.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(30, 21);
            this.btnAfficher.TabIndex = 871;
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
            this.btnMessage.Location = new System.Drawing.Point(646, 95);
            this.btnMessage.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(30, 21);
            this.btnMessage.TabIndex = 879;
            this.toolTip1.SetToolTip(this.btnMessage, "Signaler à l\'admin");
            this.btnMessage.UseVisualStyleBackColor = false;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // dgvTransact
            // 
            this.dgvTransact.AllowUserToAddRows = false;
            this.dgvTransact.AllowUserToDeleteRows = false;
            this.dgvTransact.AllowUserToResizeColumns = false;
            this.dgvTransact.AllowUserToResizeRows = false;
            this.dgvTransact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTransact.AutoGenerateColumns = false;
            this.dgvTransact.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvTransact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTransact.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransact.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtransactDataGridViewTextBoxColumn,
            this.datejourDataGridViewTextBoxColumn,
            this.montantDataGridViewTextBoxColumn,
            this.libelleDataGridViewTextBoxColumn,
            this.nomfichierDataGridViewTextBoxColumn,
            this.extfichierDataGridViewTextBoxColumn,
            this.typeopDataGridViewTextBoxColumn,
            this.numcompteDataGridViewTextBoxColumn});
            this.dgvTransact.DataSource = this.transactionBBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransact.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTransact.EnableHeadersVisualStyles = false;
            this.dgvTransact.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.dgvTransact.Location = new System.Drawing.Point(12, 126);
            this.dgvTransact.MultiSelect = false;
            this.dgvTransact.Name = "dgvTransact";
            this.dgvTransact.ReadOnly = true;
            this.dgvTransact.RowHeadersVisible = false;
            this.dgvTransact.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTransact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransact.Size = new System.Drawing.Size(679, 313);
            this.dgvTransact.TabIndex = 861;
            this.dgvTransact.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransact_CellClick);
            // 
            // dtpDateA
            // 
            this.dtpDateA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateA.Location = new System.Drawing.Point(211, 95);
            this.dtpDateA.Name = "dtpDateA";
            this.dtpDateA.Size = new System.Drawing.Size(108, 28);
            this.dtpDateA.TabIndex = 869;
            // 
            // dtpDateDe
            // 
            this.dtpDateDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDe.Location = new System.Drawing.Point(65, 95);
            this.dtpDateDe.Name = "dtpDateDe";
            this.dtpDateDe.Size = new System.Drawing.Size(108, 28);
            this.dtpDateDe.TabIndex = 870;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(177, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 22);
            this.label3.TabIndex = 867;
            this.label3.Text = "à :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(8, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 22);
            this.label2.TabIndex = 868;
            this.label2.Text = "De :";
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(423, 92);
            this.txtMontant.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtMontant.MaxLength = 75;
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(117, 28);
            this.txtMontant.TabIndex = 882;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(362, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 881;
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
            this.cbo.Location = new System.Drawing.Point(543, 92);
            this.cbo.MaxDropDownItems = 10;
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(89, 30);
            this.cbo.Sorted = true;
            this.cbo.TabIndex = 880;
            this.cbo.SelectedIndexChanged += new System.EventHandler(this.cbo_SelectedIndexChanged);
            // 
            // cboCompte
            // 
            this.cboCompte.DropDownHeight = 200;
            this.cboCompte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCompte.FormattingEnabled = true;
            this.cboCompte.IntegralHeight = false;
            this.cboCompte.Items.AddRange(new object[] {
            "Max",
            "Min"});
            this.cboCompte.Location = new System.Drawing.Point(65, 62);
            this.cboCompte.MaxDropDownItems = 10;
            this.cboCompte.Name = "cboCompte";
            this.cboCompte.Size = new System.Drawing.Size(288, 30);
            this.cboCompte.Sorted = true;
            this.cboCompte.TabIndex = 883;
            this.cboCompte.DropDown += new System.EventHandler(this.cboCompte_DropDown);
            this.cboCompte.SelectedIndexChanged += new System.EventHandler(this.cboCompte_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(8, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 868;
            this.label4.Text = "Compte :";
            // 
            // idtransactDataGridViewTextBoxColumn
            // 
            this.idtransactDataGridViewTextBoxColumn.DataPropertyName = "idtransact";
            this.idtransactDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idtransactDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.idtransactDataGridViewTextBoxColumn.Name = "idtransactDataGridViewTextBoxColumn";
            this.idtransactDataGridViewTextBoxColumn.ReadOnly = true;
            this.idtransactDataGridViewTextBoxColumn.Width = 50;
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
            this.montantDataGridViewTextBoxColumn.DataPropertyName = "montant";
            dataGridViewCellStyle2.Format = "N2";
            this.montantDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.libelleDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.libelleDataGridViewTextBoxColumn.Name = "libelleDataGridViewTextBoxColumn";
            this.libelleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomfichierDataGridViewTextBoxColumn
            // 
            this.nomfichierDataGridViewTextBoxColumn.DataPropertyName = "nomfichier";
            this.nomfichierDataGridViewTextBoxColumn.HeaderText = "Preuve";
            this.nomfichierDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.nomfichierDataGridViewTextBoxColumn.Name = "nomfichierDataGridViewTextBoxColumn";
            this.nomfichierDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomfichierDataGridViewTextBoxColumn.Width = 150;
            // 
            // extfichierDataGridViewTextBoxColumn
            // 
            this.extfichierDataGridViewTextBoxColumn.DataPropertyName = "extfichier";
            this.extfichierDataGridViewTextBoxColumn.HeaderText = "extfichier";
            this.extfichierDataGridViewTextBoxColumn.Name = "extfichierDataGridViewTextBoxColumn";
            this.extfichierDataGridViewTextBoxColumn.ReadOnly = true;
            this.extfichierDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeopDataGridViewTextBoxColumn
            // 
            this.typeopDataGridViewTextBoxColumn.DataPropertyName = "type_op";
            this.typeopDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeopDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.typeopDataGridViewTextBoxColumn.Name = "typeopDataGridViewTextBoxColumn";
            this.typeopDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeopDataGridViewTextBoxColumn.Width = 80;
            // 
            // numcompteDataGridViewTextBoxColumn
            // 
            this.numcompteDataGridViewTextBoxColumn.DataPropertyName = "numcompte";
            this.numcompteDataGridViewTextBoxColumn.HeaderText = "Compte";
            this.numcompteDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.numcompteDataGridViewTextBoxColumn.Name = "numcompteDataGridViewTextBoxColumn";
            this.numcompteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionBBindingSource
            // 
            this.transactionBBindingSource.DataMember = "TransactionB";
            this.transactionBBindingSource.DataSource = this.dataSetTransact;
            // 
            // dataSetTransact
            // 
            this.dataSetTransact.DataSetName = "DataSetTransact";
            this.dataSetTransact.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionBTableAdapter
            // 
            this.transactionBTableAdapter.ClearBeforeFill = true;
            // 
            // FormT_Bancaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(703, 451);
            this.Controls.Add(this.cboCompte);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.dtpDateA);
            this.Controls.Add(this.dtpDateDe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTransact);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormT_Bancaire";
            this.Text = "FormT_Bancaire";
            this.Load += new System.EventHandler(this.FormT_Bancaire_Load);
            this.Shown += new System.EventHandler(this.FormT_Bancaire_Shown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTransact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnVoir;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnSupprimer;
        public System.Windows.Forms.Button btnModifier;
        public System.Windows.Forms.Button btnEntree;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Button btnSortie;
        public System.Windows.Forms.DataGridView dgvTransact;
        public System.Windows.Forms.Button btnAfficher;
        public System.Windows.Forms.DateTimePicker dtpDateA;
        public System.Windows.Forms.DateTimePicker dtpDateDe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DataSetTransact dataSetTransact;
        private System.Windows.Forms.BindingSource transactionBBindingSource;
        private DataSetTransactTableAdapters.TransactionBTableAdapter transactionBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtransactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datejourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomfichierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extfichierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcompteDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button btnMessage;
        public System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbo;
        public System.Windows.Forms.ComboBox cboCompte;
        private System.Windows.Forms.Label label4;
    }
}