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
                string userType = cmbEmplType.Text;
                if (password != conPass)
                {
                    MessageBox.Show("Please input mathching passwords");
                }
                if (password == null || username == null || username.Length <= 2 || password.Length <= 2 || userType == null || userType.Length <= 2)
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
                Login login = new Login();
                login.Show();
                //closing for efficiency
                this.Close();
            }
            
        }
    }
}
