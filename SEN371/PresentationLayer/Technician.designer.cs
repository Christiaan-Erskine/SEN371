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
            this.cbbDepartment = new System.Windows.Forms.ComboBox();
            this.cbbManagement = new System.Windows.Forms.ComboBox();
            this.cbbReq = new System.Windows.Forms.ComboBox();
            this.cbbView = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSQL = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbDepartment
            // 
            this.cbbDepartment.AllowDrop = true;
            this.cbbDepartment.FormattingEnabled = true;
            this.cbbDepartment.Location = new System.Drawing.Point(297, 23);
            this.cbbDepartment.Name = "cbbDepartment";
            this.cbbDepartment.Size = new System.Drawing.Size(89, 21);
            this.cbbDepartment.TabIndex = 24;
            this.cbbDepartment.Text = "Department";
            // 
            // cbbManagement
            // 
            this.cbbManagement.AllowDrop = true;
            this.cbbManagement.FormattingEnabled = true;
            this.cbbManagement.Location = new System.Drawing.Point(202, 23);
            this.cbbManagement.Name = "cbbManagement";
            this.cbbManagement.Size = new System.Drawing.Size(89, 21);
            this.cbbManagement.TabIndex = 23;
            this.cbbManagement.Text = "Management";
            // 
            // cbbReq
            // 
            this.cbbReq.AllowDrop = true;
            this.cbbReq.FormattingEnabled = true;
            this.cbbReq.Location = new System.Drawing.Point(107, 23);
            this.cbbReq.Name = "cbbReq";
            this.cbbReq.Size = new System.Drawing.Size(89, 21);
            this.cbbReq.TabIndex = 22;
            this.cbbReq.Text = "Requests";
            // 
            // cbbView
            // 
            this.cbbView.AllowDrop = true;
            this.cbbView.FormattingEnabled = true;
            this.cbbView.Location = new System.Drawing.Point(12, 23);
            this.cbbView.Name = "cbbView";
            this.cbbView.Size = new System.Drawing.Size(89, 21);
            this.cbbView.TabIndex = 21;
            this.cbbView.Text = "View";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Logged-In as: Technician";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(430, 13);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(325, 31);
            this.lblLogo.TabIndex = 19;
            this.lblLogo.Text = "Premier Service Solutions";
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 21);
            this.comboBox1.TabIndex = 63;
            this.comboBox1.Text = "Set Job Status";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 64;
            // 
            // dgvOutput
            // 
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Location = new System.Drawing.Point(195, 89);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.Size = new System.Drawing.Size(487, 323);
            this.dgvOutput.TabIndex = 65;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 415);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 84;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 85;
            this.button1.Text = "Close Request";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(757, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 29);
            this.button2.TabIndex = 88;
            this.button2.Text = "Run Query";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(757, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 29);
            this.button3.TabIndex = 87;
            this.button3.Text = "View All Requests";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnSQL
            // 
            this.btnSQL.Location = new System.Drawing.Point(757, 101);
            this.btnSQL.Name = "btnSQL";
            this.btnSQL.Size = new System.Drawing.Size(107, 29);
            this.btnSQL.TabIndex = 86;
            this.btnSQL.Text = "See Job Status";
            this.btnSQL.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(757, 395);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 29);
            this.button4.TabIndex = 89;
            this.button4.Text = "Log Problem";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Technician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSQL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvOutput);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cbbDepartment);
            this.Controls.Add(this.cbbManagement);
            this.Controls.Add(this.cbbReq);
            this.Controls.Add(this.cbbView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLogo);
            this.Name = "Technician";
            this.Text = "Technician";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbDepartment;
        private System.Windows.Forms.ComboBox cbbManagement;
        private System.Windows.Forms.ComboBox cbbReq;
        private System.Windows.Forms.ComboBox cbbView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSQL;
        private System.Windows.Forms.Button button4;
    }
}