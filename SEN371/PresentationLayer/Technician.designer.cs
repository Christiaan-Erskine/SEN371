namespace Project_1.PresentationLayer
{
    partial class Technician
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnIncomplete = new System.Windows.Forms.RadioButton();
            this.rbtnComplete = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripView = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outstandingCallsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStriRequests = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripManagement = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripDepartment = new System.Windows.Forms.ToolStripComboBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Logged-In as: Technician";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(8, 10);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(480, 46);
            this.lblLogo.TabIndex = 19;
            this.lblLogo.Text = "Premier Service Solutions";
            // 
            // dgvOutput
            // 
            this.dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOutput.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Location = new System.Drawing.Point(639, 80);
            this.dgvOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.RowHeadersWidth = 62;
            this.dgvOutput.Size = new System.Drawing.Size(1167, 920);
            this.dgvOutput.TabIndex = 65;
            this.dgvOutput.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOutput_CellContentClick);
            this.dgvOutput.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOutput_CellEnter);
            this.dgvOutput.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvOutput_MouseDoubleClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(18, 817);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 43);
            this.btnUpdate.TabIndex = 84;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rbtnIncomplete);
            this.panel1.Controls.Add(this.rbtnComplete);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.lblLogo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(70, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 920);
            this.panel1.TabIndex = 90;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rbtnIncomplete
            // 
            this.rbtnIncomplete.AutoSize = true;
            this.rbtnIncomplete.Location = new System.Drawing.Point(177, 238);
            this.rbtnIncomplete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnIncomplete.Name = "rbtnIncomplete";
            this.rbtnIncomplete.Size = new System.Drawing.Size(143, 24);
            this.rbtnIncomplete.TabIndex = 88;
            this.rbtnIncomplete.TabStop = true;
            this.rbtnIncomplete.Text = "Job Incomplete";
            this.rbtnIncomplete.UseVisualStyleBackColor = true;
            // 
            // rbtnComplete
            // 
            this.rbtnComplete.AutoSize = true;
            this.rbtnComplete.Location = new System.Drawing.Point(18, 238);
            this.rbtnComplete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnComplete.Name = "rbtnComplete";
            this.rbtnComplete.Size = new System.Drawing.Size(132, 24);
            this.rbtnComplete.TabIndex = 87;
            this.rbtnComplete.TabStop = true;
            this.rbtnComplete.Text = "Job Complete";
            this.rbtnComplete.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 86;
            this.label2.Text = "Toggle Job Status";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripView,
            this.toolStriRequests,
            this.toolStripManagement,
            this.toolStripDepartment});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1864, 37);
            this.menuStrip1.TabIndex = 94;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripView
            // 
            this.toolStripView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviceRequestsToolStripMenuItem,
            this.clientServicesToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.callToolStripMenuItem,
            this.outstandingCallsToolStripMenuItem});
            this.toolStripView.Name = "toolStripView";
            this.toolStripView.Size = new System.Drawing.Size(65, 33);
            this.toolStripView.Text = "View";
            // 
            // serviceRequestsToolStripMenuItem
            // 
            this.serviceRequestsToolStripMenuItem.Name = "serviceRequestsToolStripMenuItem";
            this.serviceRequestsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.serviceRequestsToolStripMenuItem.Text = "Service Requests";
            this.serviceRequestsToolStripMenuItem.Click += new System.EventHandler(this.serviceRequestsToolStripMenuItem_Click);
            // 
            // clientServicesToolStripMenuItem
            // 
            this.clientServicesToolStripMenuItem.Name = "clientServicesToolStripMenuItem";
            this.clientServicesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.clientServicesToolStripMenuItem.Text = "Client Services";
            this.clientServicesToolStripMenuItem.Click += new System.EventHandler(this.clientServicesToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // callToolStripMenuItem
            // 
            this.callToolStripMenuItem.Name = "callToolStripMenuItem";
            this.callToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.callToolStripMenuItem.Text = "Client Calls";
            this.callToolStripMenuItem.Click += new System.EventHandler(this.callToolStripMenuItem_Click);
            // 
            // outstandingCallsToolStripMenuItem
            // 
            this.outstandingCallsToolStripMenuItem.Name = "outstandingCallsToolStripMenuItem";
            this.outstandingCallsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.outstandingCallsToolStripMenuItem.Text = "Outstanding Calls";
            this.outstandingCallsToolStripMenuItem.Click += new System.EventHandler(this.outstandingCallsToolStripMenuItem_Click);
            // 
            // toolStriRequests
            // 
            this.toolStriRequests.Enabled = false;
            this.toolStriRequests.Name = "toolStriRequests";
            this.toolStriRequests.Size = new System.Drawing.Size(121, 33);
            this.toolStriRequests.Text = "Requests";
            // 
            // toolStripManagement
            // 
            this.toolStripManagement.Enabled = false;
            this.toolStripManagement.Items.AddRange(new object[] {
            "Call Agent",
            "Services Manager",
            "Contract Manager",
            "Client Data manager"});
            this.toolStripManagement.Name = "toolStripManagement";
            this.toolStripManagement.Size = new System.Drawing.Size(121, 33);
            this.toolStripManagement.Text = "Management";
            // 
            // toolStripDepartment
            // 
            this.toolStripDepartment.Enabled = false;
            this.toolStripDepartment.Items.AddRange(new object[] {
            "Client Maintenance",
            "Contract Maintenance",
            "Call Centre",
            "Service Department"});
            this.toolStripDepartment.Name = "toolStripDepartment";
            this.toolStripDepartment.Size = new System.Drawing.Size(121, 33);
            this.toolStripDepartment.Text = "Department";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(195, 817);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 43);
            this.button3.TabIndex = 87;
            this.button3.Text = "View All Requests";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Technician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1864, 1112);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvOutput);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Technician";
            this.ShowIcon = false;
            this.Text = "Technician";
            this.Load += new System.EventHandler(this.Technician_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStriRequests;
        private System.Windows.Forms.ToolStripComboBox toolStripManagement;
        private System.Windows.Forms.ToolStripComboBox toolStripDepartment;
        private System.Windows.Forms.ToolStripMenuItem toolStripView;
        private System.Windows.Forms.ToolStripMenuItem serviceRequestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientServicesToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton rbtnIncomplete;
        private System.Windows.Forms.RadioButton rbtnComplete;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outstandingCallsToolStripMenuItem;
    }
}