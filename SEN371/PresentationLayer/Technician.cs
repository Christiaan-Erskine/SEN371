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
        public BusinessLogicClasses.Call call = new BusinessLogicClasses.Call();

        public string activeTable = "Call";
        public Technician()
        {
            InitializeComponent();

            DataAccessLayer.DataHandler dh = new DataAccessLayer.DataHandler();
            SqlDataAdapter adapter = dh.RetrieveData("Call");
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
            try
            {
                if (activeTable == "Call")
                {
                    rbtnComplete.Enabled = true;
                    rbtnIncomplete.Enabled = true;

                    call.CallId = dgvOutput.CurrentRow.Cells[0].Value.ToString();
                    //call.CallStarted = dgvOutput.CurrentRow.Cells[1].Value; //Converting back from SQL DateTime causes issues, should not change anyways 
                    //call.CallEnded = dgvOutput.CurrentRow.Cells[2].Value;
                    call.Description = dgvOutput.CurrentRow.Cells[3].Value.ToString();
                    call.AgentId = dgvOutput.CurrentRow.Cells[4].Value.ToString();
                    call.ClientId = dgvOutput.CurrentRow.Cells[5].Value.ToString();
                }
                else
                {
                    rbtnComplete.Enabled = false;
                    rbtnIncomplete.Enabled = false;
                }
            }
            catch { }

        }

        private void callToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccessLayer.DataHandler dh = new DataAccessLayer.DataHandler();
            SqlDataAdapter adapter = dh.RetrieveData("Call");
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvOutput.DataSource = ds.Tables[0];
            activeTable = "Call";
        }

        private void outstandingCallsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccessLayer.DataHandler dh = new DataAccessLayer.DataHandler();
            SqlDataAdapter adapter = dh.RetrieveData("Call", "NOT ProblemDescription = 'Resolved'");
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvOutput.DataSource = ds.Tables[0];
            activeTable = "Call";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string description = "Resolved";
            if (rbtnIncomplete.Checked == true)
                description = call.Description;
            if (description == "Resolved" && rbtnIncomplete.Checked == true)
                description = "Unresolved";
            else
                description = "Resolved";

            call.UpdateCall(description, call.AgentId, call.CallId);
        }

        private void dgvOutput_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PresentationLayer.Search search = new PresentationLayer.Search();
            search.Show();
        }
    }
}
