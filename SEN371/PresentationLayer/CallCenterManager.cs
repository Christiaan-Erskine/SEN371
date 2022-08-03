using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//import this to all classes so you can return a sql adapter

namespace Project_1.PresentationLayer
{
    public partial class CallCenterManager : Form
    {
        public string activeTable = "Client"; //The active table will be used to CRUD with the correct table, can be used for dynamic fields with on click if statement
        BusinessLogicClasses.BusinessClient bclient = new BusinessLogicClasses.BusinessClient();
        public CallCenterManager()
        {
            InitializeComponent();
            DataAccessLayer.DataHandler dh = new DataAccessLayer.DataHandler();
            SqlDataAdapter adapter = dh.RetrieveData("Client");
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvOutput.DataSource = ds.Tables[0];
            activeTable = "Client";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CallCenterManager_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Problem problem = new Problem();
            problem.Show();
        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            ManageCall call = new ManageCall();
            call.Show();
        }

        private void toolStriRequests_Click(object sender, EventArgs e)
        {
          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (activeTable == "Client")
            {
                //MessageBox.Show("Newly Created Client Object:\n" + bclient.ClientId + " " + bclient.Name + " " + bclient.Surname + " " + bclient.ClientNumber + " " + bclient.Email + " " + bclient.ClientType);
                bclient.UpdateClient(txtName.Text, txtSurname.Text, txtCellPhone.Text, txtEmail.Text, txtType.Text, bclient.ClientId); //User has no ability to change id
                //(string Name, string Surname, string Cellphone, string Email, string NewType, string ClientId)

                //Update shows valid SQL query, but does not make changes in the database
            }


            dgvOutput.Refresh();
        }
    }
}
