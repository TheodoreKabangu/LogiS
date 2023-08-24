namespace LogiS
{
    partial class FormMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMessage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMessage = new System.Windows.Forms.DataGridView();
            this.txtExpediteur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.dtpDateA = new System.Windows.Forms.DateTimePicker();
            this.dtpDateDe = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOuvrir = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.messageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMessage = new LogiS.DataSetMessage();
            this.messageTableAdapter = new LogiS.DataSetMessageTableAdapters.MessageTableAdapter();
            this.idmessageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expediteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datejourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomfichierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statutmsg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 27);
            this.panel1.TabIndex = 849;
            // 
            // dgvMessage
            // 
            this.dgvMessage.AllowUserToAddRows = false;
            this.dgvMessage.AllowUserToDeleteRows = false;
            this.dgvMessage.AllowUserToResizeColumns = false;
            this.dgvMessage.AllowUserToResizeRows = false;
            this.dgvMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMessage.AutoGenerateColumns = false;
            this.dgvMessage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMessage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMessage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmessageDataGridViewTextBoxColumn,
            this.expediteurDataGridViewTextBoxColumn,
            this.objetDataGridViewTextBoxColumn,
            this.msgDataGridViewTextBoxColumn,
            this.datejourDataGridViewTextBoxColumn,
            this.heureDataGridViewTextBoxColumn,
            this.nomfichierDataGridViewTextBoxColumn,
            this.statutmsg});
            this.dgvMessage.DataSource = this.messageBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMessage.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMessage.EnableHeadersVisualStyles = false;
            this.dgvMessage.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.dgvMessage.Location = new System.Drawing.Point(12, 77);
            this.dgvMessage.MultiSelect = false;
            this.dgvMessage.Name = "dgvMessage";
            this.dgvMessage.ReadOnly = true;
            this.dgvMessage.RowHeadersVisible = false;
            this.dgvMessage.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMessage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMessage.Size = new System.Drawing.Size(679, 362);
            this.dgvMessage.TabIndex = 850;
            this.dgvMessage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMessage_CellClick);
            // 
            // txtExpediteur
            // 
            this.txtExpediteur.Location = new System.Drawing.Point(398, 41);
            this.txtExpediteur.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtExpediteur.MaxLength = 75;
            this.txtExpediteur.Name = "txtExpediteur";
            this.txtExpediteur.Size = new System.Drawing.Size(217, 28);
            this.txtExpediteur.TabIndex = 865;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(318, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 864;
            this.label1.Text = "Expéditeur :";
            // 
            // btnAfficher
            // 
            this.btnAfficher.BackColor = System.Drawing.Color.Transparent;
            this.btnAfficher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAfficher.FlatAppearance.BorderSize = 0;
            this.btnAfficher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAfficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAfficher.Image = ((System.Drawing.Image)(resources.GetObject("btnAfficher.Image")));
            this.btnAfficher.Location = new System.Drawing.Point(618, 41);
            this.btnAfficher.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(30, 21);
            this.btnAfficher.TabIndex = 863;
            this.toolTip1.SetToolTip(this.btnAfficher, "Rechercher");
            this.btnAfficher.UseVisualStyleBackColor = false;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // dtpDateA
            // 
            this.dtpDateA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateA.Location = new System.Drawing.Point(193, 41);
            this.dtpDateA.Name = "dtpDateA";
            this.dtpDateA.Size = new System.Drawing.Size(120, 28);
            this.dtpDateA.TabIndex = 861;
            // 
            // dtpDateDe
            // 
            this.dtpDateDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDe.Location = new System.Drawing.Point(40, 41);
            this.dtpDateDe.Name = "dtpDateDe";
            this.dtpDateDe.Size = new System.Drawing.Size(120, 28);
            this.dtpDateDe.TabIndex = 862;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(162, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 22);
            this.label6.TabIndex = 859;
            this.label6.Text = "à :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(8, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 22);
            this.label3.TabIndex = 860;
            this.label3.Text = "De :";
            // 
            // btnOuvrir
            // 
            this.btnOuvrir.BackColor = System.Drawing.Color.Transparent;
            this.btnOuvrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOuvrir.Enabled = false;
            this.btnOuvrir.FlatAppearance.BorderSize = 0;
            this.btnOuvrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOuvrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOuvrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnOuvrir.Image = ((System.Drawing.Image)(resources.GetObject("btnOuvrir.Image")));
            this.btnOuvrir.Location = new System.Drawing.Point(661, 41);
            this.btnOuvrir.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(30, 21);
            this.btnOuvrir.TabIndex = 863;
            this.toolTip1.SetToolTip(this.btnOuvrir, "Ouvrir");
            this.btnOuvrir.UseVisualStyleBackColor = false;
            this.btnOuvrir.Click += new System.EventHandler(this.btnOuvrir_Click);
            // 
            // messageBindingSource
            // 
            this.messageBindingSource.DataMember = "Message";
            this.messageBindingSource.DataSource = this.dataSetMessage;
            // 
            // dataSetMessage
            // 
            this.dataSetMessage.DataSetName = "DataSetMessage";
            this.dataSetMessage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // messageTableAdapter
            // 
            this.messageTableAdapter.ClearBeforeFill = true;
            // 
            // idmessageDataGridViewTextBoxColumn
            // 
            this.idmessageDataGridViewTextBoxColumn.DataPropertyName = "idmessage";
            this.idmessageDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idmessageDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.idmessageDataGridViewTextBoxColumn.Name = "idmessageDataGridViewTextBoxColumn";
            this.idmessageDataGridViewTextBoxColumn.ReadOnly = true;
            this.idmessageDataGridViewTextBoxColumn.Width = 40;
            // 
            // expediteurDataGridViewTextBoxColumn
            // 
            this.expediteurDataGridViewTextBoxColumn.DataPropertyName = "expediteur";
            this.expediteurDataGridViewTextBoxColumn.HeaderText = "Expéditeur";
            this.expediteurDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.expediteurDataGridViewTextBoxColumn.Name = "expediteurDataGridViewTextBoxColumn";
            this.expediteurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // objetDataGridViewTextBoxColumn
            // 
            this.objetDataGridViewTextBoxColumn.DataPropertyName = "objet";
            this.objetDataGridViewTextBoxColumn.HeaderText = "Objet";
            this.objetDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.objetDataGridViewTextBoxColumn.Name = "objetDataGridViewTextBoxColumn";
            this.objetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // msgDataGridViewTextBoxColumn
            // 
            this.msgDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.msgDataGridViewTextBoxColumn.DataPropertyName = "msg";
            this.msgDataGridViewTextBoxColumn.HeaderText = "Message";
            this.msgDataGridViewTextBoxColumn.MinimumWidth = 250;
            this.msgDataGridViewTextBoxColumn.Name = "msgDataGridViewTextBoxColumn";
            this.msgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datejourDataGridViewTextBoxColumn
            // 
            this.datejourDataGridViewTextBoxColumn.DataPropertyName = "date_jour";
            this.datejourDataGridViewTextBoxColumn.HeaderText = "Date";
            this.datejourDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.datejourDataGridViewTextBoxColumn.Name = "datejourDataGridViewTextBoxColumn";
            this.datejourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // heureDataGridViewTextBoxColumn
            // 
            this.heureDataGridViewTextBoxColumn.DataPropertyName = "heure";
            this.heureDataGridViewTextBoxColumn.HeaderText = "Heure";
            this.heureDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.heureDataGridViewTextBoxColumn.Name = "heureDataGridViewTextBoxColumn";
            this.heureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomfichierDataGridViewTextBoxColumn
            // 
            this.nomfichierDataGridViewTextBoxColumn.DataPropertyName = "nomfichier";
            this.nomfichierDataGridViewTextBoxColumn.HeaderText = "Fichier";
            this.nomfichierDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.nomfichierDataGridViewTextBoxColumn.Name = "nomfichierDataGridViewTextBoxColumn";
            this.nomfichierDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomfichierDataGridViewTextBoxColumn.Width = 150;
            // 
            // statutmsg
            // 
            this.statutmsg.DataPropertyName = "statutmsg";
            this.statutmsg.HeaderText = "statutmsg";
            this.statutmsg.Name = "statutmsg";
            this.statutmsg.ReadOnly = true;
            this.statutmsg.Visible = false;
            // 
            // FormMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(703, 451);
            this.Controls.Add(this.txtExpediteur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOuvrir);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.dtpDateA);
            this.Controls.Add(this.dtpDateDe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMessage);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMessage";
            this.Load += new System.EventHandler(this.FormMessage_Load);
            this.Shown += new System.EventHandler(this.FormMessage_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dgvMessage;
        public System.Windows.Forms.TextBox txtExpediteur;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnAfficher;
        public System.Windows.Forms.DateTimePicker dtpDateA;
        public System.Windows.Forms.DateTimePicker dtpDateDe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnOuvrir;
        private System.Windows.Forms.ToolTip toolTip1;
        private DataSetMessage dataSetMessage;
        private System.Windows.Forms.BindingSource messageBindingSource;
        private DataSetMessageTableAdapters.MessageTableAdapter messageTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmessageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expediteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn msgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datejourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomfichierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statutmsg;
    }
}