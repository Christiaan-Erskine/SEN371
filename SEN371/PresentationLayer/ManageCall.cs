using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Project_1.PresentationLayer
{
    public partial class ManageCall : Form
    {
        public ManageCall()
        {
            InitializeComponent();
        }

        bool timerStarted = false;
        long starTime = 0;
        long stopTime = 0;

        private void btnStartRecording_Click(object sender, EventArgs e)
        {
            if (!timerStarted)
            {
                timerStarted = true;
                starTime = DateTime.Now.Ticks;
                timer.Start();
            }
        }

        private void btnStopRecording_Click(object sender, EventArgs e)
        {
            if (timerStarted)
            {
                timerStarted = false;
                stopTime = DateTime.Now.Ticks;
                timer.Stop();
            }
        }

        private void btnOpenRecording_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveRecording_Click(object sender, EventArgs e)
        {

        }
       
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            var des = TextBoxProblemDescription.Text.TrimStart().TrimEnd();
           
            if (des.Length == 0)
            {
                MessageBox.Show("Please enter a problem description");
                return;
            }
            var id = Globals.empId;

            //agent id is missing here
            //BusinessLogicClasses.Call call = new BusinessLogicClasses.Call(new DateTime(starTime), new DateTime(stopTime), "", TextBoxProblemDescription.Text);

           // call.StoreCall();
                  
        }

        private void btnStartCall_Click(object sender, EventArgs e)
        {

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {

        }

        private void btnChooseClient_Click(object sender, EventArgs e)
        {

        }
        
        private void btnnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer_Tick(object sender, EventArgs e)     
        {
            TextBoxTimer.Text = new DateTime(DateTime.Now.Ticks - starTime).ToString("HH:mm:ss:ff");                                       
        }

        private void ManageCall_Load(object sender, EventArgs e)
        {

        }
    }
}
