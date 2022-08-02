using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_1.PresentationLayer
{
    public partial class CallCenterEmployee : Form
    {
        BusinessLogicClasses.BusinessClient client = new BusinessLogicClasses.BusinessClient();
        public string activeTable = "Call"; //The active table will be used to CRUD with the correct table, can be used for dynamic fields with on click if statement
        public CallCenterEmployee()
        {
            InitializeComponent();

            BusinessLogicClasses.Call call = new BusinessLogicClasses.Call();
            SqlDataAdapter adapter = call.GetInfo();
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvOutput.DataSource = ds.Tables[0];
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void cbbView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Problem problem = new Problem();
            problem.Show();
        }

        private void callHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusinessLogicClasses.Call call = new BusinessLogicClasses.Call();
            SqlDataAdapter adapter = call.GetInfo();
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvOutput.DataSource = ds.Tables[0];
            activeTable = "Call";
        }

        private void clientInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccessLayer.DataHandler dh = new DataAccessLayer.DataHandler();
            SqlDataAdapter adapter = dh.RetrieveData("Client");
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvOutput.DataSource = ds.Tables[0];
            activeTable = "Client";
        }

        private void CallCenterEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            PresentationLayer.ManageCall callManager = new PresentationLayer.ManageCall();
            callManager.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (client.ClientId == null)
            {
                MessageBox.Show("Please select a value on the table");
            }
            else
            {
                client.UpdateClient(txtName.Text, txtSurname.Text, txtNumber.Text, txtEmail.Text, client.ClientId);
            }
            
        }

        private void dgvOutput_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (activeTable == "Client")
            {
                client.ClientId = dgvOutput.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = client.Name = dgvOutput.CurrentRow.Cells[1].Value.ToString();
                txtSurname.Text = client.Surname = dgvOutput.CurrentRow.Cells[2].Value.ToString();
                txtNumber.Text = client.ClientNumber = dgvOutput.CurrentRow.Cells[3].Value.ToString();
                txtEmail.Text = client.Email = dgvOutput.CurrentRow.Cells[4].Value.ToString();
            }
        }
        private void dgvOutput_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //This can be used in both mouse and menu navigation
            //Error when changing tables, unselect on button press for those buttons

            try
            {
                if (activeTable == "Client")
                {
                    client.ClientId = dgvOutput.CurrentRow.Cells[0].Value.ToString();
                    txtName.Text = client.Name = dgvOutput.CurrentRow.Cells[1].Value.ToString();
                    txtSurname.Text = client.Surname = dgvOutput.CurrentRow.Cells[2].Value.ToString();
                    txtNumber.Text = client.ClientNumber = dgvOutput.CurrentRow.Cells[3].Value.ToString();
                    txtEmail.Text = client.Email = dgvOutput.CurrentRow.Cells[4].Value.ToString();
                }
            }
            catch(Exception error) 
            {
                MessageBox.Show(error.Message);
            }


        }
        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
