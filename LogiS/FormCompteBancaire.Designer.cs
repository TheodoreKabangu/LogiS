namespace LogiS
{
    partial class FormCompteBancaire
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompteBancaire));
            this.txtCompte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDevise = new System.Windows.Forms.TextBox();
            this.dgvCompte = new System.Windows.Forms.DataGridView();
            this.numcompteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intituleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compteBancaireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCompte = new LogiS.DataSetCompte();
            this.panel1 = new System.Windows.Forms.Panel();
            this.compteBancaireTableAdapter = new LogiS.DataSetCompteTableAdapters.CompteBancaireTableAdapter();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compteBancaireBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCompte)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCompte
            // 
            this.txtCompte.Location = new System.Drawing.Point(95, 49);
            this.txtCompte.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCompte.MaxLength = 50;
            this.txtCompte.Name = "txtCompte";
            this.txtCompte.Size = new System.Drawing.Size(365, 28);
            this.txtCompte.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(8, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 22);
            this.label4.TabIndex = 906;
            this.label4.Text = "N° compte :";
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(95, 78);
            this.txtLibelle.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtLibelle.MaxLength = 100;
            this.txtLibelle.Multiline = true;
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(365, 50);
            this.txtLibelle.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(8, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 908;
            this.label3.Text = "Intitulé :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(8, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 906;
            this.label1.Text = "Devise :";
            // 
            // txtDevise
            // 
            this.txtDevise.Location = new System.Drawing.Point(95, 132);
            this.txtDevise.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDevise.MaxLength = 4;
            this.txtDevise.Name = "txtDevise";
            this.txtDevise.Size = new System.Drawing.Size(365, 28);
            this.txtDevise.TabIndex = 3;
            // 
            // dgvCompte
            // 
            this.dgvCompte.AllowUserToAddRows = false;
            this.dgvCompte.AllowUserToDeleteRows = false;
            this.dgvCompte.AllowUserToResizeColumns = false;
            this.dgvCompte.AllowUserToResizeRows = false;
            this.dgvCompte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCompte.AutoGenerateColumns = false;
            this.dgvCompte.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvCompte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCompte.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numcompteDataGridViewTextBoxColumn,
            this.intituleDataGridViewTextBoxColumn,
            this.deviseDataGridViewTextBoxColumn});
            this.dgvCompte.DataSource = this.compteBancaireBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompte.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCompte.EnableHeadersVisualStyles = false;
            this.dgvCompte.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.dgvCompte.Location = new System.Drawing.Point(12, 208);
            this.dgvCompte.MultiSelect = false;
            this.dgvCompte.Name = "dgvCompte";
            this.dgvCompte.ReadOnly = true;
            this.dgvCompte.RowHeadersVisible = false;
            this.dgvCompte.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCompte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompte.Size = new System.Drawing.Size(458, 231);
            this.dgvCompte.TabIndex = 909;
            this.dgvCompte.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompte_CellClick);
            // 
            // numcompteDataGridViewTextBoxColumn
            // 
            this.numcompteDataGridViewTextBoxColumn.DataPropertyName = "numcompte";
            this.numcompteDataGridViewTextBoxColumn.HeaderText = "Numéro";
            this.numcompteDataGridViewTextBoxColumn.MinimumWidth = 170;
            this.numcompteDataGridViewTextBoxColumn.Name = "numcompteDataGridViewTextBoxColumn";
            this.numcompteDataGridViewTextBoxColumn.ReadOnly = true;
            this.numcompteDataGridViewTextBoxColumn.Width = 170;
            // 
            // intituleDataGridViewTextBoxColumn
            // 
            this.intituleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.intituleDataGridViewTextBoxColumn.DataPropertyName = "intitule";
            this.intituleDataGridViewTextBoxColumn.HeaderText = "Intitulé";
            this.intituleDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.intituleDataGridViewTextBoxColumn.Name = "intituleDataGridViewTextBoxColumn";
            this.intituleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deviseDataGridViewTextBoxColumn
            // 
            this.deviseDataGridViewTextBoxColumn.DataPropertyName = "devise";
            this.deviseDataGridViewTextBoxColumn.HeaderText = "Devise";
            this.deviseDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.deviseDataGridViewTextBoxColumn.Name = "deviseDataGridViewTextBoxColumn";
            this.deviseDataGridViewTextBoxColumn.ReadOnly = true;
            this.deviseDataGridViewTextBoxColumn.Width = 60;
            // 
            // compteBancaireBindingSource
            // 
            this.compteBancaireBindingSource.DataMember = "CompteBancaire";
            this.compteBancaireBindingSource.DataSource = this.dataSetCompte;
            // 
            // dataSetCompte
            // 
            this.dataSetCompte.DataSetName = "DataSetCompte";
            this.dataSetCompte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 27);
            this.panel1.TabIndex = 910;
            // 
            // compteBancaireTableAdapter
            // 
            this.compteBancaireTableAdapter.ClearBeforeFill = true;
            // 
            // btnAfficher
            // 
            this.btnAfficher.BackColor = System.Drawing.Color.Transparent;
            this.btnAfficher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAfficher.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.btnAfficher.FlatAppearance.BorderSize = 0;
            this.btnAfficher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAfficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAfficher.Image = ((System.Drawing.Image)(resources.GetObject("btnAfficher.Image")));
            this.btnAfficher.Location = new System.Drawing.Point(263, 170);
            this.btnAfficher.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(30, 30);
            this.btnAfficher.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnAfficher, "Afficher");
            this.btnAfficher.UseVisualStyleBackColor = false;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Transparent;
            this.btnModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModifier.Enabled = false;
            this.btnModifier.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnModifier.Image = ((System.Drawing.Image)(resources.GetObject("btnModifier.Image")));
            this.btnModifier.Location = new System.Drawing.Point(179, 170);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(30, 30);
            this.btnModifier.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnModifier, "Modifier");
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Transparent;
            this.btnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAjouter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAjouter.Image = ((System.Drawing.Image)(resources.GetObject("btnAjouter.Image")));
            this.btnAjouter.Location = new System.Drawing.Point(137, 170);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(30, 30);
            this.btnAjouter.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnAjouter, "Enregistrer");
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Transparent;
            this.btnAnnuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAnnuler.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAnnuler.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnuler.Image")));
            this.btnAnnuler.Location = new System.Drawing.Point(95, 170);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(30, 30);
            this.btnAnnuler.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnAnnuler, "Annuler");
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Transparent;
            this.btnSupprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSupprimer.Enabled = false;
            this.btnSupprimer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("btnSupprimer.Image")));
            this.btnSupprimer.Location = new System.Drawing.Point(221, 170);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(30, 30);
            this.btnSupprimer.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnSupprimer, "Supprimer");
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // FormCompteBancaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 451);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCompte);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDevise);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCompte);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(504, 507);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(504, 507);
            this.Name = "FormCompteBancaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Compte - LogiS";
            this.Load += new System.EventHandler(this.FormCompteBancaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compteBancaireBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCompte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtCompte;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtDevise;
        public System.Windows.Forms.DataGridView dgvCompte;
        private System.Windows.Forms.Panel panel1;
        private DataSetCompte dataSetCompte;
        private System.Windows.Forms.BindingSource compteBancaireBindingSource;
        private DataSetCompteTableAdapters.CompteBancaireTableAdapter compteBancaireTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcompteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intituleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviseDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Button btnModifier;
        public System.Windows.Forms.Button btnAjouter;
        public System.Windows.Forms.Button btnAnnuler;
        public System.Windows.Forms.Button btnSupprimer;
    }
}