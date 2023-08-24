namespace LogiS
{
    partial class FormCmdDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCmdDetail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCmd = new System.Windows.Forms.DataGridView();
            this.dataSetCommande = new LogiS.DataSetCommande();
            this.dgvCmdDetail = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idstockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomcommercial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtecomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteenvoyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtearriveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteentreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commandeLigneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCmdLigne = new LogiS.DataSetCmdLigne();
            this.commandeLigneTableAdapter = new LogiS.DataSetCmdLigneTableAdapters.CommandeLigneTableAdapter();
            this.btnEcart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.commandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commandeTableAdapter = new LogiS.DataSetCommandeTableAdapters.CommandeTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCommande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmdDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeLigneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCmdLigne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 27);
            this.panel2.TabIndex = 872;
            // 
            // dgvCmd
            // 
            this.dgvCmd.AllowUserToAddRows = false;
            this.dgvCmd.AllowUserToDeleteRows = false;
            this.dgvCmd.AllowUserToResizeColumns = false;
            this.dgvCmd.AllowUserToResizeRows = false;
            this.dgvCmd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCmd.AutoGenerateColumns = false;
            this.dgvCmd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvCmd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCmd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCmd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCmd.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCmd.EnableHeadersVisualStyles = false;
            this.dgvCmd.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.dgvCmd.Location = new System.Drawing.Point(12, 60);
            this.dgvCmd.MultiSelect = false;
            this.dgvCmd.Name = "dgvCmd";
            this.dgvCmd.ReadOnly = true;
            this.dgvCmd.RowHeadersVisible = false;
            this.dgvCmd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCmd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCmd.Size = new System.Drawing.Size(679, 100);
            this.dgvCmd.TabIndex = 874;
            // 
            // dataSetCommande
            // 
            this.dataSetCommande.DataSetName = "DataSetCommande";
            this.dataSetCommande.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvCmdDetail
            // 
            this.dgvCmdDetail.AllowUserToAddRows = false;
            this.dgvCmdDetail.AllowUserToDeleteRows = false;
            this.dgvCmdDetail.AllowUserToResizeColumns = false;
            this.dgvCmdDetail.AllowUserToResizeRows = false;
            this.dgvCmdDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCmdDetail.AutoGenerateColumns = false;
            this.dgvCmdDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvCmdDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCmdDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCmdDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCmdDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCmdDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idstockDataGridViewTextBoxColumn,
            this.nomcommercial,
            this.qtecomDataGridViewTextBoxColumn,
            this.qteenvoyeDataGridViewTextBoxColumn,
            this.qtearriveDataGridViewTextBoxColumn,
            this.qteentreDataGridViewTextBoxColumn,
            this.Column1});
            this.dgvCmdDetail.DataSource = this.commandeLigneBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCmdDetail.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCmdDetail.EnableHeadersVisualStyles = false;
            this.dgvCmdDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.dgvCmdDetail.Location = new System.Drawing.Point(12, 166);
            this.dgvCmdDetail.MultiSelect = false;
            this.dgvCmdDetail.Name = "dgvCmdDetail";
            this.dgvCmdDetail.ReadOnly = true;
            this.dgvCmdDetail.RowHeadersVisible = false;
            this.dgvCmdDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCmdDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCmdDetail.Size = new System.Drawing.Size(679, 273);
            this.dgvCmdDetail.TabIndex = 875;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // idstockDataGridViewTextBoxColumn
            // 
            this.idstockDataGridViewTextBoxColumn.DataPropertyName = "idstock";
            this.idstockDataGridViewTextBoxColumn.HeaderText = "idstock";
            this.idstockDataGridViewTextBoxColumn.Name = "idstockDataGridViewTextBoxColumn";
            this.idstockDataGridViewTextBoxColumn.ReadOnly = true;
            this.idstockDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomcommercial
            // 
            this.nomcommercial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomcommercial.DataPropertyName = "nomcommercial";
            this.nomcommercial.HeaderText = "Produit";
            this.nomcommercial.MinimumWidth = 250;
            this.nomcommercial.Name = "nomcommercial";
            this.nomcommercial.ReadOnly = true;
            // 
            // qtecomDataGridViewTextBoxColumn
            // 
            this.qtecomDataGridViewTextBoxColumn.DataPropertyName = "qtecom";
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.qtecomDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.qtecomDataGridViewTextBoxColumn.HeaderText = "Qté com.";
            this.qtecomDataGridViewTextBoxColumn.Name = "qtecomDataGridViewTextBoxColumn";
            this.qtecomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qteenvoyeDataGridViewTextBoxColumn
            // 
            this.qteenvoyeDataGridViewTextBoxColumn.DataPropertyName = "qte_envoye";
            dataGridViewCellStyle6.Format = "N0";
            this.qteenvoyeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.qteenvoyeDataGridViewTextBoxColumn.HeaderText = "Q. envoyée";
            this.qteenvoyeDataGridViewTextBoxColumn.Name = "qteenvoyeDataGridViewTextBoxColumn";
            this.qteenvoyeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtearriveDataGridViewTextBoxColumn
            // 
            this.qtearriveDataGridViewTextBoxColumn.DataPropertyName = "qte_arrive";
            dataGridViewCellStyle7.Format = "N0";
            this.qtearriveDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.qtearriveDataGridViewTextBoxColumn.HeaderText = "Q. arrivée";
            this.qtearriveDataGridViewTextBoxColumn.Name = "qtearriveDataGridViewTextBoxColumn";
            this.qtearriveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qteentreDataGridViewTextBoxColumn
            // 
            this.qteentreDataGridViewTextBoxColumn.DataPropertyName = "qte_entre";
            dataGridViewCellStyle8.Format = "N0";
            this.qteentreDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.qteentreDataGridViewTextBoxColumn.HeaderText = "Q. entrée";
            this.qteentreDataGridViewTextBoxColumn.Name = "qteentreDataGridViewTextBoxColumn";
            this.qteentreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column1.HeaderText = "Ecart";
            this.Column1.MinimumWidth = 100;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // commandeLigneBindingSource
            // 
            this.commandeLigneBindingSource.DataMember = "CommandeLigne";
            this.commandeLigneBindingSource.DataSource = this.dataSetCmdLigne;
            // 
            // dataSetCmdLigne
            // 
            this.dataSetCmdLigne.DataSetName = "DataSetCmdLigne";
            this.dataSetCmdLigne.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // commandeLigneTableAdapter
            // 
            this.commandeLigneTableAdapter.ClearBeforeFill = true;
            // 
            // btnEcart
            // 
            this.btnEcart.BackColor = System.Drawing.Color.Transparent;
            this.btnEcart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEcart.FlatAppearance.BorderSize = 0;
            this.btnEcart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEcart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEcart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEcart.Image = ((System.Drawing.Image)(resources.GetObject("btnEcart.Image")));
            this.btnEcart.Location = new System.Drawing.Point(619, 31);
            this.btnEcart.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEcart.Name = "btnEcart";
            this.btnEcart.Size = new System.Drawing.Size(30, 21);
            this.btnEcart.TabIndex = 883;
            this.toolTip1.SetToolTip(this.btnEcart, "Calculer les écarts");
            this.btnEcart.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(661, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 21);
            this.button1.TabIndex = 883;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // commandeBindingSource
            // 
            this.commandeBindingSource.DataMember = "Commande";
            this.commandeBindingSource.DataSource = this.dataSetCommande;
            // 
            // commandeTableAdapter
            // 
            this.commandeTableAdapter.ClearBeforeFill = true;
            // 
            // idcomDataGridViewTextBoxColumn
            // 
            this.idcomDataGridViewTextBoxColumn.DataPropertyName = "idcom";
            this.idcomDataGridViewTextBoxColumn.HeaderText = "ID cmd.";
            this.idcomDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.idcomDataGridViewTextBoxColumn.Name = "idcomDataGridViewTextBoxColumn";
            this.idcomDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcomDataGridViewTextBoxColumn.Width = 80;
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
            this.containerDataGridViewTextBoxColumn.Name = "containerDataGridViewTextBoxColumn";
            this.containerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numcontainerDataGridViewTextBoxColumn
            // 
            this.numcontainerDataGridViewTextBoxColumn.DataPropertyName = "numcontainer";
            this.numcontainerDataGridViewTextBoxColumn.HeaderText = "N° CTNR";
            this.numcontainerDataGridViewTextBoxColumn.MinimumWidth = 140;
            this.numcontainerDataGridViewTextBoxColumn.Name = "numcontainerDataGridViewTextBoxColumn";
            this.numcontainerDataGridViewTextBoxColumn.ReadOnly = true;
            this.numcontainerDataGridViewTextBoxColumn.Width = 140;
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
            dataGridViewCellStyle2.Format = "N2";
            this.montantchargeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.montantchargeDataGridViewTextBoxColumn.HeaderText = "M. charges";
            this.montantchargeDataGridViewTextBoxColumn.MinimumWidth = 110;
            this.montantchargeDataGridViewTextBoxColumn.Name = "montantchargeDataGridViewTextBoxColumn";
            this.montantchargeDataGridViewTextBoxColumn.ReadOnly = true;
            this.montantchargeDataGridViewTextBoxColumn.Width = 110;
            // 
            // datearriveDataGridViewTextBoxColumn
            // 
            this.datearriveDataGridViewTextBoxColumn.DataPropertyName = "date_arrive";
            this.datearriveDataGridViewTextBoxColumn.HeaderText = "DAP";
            this.datearriveDataGridViewTextBoxColumn.Name = "datearriveDataGridViewTextBoxColumn";
            this.datearriveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // etatcomDataGridViewTextBoxColumn
            // 
            this.etatcomDataGridViewTextBoxColumn.DataPropertyName = "etatcom";
            this.etatcomDataGridViewTextBoxColumn.HeaderText = "Statut";
            this.etatcomDataGridViewTextBoxColumn.Name = "etatcomDataGridViewTextBoxColumn";
            this.etatcomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fichierfactureDataGridViewTextBoxColumn
            // 
            this.fichierfactureDataGridViewTextBoxColumn.DataPropertyName = "fichierfacture";
            this.fichierfactureDataGridViewTextBoxColumn.HeaderText = "Facture";
            this.fichierfactureDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.fichierfactureDataGridViewTextBoxColumn.Name = "fichierfactureDataGridViewTextBoxColumn";
            this.fichierfactureDataGridViewTextBoxColumn.ReadOnly = true;
            this.fichierfactureDataGridViewTextBoxColumn.Width = 120;
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
            this.fichierpvDataGridViewTextBoxColumn.DataPropertyName = "fichierpv";
            this.fichierpvDataGridViewTextBoxColumn.HeaderText = "PV réception";
            this.fichierpvDataGridViewTextBoxColumn.MinimumWidth = 140;
            this.fichierpvDataGridViewTextBoxColumn.Name = "fichierpvDataGridViewTextBoxColumn";
            this.fichierpvDataGridViewTextBoxColumn.ReadOnly = true;
            this.fichierpvDataGridViewTextBoxColumn.Width = 140;
            // 
            // extpvDataGridViewTextBoxColumn
            // 
            this.extpvDataGridViewTextBoxColumn.DataPropertyName = "extpv";
            this.extpvDataGridViewTextBoxColumn.HeaderText = "extpv";
            this.extpvDataGridViewTextBoxColumn.Name = "extpvDataGridViewTextBoxColumn";
            this.extpvDataGridViewTextBoxColumn.ReadOnly = true;
            this.extpvDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormCmdDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(703, 451);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEcart);
            this.Controls.Add(this.dgvCmdDetail);
            this.Controls.Add(this.dgvCmd);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(725, 507);
            this.Name = "FormCmdDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Commande - LogiS";
            this.Load += new System.EventHandler(this.FormCmdDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCommande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmdDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeLigneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCmdLigne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dgvCmd;
        private DataSetCommande dataSetCommande;
        public System.Windows.Forms.DataGridView dgvCmdDetail;
        private DataSetCmdLigne dataSetCmdLigne;
        private System.Windows.Forms.BindingSource commandeLigneBindingSource;
        private DataSetCmdLigneTableAdapters.CommandeLigneTableAdapter commandeLigneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn datearriveprobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn factureDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn pvreceptionDataGridViewImageColumn;
        public System.Windows.Forms.Button btnEcart;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomcommercial;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtecomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteenvoyeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtearriveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteentreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
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