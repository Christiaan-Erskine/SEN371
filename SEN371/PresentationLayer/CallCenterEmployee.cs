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
        public string activeTable = "Call"; //The active table will be used to CRUD with the correct table, can be used for dynamic fields with on click if statement
        public CallCenterEmployee()
        {
            InitializeComponent();

            //BusinessLogicClasses.Call call = new BusinessLogicClasses.Call();
            //SqlDataAdapter adapter = call.GetInfo();
            //DataSet ds = new DataSet();
            //adapter.Fill(ds);
            //dgvOutput.DataSource = ds.Tables[0];
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
            // TODO: This line of code loads data into the 'premierServiceSolutionsDBDataSet.PersoneAddressDetails' table. You can move, or remove it, as needed.
            this.personeAddressDetailsTableAdapter.Fill(this.premierServiceSolutionsDBDataSet.PersoneAddressDetails);
            // TODO: This line of code loads data into the 'premierServiceSolutionsDBDataSet.PersoneAddressDetails' table. You can move, or remove it, as needed.
            this.personeAddressDetailsTableAdapter.Fill(this.premierServiceSolutionsDBDataSet.PersoneAddressDetails);     
        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            PresentationLayer.ManageCall callManager = new PresentationLayer.ManageCall();
            callManager.Show();
        }
    }
}
