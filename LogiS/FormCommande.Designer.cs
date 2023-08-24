namespace LogiS
{
    partial class FormCommande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCommande));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnTiers = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRecu = new System.Windows.Forms.Button();
            this.btnArrive = new System.Windows.Forms.Button();
            this.btnEnvoi = new System.Windows.Forms.Button();
            this.btncmd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCmd = new System.Windows.Forms.DataGridView();
            this.idcomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.containerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numcontainerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chargesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantchargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datearriveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etatcomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fichierfactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extfactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fichierpvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extpvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCommande = new LogiS.DataSetCommande();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo = new System.Windows.Forms.ComboBox();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.dtpDateA = new System.Windows.Forms.DateTimePicker();
            this.dtpDateDe = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.commandeTableAdapter = new LogiS.DataSetCommandeTableAdapters.CommandeTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCommande)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnTiers);
            this.panel1.Controls.Add(this.btnClient);
            this.panel1.Controls.Add(this.btnFour);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnRecu);
            this.panel1.Controls.Add(this.btnArrive);
            this.panel1.Controls.Add(this.btnEnvoi);
            this.panel1.Controls.Add(this.btncmd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 30);
            this.panel1.TabIndex = 872;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(451, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 30);
            this.panel4.TabIndex = 851;
            // 
            // btnTiers
            // 
            this.btnTiers.BackColor = System.Drawing.Color.Transparent;
            this.btnTiers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTiers.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTiers.Enabled = false;
            this.btnTiers.FlatAppearance.BorderSize = 0;
            this.btnTiers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTiers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnTiers.Image = ((System.Drawing.Image)(resources.GetObject("btnTiers.Image")));
            this.btnTiers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTiers.Location = new System.Drawing.Point(421, 0);
            this.btnTiers.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnTiers.Name = "btnTiers";
            this.btnTiers.Size = new System.Drawing.Size(30, 30);
            this.btnTiers.TabIndex = 848;
            this.btnTiers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTiers.UseVisualStyleBackColor = false;
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.Transparent;
            this.btnClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClient.Enabled = false;
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnClient.Image = ((System.Drawing.Image)(resources.GetObject("btnClient.Image")));
            this.btnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.Location = new System.Drawing.Point(391, 0);
            this.btnClient.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(30, 30);
            this.btnClient.TabIndex = 849;
            this.btnClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClient.UseVisualStyleBackColor = false;
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.Transparent;
            this.btnFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFour.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFour.Enabled = false;
            this.btnFour.FlatAppearance.BorderSize = 0;
            this.btnFour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFour.Image = ((System.Drawing.Image)(resources.GetObject("btnFour.Image")));
            this.btnFour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFour.Location = new System.Drawing.Point(361, 0);
            this.btnFour.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(30, 30);
            this.btnFour.TabIndex = 850;
            this.btnFour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFour.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(360, 0);
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
            // btnRecu
            // 
            this.btnRecu.BackColor = System.Drawing.Color.Transparent;
            this.btnRecu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRecu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRecu.FlatAppearance.BorderSize = 0;
            this.btnRecu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRecu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnRecu.Image = ((System.Drawing.Image)(resources.GetObject("btnRecu.Image")));
            this.btnRecu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecu.Location = new System.Drawing.Point(270, 0);
            this.btnRecu.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRecu.Name = "btnRecu";
            this.btnRecu.Size = new System.Drawing.Size(90, 30);
            this.btnRecu.TabIndex = 839;
            this.btnRecu.Text = "Reçu";
            this.btnRecu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnRecu, "Confirmer statut reçu");
            this.btnRecu.UseVisualStyleBackColor = false;
            this.btnRecu.Click += new System.EventHandler(this.btnRecu_Click);
            // 
            // btnArrive
            // 
            this.btnArrive.BackColor = System.Drawing.Color.Transparent;
            this.btnArrive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnArrive.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnArrive.FlatAppearance.BorderSize = 0;
            this.btnArrive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnArrive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnArrive.Image = ((System.Drawing.Image)(resources.GetObject("btnArrive.Image")));
            this.btnArrive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArrive.Location = new System.Drawing.Point(180, 0);
            this.btnArrive.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnArrive.Name = "btnArrive";
            this.btnArrive.Size = new System.Drawing.Size(90, 30);
            this.btnArrive.TabIndex = 839;
            this.btnArrive.Text = "Arrivé";
            this.btnArrive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnArrive, "Confirmer statut arrivé");
            this.btnArrive.UseVisualStyleBackColor = false;
            this.btnArrive.Click += new System.EventHandler(this.btnArrive_Click);
            // 
            // btnEnvoi
            // 
            this.btnEnvoi.BackColor = System.Drawing.Color.Transparent;
            this.btnEnvoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEnvoi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEnvoi.FlatAppearance.BorderSize = 0;
            this.btnEnvoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEnvoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnvoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEnvoi.Image = ((System.Drawing.Image)(resources.GetObject("btnEnvoi.Image")));
            this.btnEnvoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnvoi.Location = new System.Drawing.Point(90, 0);
            this.btnEnvoi.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEnvoi.Name = "btnEnvoi";
            this.btnEnvoi.Size = new System.Drawing.Size(90, 30);
            this.btnEnvoi.TabIndex = 852;
            this.btnEnvoi.Text = "Envoyé";
            this.btnEnvoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnEnvoi, "Confirmer statut envoyé");
            this.btnEnvoi.UseVisualStyleBackColor = false;
            this.btnEnvoi.Click += new System.EventHandler(this.btnEnvoi_Click);
            // 
            // btncmd
            // 
            this.btncmd.BackColor = System.Drawing.Color.Transparent;
            this.btncmd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncmd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btncmd.FlatAppearance.BorderSize = 0;
            this.btncmd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btncmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btncmd.Image = ((System.Drawing.Image)(resources.GetObject("btncmd.Image")));
            this.btncmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncmd.Location = new System.Drawing.Point(0, 0);
            this.btncmd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btncmd.Name = "btncmd";
            this.btncmd.Size = new System.Drawing.Size(90, 30);
            this.btncmd.TabIndex = 839;
            this.btncmd.Text = "Afficher";
            this.btncmd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btncmd, "Détails commande");
            this.btncmd.UseVisualStyleBackColor = false;
            this.btncmd.Click += new System.EventHandler(this.btncmd_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 27);
            this.panel2.TabIndex = 871;
            // 
            // dgvCmd
            // 
            this.dgvCmd.AllowUserToAddRows = false;
            this.dgvCmd.AllowUserToDeleteRows = false;
            this.dgvCmd.AllowUserToResizeColumns = false;
            this.dgvCmd.AllowUserToResizeRows = false;
            this.dgvCmd.AutoGenerateColumns = false;
            this.dgvCmd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvCmd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCmd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCmd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCmd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcomDataGridViewTextBoxColumn,
            this.libelleDataGridViewTextBoxColumn,
            this.containerDataGridViewTextBoxColumn,
            this.numcontainerDataGridViewTextBoxColumn,
            this.chargesDataGridViewTextBoxColumn,
            this.montantchargeDataGridViewTextBoxColumn,
            this.datearriveDataGridViewTextBoxColumn,
            this.etatcomDataGridViewTextBoxColumn,
            this.fichierfactureDataGridViewTextBoxColumn,
            this.extfactureDataGridViewTextBoxColumn,
            this.fichierpvDataGridViewTextBoxColumn,
            this.extpvDataGridViewTextBoxColumn});
            this.dgvCmd.DataSource = this.commandeBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCmd.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCmd.EnableHeadersVisualStyles = false;
            this.dgvCmd.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.dgvCmd.Location = new System.Drawing.Point(12, 102);
            this.dgvCmd.MultiSelect = false;
            this.dgvCmd.Name = "dgvCmd";
            this.dgvCmd.ReadOnly = true;
            this.dgvCmd.RowHeadersVisible = false;
            this.dgvCmd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCmd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCmd.Size = new System.Drawing.Size(679, 337);
            this.dgvCmd.TabIndex = 873;
            // 
            // idcomDataGridViewTextBoxColumn
            // 
            this.idcomDataGridViewTextBoxColumn.DataPropertyName = "idcom";
            this.idcomDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idcomDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.idcomDataGridViewTextBoxColumn.Name = "idcomDataGridViewTextBoxColumn";
            this.idcomDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcomDataGridViewTextBoxColumn.Width = 50;
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
            // containerDataGridViewTextBoxColumn
            // 
            this.containerDataGridViewTextBoxColumn.DataPropertyName = "container";
            this.containerDataGridViewTextBoxColumn.HeaderText = "CTNR";
            this.containerDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.containerDataGridViewTextBoxColumn.Name = "containerDataGridViewTextBoxColumn";
            this.containerDataGridViewTextBoxColumn.ReadOnly = true;
            this.containerDataGridViewTextBoxColumn.Width = 70;
            // 
            // numcontainerDataGridViewTextBoxColumn
            // 
            this.numcontainerDataGridViewTextBoxColumn.DataPropertyName = "numcontainer";
            this.numcontainerDataGridViewTextBoxColumn.HeaderText = "N° CTNR";
            this.numcontainerDataGridViewTextBoxColumn.MinimumWidth = 110;
            this.numcontainerDataGridViewTextBoxColumn.Name = "numcontainerDataGridViewTextBoxColumn";
            this.numcontainerDataGridViewTextBoxColumn.ReadOnly = true;
            this.numcontainerDataGridViewTextBoxColumn.Width = 110;
            // 
            // chargesDataGridViewTextBoxColumn
            // 
            this.chargesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chargesDataGridViewTextBoxColumn.DataPropertyName = "charges";
            this.chargesDataGridViewTextBoxColumn.HeaderText = "Charges";
            this.chargesDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.chargesDataGridViewTextBoxColumn.Name = "chargesDataGridViewTextBoxColumn";
            this.chargesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montantchargeDataGridViewTextBoxColumn
            // 
            this.montantchargeDataGridViewTextBoxColumn.DataPropertyName = "montantcharge";
            this.montantchargeDataGridViewTextBoxColumn.HeaderText = "M. charges";
            this.montantchargeDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.montantchargeDataGridViewTextBoxColumn.Name = "montantchargeDataGridViewTextBoxColumn";
            this.montantchargeDataGridViewTextBoxColumn.ReadOnly = true;
            this.montantchargeDataGridViewTextBoxColumn.Width = 120;
            // 
            // datearriveDataGridViewTextBoxColumn
            // 
            this.datearriveDataGridViewTextBoxColumn.DataPropertyName = "date_arrive";
            this.datearriveDataGridViewTextBoxColumn.HeaderText = "DAP";
            this.datearriveDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.datearriveDataGridViewTextBoxColumn.Name = "datearriveDataGridViewTextBoxColumn";
            this.datearriveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // etatcomDataGridViewTextBoxColumn
            // 
            this.etatcomDataGridViewTextBoxColumn.DataPropertyName = "etatcom";
            this.etatcomDataGridViewTextBoxColumn.HeaderText = "Statut";
            this.etatcomDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.etatcomDataGridViewTextBoxColumn.Name = "etatcomDataGridViewTextBoxColumn";
            this.etatcomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fichierfactureDataGridViewTextBoxColumn
            // 
            this.fichierfactureDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fichierfactureDataGridViewTextBoxColumn.DataPropertyName = "fichierfacture";
            this.fichierfactureDataGridViewTextBoxColumn.HeaderText = "Facture";
            this.fichierfactureDataGridViewTextBoxColumn.MinimumWidth = 140;
            this.fichierfactureDataGridViewTextBoxColumn.Name = "fichierfactureDataGridViewTextBoxColumn";
            this.fichierfactureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // extfactureDataGridViewTextBoxColumn
            // 
            this.extfactureDataGridViewTextBoxColumn.DataPropertyName = "extfacture";
            this.extfactureDataGridViewTextBoxColumn.HeaderText = "extfacture";
            this.extfactureDataGridViewTextBoxColumn.Name = "extfactureDataGridViewTextBoxColumn";
            this.extfactureDataGridViewTextBoxColumn.ReadOnly = true;
            this.extfactureDataGridViewTextBoxColumn.Visible = false;
            // 
            // fichierpvDataGridViewTextBoxColumn
            // 
            this.fichierpvDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fichierpvDataGridViewTextBoxColumn.DataPropertyName = "fichierpv";
            this.fichierpvDataGridViewTextBoxColumn.HeaderText = "PV réception";
            this.fichierpvDataGridViewTextBoxColumn.MinimumWidth = 140;
            this.fichierpvDataGridViewTextBoxColumn.Name = "fichierpvDataGridViewTextBoxColumn";
            this.fichierpvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // extpvDataGridViewTextBoxColumn
            // 
            this.extpvDataGridViewTextBoxColumn.DataPropertyName = "extpv";
            this.extpvDataGridViewTextBoxColumn.HeaderText = "extpv";
            this.extpvDataGridViewTextBoxColumn.Name = "extpvDataGridViewTextBoxColumn";
            this.extpvDataGridViewTextBoxColumn.ReadOnly = true;
            this.extpvDataGridViewTextBoxColumn.Visible = false;
            // 
            // commandeBindingSource
            // 
            this.commandeBindingSource.DataMember = "Commande";
            this.commandeBindingSource.DataSource = this.dataSetCommande;
            // 
            // dataSetCommande
            // 
            this.dataSetCommande.DataSetName = "DataSetCommande";
            this.dataSetCommande.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(8, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 875;
            this.label1.Text = "Statut :";
            // 
            // cbo
            // 
            this.cbo.DropDownHeight = 200;
            this.cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo.FormattingEnabled = true;
            this.cbo.IntegralHeight = false;
            this.cbo.Items.AddRange(new object[] {
            "arrivé",
            "brouillon",
            "envoyé",
            "reçu"});
            this.cbo.Location = new System.Drawing.Point(68, 66);
            this.cbo.MaxDropDownItems = 10;
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(210, 30);
            this.cbo.Sorted = true;
            this.cbo.TabIndex = 874;
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
            this.btnAfficher.Location = new System.Drawing.Point(589, 64);
            this.btnAfficher.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(30, 21);
            this.btnAfficher.TabIndex = 882;
            this.btnAfficher.UseVisualStyleBackColor = false;
            // 
            // dtpDateA
            // 
            this.dtpDateA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateA.Location = new System.Drawing.Point(472, 64);
            this.dtpDateA.Name = "dtpDateA";
            this.dtpDateA.Size = new System.Drawing.Size(108, 28);
            this.dtpDateA.TabIndex = 880;
            // 
            // dtpDateDe
            // 
            this.dtpDateDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDe.Location = new System.Drawing.Point(321, 64);
            this.dtpDateDe.Name = "dtpDateDe";
            this.dtpDateDe.Size = new System.Drawing.Size(108, 28);
            this.dtpDateDe.TabIndex = 881;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(438, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 22);
            this.label3.TabIndex = 878;
            this.label3.Text = "à :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(287, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 22);
            this.label2.TabIndex = 879;
            this.label2.Text = "De :";
            // 
            // commandeTableAdapter
            // 
            this.commandeTableAdapter.ClearBeforeFill = true;
            // 
            // FormCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(703, 451);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.dtpDateA);
            this.Controls.Add(this.dtpDateDe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo);
            this.Controls.Add(this.dgvCmd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCommande";
            this.Text = "FormCommande";
            this.Load += new System.EventHandler(this.FormCommande_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCommande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button btnTiers;
        public System.Windows.Forms.Button btnClient;
        public System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnRecu;
        public System.Windows.Forms.Button btnArrive;
        public System.Windows.Forms.Button btnEnvoi;
        public System.Windows.Forms.Button btncmd;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dgvCmd;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbo;
        public System.Windows.Forms.Button btnAfficher;
        public System.Windows.Forms.DateTimePicker dtpDateA;
        public System.Windows.Forms.DateTimePicker dtpDateDe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private DataSetCommande dataSetCommande;
        private System.Windows.Forms.BindingSource commandeBindingSource;
        private DataSetCommandeTableAdapters.CommandeTableAdapter commandeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn containerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcontainerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chargesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantchargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datearriveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etatcomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fichierfactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extfactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fichierpvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extpvDataGridViewTextBoxColumn;
    }
}