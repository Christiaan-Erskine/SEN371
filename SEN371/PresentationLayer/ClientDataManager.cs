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
    //ToDo:
    //Fix Delete (Connected to Person Address)
    //Show Employee types / departments
    //RetrieveData Function, too much repeating code with only difference being string  
    //Impliment Add, should be easy
    //Update SQL Adapter on refresh
    public partial class ClientDataManager : Form
    {
        public string activeTable = "Client"; //The active table will be used to CRUD with the correct table, can be used for dynamic fields with on click if statement
        BusinessLogicClasses.BusinessClient bclient = new BusinessLogicClasses.BusinessClient();
        public ClientDataManager()
        {
            InitializeComponent();
        }

        private void ClientDataManager_Load(object sender, EventArgs e)
        {
            DataAccessLayer.DataHandler dh = new DataAccessLayer.DataHandler();
            SqlDataAdapter adapter = dh.RetrieveData("Client");
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvOutput.DataSource = ds.Tables[0]; // On start form shows client table
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Problem problem = new Problem();
            problem.Show();
        }

        private void lblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PresentationLayer.Login login = new PresentationLayer.Login();
            login.Show();
            this.Close();
        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            PresentationLayer.RunQuery runQuery = new PresentationLayer.RunQuery();
            runQuery.Show();
        }

        private void businessClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccessLayer.DataHandler dh = new DataAccessLayer.DataHandler();
            BusinessLogicClasses.BusinessClient bclient = new BusinessLogicClasses.BusinessClient();
            SqlDataAdapter adapter = bclient.GetInfo();
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvOutput.DataSource = ds.Tables[0];
            activeTable = "Client";
        }

        private void clientsTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccessLayer.DataHandler dh = new DataAccessLayer.DataHandler();
            SqlDataAdapter adapter = dh.RetrieveData("Client");
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvOutput.DataSource = ds.Tables[0];
            activeTable = "Client";
        }

        private void individualClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusinessLogicClasses.IndividualClient iclient = new BusinessLogicClasses.IndividualClient();
            SqlDataAdapter adapter = iclient.GetInfo();
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvOutput.DataSource = ds.Tables[0];
            activeTable = "Client";
        }

        private void employeeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvOutput.ClearSelection();
            DataAccessLayer.DataHandler dh = new DataAccessLayer.DataHandler();
            SqlDataAdapter adapter = dh.RetrieveData("Employee");
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvOutput.DataSource = ds.Tables[0];
            activeTable = "Employee";
        }

        private void contractsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccessLayer.DataHandler dh = new DataAccessLayer.DataHandler();
            SqlDataAdapter adapter = dh.RetrieveData("Contract");
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvOutput.DataSource = ds.Tables[0];
            activeTable = "Contract";
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusinessLogicClasses.Service service = new BusinessLogicClasses.Service();
            SqlDataAdapter adapter = service.GetInfo();
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvOutput.DataSource = ds.Tables[0];
            activeTable = "Service";
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            DataAccessLayer.DataHandler dh = new DataAccessLayer.DataHandler();
            SqlDataAdapter adapter = dh.RetrieveData("Contract"); //can't use contract parent object
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvOutput.DataSource = ds.Tables[0];
            activeTable = "Contract";
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            BusinessLogicClasses.Service service = new BusinessLogicClasses.Service();
            SqlDataAdapter adapter = service.GetInfo();
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvOutput.DataSource = ds.Tables[0];
            activeTable = "Service";
        }

        private void toolStripView_Click(object sender, EventArgs e)
        {
            //Hard to get values of menu
        }

        private void btnUpdtSelecct_Click(object sender, EventArgs e)
        {
            if (activeTable == "Client")
            {
                //MessageBox.Show("Newly Created Client Object:\n" + bclient.ClientId + " " + bclient.Name + " " + bclient.Surname + " " + bclient.ClientNumber + " " + bclient.Email + " " + bclient.ClientType);
                bclient.UpdateClient(txtName.Text, txtSurname.Text, txtCellPhone.Text, txtEmail.Text, txtType.Text, bclient.ClientId); //User has no ability to change id
                //(string Name, string Surname, string Cellphone, string Email, string NewType, string ClientId)

                //Update shows valid SQL query, but does not make changes in the database
            }

            //To see changes in database, has no effect
            //System.Threading.Thread.Sleep(5000);
            this.Refresh();
            dgvOutput.Update();
            dgvOutput.Refresh();

        }

        private void dgvOutput_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Too slow, need to wait 2-3 seconds before a new row can be selected
        }

        private void dgvOutput_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Only works for mouse navigation
        }

        private void btnDelSelect_Click(object sender, EventArgs e)
        {
            if (activeTable == "Client")
            {
                bclient.DeleteClient(bclient.ClientId);
                //Doesn't delete due to Person Address, ask Christiaan
            }
        }

        private void dgvOutput_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //This can be used in both mouse and menu navigation
            //Error when changing tables, unselect on button press for those buttons

            dgvOutput.Update();
            dgvOutput.Refresh();

            try
            {
                if (activeTable == "Client")
                {
                    bclient.ClientId = dgvOutput.CurrentRow.Cells[0].Value.ToString();
                    txtName.Text = bclient.Name = dgvOutput.CurrentRow.Cells[1].Value.ToString();
                    txtSurname.Text = bclient.Surname = dgvOutput.CurrentRow.Cells[2].Value.ToString();
                    txtCellPhone.Text = bclient.ClientNumber = dgvOutput.CurrentRow.Cells[3].Value.ToString();
                    txtEmail.Text = bclient.Email = dgvOutput.CurrentRow.Cells[4].Value.ToString();
                    txtType.Text = bclient.ClientType = dgvOutput.CurrentRow.Cells[5].Value.ToString();
                }
            }catch {/* Lol */}


        }

        private void btnAddSelect_Click(object sender, EventArgs e)
        {
            bclient.StoreClient(txtName.Text, txtSurname.Text, txtCellPhone.Text, txtEmail.Text, txtType.Text);
        }
    }
}
