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
    public partial class Technician : Form
    {
        public string activeTable = "ServiceRequest";
        public Technician()
        {
            InitializeComponent();

            DataAccessLayer.DataHandler dh = new DataAccessLayer.DataHandler();
            SqlDataAdapter adapter = dh.RetrieveData("ServiceRequest");
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvOutput.DataSource = ds.Tables[0];
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Technician_Load(object sender, EventArgs e)
        {

        }

        private void cbbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbManagement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbReq_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Problem problem = new Problem();
            problem.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RunQuery runQuery = new RunQuery();
            runQuery.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataAccessLayer.DataHandler dh = new DataAccessLayer.DataHandler();
            SqlDataAdapter adapter = dh.RetrieveData("ServiceRequest");
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvOutput.DataSource = ds.Tables[0];
            activeTable = "ServiceRequest";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void serviceRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccessLayer.DataHandler dh = new DataAccessLayer.DataHandler();
            SqlDataAdapter adapter = dh.RetrieveData("ServiceRequest");
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvOutput.DataSource = ds.Tables[0];
            activeTable = "ServiceRequest";
        }

        private void clientServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccessLayer.DataHandler dh = new DataAccessLayer.DataHandler();
            SqlDataAdapter adapter = dh.RetrieveData("ClientServices");
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvOutput.DataSource = ds.Tables[0];
            activeTable = "ClientServices";
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccessLayer.DataHandler dh = new DataAccessLayer.DataHandler();
            SqlDataAdapter adapter = dh.RetrieveData("PersonAddressDetails");
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvOutput.DataSource = ds.Tables[0];
            activeTable = "PersonAddressDetails";

        }

        private void dgvOutput_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvOutput_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (activeTable == "ServiceRequest")
            {
                rbtnComplete.Enabled = true;
                rbtnIncomplete.Enabled = true;
            }
            else
            {
                rbtnComplete.Enabled = false;
                rbtnIncomplete.Enabled = false;
            }
        }
    }
}
