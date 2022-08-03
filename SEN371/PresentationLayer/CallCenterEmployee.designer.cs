namespace Project_1.PresentationLayer
{
    partial class CallCenterEmployee
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label cell_NumberLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label client_TypeLabel;
            System.Windows.Forms.Label full_AddressLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallCenterEmployee));
            this.label9 = new System.Windows.Forms.Label();
            this.radioButtonEmployee = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btnSQL = new System.Windows.Forms.Button();
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.personAddressDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.premierServiceSolutionsDBDataSet1 = new Project_1.PremierServiceSolutionsDBDataSet1();
            this.lblLogo = new System.Windows.Forms.Label();
            this.radioButtonClient = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmployeeType = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.full_AddressTextBox = new System.Windows.Forms.TextBox();
            this.client_TypeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cell_NumberTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripView = new System.Windows.Forms.ToolStripMenuItem();
            this.callHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStriRequests = new System.Windows.Forms.ToolStripMenuItem();
            this.callCentreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripManagement = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripDepartment = new System.Windows.Forms.ToolStripComboBox();
            this.personAddressDetailsTableAdapter = new Project_1.PremierServiceSolutionsDBDataSet1TableAdapters.PersonAddressDetailsTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableAdapterManager = new Project_1.PremierServiceSolutionsDBDataSet1TableAdapters.TableAdapterManager();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.callBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.callTableAdapter = new Project_1.PremierServiceSolutionsDBDataSet1TableAdapters.CallTableAdapter();
            this.lblLogOut = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            cell_NumberLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            client_TypeLabel = new System.Windows.Forms.Label();
            full_AddressLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personAddressDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.premierServiceSolutionsDBDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.callBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(53, 240);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 20);
            nameLabel.TabIndex = 87;
            nameLabel.Text = "Name:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(31, 280);
            surnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(78, 20);
            surnameLabel.TabIndex = 88;
            surnameLabel.Text = "Surname:";
            // 
            // cell_NumberLabel
            // 
            cell_NumberLabel.AutoSize = true;
            cell_NumberLabel.Location = new System.Drawing.Point(9, 317);
            cell_NumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cell_NumberLabel.Name = "cell_NumberLabel";
            cell_NumberLabel.Size = new System.Drawing.Size(99, 20);
            cell_NumberLabel.TabIndex = 89;
            cell_NumberLabel.Text = "Cell Number:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(57, 357);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 20);
            emailLabel.TabIndex = 90;
            emailLabel.Text = "Email:";
            // 
            // client_TypeLabel
            // 
            client_TypeLabel.AutoSize = true;
            client_TypeLabel.Location = new System.Drawing.Point(15, 397);
            client_TypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            client_TypeLabel.Name = "client_TypeLabel";
            client_TypeLabel.Size = new System.Drawing.Size(91, 20);
            client_TypeLabel.TabIndex = 91;
            client_TypeLabel.Text = "Client Type:";
            // 
            // full_AddressLabel
            // 
            full_AddressLabel.AutoSize = true;
            full_AddressLabel.Location = new System.Drawing.Point(9, 437);
            full_AddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            full_AddressLabel.Name = "full_AddressLabel";
            full_AddressLabel.Size = new System.Drawing.Size(101, 20);
            full_AddressLabel.TabIndex = 92;
            full_AddressLabel.Text = "Full Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(21, 645);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(121, 20);
            label2.TabIndex = 95;
            label2.Text = "Employee Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 514);
            this.label9.Margin = new System.Windows.Forms.Padding(10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 26);
            this.label9.TabIndex = 77;
            this.label9.Text = "Select Person Type";
            // 
            // radioButtonEmployee
            // 
            this.radioButtonEmployee.AutoSize = true;
            this.radioButtonEmployee.Location = new System.Drawing.Point(135, 578);
            this.radioButtonEmployee.Margin = new System.Windows.Forms.Padding(10);
            this.radioButtonEmployee.Name = "radioButtonEmployee";
            this.radioButtonEmployee.Size = new System.Drawing.Size(104, 24);
            this.radioButtonEmployee.TabIndex = 76;
            this.radioButtonEmployee.TabStop = true;
            this.radioButtonEmployee.Text = "Employee";
            this.radioButtonEmployee.UseVisualStyleBackColor = true;
            this.radioButtonEmployee.CheckedChanged += new System.EventHandler(this.radioButtonEmployee_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(-68, 372);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 24);
            this.radioButton1.TabIndex = 75;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Client";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-69, 277);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 72;
            this.label7.Text = "Country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-72, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 69;
            this.label6.Text = "Surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-72, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 68;
            this.label5.Text = "Name";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(20, 997);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 45);
            this.button5.TabIndex = 61;
            this.button5.Text = "Log Problem";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnSQL
            // 
            this.btnSQL.Location = new System.Drawing.Point(14, 50);
            this.btnSQL.Name = "btnSQL";
            this.btnSQL.Size = new System.Drawing.Size(160, 45);
            this.btnSQL.TabIndex = 56;
            this.btnSQL.Text = "Manage Call";
            this.btnSQL.UseVisualStyleBackColor = true;
            this.btnSQL.Click += new System.EventHandler(this.btnSQL_Click);
            // 
            // dgvOutput
            // 
            this.dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOutput.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOutput.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOutput.Location = new System.Drawing.Point(669, 112);
            this.dgvOutput.Margin = new System.Windows.Forms.Padding(10);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.RowHeadersWidth = 62;
            this.dgvOutput.Size = new System.Drawing.Size(1126, 1059);
            this.dgvOutput.TabIndex = 55;
            this.dgvOutput.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvOutput_MouseDoubleClick);
            // 
            // personAddressDetailsBindingSource
            // 
            this.personAddressDetailsBindingSource.DataMember = "PersonAddressDetails";
            this.personAddressDetailsBindingSource.DataSource = this.premierServiceSolutionsDBDataSet1;
            // 
            // premierServiceSolutionsDBDataSet1
            // 
            this.premierServiceSolutionsDBDataSet1.DataSetName = "PremierServiceSolutionsDBDataSet1";
            this.premierServiceSolutionsDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(17, 19);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(480, 46);
            this.lblLogo.TabIndex = 53;
            this.lblLogo.Text = "Premier Service Solutions";
            this.lblLogo.Click += new System.EventHandler(this.lblLogo_Click);
            // 
            // radioButtonClient
            // 
            this.radioButtonClient.AutoSize = true;
            this.radioButtonClient.Location = new System.Drawing.Point(34, 578);
            this.radioButtonClient.Margin = new System.Windows.Forms.Padding(10);
            this.radioButtonClient.Name = "radioButtonClient";
            this.radioButtonClient.Size = new System.Drawing.Size(74, 24);
            this.radioButtonClient.TabIndex = 87;
            this.radioButtonClient.TabStop = true;
            this.radioButtonClient.Text = "Client";
            this.radioButtonClient.UseVisualStyleBackColor = true;
            this.radioButtonClient.CheckedChanged += new System.EventHandler(this.radioButtonClient_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxEmployeeType);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(full_AddressLabel);
            this.panel1.Controls.Add(this.full_AddressTextBox);
            this.panel1.Controls.Add(client_TypeLabel);
            this.panel1.Controls.Add(this.client_TypeTextBox);
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(cell_NumberLabel);
            this.panel1.Controls.Add(this.lblLogo);
            this.panel1.Controls.Add(this.cell_NumberTextBox);
            this.panel1.Controls.Add(surnameLabel);
            this.panel1.Controls.Add(this.surnameTextBox);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.radioButtonClient);
            this.panel1.Controls.Add(this.radioButtonEmployee);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(83, 112);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(548, 1059);
            this.panel1.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 26);
            this.label3.TabIndex = 97;
            this.label3.Text = "Input Values";
            // 
            // textBoxEmployeeType
            // 
            this.textBoxEmployeeType.Location = new System.Drawing.Point(156, 645);
            this.textBoxEmployeeType.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxEmployeeType.Name = "textBoxEmployeeType";
            this.textBoxEmployeeType.Size = new System.Drawing.Size(181, 26);
            this.textBoxEmployeeType.TabIndex = 96;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(14, 995);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 45);
            this.btnSave.TabIndex = 94;
            this.btnSave.Text = "Submit new";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSubmitNewClient_Click);
            // 
            // full_AddressTextBox
            // 
            this.full_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personAddressDetailsBindingSource, "Full Address", true));
            this.full_AddressTextBox.Location = new System.Drawing.Point(130, 449);
            this.full_AddressTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.full_AddressTextBox.Name = "full_AddressTextBox";
            this.full_AddressTextBox.Size = new System.Drawing.Size(394, 26);
            this.full_AddressTextBox.TabIndex = 93;
            // 
            // client_TypeTextBox
            // 
            this.client_TypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personAddressDetailsBindingSource, "Client Type", true));
            this.client_TypeTextBox.Location = new System.Drawing.Point(130, 403);
            this.client_TypeTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.client_TypeTextBox.Name = "client_TypeTextBox";
            this.client_TypeTextBox.Size = new System.Drawing.Size(394, 26);
            this.client_TypeTextBox.TabIndex = 92;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personAddressDetailsBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(130, 357);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(394, 26);
            this.emailTextBox.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Logged-In as: Call Center Employee";
            // 
            // cell_NumberTextBox
            // 
            this.cell_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personAddressDetailsBindingSource, "Cell Number", true));
            this.cell_NumberTextBox.Location = new System.Drawing.Point(130, 311);
            this.cell_NumberTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.cell_NumberTextBox.Name = "cell_NumberTextBox";
            this.cell_NumberTextBox.Size = new System.Drawing.Size(394, 26);
            this.cell_NumberTextBox.TabIndex = 90;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personAddressDetailsBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(130, 266);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(394, 26);
            this.surnameTextBox.TabIndex = 89;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personAddressDetailsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(130, 220);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(394, 26);
            this.nameTextBox.TabIndex = 88;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripView,
            this.toolStriRequests,
            this.toolStripManagement,
            this.toolStripDepartment});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(2133, 37);
            this.menuStrip1.TabIndex = 93;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripView
            // 
            this.toolStripView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.callHistoryToolStripMenuItem,
            this.clientInformationToolStripMenuItem});
            this.toolStripView.Name = "toolStripView";
            this.toolStripView.Size = new System.Drawing.Size(65, 29);
            this.toolStripView.Text = "View";
            // 
            // callHistoryToolStripMenuItem
            // 
            this.callHistoryToolStripMenuItem.Name = "callHistoryToolStripMenuItem";
            this.callHistoryToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.callHistoryToolStripMenuItem.Text = "Call History";
            this.callHistoryToolStripMenuItem.Click += new System.EventHandler(this.callHistoryToolStripMenuItem_Click);
            // 
            // clientInformationToolStripMenuItem
            // 
            this.clientInformationToolStripMenuItem.Name = "clientInformationToolStripMenuItem";
            this.clientInformationToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.clientInformationToolStripMenuItem.Text = "Client Information";
            this.clientInformationToolStripMenuItem.Click += new System.EventHandler(this.clientInformationToolStripMenuItem_Click);
            // 
            // toolStriRequests
            // 
            this.toolStriRequests.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.callCentreToolStripMenuItem,
            this.serviceToolStripMenuItem});
            this.toolStriRequests.Name = "toolStriRequests";
            this.toolStriRequests.Size = new System.Drawing.Size(99, 29);
            this.toolStriRequests.Text = "Requests";
            // 
            // callCentreToolStripMenuItem
            // 
            this.callCentreToolStripMenuItem.Name = "callCentreToolStripMenuItem";
            this.callCentreToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.callCentreToolStripMenuItem.Text = "Call Centre";
            this.callCentreToolStripMenuItem.Click += new System.EventHandler(this.callCentreToolStripMenuItem_Click);
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.serviceToolStripMenuItem.Text = "Service";
            this.serviceToolStripMenuItem.Click += new System.EventHandler(this.serviceToolStripMenuItem_Click);
            // 
            // toolStripManagement
            // 
            this.toolStripManagement.Enabled = false;
            this.toolStripManagement.Name = "toolStripManagement";
            this.toolStripManagement.Size = new System.Drawing.Size(110, 33);
            this.toolStripManagement.Text = "Management";
            // 
            // toolStripDepartment
            // 
            this.toolStripDepartment.Enabled = false;
            this.toolStripDepartment.Name = "toolStripDepartment";
            this.toolStripDepartment.Size = new System.Drawing.Size(110, 33);
            this.toolStripDepartment.Text = "Department";
            // 
            // personAddressDetailsTableAdapter
            // 
            this.personAddressDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bindingNavigator1.BindingSource = this.personAddressDetailsBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 37);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(2133, 33);
            this.bindingNavigator1.TabIndex = 94;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CallTableAdapter = null;
            this.tableAdapterManager.ClientManagementInformationTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ContractServicesTableAdapter = null;
            this.tableAdapterManager.ContractTableAdapter = null;
            this.tableAdapterManager.ContractTypeTableAdapter = null;
            this.tableAdapterManager.DepartmentTableAdapter = null;
            this.tableAdapterManager.EmployeeDepartmentTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.PersonAddressTableAdapter = null;
            this.tableAdapterManager.ServiceRequestTableAdapter = null;
            this.tableAdapterManager.ServiceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project_1.PremierServiceSolutionsDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // callBindingSource
            // 
            this.callBindingSource.DataMember = "Call";
            this.callBindingSource.DataSource = this.premierServiceSolutionsDBDataSet1;
            // 
            // callTableAdapter
            // 
            this.callTableAdapter.ClearBeforeFill = true;
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Location = new System.Drawing.Point(16, 10);
            this.lblLogOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(66, 20);
            this.lblLogOut.TabIndex = 95;
            this.lblLogOut.TabStop = true;
            this.lblLogOut.Text = "Log Out";
            this.lblLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLogOut_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.lblLogOut);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.btnSQL);
            this.panel2.Location = new System.Drawing.Point(1843, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 1059);
            this.panel2.TabIndex = 96;
            // 
            // CallCenterEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2133, 1253);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvOutput);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CallCenterEmployee";
            this.ShowIcon = false;
            this.Text = "CallCenterEmployee";
            this.Load += new System.EventHandler(this.CallCenterEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personAddressDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.premierServiceSolutionsDBDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.callBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButtonEmployee;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnSQL;
        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.RadioButton radioButtonClient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripManagement;
        private System.Windows.Forms.ToolStripComboBox toolStripDepartment;
        private System.Windows.Forms.ToolStripMenuItem toolStripView;
        private System.Windows.Forms.ToolStripMenuItem callHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStriRequests;
        private System.Windows.Forms.ToolStripMenuItem callCentreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private PremierServiceSolutionsDBDataSet1 premierServiceSolutionsDBDataSet1;
        private System.Windows.Forms.BindingSource personAddressDetailsBindingSource;
        private PremierServiceSolutionsDBDataSet1TableAdapters.PersonAddressDetailsTableAdapter personAddressDetailsTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox nameTextBox;
        private PremierServiceSolutionsDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox full_AddressTextBox;
        private System.Windows.Forms.TextBox client_TypeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox cell_NumberTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TextBox textBoxEmployeeType;
        private System.Windows.Forms.BindingSource callBindingSource;
        private PremierServiceSolutionsDBDataSet1TableAdapters.CallTableAdapter callTableAdapter;
        private System.Windows.Forms.LinkLabel lblLogOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}