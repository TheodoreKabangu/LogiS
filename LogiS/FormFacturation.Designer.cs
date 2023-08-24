namespace LogiS
{
    partial class FormFacturation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacturation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.dtpDateA = new System.Windows.Forms.DateTimePicker();
            this.dtpDateDe = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvFacture = new System.Windows.Forms.DataGridView();
            this.idfactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datefactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetermeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remiseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raison_retrait = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factureClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetFactureClient = new LogiS.DataSetFactureClient();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnVoir = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.factureClientTableAdapter = new LogiS.DataSetFactureClientTableAdapters.FactureClientTableAdapter();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtRaison = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factureClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFactureClient)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.btnAfficher.Location = new System.Drawing.Point(578, 66);
            this.btnAfficher.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(30, 21);
            this.btnAfficher.TabIndex = 853;
            this.toolTip1.SetToolTip(this.btnAfficher, "Afficher");
            this.btnAfficher.UseVisualStyleBackColor = false;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // dtpDateA
            // 
            this.dtpDateA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateA.Location = new System.Drawing.Point(193, 68);
            this.dtpDateA.Name = "dtpDateA";
            this.dtpDateA.Size = new System.Drawing.Size(120, 28);
            this.dtpDateA.TabIndex = 851;
            // 
            // dtpDateDe
            // 
            this.dtpDateDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDe.Location = new System.Drawing.Point(40, 68);
            this.dtpDateDe.Name = "dtpDateDe";
            this.dtpDateDe.Size = new System.Drawing.Size(120, 28);
            this.dtpDateDe.TabIndex = 852;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(162, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 22);
            this.label6.TabIndex = 849;
            this.label6.Text = "à :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(8, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 22);
            this.label3.TabIndex = 850;
            this.label3.Text = "De :";
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
            this.datefactureDataGridViewTextBoxColumn,
            this.datetermeDataGridViewTextBoxColumn,
            this.libelle,
            this.montantDataGridViewTextBoxColumn,
            this.remiseDataGridViewTextBoxColumn,
            this.categorie,
            this.nomclient,
            this.statut,
            this.raison_retrait,
            this.idclientDataGridViewTextBoxColumn});
            this.dgvFacture.DataSource = this.factureClientBindingSource;
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
            this.dgvFacture.TabIndex = 847;
            this.dgvFacture.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacture_CellClick);
            // 
            // idfactureDataGridViewTextBoxColumn
            // 
            this.idfactureDataGridViewTextBoxColumn.DataPropertyName = "idfacture";
            this.idfactureDataGridViewTextBoxColumn.HeaderText = "N°";
            this.idfactureDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.idfactureDataGridViewTextBoxColumn.Name = "idfactureDataGridViewTextBoxColumn";
            this.idfactureDataGridViewTextBoxColumn.ReadOnly = true;
            this.idfactureDataGridViewTextBoxColumn.Width = 60;
            // 
            // datefactureDataGridViewTextBoxColumn
            // 
            this.datefactureDataGridViewTextBoxColumn.DataPropertyName = "date_facture";
            this.datefactureDataGridViewTextBoxColumn.HeaderText = "Date facture";
            this.datefactureDataGridViewTextBoxColumn.MinimumWidth = 130;
            this.datefactureDataGridViewTextBoxColumn.Name = "datefactureDataGridViewTextBoxColumn";
            this.datefactureDataGridViewTextBoxColumn.ReadOnly = true;
            this.datefactureDataGridViewTextBoxColumn.Width = 130;
            // 
            // datetermeDataGridViewTextBoxColumn
            // 
            this.datetermeDataGridViewTextBoxColumn.DataPropertyName = "date_terme";
            this.datetermeDataGridViewTextBoxColumn.HeaderText = "Date terme";
            this.datetermeDataGridViewTextBoxColumn.MinimumWidth = 130;
            this.datetermeDataGridViewTextBoxColumn.Name = "datetermeDataGridViewTextBoxColumn";
            this.datetermeDataGridViewTextBoxColumn.ReadOnly = true;
            this.datetermeDataGridViewTextBoxColumn.Width = 130;
            // 
            // libelle
            // 
            this.libelle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.libelle.DataPropertyName = "libelle";
            this.libelle.HeaderText = "Libellé";
            this.libelle.MinimumWidth = 200;
            this.libelle.Name = "libelle";
            this.libelle.ReadOnly = true;
            // 
            // montantDataGridViewTextBoxColumn
            // 
            this.montantDataGridViewTextBoxColumn.DataPropertyName = "montant";
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.montantDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.montantDataGridViewTextBoxColumn.HeaderText = "Montant";
            this.montantDataGridViewTextBoxColumn.Name = "montantDataGridViewTextBoxColumn";
            this.montantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remiseDataGridViewTextBoxColumn
            // 
            this.remiseDataGridViewTextBoxColumn.DataPropertyName = "remise";
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.remiseDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.remiseDataGridViewTextBoxColumn.HeaderText = "Remise";
            this.remiseDataGridViewTextBoxColumn.Name = "remiseDataGridViewTextBoxColumn";
            this.remiseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categorie
            // 
            this.categorie.DataPropertyName = "categorie";
            this.categorie.HeaderText = "Catégorie";
            this.categorie.MinimumWidth = 100;
            this.categorie.Name = "categorie";
            this.categorie.ReadOnly = true;
            // 
            // nomclient
            // 
            this.nomclient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomclient.DataPropertyName = "nomclient";
            this.nomclient.HeaderText = "Client";
            this.nomclient.MinimumWidth = 200;
            this.nomclient.Name = "nomclient";
            this.nomclient.ReadOnly = true;
            // 
            // statut
            // 
            this.statut.DataPropertyName = "statut";
            this.statut.HeaderText = "Statut";
            this.statut.MinimumWidth = 80;
            this.statut.Name = "statut";
            this.statut.ReadOnly = true;
            this.statut.Visible = false;
            // 
            // raison_retrait
            // 
            this.raison_retrait.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.raison_retrait.DataPropertyName = "raison_retrait";
            this.raison_retrait.HeaderText = "Raison retrait";
            this.raison_retrait.MinimumWidth = 200;
            this.raison_retrait.Name = "raison_retrait";
            this.raison_retrait.ReadOnly = true;
            this.raison_retrait.Visible = false;
            // 
            // idclientDataGridViewTextBoxColumn
            // 
            this.idclientDataGridViewTextBoxColumn.DataPropertyName = "idclient";
            this.idclientDataGridViewTextBoxColumn.HeaderText = "idclient";
            this.idclientDataGridViewTextBoxColumn.Name = "idclientDataGridViewTextBoxColumn";
            this.idclientDataGridViewTextBoxColumn.ReadOnly = true;
            this.idclientDataGridViewTextBoxColumn.Visible = false;
            // 
            // factureClientBindingSource
            // 
            this.factureClientBindingSource.DataMember = "FactureClient";
            this.factureClientBindingSource.DataSource = this.dataSetFactureClient;
            // 
            // dataSetFactureClient
            // 
            this.dataSetFactureClient.DataSetName = "DataSetFactureClient";
            this.dataSetFactureClient.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 27);
            this.panel1.TabIndex = 848;
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
            this.btnVoir.Location = new System.Drawing.Point(0, 0);
            this.btnVoir.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnVoir.Name = "btnVoir";
            this.btnVoir.Size = new System.Drawing.Size(75, 30);
            this.btnVoir.TabIndex = 860;
            this.btnVoir.Text = "Voir";
            this.btnVoir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnVoir, "Voir les détails");
            this.btnVoir.UseVisualStyleBackColor = false;
            this.btnVoir.Click += new System.EventHandler(this.btnVoir_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Transparent;
            this.btnAnnuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAnnuler.Enabled = false;
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAnnuler.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnuler.Image")));
            this.btnAnnuler.Location = new System.Drawing.Point(609, 3);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(30, 21);
            this.btnAnnuler.TabIndex = 863;
            this.toolTip1.SetToolTip(this.btnAnnuler, "Annuler la facture");
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // factureClientTableAdapter
            // 
            this.factureClientTableAdapter.ClearBeforeFill = true;
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(372, 66);
            this.txtLibelle.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtLibelle.MaxLength = 75;
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(201, 28);
            this.txtLibelle.TabIndex = 858;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(318, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 857;
            this.label1.Text = "Libellé :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.panel2.Controls.Add(this.btnAnnuler);
            this.panel2.Controls.Add(this.txtRaison);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnVoir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 30);
            this.panel2.TabIndex = 862;
            // 
            // txtRaison
            // 
            this.txtRaison.Enabled = false;
            this.txtRaison.Location = new System.Drawing.Point(174, 3);
            this.txtRaison.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtRaison.MaxLength = 75;
            this.txtRaison.Name = "txtRaison";
            this.txtRaison.Size = new System.Drawing.Size(435, 28);
            this.txtRaison.TabIndex = 862;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(81, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 861;
            this.label2.Text = "Annuler pour :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(75, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 30);
            this.panel3.TabIndex = 847;
            // 
            // FormFacturation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(703, 451);
            this.Controls.Add(this.dgvFacture);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.dtpDateA);
            this.Controls.Add(this.dtpDateDe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFacturation";
            this.Text = "FormFacturation";
            this.Load += new System.EventHandler(this.FormFacturation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factureClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFactureClient)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.DateTimePicker dtpDateA;
        public System.Windows.Forms.DateTimePicker dtpDateDe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dgvFacture;
        private System.Windows.Forms.Panel panel1;
        private DataSetFactureClient dataSetFactureClient;
        private System.Windows.Forms.BindingSource factureClientBindingSource;
        private DataSetFactureClientTableAdapters.FactureClientTableAdapter factureClientTableAdapter;
        public System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnVoir;
        public System.Windows.Forms.TextBox txtRaison;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datefactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetermeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remiseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn statut;
        private System.Windows.Forms.DataGridViewTextBoxColumn raison_retrait;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientDataGridViewTextBoxColumn;
    }
}