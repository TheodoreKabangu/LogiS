namespace LogiS
{
    partial class FormConnexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConnexion));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUtilisateur = new System.Windows.Forms.TextBox();
            this.txtMotdePass = new System.Windows.Forms.TextBox();
            this.cboUtilisateur = new System.Windows.Forms.ComboBox();
            this.linkModifier = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 50);
            this.panel2.TabIndex = 187;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(0, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(297, 49);
            this.label10.TabIndex = 189;
            this.label10.Text = "Connexion";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 50);
            this.panel1.TabIndex = 188;
            // 
            // btnConnexion
            // 
            this.btnConnexion.BackColor = System.Drawing.Color.Transparent;
            this.btnConnexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConnexion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.btnConnexion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnConnexion.Location = new System.Drawing.Point(57, 263);
            this.btnConnexion.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(100, 31);
            this.btnConnexion.TabIndex = 559;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = false;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.btnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnQuitter.Location = new System.Drawing.Point(167, 263);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(100, 31);
            this.btnQuitter.TabIndex = 559;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.checkBox1.Location = new System.Drawing.Point(57, 193);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(199, 26);
            this.checkBox1.TabIndex = 562;
            this.checkBox1.Text = "Voir le mot de passe";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(15, 150);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.TabIndex = 565;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(15, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.TabIndex = 566;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.panel4.Location = new System.Drawing.Point(57, 142);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 1);
            this.panel4.TabIndex = 563;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.panel3.Location = new System.Drawing.Point(57, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 1);
            this.panel3.TabIndex = 564;
            // 
            // txtUtilisateur
            // 
            this.txtUtilisateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtUtilisateur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilisateur.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUtilisateur.Location = new System.Drawing.Point(57, 120);
            this.txtUtilisateur.MaxLength = 10;
            this.txtUtilisateur.Name = "txtUtilisateur";
            this.txtUtilisateur.Size = new System.Drawing.Size(210, 28);
            this.txtUtilisateur.TabIndex = 560;
            this.txtUtilisateur.Text = "Utilisateur";
            this.txtUtilisateur.Click += new System.EventHandler(this.txtUtilisateur_Click);
            this.txtUtilisateur.TextChanged += new System.EventHandler(this.txtUtilisateur_TextChanged);
            // 
            // txtMotdePass
            // 
            this.txtMotdePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtMotdePass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMotdePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotdePass.ForeColor = System.Drawing.Color.DarkGray;
            this.txtMotdePass.Location = new System.Drawing.Point(57, 159);
            this.txtMotdePass.MaxLength = 10;
            this.txtMotdePass.Name = "txtMotdePass";
            this.txtMotdePass.Size = new System.Drawing.Size(210, 28);
            this.txtMotdePass.TabIndex = 561;
            this.txtMotdePass.Text = "Mot de passe";
            this.txtMotdePass.Enter += new System.EventHandler(this.txtMotdePass_Enter);
            // 
            // cboUtilisateur
            // 
            this.cboUtilisateur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUtilisateur.Enabled = false;
            this.cboUtilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboUtilisateur.FormattingEnabled = true;
            this.cboUtilisateur.Location = new System.Drawing.Point(57, 225);
            this.cboUtilisateur.Name = "cboUtilisateur";
            this.cboUtilisateur.Size = new System.Drawing.Size(210, 30);
            this.cboUtilisateur.TabIndex = 652;
            // 
            // linkModifier
            // 
            this.linkModifier.AutoSize = true;
            this.linkModifier.DisabledLinkColor = System.Drawing.Color.MediumBlue;
            this.linkModifier.LinkColor = System.Drawing.Color.MediumBlue;
            this.linkModifier.Location = new System.Drawing.Point(53, 295);
            this.linkModifier.Name = "linkModifier";
            this.linkModifier.Size = new System.Drawing.Size(204, 22);
            this.linkModifier.TabIndex = 667;
            this.linkModifier.TabStop = true;
            this.linkModifier.Text = "Modifier le mot de passe";
            this.linkModifier.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkModifier_LinkClicked);
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(297, 370);
            this.Controls.Add(this.linkModifier);
            this.Controls.Add(this.cboUtilisateur);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtUtilisateur);
            this.Controls.Add(this.txtMotdePass);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(297, 370);
            this.MinimumSize = new System.Drawing.Size(297, 370);
            this.Name = "FormConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion - LogiS";
            this.Load += new System.EventHandler(this.FormConnexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnConnexion;
        public System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txtUtilisateur;
        public System.Windows.Forms.TextBox txtMotdePass;
        public System.Windows.Forms.ComboBox cboUtilisateur;
        public System.Windows.Forms.LinkLabel linkModifier;
    }
}