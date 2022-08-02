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
            SqlDataAdapter adapter = dh.RetrieveData("Client WHERE ClienType = Business Client"); // RetrieveData(string table, string condition = "")
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvOutput.DataSource = ds.Tables[0];
        }

        private void clientsTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccessLayer.DataHandler dh = new DataAccessLayer.DataHandler();
            SqlDataAdapter adapter = dh.RetrieveData("Client");
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvOutput.DataSource = ds.Tables[0];
        }

        private void individualClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccessLayer.DataHandler dh = new DataAccessLayer.DataHandler();
            SqlDataAdapter adapter = dh.RetrieveData("Client WHERE ClienType = Individual Client"); // RetrieveData(string table, string condition = "")
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvOutput.DataSource = ds.Tables[0];
        }

        private void employeeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccessLayer.DataHandler dh = new DataAccessLayer.DataHandler();
            SqlDataAdapter adapter = dh.RetrieveData("Employee");
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvOutput.DataSource = ds.Tables[0];
        }

        private void toolStripView_Click(object sender, EventArgs e)
        {

        }
    }
}
