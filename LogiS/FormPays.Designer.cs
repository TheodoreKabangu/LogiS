namespace LogiS
{
    partial class FormPays
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPays));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.dgvPays = new System.Windows.Forms.DataGridView();
            this.idpaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nompaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monnaieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPays = new LogiS.DataSetPays();
            this.txtMonnaie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPays = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.paysTableAdapter = new LogiS.DataSetPaysTableAdapters.PaysTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPays)).BeginInit();
            this.SuspendLayout();
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
            this.btnModifier.Location = new System.Drawing.Point(203, 118);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(30, 30);
            this.btnModifier.TabIndex = 805;
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
            this.btnAjouter.Location = new System.Drawing.Point(161, 118);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(30, 30);
            this.btnAjouter.TabIndex = 806;
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
            this.btnAnnuler.Location = new System.Drawing.Point(119, 118);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(30, 30);
            this.btnAnnuler.TabIndex = 807;
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
            this.btnSupprimer.Location = new System.Drawing.Point(245, 118);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(30, 30);
            this.btnSupprimer.TabIndex = 808;
            this.toolTip1.SetToolTip(this.btnSupprimer, "Supprimer");
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
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
            this.btnAfficher.Location = new System.Drawing.Point(287, 118);
            this.btnAfficher.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(30, 30);
            this.btnAfficher.TabIndex = 809;
            this.toolTip1.SetToolTip(this.btnAfficher, "Afficher");
            this.btnAfficher.UseVisualStyleBackColor = false;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // dgvPays
            // 
            this.dgvPays.AllowUserToAddRows = false;
            this.dgvPays.AllowUserToDeleteRows = false;
            this.dgvPays.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPays.AutoGenerateColumns = false;
            this.dgvPays.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvPays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPays.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPays.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPays.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpaysDataGridViewTextBoxColumn,
            this.nompaysDataGridViewTextBoxColumn,
            this.monnaieDataGridViewTextBoxColumn});
            this.dgvPays.DataSource = this.paysBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPays.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPays.EnableHeadersVisualStyles = false;
            this.dgvPays.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.dgvPays.Location = new System.Drawing.Point(12, 156);
            this.dgvPays.MultiSelect = false;
            this.dgvPays.Name = "dgvPays";
            this.dgvPays.ReadOnly = true;
            this.dgvPays.RowHeadersVisible = false;
            this.dgvPays.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPays.Size = new System.Drawing.Size(493, 283);
            this.dgvPays.TabIndex = 804;
            this.dgvPays.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPays_CellClick);
            // 
            // idpaysDataGridViewTextBoxColumn
            // 
            this.idpaysDataGridViewTextBoxColumn.DataPropertyName = "idpays";
            this.idpaysDataGridViewTextBoxColumn.HeaderText = "N°";
            this.idpaysDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.idpaysDataGridViewTextBoxColumn.Name = "idpaysDataGridViewTextBoxColumn";
            this.idpaysDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpaysDataGridViewTextBoxColumn.Width = 40;
            // 
            // nompaysDataGridViewTextBoxColumn
            // 
            this.nompaysDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nompaysDataGridViewTextBoxColumn.DataPropertyName = "nompays";
            this.nompaysDataGridViewTextBoxColumn.HeaderText = "Nom du pays";
            this.nompaysDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.nompaysDataGridViewTextBoxColumn.Name = "nompaysDataGridViewTextBoxColumn";
            this.nompaysDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monnaieDataGridViewTextBoxColumn
            // 
            this.monnaieDataGridViewTextBoxColumn.DataPropertyName = "monnaie";
            this.monnaieDataGridViewTextBoxColumn.HeaderText = "Monnaie";
            this.monnaieDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.monnaieDataGridViewTextBoxColumn.Name = "monnaieDataGridViewTextBoxColumn";
            this.monnaieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paysBindingSource
            // 
            this.paysBindingSource.DataMember = "Pays";
            this.paysBindingSource.DataSource = this.dataSetPays;
            // 
            // dataSetPays
            // 
            this.dataSetPays.DataSetName = "DataSetPays";
            this.dataSetPays.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMonnaie
            // 
            this.txtMonnaie.Location = new System.Drawing.Point(119, 80);
            this.txtMonnaie.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtMonnaie.MaxLength = 5;
            this.txtMonnaie.Name = "txtMonnaie";
            this.txtMonnaie.Size = new System.Drawing.Size(386, 28);
            this.txtMonnaie.TabIndex = 800;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(8, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 802;
            this.label1.Text = "Monnaie :";
            // 
            // txtPays
            // 
            this.txtPays.Location = new System.Drawing.Point(119, 51);
            this.txtPays.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPays.MaxLength = 50;
            this.txtPays.Name = "txtPays";
            this.txtPays.Size = new System.Drawing.Size(386, 28);
            this.txtPays.TabIndex = 799;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(8, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 803;
            this.label2.Text = "Nom pays :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 27);
            this.panel2.TabIndex = 801;
            // 
            // paysTableAdapter
            // 
            this.paysTableAdapter.ClearBeforeFill = true;
            // 
            // FormPays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(517, 451);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.dgvPays);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.txtMonnaie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPays);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(539, 507);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(539, 507);
            this.Name = "FormPays";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pays - LogiS";
            this.Load += new System.EventHandler(this.FormPays_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Button btnModifier;
        public System.Windows.Forms.Button btnAjouter;
        public System.Windows.Forms.Button btnAnnuler;
        public System.Windows.Forms.Button btnSupprimer;
        public System.Windows.Forms.DataGridView dgvPays;
        public System.Windows.Forms.TextBox txtMonnaie;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtPays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnAfficher;
        private DataSetPays dataSetPays;
        private System.Windows.Forms.BindingSource paysBindingSource;
        private DataSetPaysTableAdapters.PaysTableAdapter paysTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nompaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monnaieDataGridViewTextBoxColumn;
    }
}