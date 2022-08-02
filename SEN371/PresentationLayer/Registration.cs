using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1.PresentationLayer
{
    public partial class Registration : Form
    {
        string userType;
        public Registration()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPass.Text;
                string conPass = txtConPass.Text;
                userType = cmbEmplType.Text;
                
                if (password != conPass)
                {
                    MessageBox.Show("Please input mathching passwords");
                }
                else if(password == null || username == null || username.Length <= 2 || password.Length <= 2 || userType == null || userType.Length <= 2)
                {
                    MessageBox.Show("Fields cannot be empty");
                }
                else
                {
                    //Store values in some form of strage
                }
                
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                if(userType == "Call centre")
                {
                    CallCenterEmployee callCenterEmployee = new CallCenterEmployee();
                    callCenterEmployee.Show();
                    this.Close();
                }
                else if (userType == "Technician")
                {
                    //Method to sign user in
                    Technician technician = new Technician();
                    technician.Show();
                    this.Close();
                }
                else if (userType == "Call centre Manager")
                {
                    CallCenterManager callCenterManager = new CallCenterManager();
                    callCenterManager.Show();
                    this.Close();
                }
                else if (userType == "Client Data Manager")
                {
                    ClientDataManager clientDataManager = new ClientDataManager();
                    clientDataManager.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("This user type has not been configured yet");
                }
                //if (userType == "Services Manager")
                //{
                    
                //}
                //if (userType == "Contract Manager")
                //{

                //}
            }
            
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
