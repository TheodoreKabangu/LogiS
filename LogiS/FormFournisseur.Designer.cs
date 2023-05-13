namespace LogiS
{
    partial class FormFournisseur
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFournisseur));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFour = new System.Windows.Forms.DataGridView();
            this.fournisseurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetFour = new LogiS.DataSetFour();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPayer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnTriCroissant = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.fournisseurTableAdapter = new LogiS.DataSetFourTableAdapters.FournisseurTableAdapter();
            this.cboContainer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.idfourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personcontactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numcompteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intituleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeswiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFour)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFour
            // 
            this.dgvFour.AllowUserToAddRows = false;
            this.dgvFour.AllowUserToDeleteRows = false;
            this.dgvFour.AllowUserToResizeColumns = false;
            this.dgvFour.AllowUserToResizeRows = false;
            this.dgvFour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFour.AutoGenerateColumns = false;
            this.dgvFour.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvFour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFour.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFour.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfourDataGridViewTextBoxColumn,
            this.Column0,
            this.Column1,
            this.Column2,
            this.personcontactDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.numcompteDataGridViewTextBoxColumn,
            this.intituleDataGridViewTextBoxColumn,
            this.codeswiftDataGridViewTextBoxColumn,
            this.banqueDataGridViewTextBoxColumn});
            this.dgvFour.DataSource = this.fournisseurBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFour.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFour.EnableHeadersVisualStyles = false;
            this.dgvFour.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.dgvFour.Location = new System.Drawing.Point(12, 107);
            this.dgvFour.MultiSelect = false;
            this.dgvFour.Name = "dgvFour";
            this.dgvFour.ReadOnly = true;
            this.dgvFour.RowHeadersVisible = false;
            this.dgvFour.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFour.Size = new System.Drawing.Size(679, 332);
            this.dgvFour.TabIndex = 842;
            // 
            // fournisseurBindingSource
            // 
            this.fournisseurBindingSource.DataMember = "Fournisseur";
            this.fournisseurBindingSource.DataSource = this.dataSetFour;
            // 
            // dataSetFour
            // 
            this.dataSetFour.DataSetName = "DataSetFour";
            this.dataSetFour.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 27);
            this.panel2.TabIndex = 841;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(673, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 838;
            this.toolTip1.SetToolTip(this.btnExit, "Close");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPayer
            // 
            this.btnPayer.BackColor = System.Drawing.Color.Transparent;
            this.btnPayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPayer.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPayer.FlatAppearance.BorderSize = 0;
            this.btnPayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPayer.Image = ((System.Drawing.Image)(resources.GetObject("btnPayer.Image")));
            this.btnPayer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayer.Location = new System.Drawing.Point(160, 0);
            this.btnPayer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPayer.Name = "btnPayer";
            this.btnPayer.Size = new System.Drawing.Size(80, 30);
            this.btnPayer.TabIndex = 839;
            this.btnPayer.Text = "Pay";
            this.btnPayer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnPayer, "Pay this supplier");
            this.btnPayer.UseVisualStyleBackColor = false;
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Transparent;
            this.btnModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModifier.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnModifier.Image = ((System.Drawing.Image)(resources.GetObject("btnModifier.Image")));
            this.btnModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifier.Location = new System.Drawing.Point(80, 0);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(80, 30);
            this.btnModifier.TabIndex = 839;
            this.btnModifier.Text = "Edit";
            this.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnModifier, "Edit this supplier");
            this.btnModifier.UseVisualStyleBackColor = false;
            // 
            // btnNouveau
            // 
            this.btnNouveau.BackColor = System.Drawing.Color.Transparent;
            this.btnNouveau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNouveau.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNouveau.FlatAppearance.BorderSize = 0;
            this.btnNouveau.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNouveau.Image = ((System.Drawing.Image)(resources.GetObject("btnNouveau.Image")));
            this.btnNouveau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNouveau.Location = new System.Drawing.Point(0, 0);
            this.btnNouveau.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(80, 30);
            this.btnNouveau.TabIndex = 839;
            this.btnNouveau.Text = "New";
            this.btnNouveau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnNouveau, "Add a new supplier");
            this.btnNouveau.UseVisualStyleBackColor = false;
            // 
            // btnTriCroissant
            // 
            this.btnTriCroissant.BackColor = System.Drawing.Color.Transparent;
            this.btnTriCroissant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTriCroissant.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTriCroissant.FlatAppearance.BorderSize = 0;
            this.btnTriCroissant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTriCroissant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTriCroissant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnTriCroissant.Image = ((System.Drawing.Image)(resources.GetObject("btnTriCroissant.Image")));
            this.btnTriCroissant.Location = new System.Drawing.Point(241, 0);
            this.btnTriCroissant.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnTriCroissant.Name = "btnTriCroissant";
            this.btnTriCroissant.Size = new System.Drawing.Size(30, 30);
            this.btnTriCroissant.TabIndex = 848;
            this.toolTip1.SetToolTip(this.btnTriCroissant, "Amount ascending");
            this.btnTriCroissant.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(271, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 849;
            this.toolTip1.SetToolTip(this.button2, "Amount descending");
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnTriCroissant);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnPayer);
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Controls.Add(this.btnNouveau);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 30);
            this.panel1.TabIndex = 843;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(240, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 30);
            this.panel3.TabIndex = 847;
            // 
            // fournisseurTableAdapter
            // 
            this.fournisseurTableAdapter.ClearBeforeFill = true;
            // 
            // cboContainer
            // 
            this.cboContainer.DropDownHeight = 200;
            this.cboContainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboContainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboContainer.FormattingEnabled = true;
            this.cboContainer.IntegralHeight = false;
            this.cboContainer.Items.AddRange(new object[] {
            "20",
            "40",
            "45"});
            this.cboContainer.Location = new System.Drawing.Point(100, 65);
            this.cboContainer.MaxDropDownItems = 10;
            this.cboContainer.Name = "cboContainer";
            this.cboContainer.Size = new System.Drawing.Size(325, 30);
            this.cboContainer.Sorted = true;
            this.cboContainer.TabIndex = 844;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(8, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 845;
            this.label3.Text = "Country :";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 200;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Items.AddRange(new object[] {
            "Max",
            "Min"});
            this.comboBox1.Location = new System.Drawing.Point(602, 65);
            this.comboBox1.MaxDropDownItems = 10;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(89, 30);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 844;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(421, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 845;
            this.label1.Text = "Amount :";
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(482, 65);
            this.txtMontant.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtMontant.MaxLength = 75;
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(117, 28);
            this.txtMontant.TabIndex = 846;
            // 
            // idfourDataGridViewTextBoxColumn
            // 
            this.idfourDataGridViewTextBoxColumn.DataPropertyName = "idfour";
            this.idfourDataGridViewTextBoxColumn.HeaderText = "N°";
            this.idfourDataGridViewTextBoxColumn.Name = "idfourDataGridViewTextBoxColumn";
            this.idfourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column0
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Column0.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column0.HeaderText = "Total";
            this.Column0.MinimumWidth = 100;
            this.Column0.Name = "Column0";
            this.Column0.ReadOnly = true;
            // 
            // Column1
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "Paid";
            this.Column1.MinimumWidth = 100;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.HeaderText = "Rest";
            this.Column2.MinimumWidth = 100;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // personcontactDataGridViewTextBoxColumn
            // 
            this.personcontactDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.personcontactDataGridViewTextBoxColumn.DataPropertyName = "person_contact";
            this.personcontactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.personcontactDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.personcontactDataGridViewTextBoxColumn.Name = "personcontactDataGridViewTextBoxColumn";
            this.personcontactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            this.telephoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numcompteDataGridViewTextBoxColumn
            // 
            this.numcompteDataGridViewTextBoxColumn.DataPropertyName = "numcompte";
            this.numcompteDataGridViewTextBoxColumn.HeaderText = "Account #";
            this.numcompteDataGridViewTextBoxColumn.MinimumWidth = 130;
            this.numcompteDataGridViewTextBoxColumn.Name = "numcompteDataGridViewTextBoxColumn";
            this.numcompteDataGridViewTextBoxColumn.ReadOnly = true;
            this.numcompteDataGridViewTextBoxColumn.Width = 130;
            // 
            // intituleDataGridViewTextBoxColumn
            // 
            this.intituleDataGridViewTextBoxColumn.DataPropertyName = "intitule";
            this.intituleDataGridViewTextBoxColumn.HeaderText = "Account Name";
            this.intituleDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.intituleDataGridViewTextBoxColumn.Name = "intituleDataGridViewTextBoxColumn";
            this.intituleDataGridViewTextBoxColumn.ReadOnly = true;
            this.intituleDataGridViewTextBoxColumn.Width = 200;
            // 
            // codeswiftDataGridViewTextBoxColumn
            // 
            this.codeswiftDataGridViewTextBoxColumn.DataPropertyName = "code_swift";
            this.codeswiftDataGridViewTextBoxColumn.HeaderText = "Swift";
            this.codeswiftDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.codeswiftDataGridViewTextBoxColumn.Name = "codeswiftDataGridViewTextBoxColumn";
            this.codeswiftDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // banqueDataGridViewTextBoxColumn
            // 
            this.banqueDataGridViewTextBoxColumn.DataPropertyName = "banque";
            this.banqueDataGridViewTextBoxColumn.HeaderText = "Bank";
            this.banqueDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.banqueDataGridViewTextBoxColumn.Name = "banqueDataGridViewTextBoxColumn";
            this.banqueDataGridViewTextBoxColumn.ReadOnly = true;
            this.banqueDataGridViewTextBoxColumn.Width = 200;
            // 
            // FormFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(703, 451);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboContainer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvFour);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFournisseur";
            this.Text = "FormFournisseur";
            this.Load += new System.EventHandler(this.FormFournisseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFour)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.DataGridView dgvFour;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnPayer;
        public System.Windows.Forms.Button btnModifier;
        public System.Windows.Forms.Button btnNouveau;
        private DataSetFour dataSetFour;
        private System.Windows.Forms.BindingSource fournisseurBindingSource;
        private DataSetFourTableAdapters.FournisseurTableAdapter fournisseurTableAdapter;
        public System.Windows.Forms.ComboBox cboContainer;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button btnTriCroissant;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn personcontactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcompteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intituleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeswiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn banqueDataGridViewTextBoxColumn;
    }
}