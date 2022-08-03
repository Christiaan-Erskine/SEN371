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
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.radioButtonClient = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxEmployeeType = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.full_AddressTextBox = new System.Windows.Forms.TextBox();
            this.client_TypeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(37, 43);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 87;
            nameLabel.Text = "Name:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(23, 69);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(52, 13);
            surnameLabel.TabIndex = 88;
            surnameLabel.Text = "Surname:";
            // 
            // cell_NumberLabel
            // 
            cell_NumberLabel.AutoSize = true;
            cell_NumberLabel.Location = new System.Drawing.Point(8, 93);
            cell_NumberLabel.Name = "cell_NumberLabel";
            cell_NumberLabel.Size = new System.Drawing.Size(67, 13);
            cell_NumberLabel.TabIndex = 89;
            cell_NumberLabel.Text = "Cell Number:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(40, 119);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 90;
            emailLabel.Text = "Email:";
            // 
            // client_TypeLabel
            // 
            client_TypeLabel.AutoSize = true;
            client_TypeLabel.Location = new System.Drawing.Point(12, 145);
            client_TypeLabel.Name = "client_TypeLabel";
            client_TypeLabel.Size = new System.Drawing.Size(63, 13);
            client_TypeLabel.TabIndex = 91;
            client_TypeLabel.Text = "Client Type:";
            // 
            // full_AddressLabel
            // 
            full_AddressLabel.AutoSize = true;
            full_AddressLabel.Location = new System.Drawing.Point(8, 171);
            full_AddressLabel.Name = "full_AddressLabel";
            full_AddressLabel.Size = new System.Drawing.Size(67, 13);
            full_AddressLabel.TabIndex = 92;
            full_AddressLabel.Text = "Full Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(126, 255);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 13);
            label2.TabIndex = 95;
            label2.Text = "Employee Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 77;
            this.label9.Text = "Select Person Type";
            // 
            // radioButtonEmployee
            // 
            this.radioButtonEmployee.AutoSize = true;
            this.radioButtonEmployee.Location = new System.Drawing.Point(25, 251);
            this.radioButtonEmployee.Name = "radioButtonEmployee";
            this.radioButtonEmployee.Size = new System.Drawing.Size(71, 17);
            this.radioButtonEmployee.TabIndex = 76;
            this.radioButtonEmployee.TabStop = true;
            this.radioButtonEmployee.Text = "Employee";
            this.radioButtonEmployee.UseVisualStyleBackColor = true;
            this.radioButtonEmployee.CheckedChanged += new System.EventHandler(this.radioButtonEmployee_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(-45, 242);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 17);
            this.radioButton1.TabIndex = 75;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Client";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-46, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 72;
            this.label7.Text = "Country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-48, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "Surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-48, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Name";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1019, 552);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 29);
            this.button5.TabIndex = 61;
            this.button5.Text = "Log Problem";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnSQL
            // 
            this.btnSQL.Location = new System.Drawing.Point(1018, 107);
            this.btnSQL.Margin = new System.Windows.Forms.Padding(2);
            this.btnSQL.Name = "btnSQL";
            this.btnSQL.Size = new System.Drawing.Size(107, 29);
            this.btnSQL.TabIndex = 56;
            this.btnSQL.Text = "Manage Call";
            this.btnSQL.UseVisualStyleBackColor = true;
            this.btnSQL.Click += new System.EventHandler(this.btnSQL_Click);
            // 
            // dgvOutput
            // 
            this.dgvOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Location = new System.Drawing.Point(386, 107);
            this.dgvOutput.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.RowHeadersWidth = 62;
            this.dgvOutput.Size = new System.Drawing.Size(628, 518);
            this.dgvOutput.TabIndex = 55;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Logged-In as: Call Center Employee";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(457, 50);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(325, 31);
            this.lblLogo.TabIndex = 53;
            this.lblLogo.Text = "Premier Service Solutions";
            // 
            // radioButtonClient
            // 
            this.radioButtonClient.AutoSize = true;
            this.radioButtonClient.Location = new System.Drawing.Point(25, 229);
            this.radioButtonClient.Name = "radioButtonClient";
            this.radioButtonClient.Size = new System.Drawing.Size(51, 17);
            this.radioButtonClient.TabIndex = 87;
            this.radioButtonClient.TabStop = true;
            this.radioButtonClient.Text = "Client";
            this.radioButtonClient.UseVisualStyleBackColor = true;
            this.radioButtonClient.CheckedChanged += new System.EventHandler(this.radioButtonClient_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBoxEmployeeType);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(full_AddressLabel);
            this.panel1.Controls.Add(this.full_AddressTextBox);
            this.panel1.Controls.Add(client_TypeLabel);
            this.panel1.Controls.Add(this.client_TypeTextBox);
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(cell_NumberLabel);
            this.panel1.Controls.Add(this.cell_NumberTextBox);
            this.panel1.Controls.Add(surnameLabel);
            this.panel1.Controls.Add(this.surnameTextBox);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.radioButtonClient);
            this.panel1.Controls.Add(this.radioButtonEmployee);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(10, 179);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 353);
            this.panel1.TabIndex = 92;
            // 
            // textBoxEmployeeType
            // 
            this.textBoxEmployeeType.Location = new System.Drawing.Point(215, 251);
            this.textBoxEmployeeType.Name = "textBoxEmployeeType";
            this.textBoxEmployeeType.Size = new System.Drawing.Size(122, 20);
            this.textBoxEmployeeType.TabIndex = 96;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 314);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 94;
            this.btnSave.Text = "Submit new";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSubmitNewClient_Click);
            // 
            // full_AddressTextBox
            // 
            this.full_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personAddressDetailsBindingSource, "Full Address", true));
            this.full_AddressTextBox.Location = new System.Drawing.Point(81, 168);
            this.full_AddressTextBox.Name = "full_AddressTextBox";
            this.full_AddressTextBox.Size = new System.Drawing.Size(264, 20);
            this.full_AddressTextBox.TabIndex = 93;
            // 
            // client_TypeTextBox
            // 
            this.client_TypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personAddressDetailsBindingSource, "Client Type", true));
            this.client_TypeTextBox.Location = new System.Drawing.Point(81, 142);
            this.client_TypeTextBox.Name = "client_TypeTextBox";
            this.client_TypeTextBox.Size = new System.Drawing.Size(264, 20);
            this.client_TypeTextBox.TabIndex = 92;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personAddressDetailsBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(81, 116);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(264, 20);
            this.emailTextBox.TabIndex = 91;
            // 
            // cell_NumberTextBox
            // 
            this.cell_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personAddressDetailsBindingSource, "Cell Number", true));
            this.cell_NumberTextBox.Location = new System.Drawing.Point(81, 90);
            this.cell_NumberTextBox.Name = "cell_NumberTextBox";
            this.cell_NumberTextBox.Size = new System.Drawing.Size(264, 20);
            this.cell_NumberTextBox.TabIndex = 90;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personAddressDetailsBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(81, 66);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(264, 20);
            this.surnameTextBox.TabIndex = 89;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personAddressDetailsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(81, 40);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(264, 20);
            this.nameTextBox.TabIndex = 88;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripView,
            this.toolStriRequests,
            this.toolStripManagement,
            this.toolStripDepartment});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1129, 25);
            this.menuStrip1.TabIndex = 93;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripView
            // 
            this.toolStripView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.callHistoryToolStripMenuItem,
            this.clientInformationToolStripMenuItem});
            this.toolStripView.Name = "toolStripView";
            this.toolStripView.Size = new System.Drawing.Size(44, 23);
            this.toolStripView.Text = "View";
            // 
            // callHistoryToolStripMenuItem
            // 
            this.callHistoryToolStripMenuItem.Name = "callHistoryToolStripMenuItem";
            this.callHistoryToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.callHistoryToolStripMenuItem.Text = "Call History";
            this.callHistoryToolStripMenuItem.Click += new System.EventHandler(this.callHistoryToolStripMenuItem_Click);
            // 
            // clientInformationToolStripMenuItem
            // 
            this.clientInformationToolStripMenuItem.Name = "clientInformationToolStripMenuItem";
            this.clientInformationToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.clientInformationToolStripMenuItem.Text = "Client Information";
            this.clientInformationToolStripMenuItem.Click += new System.EventHandler(this.clientInformationToolStripMenuItem_Click);
            // 
            // toolStriRequests
            // 
            this.toolStriRequests.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.callCentreToolStripMenuItem,
            this.serviceToolStripMenuItem});
            this.toolStriRequests.Name = "toolStriRequests";
            this.toolStriRequests.Size = new System.Drawing.Size(66, 23);
            this.toolStriRequests.Text = "Requests";
            // 
            // callCentreToolStripMenuItem
            // 
            this.callCentreToolStripMenuItem.Name = "callCentreToolStripMenuItem";
            this.callCentreToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.callCentreToolStripMenuItem.Text = "Call Centre";
            this.callCentreToolStripMenuItem.Click += new System.EventHandler(this.callCentreToolStripMenuItem_Click);
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.serviceToolStripMenuItem.Text = "Service";
            this.serviceToolStripMenuItem.Click += new System.EventHandler(this.serviceToolStripMenuItem_Click);
            // 
            // toolStripManagement
            // 
            this.toolStripManagement.Enabled = false;
            this.toolStripManagement.Name = "toolStripManagement";
            this.toolStripManagement.Size = new System.Drawing.Size(75, 23);
            this.toolStripManagement.Text = "Management";
            // 
            // toolStripDepartment
            // 
            this.toolStripDepartment.Enabled = false;
            this.toolStripDepartment.Name = "toolStripDepartment";
            this.toolStripDepartment.Size = new System.Drawing.Size(75, 23);
            this.toolStripDepartment.Text = "Department";
            // 
            // personAddressDetailsTableAdapter
            // 
            this.personAddressDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.personAddressDetailsBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 25);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1129, 25);
            this.bindingNavigator1.TabIndex = 94;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // CallCenterEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 643);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnSQL);
            this.Controls.Add(this.dgvOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.menuStrip1);
            this.Name = "CallCenterEmployee";
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
        private System.Windows.Forms.Label label1;
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
    }
}