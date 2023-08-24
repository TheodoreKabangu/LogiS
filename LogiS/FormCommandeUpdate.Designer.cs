namespace LogiS
{
    partial class FormCommandeUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCommandeUpdate));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.cboCTNR = new System.Windows.Forms.ComboBox();
            this.btnFichier = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtFour = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFichier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumCTNR = new System.Windows.Forms.TextBox();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Transparent;
            this.btnModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModifier.Enabled = false;
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnModifier.Image = ((System.Drawing.Image)(resources.GetObject("btnModifier.Image")));
            this.btnModifier.Location = new System.Drawing.Point(212, 392);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(30, 30);
            this.btnModifier.TabIndex = 920;
            this.toolTip1.SetToolTip(this.btnModifier, "Modifier");
            this.btnModifier.UseVisualStyleBackColor = false;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Transparent;
            this.btnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAjouter.Image = ((System.Drawing.Image)(resources.GetObject("btnAjouter.Image")));
            this.btnAjouter.Location = new System.Drawing.Point(170, 392);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(30, 30);
            this.btnAjouter.TabIndex = 919;
            this.toolTip1.SetToolTip(this.btnAjouter, "Enregistrer");
            this.btnAjouter.UseVisualStyleBackColor = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Transparent;
            this.btnAnnuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAnnuler.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnuler.Image")));
            this.btnAnnuler.Location = new System.Drawing.Point(128, 392);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(30, 30);
            this.btnAnnuler.TabIndex = 918;
            this.toolTip1.SetToolTip(this.btnAnnuler, "Annuler");
            this.btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // cboCTNR
            // 
            this.cboCTNR.DropDownHeight = 200;
            this.cboCTNR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCTNR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCTNR.FormattingEnabled = true;
            this.cboCTNR.IntegralHeight = false;
            this.cboCTNR.Items.AddRange(new object[] {
            "arrivé",
            "brouillon",
            "envoyé",
            "reçu"});
            this.cboCTNR.Location = new System.Drawing.Point(128, 126);
            this.cboCTNR.MaxDropDownItems = 10;
            this.cboCTNR.Name = "cboCTNR";
            this.cboCTNR.Size = new System.Drawing.Size(159, 30);
            this.cboCTNR.Sorted = true;
            this.cboCTNR.TabIndex = 923;
            // 
            // btnFichier
            // 
            this.btnFichier.BackColor = System.Drawing.Color.Transparent;
            this.btnFichier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFichier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFichier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFichier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFichier.Image = ((System.Drawing.Image)(resources.GetObject("btnFichier.Image")));
            this.btnFichier.Location = new System.Drawing.Point(483, 300);
            this.btnFichier.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnFichier.Name = "btnFichier";
            this.btnFichier.Size = new System.Drawing.Size(30, 21);
            this.btnFichier.TabIndex = 922;
            this.btnFichier.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 300);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(355, 28);
            this.textBox1.TabIndex = 921;
            // 
            // txtFour
            // 
            this.txtFour.Enabled = false;
            this.txtFour.Location = new System.Drawing.Point(128, 354);
            this.txtFour.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtFour.MaxLength = 50;
            this.txtFour.Name = "txtFour";
            this.txtFour.Size = new System.Drawing.Size(385, 28);
            this.txtFour.TabIndex = 908;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(15, 357);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 22);
            this.label5.TabIndex = 916;
            this.label5.Text = "Fournisseur :";
            // 
            // txtFichier
            // 
            this.txtFichier.Location = new System.Drawing.Point(128, 324);
            this.txtFichier.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtFichier.MaxLength = 50;
            this.txtFichier.Name = "txtFichier";
            this.txtFichier.Size = new System.Drawing.Size(385, 28);
            this.txtFichier.TabIndex = 907;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(15, 327);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 22);
            this.label4.TabIndex = 917;
            this.label4.Text = "Preuve :";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(128, 42);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(159, 28);
            this.dtpDate.TabIndex = 915;
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(128, 72);
            this.txtLibelle.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtLibelle.MaxLength = 250;
            this.txtLibelle.Multiline = true;
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(560, 52);
            this.txtLibelle.TabIndex = 905;
            // 
            // txtCharge
            // 
            this.txtCharge.Location = new System.Drawing.Point(128, 243);
            this.txtCharge.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCharge.MaxLength = 250;
            this.txtCharge.Multiline = true;
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new System.Drawing.Size(560, 52);
            this.txtCharge.TabIndex = 906;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(15, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 22);
            this.label6.TabIndex = 910;
            this.label6.Text = "Libellé :";
            // 
            // txtNumCTNR
            // 
            this.txtNumCTNR.Location = new System.Drawing.Point(128, 185);
            this.txtNumCTNR.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNumCTNR.MaxLength = 25;
            this.txtNumCTNR.Name = "txtNumCTNR";
            this.txtNumCTNR.Size = new System.Drawing.Size(367, 28);
            this.txtNumCTNR.TabIndex = 904;
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(128, 214);
            this.txtMontant.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtMontant.MaxLength = 13;
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(159, 28);
            this.txtMontant.TabIndex = 903;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(15, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 909;
            this.label3.Text = "Libellé :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(15, 188);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 22);
            this.label8.TabIndex = 913;
            this.label8.Text = "Container :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(17, 129);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 22);
            this.label7.TabIndex = 912;
            this.label7.Text = "Container :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 911;
            this.label1.Text = "Date com. :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(15, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 914;
            this.label2.Text = "Montant :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 27);
            this.panel2.TabIndex = 902;
            // 
            // FormCommandeUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(703, 451);
            this.Controls.Add(this.cboCTNR);
            this.Controls.Add(this.btnFichier);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.txtFour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFichier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.txtCharge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNumCTNR);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCommandeUpdate";
            this.Text = "FormCommandeUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Button btnModifier;
        public System.Windows.Forms.Button btnAjouter;
        public System.Windows.Forms.Button btnAnnuler;
        public System.Windows.Forms.ComboBox cboCTNR;
        public System.Windows.Forms.Button btnFichier;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox txtFour;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtFichier;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dtpDate;
        public System.Windows.Forms.TextBox txtLibelle;
        public System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtNumCTNR;
        public System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;

    }
}