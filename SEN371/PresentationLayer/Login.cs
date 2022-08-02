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
    public partial class Login : Form
    {
        public BusinessLogicClasses.User currentUser; // The current user information (such as EployeeId) can be passed to different forms
        public Login()
        {
            InitializeComponent();

            //DataAccessLayer.txtFileHandler txt = new DataAccessLayer.txtFileHandler();
            //string user = txt.users[0].Username + " " + txt.users[0].Password + " " + txt.users[0].EmployeeType;
            //MessageBox.Show(user);
            //BusinessLogicClasses.User newuser = new BusinessLogicClasses.User("2", "jim1982", "Call Centre Employee");
            //BusinessLogicClasses.User newuser1 = new BusinessLogicClasses.User("1", "5ecurePassword!", "Client Data Manager");

            //txt.users.Add(newuser1);
            //txt.users.Add(newuser);

            //txt.WriteToFile();
            //txt.AddNewUser(newuser);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPass.Text;
            string employeeType = "";

            DataAccessLayer.txtFileHandler txt = new DataAccessLayer.txtFileHandler();

            for(int i = 0; i < txt.users.Count; i++)
            {
                if (txt.users[i].Username == username && txt.users[i].Password == password)
                {
                    MessageBox.Show("Success, welcome valued " + txt.users[i].EmployeeType +", \n" + "Have a great day!");
                    employeeType = txt.users[i].EmployeeType;
                    this.currentUser = txt.users[i];
                    break;
                }
                else if (txt.users[i].Username == username && txt.users[i].Password != password)
                {
                    MessageBox.Show("Please enter correct password for user #" + username);
                }
                else //more validation
                {
                    //MessageBox.Show("Please enter valid credentials");
                }
            }

            switch(employeeType)
            {
                case "Call Centre Employee":
                    {
                        this.Hide();
                        PresentationLayer.CallCenterEmployee callCenterEmployee = new PresentationLayer.CallCenterEmployee();
                        callCenterEmployee.Show();
                        break;
                    }
                case "Call Centre Manager":
                    {
                        this.Hide();
                        PresentationLayer.CallCenterManager callCenterManager = new PresentationLayer.CallCenterManager();
                        callCenterManager.Show();
                        break;
                    }
                case "Technician":
                    {
                        this.Hide();
                        PresentationLayer.Technician technician = new PresentationLayer.Technician();
                        technician.Show();
                        break;
                    }
                case "Client Data Manager":
                    {
                        this.Hide();
                        PresentationLayer.ClientDataManager callCenterManager = new PresentationLayer.ClientDataManager();
                        callCenterManager.Show();
                        break;
                    }
                case "Contract Manager": // NO SERVICES MANAGER CLASS FORM
                    {
                        this.Hide();
                        PresentationLayer.CallCenterManager callCenterManager = new PresentationLayer.CallCenterManager();
                        callCenterManager.Show();
                        break;
                    }
                case "Services Manager": // NO SERVICES MANAGER CLASS FORM
                    {
                        this.Hide();
                        PresentationLayer.CallCenterManager callCenterManager = new PresentationLayer.CallCenterManager();
                        callCenterManager.Show();
                        break;
                    }
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PresentationLayer.Registration Register = new PresentationLayer.Registration();
            Register.Show(); // Only a popup, Does not close Login
        }
    }
}
