namespace LogiS
{
    partial class FormDepotSortie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepotSortie));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboDepot = new System.Windows.Forms.ComboBox();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.dtpDateA = new System.Windows.Forms.DateTimePicker();
            this.dtpDateDe = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPays = new System.Windows.Forms.Label();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.idsortieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datejourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomcommercialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numlotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtesortieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomdepotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockSortieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSortieStock = new LogiS.DataSetSortieStock();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRetirer = new System.Windows.Forms.Button();
            this.stockSortieTableAdapter = new LogiS.DataSetSortieStockTableAdapters.StockSortieTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockSortieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSortieStock)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDepot
            // 
            this.cboDepot.DropDownHeight = 200;
            this.cboDepot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDepot.FormattingEnabled = true;
            this.cboDepot.IntegralHeight = false;
            this.cboDepot.Items.AddRange(new object[] {
            "Max",
            "Min"});
            this.cboDepot.Location = new System.Drawing.Point(65, 44);
            this.cboDepot.MaxDropDownItems = 10;
            this.cboDepot.Name = "cboDepot";
            this.cboDepot.Size = new System.Drawing.Size(243, 30);
            this.cboDepot.Sorted = true;
            this.cboDepot.TabIndex = 915;
            this.cboDepot.DropDown += new System.EventHandler(this.cboDepot_DropDown);
            this.cboDepot.SelectedIndexChanged += new System.EventHandler(this.cboDepot_SelectedIndexChanged);
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
            this.btnAfficher.Location = new System.Drawing.Point(596, 42);
            this.btnAfficher.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(30, 23);
            this.btnAfficher.TabIndex = 914;
            this.toolTip1.SetToolTip(this.btnAfficher, "Rechercher");
            this.btnAfficher.UseVisualStyleBackColor = false;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // dtpDateA
            // 
            this.dtpDateA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateA.Location = new System.Drawing.Point(482, 42);
            this.dtpDateA.Name = "dtpDateA";
            this.dtpDateA.Size = new System.Drawing.Size(108, 28);
            this.dtpDateA.TabIndex = 912;
            // 
            // dtpDateDe
            // 
            this.dtpDateDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDe.Location = new System.Drawing.Point(349, 42);
            this.dtpDateDe.Name = "dtpDateDe";
            this.dtpDateDe.Size = new System.Drawing.Size(108, 28);
            this.dtpDateDe.TabIndex = 913;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(461, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 22);
            this.label3.TabIndex = 910;
            this.label3.Text = "à :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(315, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 22);
            this.label2.TabIndex = 911;
            this.label2.Text = "De :";
            // 
            // lblPays
            // 
            this.lblPays.AutoSize = true;
            this.lblPays.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPays.Location = new System.Drawing.Point(8, 47);
            this.lblPays.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPays.Name = "lblPays";
            this.lblPays.Size = new System.Drawing.Size(68, 22);
            this.lblPays.TabIndex = 909;
            this.lblPays.Text = "Dépôt :";
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
            this.idsortieDataGridViewTextBoxColumn,
            this.datejourDataGridViewTextBoxColumn,
            this.nomcommercialDataGridViewTextBoxColumn,
            this.uniteDataGridViewTextBoxColumn,
            this.numlotDataGridViewTextBoxColumn,
            this.expirationDataGridViewTextBoxColumn,
            this.qtesortieDataGridViewTextBoxColumn,
            this.libelle,
            this.nomdepotDataGridViewTextBoxColumn});
            this.dgvStock.DataSource = this.stockSortieBindingSource;
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
            this.dgvStock.Location = new System.Drawing.Point(12, 76);
            this.dgvStock.MultiSelect = false;
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(679, 363);
            this.dgvStock.TabIndex = 908;
            this.dgvStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellClick);
            // 
            // idsortieDataGridViewTextBoxColumn
            // 
            this.idsortieDataGridViewTextBoxColumn.DataPropertyName = "idsortie";
            this.idsortieDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idsortieDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.idsortieDataGridViewTextBoxColumn.Name = "idsortieDataGridViewTextBoxColumn";
            this.idsortieDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsortieDataGridViewTextBoxColumn.Width = 50;
            // 
            // datejourDataGridViewTextBoxColumn
            // 
            this.datejourDataGridViewTextBoxColumn.DataPropertyName = "date_jour";
            this.datejourDataGridViewTextBoxColumn.HeaderText = "Date";
            this.datejourDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.datejourDataGridViewTextBoxColumn.Name = "datejourDataGridViewTextBoxColumn";
            this.datejourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomcommercialDataGridViewTextBoxColumn
            // 
            this.nomcommercialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomcommercialDataGridViewTextBoxColumn.DataPropertyName = "nomcommercial";
            this.nomcommercialDataGridViewTextBoxColumn.HeaderText = "Produit";
            this.nomcommercialDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.nomcommercialDataGridViewTextBoxColumn.Name = "nomcommercialDataGridViewTextBoxColumn";
            this.nomcommercialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uniteDataGridViewTextBoxColumn
            // 
            this.uniteDataGridViewTextBoxColumn.DataPropertyName = "unite";
            this.uniteDataGridViewTextBoxColumn.HeaderText = "Unité";
            this.uniteDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.uniteDataGridViewTextBoxColumn.Name = "uniteDataGridViewTextBoxColumn";
            this.uniteDataGridViewTextBoxColumn.ReadOnly = true;
            this.uniteDataGridViewTextBoxColumn.Width = 80;
            // 
            // numlotDataGridViewTextBoxColumn
            // 
            this.numlotDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            // qtesortieDataGridViewTextBoxColumn
            // 
            this.qtesortieDataGridViewTextBoxColumn.DataPropertyName = "qtesortie";
            this.qtesortieDataGridViewTextBoxColumn.HeaderText = "Quantité";
            this.qtesortieDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.qtesortieDataGridViewTextBoxColumn.Name = "qtesortieDataGridViewTextBoxColumn";
            this.qtesortieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // libelle
            // 
            this.libelle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.libelle.DataPropertyName = "libelle";
            this.libelle.HeaderText = "Libellé";
            this.libelle.MinimumWidth = 150;
            this.libelle.Name = "libelle";
            this.libelle.ReadOnly = true;
            // 
            // nomdepotDataGridViewTextBoxColumn
            // 
            this.nomdepotDataGridViewTextBoxColumn.DataPropertyName = "nomdepot";
            this.nomdepotDataGridViewTextBoxColumn.HeaderText = "Dépôt";
            this.nomdepotDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.nomdepotDataGridViewTextBoxColumn.Name = "nomdepotDataGridViewTextBoxColumn";
            this.nomdepotDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockSortieBindingSource
            // 
            this.stockSortieBindingSource.DataMember = "StockSortie";
            this.stockSortieBindingSource.DataSource = this.dataSetSortieStock;
            // 
            // dataSetSortieStock
            // 
            this.dataSetSortieStock.DataSetName = "DataSetSortieStock";
            this.dataSetSortieStock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 27);
            this.panel2.TabIndex = 907;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(673, 28);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 916;
            this.toolTip1.SetToolTip(this.btnExit, "Fermer");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRetirer
            // 
            this.btnRetirer.BackColor = System.Drawing.Color.Transparent;
            this.btnRetirer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRetirer.Enabled = false;
            this.btnRetirer.FlatAppearance.BorderSize = 0;
            this.btnRetirer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRetirer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetirer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnRetirer.Image = ((System.Drawing.Image)(resources.GetObject("btnRetirer.Image")));
            this.btnRetirer.Location = new System.Drawing.Point(638, 42);
            this.btnRetirer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRetirer.Name = "btnRetirer";
            this.btnRetirer.Size = new System.Drawing.Size(30, 23);
            this.btnRetirer.TabIndex = 917;
            this.toolTip1.SetToolTip(this.btnRetirer, "Supprimer");
            this.btnRetirer.UseVisualStyleBackColor = false;
            this.btnRetirer.Click += new System.EventHandler(this.btnRetirer_Click);
            // 
            // stockSortieTableAdapter
            // 
            this.stockSortieTableAdapter.ClearBeforeFill = true;
            // 
            // FormDepotSortie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(703, 451);
            this.Controls.Add(this.btnRetirer);
            this.Controls.Add(this.cboDepot);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.dtpDateA);
            this.Controls.Add(this.dtpDateDe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPays);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDepotSortie";
            this.Text = "FormDepotSortie";
            this.Load += new System.EventHandler(this.FormDepotSortie_Load);
            this.Shown += new System.EventHandler(this.FormDepotSortie_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockSortieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSortieStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cboDepot;
        public System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.DateTimePicker dtpDateA;
        public System.Windows.Forms.DateTimePicker dtpDateDe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblPays;
        public System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnExit;
        private DataSetSortieStock dataSetSortieStock;
        private System.Windows.Forms.BindingSource stockSortieBindingSource;
        private DataSetSortieStockTableAdapters.StockSortieTableAdapter stockSortieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsortieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datejourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomcommercialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numlotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtesortieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomdepotDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button btnRetirer;
    }
}