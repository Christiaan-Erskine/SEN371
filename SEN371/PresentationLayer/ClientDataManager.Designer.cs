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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbDepartment = new System.Windows.Forms.ComboBox();
            this.cbbManagement = new System.Windows.Forms.ComboBox();
            this.cbbReq = new System.Windows.Forms.ComboBox();
            this.cbbView = new System.Windows.Forms.ComboBox();
            this.btnSQL = new System.Windows.Forms.Button();
            this.btnContracts = new System.Windows.Forms.Button();
            this.btnUpdtSelecct = new System.Windows.Forms.Button();
            this.btnDelSelect = new System.Windows.Forms.Button();
            this.btnAddSelect = new System.Windows.Forms.Button();
            this.btnSavSelect = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.lblLogOut = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOutput
            // 
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Location = new System.Drawing.Point(402, 92);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.Size = new System.Drawing.Size(615, 518);
            this.dgvOutput.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Location = new System.Drawing.Point(14, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 517);
            this.panel1.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(31, 488);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(112, 488);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(193, 488);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(274, 488);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Green;
            this.linkLabel1.Location = new System.Drawing.Point(95, 143);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(185, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add The Dynamic Fields In A Meeting";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(422, 9);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(325, 31);
            this.lblLogo.TabIndex = 2;
            this.lblLogo.Text = "Premier Service Solutions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Logged-In as: Client Data Manager";
            // 
            // cbbDepartment
            // 
            this.cbbDepartment.AllowDrop = true;
            this.cbbDepartment.FormattingEnabled = true;
            this.cbbDepartment.Location = new System.Drawing.Point(302, 65);
            this.cbbDepartment.Name = "cbbDepartment";
            this.cbbDepartment.Size = new System.Drawing.Size(89, 21);
            this.cbbDepartment.TabIndex = 7;
            this.cbbDepartment.Text = "Dapartment";
            // 
            // cbbManagement
            // 
            this.cbbManagement.AllowDrop = true;
            this.cbbManagement.FormattingEnabled = true;
            this.cbbManagement.Location = new System.Drawing.Point(207, 65);
            this.cbbManagement.Name = "cbbManagement";
            this.cbbManagement.Size = new System.Drawing.Size(89, 21);
            this.cbbManagement.TabIndex = 6;
            this.cbbManagement.Text = "Management";
            // 
            // cbbReq
            // 
            this.cbbReq.AllowDrop = true;
            this.cbbReq.FormattingEnabled = true;
            this.cbbReq.Location = new System.Drawing.Point(112, 65);
            this.cbbReq.Name = "cbbReq";
            this.cbbReq.Size = new System.Drawing.Size(89, 21);
            this.cbbReq.TabIndex = 5;
            this.cbbReq.Text = "Requests";
            // 
            // cbbView
            // 
            this.cbbView.AllowDrop = true;
            this.cbbView.FormattingEnabled = true;
            this.cbbView.Location = new System.Drawing.Point(17, 65);
            this.cbbView.Name = "cbbView";
            this.cbbView.Size = new System.Drawing.Size(89, 21);
            this.cbbView.TabIndex = 4;
            this.cbbView.Text = "View";
            // 
            // btnSQL
            // 
            this.btnSQL.Location = new System.Drawing.Point(910, 34);
            this.btnSQL.Name = "btnSQL";
            this.btnSQL.Size = new System.Drawing.Size(107, 29);
            this.btnSQL.TabIndex = 8;
            this.btnSQL.Text = "Run Query";
            this.btnSQL.UseVisualStyleBackColor = true;
            // 
            // btnContracts
            // 
            this.btnContracts.Location = new System.Drawing.Point(1030, 34);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(107, 29);
            this.btnContracts.TabIndex = 9;
            this.btnContracts.Text = "Show Contracts";
            this.btnContracts.UseVisualStyleBackColor = true;
            // 
            // btnUpdtSelecct
            // 
            this.btnUpdtSelecct.Location = new System.Drawing.Point(1030, 92);
            this.btnUpdtSelecct.Name = "btnUpdtSelecct";
            this.btnUpdtSelecct.Size = new System.Drawing.Size(107, 29);
            this.btnUpdtSelecct.TabIndex = 10;
            this.btnUpdtSelecct.Text = "Update Selected";
            this.btnUpdtSelecct.UseVisualStyleBackColor = true;
            // 
            // btnDelSelect
            // 
            this.btnDelSelect.Location = new System.Drawing.Point(1030, 127);
            this.btnDelSelect.Name = "btnDelSelect";
            this.btnDelSelect.Size = new System.Drawing.Size(107, 29);
            this.btnDelSelect.TabIndex = 11;
            this.btnDelSelect.Text = "Delete Selected";
            this.btnDelSelect.UseVisualStyleBackColor = true;
            // 
            // btnAddSelect
            // 
            this.btnAddSelect.Location = new System.Drawing.Point(1030, 162);
            this.btnAddSelect.Name = "btnAddSelect";
            this.btnAddSelect.Size = new System.Drawing.Size(107, 29);
            this.btnAddSelect.TabIndex = 12;
            this.btnAddSelect.Text = "Add Selected";
            this.btnAddSelect.UseVisualStyleBackColor = true;
            // 
            // btnSavSelect
            // 
            this.btnSavSelect.Location = new System.Drawing.Point(1030, 197);
            this.btnSavSelect.Name = "btnSavSelect";
            this.btnSavSelect.Size = new System.Drawing.Size(107, 29);
            this.btnSavSelect.TabIndex = 13;
            this.btnSavSelect.Text = "Save Selected";
            this.btnSavSelect.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Green;
            this.linkLabel2.Location = new System.Drawing.Point(99, 261);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(183, 13);
            this.linkLabel2.TabIndex = 9;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "\"Add\" and \"Save\" may be redundant";
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(1030, 259);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(107, 29);
            this.btnClient.TabIndex = 14;
            this.btnClient.Text = "Find Client Details";
            this.btnClient.UseVisualStyleBackColor = true;
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(1030, 294);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(107, 29);
            this.btnIssue.TabIndex = 15;
            this.btnIssue.Text = "View Issue History";
            this.btnIssue.UseVisualStyleBackColor = true;
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(1030, 329);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(107, 37);
            this.btnEmployee.TabIndex = 16;
            this.btnEmployee.Text = "Find Employee Details";
            this.btnEmployee.UseVisualStyleBackColor = true;
            // 
            // btnService
            // 
            this.btnService.Location = new System.Drawing.Point(1030, 372);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(107, 39);
            this.btnService.TabIndex = 17;
            this.btnService.Text = "View Service History";
            this.btnService.UseVisualStyleBackColor = true;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(1030, 602);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(107, 29);
            this.btnLog.TabIndex = 18;
            this.btnLog.Text = "Log Problem";
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Location = new System.Drawing.Point(11, 9);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(45, 13);
            this.lblLogOut.TabIndex = 19;
            this.lblLogOut.TabStop = true;
            this.lblLogOut.Text = "Log Out";
            // 
            // ClientDataManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 643);
            this.Controls.Add(this.lblLogOut);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnService);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnSavSelect);
            this.Controls.Add(this.btnAddSelect);
            this.Controls.Add(this.btnDelSelect);
            this.Controls.Add(this.btnUpdtSelecct);
            this.Controls.Add(this.btnContracts);
            this.Controls.Add(this.btnSQL);
            this.Controls.Add(this.cbbDepartment);
            this.Controls.Add(this.cbbManagement);
            this.Controls.Add(this.cbbReq);
            this.Controls.Add(this.cbbView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvOutput);
            this.Name = "ClientDataManager";
            this.Text = "Logged In as Client Data Manager";
            this.Load += new System.EventHandler(this.ClientDataManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ComboBox cbbDepartment;
        private System.Windows.Forms.ComboBox cbbManagement;
        private System.Windows.Forms.ComboBox cbbReq;
        private System.Windows.Forms.ComboBox cbbView;
        private System.Windows.Forms.Button btnSQL;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.Button btnUpdtSelecct;
        private System.Windows.Forms.Button btnDelSelect;
        private System.Windows.Forms.Button btnAddSelect;
        private System.Windows.Forms.Button btnSavSelect;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.LinkLabel lblLogOut;
    }
}