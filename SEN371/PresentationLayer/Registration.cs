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
        //ToDo
        //Register Employee = new employee in database
        //Fix Validation
        //Sometimes EmployeeType is not saved
        //Duplications in txt file, issue in txtFileHandler.cs
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
                    BusinessLogicClasses.User newUser = new BusinessLogicClasses.User(txtUsername.Text,txtPass.Text,cmbEmplType.Text);
                    DataAccessLayer.txtFileHandler th = new DataAccessLayer.txtFileHandler();
                    th.users.Add(newUser);
                    th.WriteToFile();
                }
                
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally //Errors about NULL dields even if everything has been filled, disabled for testing
            {
                
                
                /*
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

                //}*/
            }
            
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
