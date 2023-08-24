namespace LogiS
{
    partial class FormVirementFond
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVirementFond));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.cboDe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboA = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.txtSolde1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSolde2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnFichier = new System.Windows.Forms.Button();
            this.txtFichier = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 27);
            this.panel1.TabIndex = 852;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 906;
            this.label2.Text = "Type :";
            // 
            // cboType
            // 
            this.cboType.DropDownHeight = 200;
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboType.FormattingEnabled = true;
            this.cboType.IntegralHeight = false;
            this.cboType.Items.AddRange(new object[] {
            "banque-banque",
            "banque-caisse",
            "caisse-banque",
            "caisse-caisse"});
            this.cboType.Location = new System.Drawing.Point(74, 39);
            this.cboType.MaxDropDownItems = 10;
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(293, 30);
            this.cboType.Sorted = true;
            this.cboType.TabIndex = 905;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // cboDe
            // 
            this.cboDe.DropDownHeight = 200;
            this.cboDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDe.FormattingEnabled = true;
            this.cboDe.IntegralHeight = false;
            this.cboDe.Items.AddRange(new object[] {
            "banque-banque",
            "banque-caisse",
            "caisse-banque",
            "caisse-caisse"});
            this.cboDe.Location = new System.Drawing.Point(74, 73);
            this.cboDe.MaxDropDownItems = 10;
            this.cboDe.Name = "cboDe";
            this.cboDe.Size = new System.Drawing.Size(293, 30);
            this.cboDe.Sorted = true;
            this.cboDe.TabIndex = 905;
            this.cboDe.DropDown += new System.EventHandler(this.cboDe_DropDown);
            this.cboDe.SelectedIndexChanged += new System.EventHandler(this.cboDe_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(15, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 906;
            this.label1.Text = "De :";
            // 
            // cboA
            // 
            this.cboA.DropDownHeight = 200;
            this.cboA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboA.FormattingEnabled = true;
            this.cboA.IntegralHeight = false;
            this.cboA.Items.AddRange(new object[] {
            "banque-banque",
            "banque-caisse",
            "caisse-banque",
            "caisse-caisse"});
            this.cboA.Location = new System.Drawing.Point(74, 106);
            this.cboA.MaxDropDownItems = 10;
            this.cboA.Name = "cboA";
            this.cboA.Size = new System.Drawing.Size(293, 30);
            this.cboA.Sorted = true;
            this.cboA.TabIndex = 905;
            this.cboA.SelectedIndexChanged += new System.EventHandler(this.cboA_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(15, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 22);
            this.label3.TabIndex = 906;
            this.label3.Text = "A :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(15, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 907;
            this.label4.Text = "Montant :";
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(74, 144);
            this.txtMontant.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtMontant.MaxLength = 13;
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(159, 28);
            this.txtMontant.TabIndex = 908;
            this.txtMontant.TextChanged += new System.EventHandler(this.txtMontant_TextChanged);
            this.txtMontant.Leave += new System.EventHandler(this.txtMontant_Leave);
            // 
            // txtSolde1
            // 
            this.txtSolde1.Enabled = false;
            this.txtSolde1.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtSolde1.Location = new System.Drawing.Point(411, 73);
            this.txtSolde1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtSolde1.MaxLength = 100;
            this.txtSolde1.Name = "txtSolde1";
            this.txtSolde1.Size = new System.Drawing.Size(154, 28);
            this.txtSolde1.TabIndex = 916;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(374, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 22);
            this.label7.TabIndex = 917;
            this.label7.Text = "Solde :";
            // 
            // txtSolde2
            // 
            this.txtSolde2.Enabled = false;
            this.txtSolde2.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtSolde2.Location = new System.Drawing.Point(411, 106);
            this.txtSolde2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtSolde2.MaxLength = 100;
            this.txtSolde2.Name = "txtSolde2";
            this.txtSolde2.Size = new System.Drawing.Size(154, 28);
            this.txtSolde2.TabIndex = 916;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(374, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 22);
            this.label5.TabIndex = 918;
            this.label5.Text = "Solde :";
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(74, 173);
            this.txtLibelle.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtLibelle.MaxLength = 100;
            this.txtLibelle.Multiline = true;
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(491, 59);
            this.txtLibelle.TabIndex = 919;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(15, 176);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 22);
            this.label6.TabIndex = 920;
            this.label6.Text = "Libellé :";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Transparent;
            this.btnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAjouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAjouter.Location = new System.Drawing.Point(485, 281);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(80, 27);
            this.btnAjouter.TabIndex = 921;
            this.btnAjouter.Text = "Valider";
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
            this.btnAnnuler.Location = new System.Drawing.Point(393, 281);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(80, 27);
            this.btnAnnuler.TabIndex = 922;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnFichier
            // 
            this.btnFichier.BackColor = System.Drawing.Color.Transparent;
            this.btnFichier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFichier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFichier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFichier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFichier.Image = ((System.Drawing.Image)(resources.GetObject("btnFichier.Image")));
            this.btnFichier.Location = new System.Drawing.Point(535, 238);
            this.btnFichier.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnFichier.Name = "btnFichier";
            this.btnFichier.Size = new System.Drawing.Size(30, 21);
            this.btnFichier.TabIndex = 925;
            this.btnFichier.UseVisualStyleBackColor = false;
            this.btnFichier.Click += new System.EventHandler(this.btnFichier_Click);
            // 
            // txtFichier
            // 
            this.txtFichier.Enabled = false;
            this.txtFichier.Location = new System.Drawing.Point(74, 238);
            this.txtFichier.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtFichier.MaxLength = 32700;
            this.txtFichier.Name = "txtFichier";
            this.txtFichier.Size = new System.Drawing.Size(461, 28);
            this.txtFichier.TabIndex = 923;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(15, 241);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 22);
            this.label8.TabIndex = 924;
            this.label8.Text = "Preuve :";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(411, 39);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(154, 28);
            this.dtpDate.TabIndex = 927;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(374, 42);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 22);
            this.label9.TabIndex = 926;
            this.label9.Text = "Date :";
            // 
            // FormVirementFond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(578, 322);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnFichier);
            this.Controls.Add(this.txtFichier);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSolde2);
            this.Controls.Add(this.txtSolde1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboA);
            this.Controls.Add(this.cboDe);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVirementFond";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Virement fond - LogiS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cboType;
        public System.Windows.Forms.ComboBox cboDe;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cboA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtMontant;
        public System.Windows.Forms.TextBox txtSolde1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtSolde2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnAjouter;
        public System.Windows.Forms.Button btnAnnuler;
        public System.Windows.Forms.Button btnFichier;
        public System.Windows.Forms.TextBox txtFichier;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label9;
    }
}