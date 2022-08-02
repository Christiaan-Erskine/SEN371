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
            string user = txt.users[1].Username + " " + txt.users[1].Password + " " + txt.users[1].EmployeeType;
            MessageBox.Show(user);
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
