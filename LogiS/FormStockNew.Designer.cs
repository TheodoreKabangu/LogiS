namespace LogiS
{
    partial class FormStockNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStockNew));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtQteStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumLot = new System.Windows.Forms.TextBox();
            this.txtAnnee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMois = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCoutAchat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrixVente = new System.Windows.Forms.TextBox();
            this.txtBenefice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.cboDepot = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValMin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 27);
            this.panel2.TabIndex = 851;
            // 
            // txtQteStock
            // 
            this.txtQteStock.Location = new System.Drawing.Point(125, 43);
            this.txtQteStock.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtQteStock.MaxLength = 9;
            this.txtQteStock.Name = "txtQteStock";
            this.txtQteStock.Size = new System.Drawing.Size(186, 28);
            this.txtQteStock.TabIndex = 1;
            this.txtQteStock.TextChanged += new System.EventHandler(this.txtQteStock_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 880;
            this.label2.Text = "Qté initiale :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(14, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 880;
            this.label1.Text = "N° lot :";
            // 
            // txtNumLot
            // 
            this.txtNumLot.Location = new System.Drawing.Point(125, 72);
            this.txtNumLot.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNumLot.MaxLength = 20;
            this.txtNumLot.Name = "txtNumLot";
            this.txtNumLot.Size = new System.Drawing.Size(349, 28);
            this.txtNumLot.TabIndex = 2;
            this.txtNumLot.Text = "RAS";
            // 
            // txtAnnee
            // 
            this.txtAnnee.Location = new System.Drawing.Point(249, 101);
            this.txtAnnee.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtAnnee.MaxLength = 4;
            this.txtAnnee.Name = "txtAnnee";
            this.txtAnnee.Size = new System.Drawing.Size(62, 28);
            this.txtAnnee.TabIndex = 4;
            this.txtAnnee.TextChanged += new System.EventHandler(this.txtAnnee_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(190, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 882;
            this.label3.Text = "Année :";
            // 
            // cboMois
            // 
            this.cboMois.DropDownHeight = 200;
            this.cboMois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMois.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMois.FormattingEnabled = true;
            this.cboMois.IntegralHeight = false;
            this.cboMois.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cboMois.Location = new System.Drawing.Point(125, 101);
            this.cboMois.MaxDropDownItems = 10;
            this.cboMois.Name = "cboMois";
            this.cboMois.Size = new System.Drawing.Size(65, 30);
            this.cboMois.Sorted = true;
            this.cboMois.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(14, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 22);
            this.label5.TabIndex = 883;
            this.label5.Text = "Mois :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(14, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 22);
            this.label4.TabIndex = 880;
            this.label4.Text = "Coût d\'achat :";
            // 
            // txtCoutAchat
            // 
            this.txtCoutAchat.Location = new System.Drawing.Point(125, 135);
            this.txtCoutAchat.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCoutAchat.MaxLength = 9;
            this.txtCoutAchat.Name = "txtCoutAchat";
            this.txtCoutAchat.Size = new System.Drawing.Size(186, 28);
            this.txtCoutAchat.TabIndex = 5;
            this.txtCoutAchat.TextChanged += new System.EventHandler(this.txtCoutAchat_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(14, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 22);
            this.label6.TabIndex = 880;
            this.label6.Text = "Prix de vente :";
            // 
            // txtPrixVente
            // 
            this.txtPrixVente.Enabled = false;
            this.txtPrixVente.Location = new System.Drawing.Point(125, 164);
            this.txtPrixVente.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPrixVente.MaxLength = 9;
            this.txtPrixVente.Name = "txtPrixVente";
            this.txtPrixVente.Size = new System.Drawing.Size(186, 28);
            this.txtPrixVente.TabIndex = 7;
            // 
            // txtBenefice
            // 
            this.txtBenefice.Location = new System.Drawing.Point(412, 135);
            this.txtBenefice.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtBenefice.MaxLength = 5;
            this.txtBenefice.Name = "txtBenefice";
            this.txtBenefice.Size = new System.Drawing.Size(62, 28);
            this.txtBenefice.TabIndex = 6;
            this.txtBenefice.TextChanged += new System.EventHandler(this.txtBenefice_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(315, 138);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 22);
            this.label7.TabIndex = 886;
            this.label7.Text = "% bénéfice :";
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
            this.btnModifier.Location = new System.Drawing.Point(209, 230);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(30, 30);
            this.btnModifier.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnModifier, "Modifier");
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
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
            this.btnAjouter.Location = new System.Drawing.Point(167, 230);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(30, 30);
            this.btnAjouter.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnAjouter, "Enregistrer");
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
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
            this.btnAnnuler.Location = new System.Drawing.Point(125, 230);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(30, 30);
            this.btnAnnuler.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnAnnuler, "Annuler");
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // cboDepot
            // 
            this.cboDepot.DropDownHeight = 200;
            this.cboDepot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDepot.FormattingEnabled = true;
            this.cboDepot.IntegralHeight = false;
            this.cboDepot.Location = new System.Drawing.Point(125, 194);
            this.cboDepot.MaxDropDownItems = 10;
            this.cboDepot.Name = "cboDepot";
            this.cboDepot.Size = new System.Drawing.Size(349, 30);
            this.cboDepot.Sorted = true;
            this.cboDepot.TabIndex = 8;
            this.cboDepot.DropDown += new System.EventHandler(this.cboDepot_DropDown);
            this.cboDepot.SelectedIndexChanged += new System.EventHandler(this.cboDepot_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(14, 197);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 22);
            this.label8.TabIndex = 890;
            this.label8.Text = "Dépôt :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(315, 167);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 22);
            this.label9.TabIndex = 886;
            this.label9.Text = "Val. min :";
            // 
            // txtValMin
            // 
            this.txtValMin.Location = new System.Drawing.Point(412, 164);
            this.txtValMin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtValMin.MaxLength = 5;
            this.txtValMin.Name = "txtValMin";
            this.txtValMin.Size = new System.Drawing.Size(62, 28);
            this.txtValMin.TabIndex = 6;
            this.txtValMin.Text = "1";
            this.txtValMin.TextChanged += new System.EventHandler(this.txtValMin_TextChanged);
            // 
            // FormStockNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(493, 274);
            this.Controls.Add(this.cboDepot);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.txtValMin);
            this.Controls.Add(this.txtBenefice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboMois);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAnnee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumLot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrixVente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCoutAchat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQteStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(515, 330);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(515, 330);
            this.Name = "FormStockNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock - LogiS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtQteStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNumLot;
        public System.Windows.Forms.TextBox txtAnnee;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cboMois;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtCoutAchat;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtPrixVente;
        public System.Windows.Forms.TextBox txtBenefice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Button btnModifier;
        public System.Windows.Forms.Button btnAjouter;
        public System.Windows.Forms.Button btnAnnuler;
        public System.Windows.Forms.ComboBox cboDepot;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtValMin;
    }
}