namespace LogiS
{
    partial class FormMessageNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMessageNew));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFichier = new System.Windows.Forms.Button();
            this.txtFichier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObjet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCompte = new System.Windows.Forms.TextBox();
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 27);
            this.panel1.TabIndex = 849;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(119, 100);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtMessage.MaxLength = 300;
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(392, 262);
            this.txtMessage.TabIndex = 877;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(15, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 878;
            this.label3.Text = "Message :";
            // 
            // btnFichier
            // 
            this.btnFichier.BackColor = System.Drawing.Color.Transparent;
            this.btnFichier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFichier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFichier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFichier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFichier.Image = ((System.Drawing.Image)(resources.GetObject("btnFichier.Image")));
            this.btnFichier.Location = new System.Drawing.Point(481, 368);
            this.btnFichier.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnFichier.Name = "btnFichier";
            this.btnFichier.Size = new System.Drawing.Size(30, 21);
            this.btnFichier.TabIndex = 889;
            this.toolTip1.SetToolTip(this.btnFichier, "Attacher un fichier");
            this.btnFichier.UseVisualStyleBackColor = false;
            this.btnFichier.Click += new System.EventHandler(this.btnFichier_Click);
            // 
            // txtFichier
            // 
            this.txtFichier.Enabled = false;
            this.txtFichier.Location = new System.Drawing.Point(119, 368);
            this.txtFichier.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtFichier.MaxLength = 50;
            this.txtFichier.Name = "txtFichier";
            this.txtFichier.Size = new System.Drawing.Size(362, 28);
            this.txtFichier.TabIndex = 887;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(15, 371);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 22);
            this.label4.TabIndex = 888;
            this.label4.Text = "Preuve :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(15, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 888;
            this.label1.Text = "Objet :";
            // 
            // txtObjet
            // 
            this.txtObjet.Location = new System.Drawing.Point(119, 71);
            this.txtObjet.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtObjet.MaxLength = 100;
            this.txtObjet.Name = "txtObjet";
            this.txtObjet.Size = new System.Drawing.Size(392, 28);
            this.txtObjet.TabIndex = 887;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 22);
            this.label2.TabIndex = 888;
            this.label2.Text = "A :";
            // 
            // txtCompte
            // 
            this.txtCompte.Location = new System.Drawing.Point(119, 42);
            this.txtCompte.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCompte.MaxLength = 10;
            this.txtCompte.Name = "txtCompte";
            this.txtCompte.Size = new System.Drawing.Size(392, 28);
            this.txtCompte.TabIndex = 887;
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.BackColor = System.Drawing.Color.Transparent;
            this.btnEnvoyer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEnvoyer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEnvoyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnvoyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEnvoyer.Image = ((System.Drawing.Image)(resources.GetObject("btnEnvoyer.Image")));
            this.btnEnvoyer.Location = new System.Drawing.Point(119, 407);
            this.btnEnvoyer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(85, 27);
            this.btnEnvoyer.TabIndex = 890;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnEnvoyer, "Envoyer");
            this.btnEnvoyer.UseVisualStyleBackColor = false;
            this.btnEnvoyer.Click += new System.EventHandler(this.btnEnvoyer_Click);
            // 
            // FormMessageNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(528, 451);
            this.Controls.Add(this.btnEnvoyer);
            this.Controls.Add(this.btnFichier);
            this.Controls.Add(this.txtCompte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtObjet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFichier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(550, 507);
            this.MinimumSize = new System.Drawing.Size(550, 507);
            this.Name = "FormMessageNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Messagerie - LogiS ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnFichier;
        public System.Windows.Forms.TextBox txtFichier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtObjet;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCompte;
        public System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}