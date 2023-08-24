namespace LogiS
{
    partial class FormFournisseurNew
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFournisseurNew));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPersContact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomFour = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dgvPays = new System.Windows.Forms.DataGridView();
            this.idpaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nompaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monnaieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPays = new LogiS.DataSetPays();
            this.txtPays = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.paysTableAdapter = new LogiS.DataSetPaysTableAdapters.PaysTableAdapter();
            this.btnPays = new System.Windows.Forms.Button();
            this.txtCodeSwift = new System.Windows.Forms.TextBox();
            this.txtNumCompte = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIntitule = new System.Windows.Forms.TextBox();
            this.txtBanque = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPays)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 27);
            this.panel2.TabIndex = 836;
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Transparent;
            this.btnModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModifier.Enabled = false;
            this.btnModifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnModifier.Location = new System.Drawing.Point(433, 383);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(80, 27);
            this.btnModifier.TabIndex = 13;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Transparent;
            this.btnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAjouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAjouter.Location = new System.Drawing.Point(341, 383);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(80, 27);
            this.btnAjouter.TabIndex = 12;
            this.btnAjouter.Text = "Enregistrer";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Transparent;
            this.btnAnnuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAnnuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAnnuler.Location = new System.Drawing.Point(249, 383);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(80, 27);
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(168, 138);
            this.txtTel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTel.MaxLength = 15;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(345, 28);
            this.txtTel.TabIndex = 5;
            this.txtTel.TextChanged += new System.EventHandler(this.txtTel_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(8, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 22);
            this.label4.TabIndex = 849;
            this.label4.Text = "Téléphone :";
            // 
            // txtPersContact
            // 
            this.txtPersContact.Location = new System.Drawing.Point(119, 109);
            this.txtPersContact.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPersContact.MaxLength = 50;
            this.txtPersContact.Name = "txtPersContact";
            this.txtPersContact.Size = new System.Drawing.Size(394, 28);
            this.txtPersContact.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(8, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 22);
            this.label3.TabIndex = 850;
            this.label3.Text = "Pers. Contact :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(8, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 848;
            this.label1.Text = "Pays :";
            // 
            // txtNomFour
            // 
            this.txtNomFour.Location = new System.Drawing.Point(119, 51);
            this.txtNomFour.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNomFour.MaxLength = 75;
            this.txtNomFour.Name = "txtNomFour";
            this.txtNomFour.Size = new System.Drawing.Size(394, 28);
            this.txtNomFour.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(8, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 851;
            this.label2.Text = "Nom :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(8, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 22);
            this.label5.TabIndex = 849;
            this.label5.Text = "Email :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(119, 167);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtEmail.MaxLength = 75;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(394, 28);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Text = "RAS";
            // 
            // dgvPays
            // 
            this.dgvPays.AllowUserToAddRows = false;
            this.dgvPays.AllowUserToDeleteRows = false;
            this.dgvPays.AllowUserToResizeColumns = false;
            this.dgvPays.AllowUserToResizeRows = false;
            this.dgvPays.AutoGenerateColumns = false;
            this.dgvPays.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvPays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPays.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPays.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPays.ColumnHeadersVisible = false;
            this.dgvPays.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpaysDataGridViewTextBoxColumn,
            this.nompaysDataGridViewTextBoxColumn,
            this.monnaieDataGridViewTextBoxColumn});
            this.dgvPays.DataSource = this.paysBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPays.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPays.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.dgvPays.Location = new System.Drawing.Point(119, 109);
            this.dgvPays.MultiSelect = false;
            this.dgvPays.Name = "dgvPays";
            this.dgvPays.ReadOnly = true;
            this.dgvPays.RowHeadersVisible = false;
            this.dgvPays.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPays.Size = new System.Drawing.Size(394, 200);
            this.dgvPays.TabIndex = 857;
            this.dgvPays.Visible = false;
            this.dgvPays.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPays_CellClick);
            // 
            // idpaysDataGridViewTextBoxColumn
            // 
            this.idpaysDataGridViewTextBoxColumn.DataPropertyName = "idpays";
            this.idpaysDataGridViewTextBoxColumn.HeaderText = "idpays";
            this.idpaysDataGridViewTextBoxColumn.Name = "idpaysDataGridViewTextBoxColumn";
            this.idpaysDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpaysDataGridViewTextBoxColumn.Visible = false;
            // 
            // nompaysDataGridViewTextBoxColumn
            // 
            this.nompaysDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nompaysDataGridViewTextBoxColumn.DataPropertyName = "nompays";
            this.nompaysDataGridViewTextBoxColumn.HeaderText = "nompays";
            this.nompaysDataGridViewTextBoxColumn.Name = "nompaysDataGridViewTextBoxColumn";
            this.nompaysDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monnaieDataGridViewTextBoxColumn
            // 
            this.monnaieDataGridViewTextBoxColumn.DataPropertyName = "monnaie";
            this.monnaieDataGridViewTextBoxColumn.HeaderText = "monnaie";
            this.monnaieDataGridViewTextBoxColumn.Name = "monnaieDataGridViewTextBoxColumn";
            this.monnaieDataGridViewTextBoxColumn.ReadOnly = true;
            this.monnaieDataGridViewTextBoxColumn.Visible = false;
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
            // txtPays
            // 
            this.txtPays.Location = new System.Drawing.Point(119, 80);
            this.txtPays.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPays.MaxLength = 50;
            this.txtPays.Name = "txtPays";
            this.txtPays.Size = new System.Drawing.Size(363, 28);
            this.txtPays.TabIndex = 2;
            this.txtPays.TextChanged += new System.EventHandler(this.txtPays_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(119, 138);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 28);
            this.textBox1.TabIndex = 858;
            this.textBox1.Text = "+";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // paysTableAdapter
            // 
            this.paysTableAdapter.ClearBeforeFill = true;
            // 
            // btnPays
            // 
            this.btnPays.BackColor = System.Drawing.Color.Transparent;
            this.btnPays.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPays.FlatAppearance.BorderSize = 0;
            this.btnPays.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPays.Image = ((System.Drawing.Image)(resources.GetObject("btnPays.Image")));
            this.btnPays.Location = new System.Drawing.Point(483, 80);
            this.btnPays.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPays.Name = "btnPays";
            this.btnPays.Size = new System.Drawing.Size(30, 21);
            this.btnPays.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnPays, "Ajouter un pays");
            this.btnPays.UseVisualStyleBackColor = false;
            this.btnPays.Click += new System.EventHandler(this.btnPays_Click);
            // 
            // txtCodeSwift
            // 
            this.txtCodeSwift.Location = new System.Drawing.Point(119, 284);
            this.txtCodeSwift.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCodeSwift.MaxLength = 50;
            this.txtCodeSwift.Name = "txtCodeSwift";
            this.txtCodeSwift.Size = new System.Drawing.Size(394, 28);
            this.txtCodeSwift.TabIndex = 9;
            this.txtCodeSwift.Text = "RAS";
            // 
            // txtNumCompte
            // 
            this.txtNumCompte.Location = new System.Drawing.Point(119, 199);
            this.txtNumCompte.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNumCompte.MaxLength = 50;
            this.txtNumCompte.Name = "txtNumCompte";
            this.txtNumCompte.Size = new System.Drawing.Size(394, 28);
            this.txtNumCompte.TabIndex = 7;
            this.txtNumCompte.Text = "RAS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(8, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 22);
            this.label6.TabIndex = 864;
            this.label6.Text = "N° compte :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(8, 287);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 22);
            this.label8.TabIndex = 865;
            this.label8.Text = "Code swift :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(8, 231);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 22);
            this.label7.TabIndex = 866;
            this.label7.Text = "Intitulé :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(8, 316);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 22);
            this.label9.TabIndex = 867;
            this.label9.Text = "Banque :";
            // 
            // txtIntitule
            // 
            this.txtIntitule.Location = new System.Drawing.Point(119, 228);
            this.txtIntitule.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtIntitule.MaxLength = 100;
            this.txtIntitule.Multiline = true;
            this.txtIntitule.Name = "txtIntitule";
            this.txtIntitule.Size = new System.Drawing.Size(394, 51);
            this.txtIntitule.TabIndex = 8;
            this.txtIntitule.Text = "RAS";
            // 
            // txtBanque
            // 
            this.txtBanque.Location = new System.Drawing.Point(119, 313);
            this.txtBanque.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtBanque.MaxLength = 100;
            this.txtBanque.Multiline = true;
            this.txtBanque.Name = "txtBanque";
            this.txtBanque.Size = new System.Drawing.Size(394, 60);
            this.txtBanque.TabIndex = 10;
            this.txtBanque.Text = "RAS";
            // 
            // FormFournisseurNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(528, 424);
            this.Controls.Add(this.txtCodeSwift);
            this.Controls.Add(this.txtNumCompte);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIntitule);
            this.Controls.Add(this.txtBanque);
            this.Controls.Add(this.btnPays);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPersContact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPays);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomFour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvPays);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 480);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 480);
            this.Name = "FormFournisseurNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fournisseur - LogiS";
            this.Load += new System.EventHandler(this.FormFournisseurNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnModifier;
        public System.Windows.Forms.Button btnAjouter;
        public System.Windows.Forms.Button btnAnnuler;
        public System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtPersContact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNomFour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.DataGridView dgvPays;
        public System.Windows.Forms.TextBox txtPays;
        private System.Windows.Forms.TextBox textBox1;
        private DataSetPays dataSetPays;
        private System.Windows.Forms.BindingSource paysBindingSource;
        private DataSetPaysTableAdapters.PaysTableAdapter paysTableAdapter;
        public System.Windows.Forms.Button btnPays;
        public System.Windows.Forms.TextBox txtCodeSwift;
        public System.Windows.Forms.TextBox txtNumCompte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtIntitule;
        public System.Windows.Forms.TextBox txtBanque;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nompaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monnaieDataGridViewTextBoxColumn;
    }
}