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
        public Login()
        {
            InitializeComponent();

            DataAccessLayer.txtFileHandler txt = new DataAccessLayer.txtFileHandler();
            //    string user = txt.users[0].Username + " " + txt.users[0].Password + " " + txt.users[0].EmployeeType;
            //    MessageBox.Show(user);
            BusinessLogicClasses.User newuser = new BusinessLogicClasses.User("3", "fsADFFSJK4%^E#&%^", "Call Manager");
            BusinessLogicClasses.User newuser1 = new BusinessLogicClasses.User("1", "5ecurePassword!", "Client Data Manager");
            txt.WriteToFile();

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
    }
}
