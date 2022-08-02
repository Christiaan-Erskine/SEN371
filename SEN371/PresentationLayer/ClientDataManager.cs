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
    public partial class ClientDataManager : Form
    {
        public string activeTable = "Client"; //The active table will be used to CRUD with the correct table, can be used for dynamic fields with on click if statement
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
    }
}
