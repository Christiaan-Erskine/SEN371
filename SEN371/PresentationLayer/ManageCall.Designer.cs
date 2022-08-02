namespace Project_1.PresentationLayer
{
    partial class ManageCall
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnnCancel = new System.Windows.Forms.Button();
            this.btnStartRecording = new System.Windows.Forms.Button();
            this.btnStopRecording = new System.Windows.Forms.Button();
            this.TextBoxTimer = new System.Windows.Forms.TextBox();
            this.btnOpenRecording = new System.Windows.Forms.Button();
            this.btnSaveRecording = new System.Windows.Forms.Button();
            this.btnStartCall = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxProblemDescription = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Manage Call";
            // 
            // btnnCancel
            // 
            this.btnnCancel.Location = new System.Drawing.Point(525, 295);
            this.btnnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnnCancel.Name = "btnnCancel";
            this.btnnCancel.Size = new System.Drawing.Size(70, 31);
            this.btnnCancel.TabIndex = 8;
            this.btnnCancel.Text = "Cancel";
            this.btnnCancel.UseVisualStyleBackColor = true;
            this.btnnCancel.Click += new System.EventHandler(this.btnnCancel_Click);
            // 
            // btnStartRecording
            // 
            this.btnStartRecording.Location = new System.Drawing.Point(18, 66);
            this.btnStartRecording.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartRecording.Name = "btnStartRecording";
            this.btnStartRecording.Size = new System.Drawing.Size(119, 24);
            this.btnStartRecording.TabIndex = 15;
            this.btnStartRecording.Text = "Start Recording";
            this.btnStartRecording.UseVisualStyleBackColor = true;
            this.btnStartRecording.Click += new System.EventHandler(this.btnStartRecording_Click);
            // 
            // btnStopRecording
            // 
            this.btnStopRecording.Location = new System.Drawing.Point(18, 129);
            this.btnStopRecording.Margin = new System.Windows.Forms.Padding(2);
            this.btnStopRecording.Name = "btnStopRecording";
            this.btnStopRecording.Size = new System.Drawing.Size(119, 23);
            this.btnStopRecording.TabIndex = 16;
            this.btnStopRecording.Text = "Stop Recording";
            this.btnStopRecording.UseVisualStyleBackColor = true;
            this.btnStopRecording.Click += new System.EventHandler(this.btnStopRecording_Click);
            // 
            // TextBoxTimer
            // 
            this.TextBoxTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTimer.Location = new System.Drawing.Point(18, 95);
            this.TextBoxTimer.Name = "TextBoxTimer";
            this.TextBoxTimer.ReadOnly = true;
            this.TextBoxTimer.Size = new System.Drawing.Size(119, 29);
            this.TextBoxTimer.TabIndex = 17;
            this.TextBoxTimer.Text = "00:00";
            this.TextBoxTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOpenRecording
            // 
            this.btnOpenRecording.Location = new System.Drawing.Point(18, 171);
            this.btnOpenRecording.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenRecording.Name = "btnOpenRecording";
            this.btnOpenRecording.Size = new System.Drawing.Size(101, 23);
            this.btnOpenRecording.TabIndex = 18;
            this.btnOpenRecording.Text = "Open Recording";
            this.btnOpenRecording.UseVisualStyleBackColor = true;
            this.btnOpenRecording.Click += new System.EventHandler(this.btnOpenRecording_Click);
            // 
            // btnSaveRecording
            // 
            this.btnSaveRecording.Location = new System.Drawing.Point(18, 208);
            this.btnSaveRecording.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveRecording.Name = "btnSaveRecording";
            this.btnSaveRecording.Size = new System.Drawing.Size(101, 24);
            this.btnSaveRecording.TabIndex = 19;
            this.btnSaveRecording.Text = "Save Recording";
            this.btnSaveRecording.UseVisualStyleBackColor = true;
            this.btnSaveRecording.Click += new System.EventHandler(this.btnSaveRecording_Click);
            // 
            // btnStartCall
            // 
            this.btnStartCall.Location = new System.Drawing.Point(214, 283);
            this.btnStartCall.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartCall.Name = "btnStartCall";
            this.btnStartCall.Size = new System.Drawing.Size(84, 43);
            this.btnStartCall.TabIndex = 20;
            this.btnStartCall.Text = "Start Call";
            this.btnStartCall.UseVisualStyleBackColor = true;
            this.btnStartCall.Click += new System.EventHandler(this.btnStartCall_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(324, 283);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(84, 43);
            this.btnDisconnect.TabIndex = 21;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Problem description";
            // 
            // TextBoxProblemDescription
            // 
            this.TextBoxProblemDescription.Location = new System.Drawing.Point(214, 78);
            this.TextBoxProblemDescription.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxProblemDescription.Name = "TextBoxProblemDescription";
            this.TextBoxProblemDescription.Size = new System.Drawing.Size(194, 129);
            this.TextBoxProblemDescription.TabIndex = 24;
            this.TextBoxProblemDescription.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(18, 283);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 43);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(471, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Selected client:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(495, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 28;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(495, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 29;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(496, 152);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Surname";
            // 
            // timer
            // 
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ManageCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 337);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.TextBoxProblemDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnStartCall);
            this.Controls.Add(this.btnSaveRecording);
            this.Controls.Add(this.btnOpenRecording);
            this.Controls.Add(this.TextBoxTimer);
            this.Controls.Add(this.btnStopRecording);
            this.Controls.Add(this.btnStartRecording);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnnCancel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageCall";
            this.Text = "ManageCall";
            this.Load += new System.EventHandler(this.ManageCall_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnnCancel;
        private System.Windows.Forms.Button btnStartRecording;
        private System.Windows.Forms.Button btnStopRecording;
        private System.Windows.Forms.TextBox TextBoxTimer;
        private System.Windows.Forms.Button btnOpenRecording;
        private System.Windows.Forms.Button btnSaveRecording;
        private System.Windows.Forms.Button btnStartCall;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox TextBoxProblemDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer;
    }
}