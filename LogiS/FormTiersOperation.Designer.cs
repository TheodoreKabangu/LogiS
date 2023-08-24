namespace LogiS
{
    partial class FormTiersOperation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTiersOperation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.dtpDateA = new System.Windows.Forms.DateTimePicker();
            this.dtpDateDe = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvOperation = new System.Windows.Forms.DataGridView();
            this.idoperationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datejourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomfichierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extfichierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtiersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomtiers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationTiersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetOperationTiers = new LogiS.DataSetOperationTiers();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnModifier = new System.Windows.Forms.Button();
            this.operationTiersTableAdapter = new LogiS.DataSetOperationTiersTableAdapters.OperationTiersTableAdapter();
            this.btnVoir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationTiersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOperationTiers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 27);
            this.panel2.TabIndex = 858;
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
            this.btnAfficher.Location = new System.Drawing.Point(310, 40);
            this.btnAfficher.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(30, 21);
            this.btnAfficher.TabIndex = 904;
            this.toolTip1.SetToolTip(this.btnAfficher, "Afficher");
            this.btnAfficher.UseVisualStyleBackColor = false;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // dtpDateA
            // 
            this.dtpDateA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateA.Location = new System.Drawing.Point(193, 40);
            this.dtpDateA.Name = "dtpDateA";
            this.dtpDateA.Size = new System.Drawing.Size(108, 28);
            this.dtpDateA.TabIndex = 902;
            // 
            // dtpDateDe
            // 
            this.dtpDateDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDe.Location = new System.Drawing.Point(42, 40);
            this.dtpDateDe.Name = "dtpDateDe";
            this.dtpDateDe.Size = new System.Drawing.Size(108, 28);
            this.dtpDateDe.TabIndex = 903;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(159, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 22);
            this.label3.TabIndex = 900;
            this.label3.Text = "à :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(8, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 22);
            this.label2.TabIndex = 901;
            this.label2.Text = "De :";
            // 
            // dgvOperation
            // 
            this.dgvOperation.AllowUserToAddRows = false;
            this.dgvOperation.AllowUserToDeleteRows = false;
            this.dgvOperation.AllowUserToResizeColumns = false;
            this.dgvOperation.AllowUserToResizeRows = false;
            this.dgvOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOperation.AutoGenerateColumns = false;
            this.dgvOperation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvOperation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOperation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOperation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idoperationDataGridViewTextBoxColumn,
            this.datejourDataGridViewTextBoxColumn,
            this.montantDataGridViewTextBoxColumn,
            this.libelleDataGridViewTextBoxColumn,
            this.nomfichierDataGridViewTextBoxColumn,
            this.extfichierDataGridViewTextBoxColumn,
            this.categorieDataGridViewTextBoxColumn,
            this.idtiersDataGridViewTextBoxColumn,
            this.nomtiers,
            this.statut});
            this.dgvOperation.DataSource = this.operationTiersBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOperation.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOperation.EnableHeadersVisualStyles = false;
            this.dgvOperation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.dgvOperation.Location = new System.Drawing.Point(12, 74);
            this.dgvOperation.MultiSelect = false;
            this.dgvOperation.Name = "dgvOperation";
            this.dgvOperation.ReadOnly = true;
            this.dgvOperation.RowHeadersVisible = false;
            this.dgvOperation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOperation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOperation.Size = new System.Drawing.Size(679, 365);
            this.dgvOperation.TabIndex = 899;
            this.dgvOperation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOperation_CellClick);
            // 
            // idoperationDataGridViewTextBoxColumn
            // 
            this.idoperationDataGridViewTextBoxColumn.DataPropertyName = "idoperation";
            this.idoperationDataGridViewTextBoxColumn.HeaderText = "N°";
            this.idoperationDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.idoperationDataGridViewTextBoxColumn.Name = "idoperationDataGridViewTextBoxColumn";
            this.idoperationDataGridViewTextBoxColumn.ReadOnly = true;
            this.idoperationDataGridViewTextBoxColumn.Width = 50;
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
            this.libelleDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.libelleDataGridViewTextBoxColumn.Name = "libelleDataGridViewTextBoxColumn";
            this.libelleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomfichierDataGridViewTextBoxColumn
            // 
            this.nomfichierDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomfichierDataGridViewTextBoxColumn.DataPropertyName = "nomfichier";
            this.nomfichierDataGridViewTextBoxColumn.HeaderText = "Preuve";
            this.nomfichierDataGridViewTextBoxColumn.MinimumWidth = 150;
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
            // categorieDataGridViewTextBoxColumn
            // 
            this.categorieDataGridViewTextBoxColumn.DataPropertyName = "categorie";
            this.categorieDataGridViewTextBoxColumn.HeaderText = "Type";
            this.categorieDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.categorieDataGridViewTextBoxColumn.Name = "categorieDataGridViewTextBoxColumn";
            this.categorieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idtiersDataGridViewTextBoxColumn
            // 
            this.idtiersDataGridViewTextBoxColumn.DataPropertyName = "idtiers";
            this.idtiersDataGridViewTextBoxColumn.HeaderText = "idtiers";
            this.idtiersDataGridViewTextBoxColumn.Name = "idtiersDataGridViewTextBoxColumn";
            this.idtiersDataGridViewTextBoxColumn.ReadOnly = true;
            this.idtiersDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomtiers
            // 
            this.nomtiers.DataPropertyName = "nomtiers";
            this.nomtiers.HeaderText = "nomtiers";
            this.nomtiers.Name = "nomtiers";
            this.nomtiers.ReadOnly = true;
            this.nomtiers.Visible = false;
            // 
            // statut
            // 
            this.statut.DataPropertyName = "statut";
            this.statut.HeaderText = "Statut";
            this.statut.MinimumWidth = 100;
            this.statut.Name = "statut";
            this.statut.ReadOnly = true;
            // 
            // operationTiersBindingSource
            // 
            this.operationTiersBindingSource.DataMember = "OperationTiers";
            this.operationTiersBindingSource.DataSource = this.dataSetOperationTiers;
            // 
            // dataSetOperationTiers
            // 
            this.dataSetOperationTiers.DataSetName = "DataSetOperationTiers";
            this.dataSetOperationTiers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Transparent;
            this.btnModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModifier.Enabled = false;
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnModifier.Image = ((System.Drawing.Image)(resources.GetObject("btnModifier.Image")));
            this.btnModifier.Location = new System.Drawing.Point(352, 39);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(30, 23);
            this.btnModifier.TabIndex = 905;
            this.toolTip1.SetToolTip(this.btnModifier, "Modifier");
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // operationTiersTableAdapter
            // 
            this.operationTiersTableAdapter.ClearBeforeFill = true;
            // 
            // btnVoir
            // 
            this.btnVoir.BackColor = System.Drawing.Color.Transparent;
            this.btnVoir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVoir.Enabled = false;
            this.btnVoir.FlatAppearance.BorderSize = 0;
            this.btnVoir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnVoir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnVoir.Image = ((System.Drawing.Image)(resources.GetObject("btnVoir.Image")));
            this.btnVoir.Location = new System.Drawing.Point(394, 39);
            this.btnVoir.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnVoir.Name = "btnVoir";
            this.btnVoir.Size = new System.Drawing.Size(30, 23);
            this.btnVoir.TabIndex = 906;
            this.toolTip1.SetToolTip(this.btnVoir, "Voir la preuve");
            this.btnVoir.UseVisualStyleBackColor = false;
            this.btnVoir.Click += new System.EventHandler(this.btnVoir_Click);
            // 
            // FormTiersOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(703, 451);
            this.Controls.Add(this.btnVoir);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.dtpDateA);
            this.Controls.Add(this.dtpDateDe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvOperation);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(725, 507);
            this.Name = "FormTiersOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Opérations tiers - LogiS";
            this.Load += new System.EventHandler(this.FormTiersOperation_Load);
            this.Shown += new System.EventHandler(this.FormTiersOperation_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationTiersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOperationTiers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.DateTimePicker dtpDateA;
        public System.Windows.Forms.DateTimePicker dtpDateDe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dgvOperation;
        private DataSetOperationTiers dataSetOperationTiers;
        private System.Windows.Forms.BindingSource operationTiersBindingSource;
        private DataSetOperationTiersTableAdapters.OperationTiersTableAdapter operationTiersTableAdapter;
        public System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn idoperationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datejourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomfichierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extfichierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtiersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomtiers;
        private System.Windows.Forms.DataGridViewTextBoxColumn statut;
        public System.Windows.Forms.Button btnVoir;
    }
}