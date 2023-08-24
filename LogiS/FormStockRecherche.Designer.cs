namespace LogiS
{
    partial class FormStockRecherche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStockRecherche));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAfficher = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.idstockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtestockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poidsunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixventeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produitStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetStock = new LogiS.DataSetStock();
            this.txtProduit = new System.Windows.Forms.TextBox();
            this.lblPays = new System.Windows.Forms.Label();
            this.produitStockTableAdapter = new LogiS.DataSetStockTableAdapters.ProduitStockTableAdapter();
            this.btnValider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetStock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAfficher
            // 
            this.btnAfficher.BackColor = System.Drawing.Color.Transparent;
            this.btnAfficher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAfficher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAfficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAfficher.Image = ((System.Drawing.Image)(resources.GetObject("btnAfficher.Image")));
            this.btnAfficher.Location = new System.Drawing.Point(489, 40);
            this.btnAfficher.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(30, 21);
            this.btnAfficher.TabIndex = 887;
            this.toolTip1.SetToolTip(this.btnAfficher, "Afficher");
            this.btnAfficher.UseVisualStyleBackColor = false;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(687, 27);
            this.panel2.TabIndex = 849;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idstockDataGridViewTextBoxColumn,
            this.qtestockDataGridViewTextBoxColumn,
            this.poidsunitDataGridViewTextBoxColumn,
            this.volumeunitDataGridViewTextBoxColumn,
            this.expirationDataGridViewTextBoxColumn,
            this.prixventeDataGridViewTextBoxColumn,
            this.Column1});
            this.dgvStock.DataSource = this.produitStockBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStock.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvStock.EnableHeadersVisualStyles = false;
            this.dgvStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.dgvStock.Location = new System.Drawing.Point(18, 76);
            this.dgvStock.MultiSelect = false;
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvStock.Size = new System.Drawing.Size(651, 266);
            this.dgvStock.TabIndex = 867;
            this.dgvStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellClick);
            // 
            // idstockDataGridViewTextBoxColumn
            // 
            this.idstockDataGridViewTextBoxColumn.DataPropertyName = "idstock";
            this.idstockDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idstockDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.idstockDataGridViewTextBoxColumn.Name = "idstockDataGridViewTextBoxColumn";
            this.idstockDataGridViewTextBoxColumn.Width = 50;
            // 
            // qtestockDataGridViewTextBoxColumn
            // 
            this.qtestockDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qtestockDataGridViewTextBoxColumn.DataPropertyName = "qtestock";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.qtestockDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.qtestockDataGridViewTextBoxColumn.HeaderText = "Qté stock";
            this.qtestockDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.qtestockDataGridViewTextBoxColumn.Name = "qtestockDataGridViewTextBoxColumn";
            this.qtestockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // poidsunitDataGridViewTextBoxColumn
            // 
            this.poidsunitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.poidsunitDataGridViewTextBoxColumn.DataPropertyName = "poidsunit";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.poidsunitDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.poidsunitDataGridViewTextBoxColumn.HeaderText = "Poids u.";
            this.poidsunitDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.poidsunitDataGridViewTextBoxColumn.Name = "poidsunitDataGridViewTextBoxColumn";
            this.poidsunitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // volumeunitDataGridViewTextBoxColumn
            // 
            this.volumeunitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.volumeunitDataGridViewTextBoxColumn.DataPropertyName = "volumeunit";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.volumeunitDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.volumeunitDataGridViewTextBoxColumn.HeaderText = "Volume u.";
            this.volumeunitDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.volumeunitDataGridViewTextBoxColumn.Name = "volumeunitDataGridViewTextBoxColumn";
            this.volumeunitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expirationDataGridViewTextBoxColumn
            // 
            this.expirationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.expirationDataGridViewTextBoxColumn.DataPropertyName = "expiration";
            this.expirationDataGridViewTextBoxColumn.HeaderText = "Expiration";
            this.expirationDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.expirationDataGridViewTextBoxColumn.Name = "expirationDataGridViewTextBoxColumn";
            this.expirationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixventeDataGridViewTextBoxColumn
            // 
            this.prixventeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prixventeDataGridViewTextBoxColumn.DataPropertyName = "prix_vente";
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.prixventeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.prixventeDataGridViewTextBoxColumn.HeaderText = "Prix";
            this.prixventeDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.prixventeDataGridViewTextBoxColumn.Name = "prixventeDataGridViewTextBoxColumn";
            this.prixventeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column1.HeaderText = "Qté com.";
            this.Column1.MinimumWidth = 100;
            this.Column1.Name = "Column1";
            // 
            // produitStockBindingSource
            // 
            this.produitStockBindingSource.DataMember = "ProduitStock";
            this.produitStockBindingSource.DataSource = this.dataSetStock;
            // 
            // dataSetStock
            // 
            this.dataSetStock.DataSetName = "DataSetStock";
            this.dataSetStock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtProduit
            // 
            this.txtProduit.Enabled = false;
            this.txtProduit.Location = new System.Drawing.Point(137, 40);
            this.txtProduit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtProduit.MaxLength = 75;
            this.txtProduit.Name = "txtProduit";
            this.txtProduit.Size = new System.Drawing.Size(352, 28);
            this.txtProduit.TabIndex = 869;
            // 
            // lblPays
            // 
            this.lblPays.AutoSize = true;
            this.lblPays.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPays.Location = new System.Drawing.Point(14, 43);
            this.lblPays.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPays.Name = "lblPays";
            this.lblPays.Size = new System.Drawing.Size(117, 22);
            this.lblPays.TabIndex = 868;
            this.lblPays.Text = "Nom produit :";
            // 
            // produitStockTableAdapter
            // 
            this.produitStockTableAdapter.ClearBeforeFill = true;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.Transparent;
            this.btnValider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnValider.Enabled = false;
            this.btnValider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnValider.Image = ((System.Drawing.Image)(resources.GetObject("btnValider.Image")));
            this.btnValider.Location = new System.Drawing.Point(530, 40);
            this.btnValider.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(30, 21);
            this.btnValider.TabIndex = 888;
            this.toolTip1.SetToolTip(this.btnValider, "Valider");
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // FormStockRecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(687, 354);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.txtProduit);
            this.Controls.Add(this.lblPays);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(709, 410);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(709, 410);
            this.Name = "FormStockRecherche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Recherche produit - LogiS";
            this.Load += new System.EventHandler(this.FormStockRecherche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dgvStock;
        public System.Windows.Forms.TextBox txtProduit;
        public System.Windows.Forms.Label lblPays;
        private DataSetStock dataSetStock;
        private System.Windows.Forms.BindingSource produitStockBindingSource;
        private DataSetStockTableAdapters.ProduitStockTableAdapter produitStockTableAdapter;
        public System.Windows.Forms.Button btnAfficher;
        public System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtestockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poidsunitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeunitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixventeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}