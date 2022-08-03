namespace Project_1.PresentationLayer
{
    partial class ClientDataManager
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
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCellPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripView = new System.Windows.Forms.ToolStripMenuItem();
            this.businessClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStriRequests = new System.Windows.Forms.ToolStripMenuItem();
            this.contractsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.callAgentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contractMaintananceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceMaintananceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.technicianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callCentreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newHumanResourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLogOut = new System.Windows.Forms.LinkLabel();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnDelSelect = new System.Windows.Forms.Button();
            this.btnUpdtSelecct = new System.Windows.Forms.Button();
            this.btnContracts = new System.Windows.Forms.Button();
            this.btnSQL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOutput
            // 
            this.dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOutput.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Location = new System.Drawing.Point(610, 150);
            this.dgvOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvOutput.RowHeadersWidth = 62;
            this.dgvOutput.Size = new System.Drawing.Size(1227, 937);
            this.dgvOutput.TabIndex = 0;
            this.dgvOutput.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOutput_CellContentClick);
            this.dgvOutput.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOutput_CellEnter);
            this.dgvOutput.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOutput_CellMouseClick);
            this.dgvOutput.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvOutput_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSurname);
            this.panel1.Controls.Add(this.txtType);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtCellPhone);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblLogo);
            this.panel1.Location = new System.Drawing.Point(41, 149);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 938);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cellphone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "ClientType";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(180, 198);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(306, 26);
            this.txtSurname.TabIndex = 12;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(180, 251);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(306, 26);
            this.txtType.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(180, 301);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(306, 26);
            this.txtEmail.TabIndex = 10;
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Location = new System.Drawing.Point(180, 354);
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(306, 26);
            this.txtCellPhone.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(180, 146);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(306, 26);
            this.txtName.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(9, 883);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 45);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Submit New Client";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(6, 11);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(480, 46);
            this.lblLogo.TabIndex = 2;
            this.lblLogo.Text = "Premier Service Solutions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Logged-In as: Client Data Manager";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripView,
            this.toolStriRequests,
            this.toolStripManagement});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(2177, 33);
            this.menuStrip1.TabIndex = 94;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripView
            // 
            this.toolStripView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.businessClientsToolStripMenuItem,
            this.individualClientsToolStripMenuItem,
            this.clientsTableToolStripMenuItem,
            this.employeeTableToolStripMenuItem});
            this.toolStripView.Name = "toolStripView";
            this.toolStripView.Size = new System.Drawing.Size(65, 29);
            this.toolStripView.Text = "View";
            this.toolStripView.Click += new System.EventHandler(this.toolStripView_Click);
            // 
            // businessClientsToolStripMenuItem
            // 
            this.businessClientsToolStripMenuItem.Name = "businessClientsToolStripMenuItem";
            this.businessClientsToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
            this.businessClientsToolStripMenuItem.Text = "Business Clients";
            this.businessClientsToolStripMenuItem.Click += new System.EventHandler(this.businessClientsToolStripMenuItem_Click);
            // 
            // individualClientsToolStripMenuItem
            // 
            this.individualClientsToolStripMenuItem.Name = "individualClientsToolStripMenuItem";
            this.individualClientsToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
            this.individualClientsToolStripMenuItem.Text = "Individual Clients";
            this.individualClientsToolStripMenuItem.Click += new System.EventHandler(this.individualClientsToolStripMenuItem_Click);
            // 
            // clientsTableToolStripMenuItem
            // 
            this.clientsTableToolStripMenuItem.Name = "clientsTableToolStripMenuItem";
            this.clientsTableToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
            this.clientsTableToolStripMenuItem.Text = "Clients Table";
            this.clientsTableToolStripMenuItem.Click += new System.EventHandler(this.clientsTableToolStripMenuItem_Click);
            // 
            // employeeTableToolStripMenuItem
            // 
            this.employeeTableToolStripMenuItem.Name = "employeeTableToolStripMenuItem";
            this.employeeTableToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
            this.employeeTableToolStripMenuItem.Text = "Employee Table";
            this.employeeTableToolStripMenuItem.Click += new System.EventHandler(this.employeeTableToolStripMenuItem_Click);
            // 
            // toolStriRequests
            // 
            this.toolStriRequests.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contractsToolStripMenuItem,
            this.servicesToolStripMenuItem});
            this.toolStriRequests.Name = "toolStriRequests";
            this.toolStriRequests.Size = new System.Drawing.Size(99, 29);
            this.toolStriRequests.Text = "Requests";
            // 
            // contractsToolStripMenuItem
            // 
            this.contractsToolStripMenuItem.Name = "contractsToolStripMenuItem";
            this.contractsToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
            this.contractsToolStripMenuItem.Text = "Contracts";
            this.contractsToolStripMenuItem.Click += new System.EventHandler(this.contractsToolStripMenuItem_Click);
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
            this.servicesToolStripMenuItem.Text = "Services";
            this.servicesToolStripMenuItem.Click += new System.EventHandler(this.servicesToolStripMenuItem_Click);
            // 
            // toolStripManagement
            // 
            this.toolStripManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.callAgentToolStripMenuItem,
            this.contractMaintananceToolStripMenuItem,
            this.serviceMaintananceToolStripMenuItem,
            this.technicianToolStripMenuItem,
            this.callCentreToolStripMenuItem,
            this.servicesToolStripMenuItem1,
            this.newHumanResourcesToolStripMenuItem});
            this.toolStripManagement.Name = "toolStripManagement";
            this.toolStripManagement.Size = new System.Drawing.Size(133, 29);
            this.toolStripManagement.Text = "Management";
            // 
            // callAgentToolStripMenuItem
            // 
            this.callAgentToolStripMenuItem.Name = "callAgentToolStripMenuItem";
            this.callAgentToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.callAgentToolStripMenuItem.Text = "Human Resources";
            this.callAgentToolStripMenuItem.Click += new System.EventHandler(this.callAgentToolStripMenuItem_Click);
            // 
            // contractMaintananceToolStripMenuItem
            // 
            this.contractMaintananceToolStripMenuItem.Name = "contractMaintananceToolStripMenuItem";
            this.contractMaintananceToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.contractMaintananceToolStripMenuItem.Text = "Contract Maintanance";
            this.contractMaintananceToolStripMenuItem.Click += new System.EventHandler(this.contractMaintananceToolStripMenuItem_Click);
            // 
            // serviceMaintananceToolStripMenuItem
            // 
            this.serviceMaintananceToolStripMenuItem.Name = "serviceMaintananceToolStripMenuItem";
            this.serviceMaintananceToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.serviceMaintananceToolStripMenuItem.Text = "Service Maintanance";
            this.serviceMaintananceToolStripMenuItem.Click += new System.EventHandler(this.serviceMaintananceToolStripMenuItem_Click);
            // 
            // technicianToolStripMenuItem
            // 
            this.technicianToolStripMenuItem.Name = "technicianToolStripMenuItem";
            this.technicianToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.technicianToolStripMenuItem.Text = "Client Maintenance";
            this.technicianToolStripMenuItem.Click += new System.EventHandler(this.technicianToolStripMenuItem_Click);
            // 
            // callCentreToolStripMenuItem
            // 
            this.callCentreToolStripMenuItem.Name = "callCentreToolStripMenuItem";
            this.callCentreToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.callCentreToolStripMenuItem.Text = "Call Centre";
            this.callCentreToolStripMenuItem.Click += new System.EventHandler(this.callCentreToolStripMenuItem_Click);
            // 
            // servicesToolStripMenuItem1
            // 
            this.servicesToolStripMenuItem1.Name = "servicesToolStripMenuItem1";
            this.servicesToolStripMenuItem1.Size = new System.Drawing.Size(296, 34);
            this.servicesToolStripMenuItem1.Text = "Services";
            this.servicesToolStripMenuItem1.Click += new System.EventHandler(this.servicesToolStripMenuItem1_Click);
            // 
            // newHumanResourcesToolStripMenuItem
            // 
            this.newHumanResourcesToolStripMenuItem.Name = "newHumanResourcesToolStripMenuItem";
            this.newHumanResourcesToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.newHumanResourcesToolStripMenuItem.Text = "New Human Resources";
            this.newHumanResourcesToolStripMenuItem.Click += new System.EventHandler(this.newHumanResourcesToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.lblLogOut);
            this.panel2.Controls.Add(this.btnLog);
            this.panel2.Controls.Add(this.btnService);
            this.panel2.Controls.Add(this.btnEmployee);
            this.panel2.Controls.Add(this.btnIssue);
            this.panel2.Controls.Add(this.btnClient);
            this.panel2.Controls.Add(this.btnDelSelect);
            this.panel2.Controls.Add(this.btnUpdtSelecct);
            this.panel2.Controls.Add(this.btnContracts);
            this.panel2.Controls.Add(this.btnSQL);
            this.panel2.Location = new System.Drawing.Point(1909, 150);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 937);
            this.panel2.TabIndex = 18;
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Location = new System.Drawing.Point(15, 848);
            this.lblLogOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(66, 20);
            this.lblLogOut.TabIndex = 29;
            this.lblLogOut.TabStop = true;
            this.lblLogOut.Text = "Log Out";
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(19, 873);
            this.btnLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(160, 45);
            this.btnLog.TabIndex = 28;
            this.btnLog.Text = "Log Problem";
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // btnService
            // 
            this.btnService.Location = new System.Drawing.Point(19, 471);
            this.btnService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(160, 60);
            this.btnService.TabIndex = 27;
            this.btnService.Text = "View Service History";
            this.btnService.UseVisualStyleBackColor = true;
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(19, 405);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(160, 57);
            this.btnEmployee.TabIndex = 26;
            this.btnEmployee.Text = "Find Employee Details";
            this.btnEmployee.UseVisualStyleBackColor = true;
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(19, 351);
            this.btnIssue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(160, 45);
            this.btnIssue.TabIndex = 25;
            this.btnIssue.Text = "View Issue History";
            this.btnIssue.UseVisualStyleBackColor = true;
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(19, 297);
            this.btnClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(160, 45);
            this.btnClient.TabIndex = 24;
            this.btnClient.Text = "Find Client Details";
            this.btnClient.UseVisualStyleBackColor = true;
            // 
            // btnDelSelect
            // 
            this.btnDelSelect.Location = new System.Drawing.Point(19, 130);
            this.btnDelSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelSelect.Name = "btnDelSelect";
            this.btnDelSelect.Size = new System.Drawing.Size(160, 45);
            this.btnDelSelect.TabIndex = 23;
            this.btnDelSelect.Text = "Delete Selected";
            this.btnDelSelect.UseVisualStyleBackColor = true;
            // 
            // btnUpdtSelecct
            // 
            this.btnUpdtSelecct.Location = new System.Drawing.Point(19, 77);
            this.btnUpdtSelecct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdtSelecct.Name = "btnUpdtSelecct";
            this.btnUpdtSelecct.Size = new System.Drawing.Size(160, 45);
            this.btnUpdtSelecct.TabIndex = 22;
            this.btnUpdtSelecct.Text = "Update Selected";
            this.btnUpdtSelecct.UseVisualStyleBackColor = true;
            // 
            // btnContracts
            // 
            this.btnContracts.Location = new System.Drawing.Point(19, 541);
            this.btnContracts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(160, 45);
            this.btnContracts.TabIndex = 21;
            this.btnContracts.Text = "Show Contracts";
            this.btnContracts.UseVisualStyleBackColor = true;
            // 
            // btnSQL
            // 
            this.btnSQL.Location = new System.Drawing.Point(19, 11);
            this.btnSQL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSQL.Name = "btnSQL";
            this.btnSQL.Size = new System.Drawing.Size(160, 45);
            this.btnSQL.TabIndex = 20;
            this.btnSQL.Text = "Run Query";
            this.btnSQL.UseVisualStyleBackColor = true;
            // 
            // ClientDataManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2177, 1294);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvOutput);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientDataManager";
            this.ShowIcon = false;
            this.Text = "Logged In as Client Data Manager";
            this.Load += new System.EventHandler(this.ClientDataManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCellPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripView;
        private System.Windows.Forms.ToolStripMenuItem businessClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStriRequests;
        private System.Windows.Forms.ToolStripMenuItem contractsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripManagement;
        private System.Windows.Forms.ToolStripMenuItem callAgentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contractMaintananceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceMaintananceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem technicianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callCentreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newHumanResourcesToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel lblLogOut;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnDelSelect;
        private System.Windows.Forms.Button btnUpdtSelecct;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.Button btnSQL;
    }
}