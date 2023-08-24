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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvFacture = new System.Windows.Forms.DataGridView();
            this.idfactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remiseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datefactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetermeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomfichierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomfour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factureFournisseurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetFactureFour = new LogiS.DataSetFactureFour();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOuvrir = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAfficher = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDateA = new System.Windows.Forms.DateTimePicker();
            this.dtpDateDe = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.factureFournisseurTableAdapter = new LogiS.DataSetFactureFourTableAdapters.FactureFournisseurTableAdapter();
            this.txtNomFour = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chbDate = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factureFournisseurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFactureFour)).BeginInit();
            this.panel2.SuspendLayout();
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
            // dgvFacture
            // 
            this.dgvFacture.AllowUserToAddRows = false;
            this.dgvFacture.AllowUserToDeleteRows = false;
            this.dgvFacture.AllowUserToResizeColumns = false;
            this.dgvFacture.AllowUserToResizeRows = false;
            this.dgvFacture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFacture.AutoGenerateColumns = false;
            this.dgvFacture.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvFacture.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFacture.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacture.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFacture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfactureDataGridViewTextBoxColumn,
            this.montantDataGridViewTextBoxColumn,
            this.remiseDataGridViewTextBoxColumn,
            this.datefactureDataGridViewTextBoxColumn,
            this.datetermeDataGridViewTextBoxColumn,
            this.libelleDataGridViewTextBoxColumn,
            this.nomfichierDataGridViewTextBoxColumn,
            this.nomfour});
            this.dgvFacture.DataSource = this.factureFournisseurBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFacture.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvFacture.EnableHeadersVisualStyles = false;
            this.dgvFacture.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.dgvFacture.Location = new System.Drawing.Point(12, 98);
            this.dgvFacture.MultiSelect = false;
            this.dgvFacture.Name = "dgvFacture";
            this.dgvFacture.ReadOnly = true;
            this.dgvFacture.RowHeadersVisible = false;
            this.dgvFacture.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFacture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacture.Size = new System.Drawing.Size(679, 341);
            this.dgvFacture.TabIndex = 837;
            this.dgvFacture.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacture_CellClick);
            // 
            // idfactureDataGridViewTextBoxColumn
            // 
            this.idfactureDataGridViewTextBoxColumn.DataPropertyName = "idfacture";
            this.idfactureDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idfactureDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.idfactureDataGridViewTextBoxColumn.Name = "idfactureDataGridViewTextBoxColumn";
            this.idfactureDataGridViewTextBoxColumn.ReadOnly = true;
            this.idfactureDataGridViewTextBoxColumn.Width = 50;
            // 
            // montantDataGridViewTextBoxColumn
            // 
            this.montantDataGridViewTextBoxColumn.DataPropertyName = "montant";
            dataGridViewCellStyle6.Format = "N2";
            this.montantDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.montantDataGridViewTextBoxColumn.HeaderText = "Montant";
            this.montantDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.montantDataGridViewTextBoxColumn.Name = "montantDataGridViewTextBoxColumn";
            this.montantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remiseDataGridViewTextBoxColumn
            // 
            this.remiseDataGridViewTextBoxColumn.DataPropertyName = "remise";
            dataGridViewCellStyle7.Format = "N2";
            this.remiseDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.remiseDataGridViewTextBoxColumn.HeaderText = "Remise";
            this.remiseDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.remiseDataGridViewTextBoxColumn.Name = "remiseDataGridViewTextBoxColumn";
            this.remiseDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.datetermeDataGridViewTextBoxColumn.HeaderText = "D. terme";
            this.datetermeDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.datetermeDataGridViewTextBoxColumn.Name = "datetermeDataGridViewTextBoxColumn";
            this.datetermeDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.nomfichierDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.nomfichierDataGridViewTextBoxColumn.Name = "nomfichierDataGridViewTextBoxColumn";
            this.nomfichierDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomfichierDataGridViewTextBoxColumn.Width = 200;
            // 
            // nomfour
            // 
            this.nomfour.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomfour.DataPropertyName = "nomfour";
            this.nomfour.HeaderText = "Fournisseur";
            this.nomfour.MinimumWidth = 200;
            this.nomfour.Name = "nomfour";
            this.nomfour.ReadOnly = true;
            // 
            // factureFournisseurBindingSource
            // 
            this.factureFournisseurBindingSource.DataMember = "FactureFournisseur";
            this.factureFournisseurBindingSource.DataSource = this.dataSetFactureFour;
            // 
            // dataSetFactureFour
            // 
            this.dataSetFactureFour.DataSetName = "DataSetFactureFour";
            this.dataSetFactureFour.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.panel2.Controls.Add(this.chbDate);
            this.panel2.Controls.Add(this.btnOuvrir);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnSupprimer);
            this.panel2.Controls.Add(this.btnModifier);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 30);
            this.panel2.TabIndex = 836;
            // 
            // btnOuvrir
            // 
            this.btnOuvrir.BackColor = System.Drawing.Color.Transparent;
            this.btnOuvrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOuvrir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOuvrir.Enabled = false;
            this.btnOuvrir.FlatAppearance.BorderSize = 0;
            this.btnOuvrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOuvrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOuvrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnOuvrir.Image = ((System.Drawing.Image)(resources.GetObject("btnOuvrir.Image")));
            this.btnOuvrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOuvrir.Location = new System.Drawing.Point(180, 0);
            this.btnOuvrir.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(80, 30);
            this.btnOuvrir.TabIndex = 839;
            this.btnOuvrir.Text = "Voir";
            this.btnOuvrir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnOuvrir, "Voir la preuve");
            this.btnOuvrir.UseVisualStyleBackColor = false;
            this.btnOuvrir.Click += new System.EventHandler(this.btnOuvrir_Click);
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
            this.btnSupprimer.Location = new System.Drawing.Point(90, 0);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(90, 30);
            this.btnSupprimer.TabIndex = 840;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnSupprimer, "Surrpimer cette facture");
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
            this.btnModifier.Location = new System.Drawing.Point(0, 0);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(90, 30);
            this.btnModifier.TabIndex = 839;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnModifier, "Modifier cette facture");
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
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
            this.btnAfficher.Location = new System.Drawing.Point(661, 69);
            this.btnAfficher.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(30, 21);
            this.btnAfficher.TabIndex = 845;
            this.toolTip1.SetToolTip(this.btnAfficher, "Ajouter un pays");
            this.btnAfficher.UseVisualStyleBackColor = false;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
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
            // dtpDateA
            // 
            this.dtpDateA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateA.Location = new System.Drawing.Point(532, 69);
            this.dtpDateA.Name = "dtpDateA";
            this.dtpDateA.Size = new System.Drawing.Size(120, 28);
            this.dtpDateA.TabIndex = 843;
            // 
            // dtpDateDe
            // 
            this.dtpDateDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDe.Location = new System.Drawing.Point(382, 69);
            this.dtpDateDe.Name = "dtpDateDe";
            this.dtpDateDe.Size = new System.Drawing.Size(120, 28);
            this.dtpDateDe.TabIndex = 844;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(508, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 22);
            this.label6.TabIndex = 841;
            this.label6.Text = "à";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(341, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 22);
            this.label3.TabIndex = 842;
            this.label3.Text = "De :";
            // 
            // factureFournisseurTableAdapter
            // 
            this.factureFournisseurTableAdapter.ClearBeforeFill = true;
            // 
            // txtNomFour
            // 
            this.txtNomFour.Location = new System.Drawing.Point(90, 66);
            this.txtNomFour.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNomFour.MaxLength = 75;
            this.txtNomFour.Name = "txtNomFour";
            this.txtNomFour.Size = new System.Drawing.Size(247, 28);
            this.txtNomFour.TabIndex = 850;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(8, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 849;
            this.label2.Text = "Fournisseur :";
            // 
            // chbDate
            // 
            this.chbDate.AutoSize = true;
            this.chbDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.chbDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.chbDate.Location = new System.Drawing.Point(260, 0);
            this.chbDate.Name = "chbDate";
            this.chbDate.Size = new System.Drawing.Size(119, 30);
            this.chbDate.TabIndex = 889;
            this.chbDate.Text = "Date terme";
            this.chbDate.UseVisualStyleBackColor = true;
            // 
            // FormFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(703, 451);
            this.Controls.Add(this.txtNomFour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.dtpDateA);
            this.Controls.Add(this.dtpDateDe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvFacture);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFacture";
            this.Load += new System.EventHandler(this.FormFacture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factureFournisseurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFactureFour)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.DataGridView dgvFacture;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnModifier;
        public System.Windows.Forms.Button btnOuvrir;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DateTimePicker dtpDateA;
        public System.Windows.Forms.DateTimePicker dtpDateDe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnAfficher;
        public System.Windows.Forms.Button btnSupprimer;
        private DataSetFactureFour dataSetFactureFour;
        private System.Windows.Forms.BindingSource factureFournisseurBindingSource;
        private DataSetFactureFourTableAdapters.FactureFournisseurTableAdapter factureFournisseurTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remiseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datefactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetermeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomfichierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomfour;
        public System.Windows.Forms.TextBox txtNomFour;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox chbDate;
    }
}