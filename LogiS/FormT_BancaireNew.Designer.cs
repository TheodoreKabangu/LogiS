namespace LogiS
{
    partial class FormT_BancaireNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormT_BancaireNew));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboCompte = new System.Windows.Forms.ComboBox();
            this.txtOperation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.btnFichier = new System.Windows.Forms.Button();
            this.txtFichier = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCompte = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSolde = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 27);
            this.panel1.TabIndex = 851;
            // 
            // cboCompte
            // 
            this.cboCompte.DropDownHeight = 200;
            this.cboCompte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCompte.FormattingEnabled = true;
            this.cboCompte.IntegralHeight = false;
            this.cboCompte.Location = new System.Drawing.Point(93, 100);
            this.cboCompte.MaxDropDownItems = 10;
            this.cboCompte.Name = "cboCompte";
            this.cboCompte.Size = new System.Drawing.Size(389, 30);
            this.cboCompte.Sorted = true;
            this.cboCompte.TabIndex = 902;
            this.cboCompte.DropDown += new System.EventHandler(this.cboCompte_DropDown);
            this.cboCompte.SelectedIndexChanged += new System.EventHandler(this.cboCompte_SelectedIndexChanged);
            // 
            // txtOperation
            // 
            this.txtOperation.Enabled = false;
            this.txtOperation.Location = new System.Drawing.Point(93, 40);
            this.txtOperation.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtOperation.MaxLength = 100;
            this.txtOperation.Name = "txtOperation";
            this.txtOperation.Size = new System.Drawing.Size(159, 28);
            this.txtOperation.TabIndex = 903;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 904;
            this.label1.Text = "Opération :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(15, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 904;
            this.label2.Text = "Compte :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(15, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 904;
            this.label3.Text = "Libellé :";
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(93, 133);
            this.txtLibelle.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtLibelle.MaxLength = 100;
            this.txtLibelle.Multiline = true;
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(420, 59);
            this.txtLibelle.TabIndex = 903;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(15, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 904;
            this.label4.Text = "Montant :";
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(93, 198);
            this.txtMontant.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtMontant.MaxLength = 13;
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(159, 28);
            this.txtMontant.TabIndex = 903;
            this.txtMontant.TextChanged += new System.EventHandler(this.txtMontant_TextChanged);
            // 
            // btnFichier
            // 
            this.btnFichier.BackColor = System.Drawing.Color.Transparent;
            this.btnFichier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFichier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFichier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFichier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFichier.Image = ((System.Drawing.Image)(resources.GetObject("btnFichier.Image")));
            this.btnFichier.Location = new System.Drawing.Point(483, 227);
            this.btnFichier.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnFichier.Name = "btnFichier";
            this.btnFichier.Size = new System.Drawing.Size(30, 21);
            this.btnFichier.TabIndex = 907;
            this.toolTip1.SetToolTip(this.btnFichier, "Joindre une preuve");
            this.btnFichier.UseVisualStyleBackColor = false;
            this.btnFichier.Click += new System.EventHandler(this.btnFichier_Click);
            // 
            // txtFichier
            // 
            this.txtFichier.Enabled = false;
            this.txtFichier.Location = new System.Drawing.Point(93, 227);
            this.txtFichier.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtFichier.MaxLength = 32700;
            this.txtFichier.Name = "txtFichier";
            this.txtFichier.Size = new System.Drawing.Size(390, 28);
            this.txtFichier.TabIndex = 905;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(15, 227);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 22);
            this.label5.TabIndex = 906;
            this.label5.Text = "Preuve :";
            // 
            // btnCompte
            // 
            this.btnCompte.BackColor = System.Drawing.Color.Transparent;
            this.btnCompte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCompte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCompte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCompte.Image = ((System.Drawing.Image)(resources.GetObject("btnCompte.Image")));
            this.btnCompte.Location = new System.Drawing.Point(483, 100);
            this.btnCompte.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCompte.Name = "btnCompte";
            this.btnCompte.Size = new System.Drawing.Size(30, 23);
            this.btnCompte.TabIndex = 913;
            this.toolTip1.SetToolTip(this.btnCompte, "Joindre une preuve");
            this.btnCompte.UseVisualStyleBackColor = false;
            this.btnCompte.Click += new System.EventHandler(this.btnCompte_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Transparent;
            this.btnModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModifier.Enabled = false;
            this.btnModifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnModifier.Location = new System.Drawing.Point(433, 265);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(80, 27);
            this.btnModifier.TabIndex = 912;
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
            this.btnAjouter.Location = new System.Drawing.Point(341, 265);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(80, 27);
            this.btnAjouter.TabIndex = 911;
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
            this.btnAnnuler.Location = new System.Drawing.Point(249, 265);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(80, 27);
            this.btnAnnuler.TabIndex = 910;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(93, 69);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(159, 28);
            this.dtpDate.TabIndex = 909;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(15, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 22);
            this.label6.TabIndex = 908;
            this.label6.Text = "Date :";
            // 
            // txtSolde
            // 
            this.txtSolde.Enabled = false;
            this.txtSolde.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtSolde.Location = new System.Drawing.Point(312, 71);
            this.txtSolde.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtSolde.MaxLength = 100;
            this.txtSolde.Name = "txtSolde";
            this.txtSolde.Size = new System.Drawing.Size(201, 28);
            this.txtSolde.TabIndex = 914;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(256, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 22);
            this.label7.TabIndex = 915;
            this.label7.Text = "Solde :";
            // 
            // FormT_BancaireNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(528, 309);
            this.Controls.Add(this.txtSolde);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCompte);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnFichier);
            this.Controls.Add(this.txtFichier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.txtOperation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCompte);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 365);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 365);
            this.Name = "FormT_BancaireNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transaction bancaire - LogiS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox cboCompte;
        public System.Windows.Forms.TextBox txtOperation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtMontant;
        public System.Windows.Forms.Button btnFichier;
        public System.Windows.Forms.TextBox txtFichier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnModifier;
        public System.Windows.Forms.Button btnAjouter;
        public System.Windows.Forms.Button btnAnnuler;
        public System.Windows.Forms.Button btnCompte;
        public System.Windows.Forms.TextBox txtSolde;
        private System.Windows.Forms.Label label7;
    }
}