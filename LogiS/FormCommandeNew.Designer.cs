namespace LogiS
{
    partial class FormCommandeNew
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCommandeNew));
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCTNR = new System.Windows.Forms.ComboBox();
            this.dgvCmdDetail = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomcommercial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProduit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvProduit = new System.Windows.Forms.DataGridView();
            this.idproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomcommercialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poidsunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetProduit = new LogiS.DataSetProduit();
            this.produitTableAdapter = new LogiS.DataSetProduitTableAdapters.ProduitTableAdapter();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmdDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProduit)).BeginInit();
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(15, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 22);
            this.label6.TabIndex = 890;
            this.label6.Text = "Libellé :";
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(128, 68);
            this.txtLibelle.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtLibelle.MaxLength = 250;
            this.txtLibelle.Multiline = true;
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(560, 52);
            this.txtLibelle.TabIndex = 887;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(15, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 22);
            this.label7.TabIndex = 892;
            this.label7.Text = "Container :";
            // 
            // cboCTNR
            // 
            this.cboCTNR.DropDownHeight = 200;
            this.cboCTNR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCTNR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCTNR.FormattingEnabled = true;
            this.cboCTNR.IntegralHeight = false;
            this.cboCTNR.Items.AddRange(new object[] {
            "20",
            "40",
            "45"});
            this.cboCTNR.Location = new System.Drawing.Point(128, 35);
            this.cboCTNR.MaxDropDownItems = 10;
            this.cboCTNR.Name = "cboCTNR";
            this.cboCTNR.Size = new System.Drawing.Size(159, 30);
            this.cboCTNR.Sorted = true;
            this.cboCTNR.TabIndex = 901;
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
            this.dgvCmdDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvCmdDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCmdDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCmdDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCmdDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCmdDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.nomcommercial,
            this.Column4,
            this.Column1,
            this.Column3});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCmdDetail.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCmdDetail.EnableHeadersVisualStyles = false;
            this.dgvCmdDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.dgvCmdDetail.Location = new System.Drawing.Point(128, 158);
            this.dgvCmdDetail.MultiSelect = false;
            this.dgvCmdDetail.Name = "dgvCmdDetail";
            this.dgvCmdDetail.ReadOnly = true;
            this.dgvCmdDetail.RowHeadersVisible = false;
            this.dgvCmdDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCmdDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCmdDetail.Size = new System.Drawing.Size(560, 246);
            this.dgvCmdDetail.TabIndex = 902;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.MinimumWidth = 40;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 40;
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
            // Column4
            // 
            dataGridViewCellStyle2.Format = "N0";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column4.HeaderText = "Vol. unit.";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column1
            // 
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "Quantité";
            this.Column1.MinimumWidth = 100;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle4.Format = "N0";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "Vol. total";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // txtProduit
            // 
            this.txtProduit.Location = new System.Drawing.Point(128, 122);
            this.txtProduit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtProduit.MaxLength = 255;
            this.txtProduit.Name = "txtProduit";
            this.txtProduit.Size = new System.Drawing.Size(417, 28);
            this.txtProduit.TabIndex = 903;
            this.txtProduit.TextChanged += new System.EventHandler(this.txtProduit_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(15, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 22);
            this.label4.TabIndex = 904;
            this.label4.Text = "Produit :";
            // 
            // dgvProduit
            // 
            this.dgvProduit.AllowUserToAddRows = false;
            this.dgvProduit.AllowUserToDeleteRows = false;
            this.dgvProduit.AllowUserToResizeColumns = false;
            this.dgvProduit.AllowUserToResizeRows = false;
            this.dgvProduit.AutoGenerateColumns = false;
            this.dgvProduit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvProduit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduit.ColumnHeadersVisible = false;
            this.dgvProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproduitDataGridViewTextBoxColumn,
            this.nomproduitDataGridViewTextBoxColumn,
            this.nomcommercialDataGridViewTextBoxColumn,
            this.uniteDataGridViewTextBoxColumn,
            this.poidsunitDataGridViewTextBoxColumn,
            this.volumeunitDataGridViewTextBoxColumn});
            this.dgvProduit.DataSource = this.produitBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduit.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProduit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.dgvProduit.Location = new System.Drawing.Point(128, 152);
            this.dgvProduit.MultiSelect = false;
            this.dgvProduit.Name = "dgvProduit";
            this.dgvProduit.RowHeadersVisible = false;
            this.dgvProduit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProduit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduit.Size = new System.Drawing.Size(417, 209);
            this.dgvProduit.TabIndex = 905;
            this.dgvProduit.Visible = false;
            // 
            // idproduitDataGridViewTextBoxColumn
            // 
            this.idproduitDataGridViewTextBoxColumn.DataPropertyName = "idproduit";
            this.idproduitDataGridViewTextBoxColumn.HeaderText = "idproduit";
            this.idproduitDataGridViewTextBoxColumn.Name = "idproduitDataGridViewTextBoxColumn";
            // 
            // nomproduitDataGridViewTextBoxColumn
            // 
            this.nomproduitDataGridViewTextBoxColumn.DataPropertyName = "nomproduit";
            this.nomproduitDataGridViewTextBoxColumn.HeaderText = "nomproduit";
            this.nomproduitDataGridViewTextBoxColumn.Name = "nomproduitDataGridViewTextBoxColumn";
            // 
            // nomcommercialDataGridViewTextBoxColumn
            // 
            this.nomcommercialDataGridViewTextBoxColumn.DataPropertyName = "nomcommercial";
            this.nomcommercialDataGridViewTextBoxColumn.HeaderText = "nomcommercial";
            this.nomcommercialDataGridViewTextBoxColumn.Name = "nomcommercialDataGridViewTextBoxColumn";
            // 
            // uniteDataGridViewTextBoxColumn
            // 
            this.uniteDataGridViewTextBoxColumn.DataPropertyName = "unite";
            this.uniteDataGridViewTextBoxColumn.HeaderText = "unite";
            this.uniteDataGridViewTextBoxColumn.Name = "uniteDataGridViewTextBoxColumn";
            // 
            // poidsunitDataGridViewTextBoxColumn
            // 
            this.poidsunitDataGridViewTextBoxColumn.DataPropertyName = "poidsunit";
            this.poidsunitDataGridViewTextBoxColumn.HeaderText = "poidsunit";
            this.poidsunitDataGridViewTextBoxColumn.Name = "poidsunitDataGridViewTextBoxColumn";
            // 
            // volumeunitDataGridViewTextBoxColumn
            // 
            this.volumeunitDataGridViewTextBoxColumn.DataPropertyName = "volumeunit";
            this.volumeunitDataGridViewTextBoxColumn.HeaderText = "volumeunit";
            this.volumeunitDataGridViewTextBoxColumn.Name = "volumeunitDataGridViewTextBoxColumn";
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataMember = "Produit";
            this.produitBindingSource.DataSource = this.dataSetProduit;
            // 
            // dataSetProduit
            // 
            this.dataSetProduit.DataSetName = "DataSetProduit";
            this.dataSetProduit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produitTableAdapter
            // 
            this.produitTableAdapter.ClearBeforeFill = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Transparent;
            this.btnAnnuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAnnuler.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.btnAnnuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAnnuler.Location = new System.Drawing.Point(128, 412);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(85, 25);
            this.btnAnnuler.TabIndex = 906;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.Transparent;
            this.btnEnregistrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEnregistrer.Enabled = false;
            this.btnEnregistrer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.btnEnregistrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEnregistrer.Location = new System.Drawing.Point(225, 412);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(85, 25);
            this.btnEnregistrer.TabIndex = 907;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            // 
            // FormCommandeNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(703, 451);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.txtProduit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvCmdDetail);
            this.Controls.Add(this.cboCTNR);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvProduit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCommandeNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Commande - LogiS";
            this.Load += new System.EventHandler(this.FormCommandeNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmdDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cboCTNR;
        public System.Windows.Forms.DataGridView dgvCmdDetail;
        public System.Windows.Forms.TextBox txtProduit;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dgvProduit;
        private DataSetProduit dataSetProduit;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private DataSetProduitTableAdapters.ProduitTableAdapter produitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomcommercialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poidsunitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeunitDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button btnAnnuler;
        public System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomcommercial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}