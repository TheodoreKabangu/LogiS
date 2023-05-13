namespace LogiS
{
    partial class FormFacture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacture));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvPrev = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnOuvrir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFournisseur = new System.Windows.Forms.Button();
            this.dataSetFacture = new LogiS.DataSetFacture();
            this.factureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factureTableAdapter = new LogiS.DataSetFactureTableAdapters.FactureTableAdapter();
            this.idfactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datefactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetermeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remiseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomfichierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extfichierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrev)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFacture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factureBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // dgvPrev
            // 
            this.dgvPrev.AllowUserToAddRows = false;
            this.dgvPrev.AllowUserToDeleteRows = false;
            this.dgvPrev.AllowUserToResizeColumns = false;
            this.dgvPrev.AllowUserToResizeRows = false;
            this.dgvPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrev.AutoGenerateColumns = false;
            this.dgvPrev.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvPrev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrev.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrev.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrev.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfactureDataGridViewTextBoxColumn,
            this.datefactureDataGridViewTextBoxColumn,
            this.datetermeDataGridViewTextBoxColumn,
            this.montantDataGridViewTextBoxColumn,
            this.avanceDataGridViewTextBoxColumn,
            this.remiseDataGridViewTextBoxColumn,
            this.nomfichierDataGridViewTextBoxColumn,
            this.extfichierDataGridViewTextBoxColumn});
            this.dgvPrev.DataSource = this.factureBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrev.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrev.EnableHeadersVisualStyles = false;
            this.dgvPrev.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.dgvPrev.Location = new System.Drawing.Point(12, 98);
            this.dgvPrev.MultiSelect = false;
            this.dgvPrev.Name = "dgvPrev";
            this.dgvPrev.ReadOnly = true;
            this.dgvPrev.RowHeadersVisible = false;
            this.dgvPrev.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPrev.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrev.Size = new System.Drawing.Size(679, 341);
            this.dgvPrev.TabIndex = 837;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            this.panel2.Controls.Add(this.btnOuvrir);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnModifier);
            this.panel2.Controls.Add(this.btnNouveau);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 30);
            this.panel2.TabIndex = 836;
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
            this.toolTip1.SetToolTip(this.btnNouveau, "Add a new invoice");
            this.btnNouveau.UseVisualStyleBackColor = false;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Transparent;
            this.btnModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModifier.Dock = System.Windows.Forms.DockStyle.Left;
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
            this.toolTip1.SetToolTip(this.btnModifier, "Edit this invoice");
            this.btnModifier.UseVisualStyleBackColor = false;
            // 
            // btnOuvrir
            // 
            this.btnOuvrir.BackColor = System.Drawing.Color.Transparent;
            this.btnOuvrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOuvrir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOuvrir.FlatAppearance.BorderSize = 0;
            this.btnOuvrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOuvrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOuvrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnOuvrir.Image = ((System.Drawing.Image)(resources.GetObject("btnOuvrir.Image")));
            this.btnOuvrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOuvrir.Location = new System.Drawing.Point(160, 0);
            this.btnOuvrir.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(80, 30);
            this.btnOuvrir.TabIndex = 839;
            this.btnOuvrir.Text = "View";
            this.btnOuvrir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnOuvrir, "View the invoice file");
            this.btnOuvrir.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 27);
            this.panel1.TabIndex = 840;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(213, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 28);
            this.dateTimePicker1.TabIndex = 843;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(60, 68);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(120, 28);
            this.dtpDate.TabIndex = 844;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(182, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 22);
            this.label6.TabIndex = 841;
            this.label6.Text = "To :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(8, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 842;
            this.label3.Text = "From :";
            // 
            // btnFournisseur
            // 
            this.btnFournisseur.BackColor = System.Drawing.Color.Transparent;
            this.btnFournisseur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFournisseur.FlatAppearance.BorderSize = 0;
            this.btnFournisseur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFournisseur.Image = ((System.Drawing.Image)(resources.GetObject("btnFournisseur.Image")));
            this.btnFournisseur.Location = new System.Drawing.Point(342, 68);
            this.btnFournisseur.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnFournisseur.Name = "btnFournisseur";
            this.btnFournisseur.Size = new System.Drawing.Size(30, 21);
            this.btnFournisseur.TabIndex = 845;
            this.toolTip1.SetToolTip(this.btnFournisseur, "Ajouter un pays");
            this.btnFournisseur.UseVisualStyleBackColor = false;
            // 
            // dataSetFacture
            // 
            this.dataSetFacture.DataSetName = "DataSetFacture";
            this.dataSetFacture.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // factureBindingSource
            // 
            this.factureBindingSource.DataMember = "Facture";
            this.factureBindingSource.DataSource = this.dataSetFacture;
            // 
            // factureTableAdapter
            // 
            this.factureTableAdapter.ClearBeforeFill = true;
            // 
            // idfactureDataGridViewTextBoxColumn
            // 
            this.idfactureDataGridViewTextBoxColumn.DataPropertyName = "idfacture";
            this.idfactureDataGridViewTextBoxColumn.HeaderText = "N°";
            this.idfactureDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.idfactureDataGridViewTextBoxColumn.Name = "idfactureDataGridViewTextBoxColumn";
            this.idfactureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datefactureDataGridViewTextBoxColumn
            // 
            this.datefactureDataGridViewTextBoxColumn.DataPropertyName = "date_facture";
            this.datefactureDataGridViewTextBoxColumn.HeaderText = "Date";
            this.datefactureDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.datefactureDataGridViewTextBoxColumn.Name = "datefactureDataGridViewTextBoxColumn";
            this.datefactureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datetermeDataGridViewTextBoxColumn
            // 
            this.datetermeDataGridViewTextBoxColumn.DataPropertyName = "date_terme";
            this.datetermeDataGridViewTextBoxColumn.HeaderText = "Due Date";
            this.datetermeDataGridViewTextBoxColumn.MinimumWidth = 130;
            this.datetermeDataGridViewTextBoxColumn.Name = "datetermeDataGridViewTextBoxColumn";
            this.datetermeDataGridViewTextBoxColumn.ReadOnly = true;
            this.datetermeDataGridViewTextBoxColumn.Width = 130;
            // 
            // montantDataGridViewTextBoxColumn
            // 
            this.montantDataGridViewTextBoxColumn.DataPropertyName = "montant";
            this.montantDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.montantDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.montantDataGridViewTextBoxColumn.Name = "montantDataGridViewTextBoxColumn";
            this.montantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // avanceDataGridViewTextBoxColumn
            // 
            this.avanceDataGridViewTextBoxColumn.DataPropertyName = "avance";
            this.avanceDataGridViewTextBoxColumn.HeaderText = "Advance";
            this.avanceDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.avanceDataGridViewTextBoxColumn.Name = "avanceDataGridViewTextBoxColumn";
            this.avanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remiseDataGridViewTextBoxColumn
            // 
            this.remiseDataGridViewTextBoxColumn.DataPropertyName = "remise";
            this.remiseDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.remiseDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.remiseDataGridViewTextBoxColumn.Name = "remiseDataGridViewTextBoxColumn";
            this.remiseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomfichierDataGridViewTextBoxColumn
            // 
            this.nomfichierDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomfichierDataGridViewTextBoxColumn.DataPropertyName = "nomfichier";
            this.nomfichierDataGridViewTextBoxColumn.HeaderText = "Inv. file";
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
            // FormFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(703, 451);
            this.Controls.Add(this.btnFournisseur);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPrev);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFacture";
            this.Text = "FormFactureRecherche";
            this.Load += new System.EventHandler(this.FormFacture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrev)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFacture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.DataGridView dgvPrev;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnNouveau;
        public System.Windows.Forms.Button btnModifier;
        public System.Windows.Forms.Button btnOuvrir;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnFournisseur;
        private DataSetFacture dataSetFacture;
        private System.Windows.Forms.BindingSource factureBindingSource;
        private DataSetFactureTableAdapters.FactureTableAdapter factureTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datefactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetermeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remiseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomfichierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extfichierDataGridViewTextBoxColumn;
    }
}