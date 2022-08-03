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

        string selectedTable;

        BusinessLogicClasses.BusinessClient BusinessClient = new BusinessLogicClasses.BusinessClient();
        BusinessLogicClasses.Call call = new BusinessLogicClasses.Call();

        
        public CallCenterEmployee()
        {
            InitializeComponent();

            //BusinessLogicClasses.Call call = new BusinessLogicClasses.Call();
            //SqlDataAdapter adapter = call.GetInfo();
            //DataSet ds = new DataSet();
            //adapter.Fill(ds);
            //dgvOutput.DataSource = ds.Tables[0];

            dgvOutput.DataSource = personAddressDetailsBindingSource;

            selectedTable = radioButtonClient.Checked ? "Client" : "Employee";


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
            //BusinessLogicClasses.Call call = new BusinessLogicClasses.Call();
            //SqlDataAdapter adapter = call.GetInfo();
            //DataSet ds = new DataSet();
            //adapter.Fill(ds);
            //dgvOutput.DataSource = ds.Tables[0];

            dgvOutput.DataSource = callBindingSource;
            dgvOutput.Refresh();

            activeTable = "Call";
        }

        private void clientInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DataAccessLayer.DataHandler dh = new DataAccessLayer.DataHandler();
            //SqlDataAdapter adapter = dh.RetrieveData("Client");
            //DataSet ds = new DataSet();
            //adapter.Fill(ds);       
            //dgvOutput.DataSource = ds.Tables[0];


            dgvOutput.DataSource = personAddressDetailsBindingSource;
            dgvOutput.Refresh();

            activeTable = "Client";
        }

        private void CallCenterEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'premierServiceSolutionsDBDataSet1.Call' table. You can move, or remove it, as needed.
            this.callTableAdapter.Fill(this.premierServiceSolutionsDBDataSet1.Call);
            this.personAddressDetailsTableAdapter.Fill(this.premierServiceSolutionsDBDataSet1.PersonAddressDetails);                   
        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            PresentationLayer.ManageCall callManager = new PresentationLayer.ManageCall();
            callManager.Show();
        }

        private void callCentreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //implementation needed
        }

        private void serviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //implementation needed
        }

        private void radioButtonClient_CheckedChanged(object sender, EventArgs e)
        {
            selectedTable = radioButtonClient.Checked ? "Client" : "Employee";
        }

        private void radioButtonEmployee_CheckedChanged(object sender, EventArgs e)
        {
            selectedTable = radioButtonClient.Checked ? "Client" : "Employee";
        }

        private void btnSubmitNewClient_Click(object sender, EventArgs e)
        {
            //insert new client or employee

            if(selectedTable == "Client")
            {

                //client_TypeTextBox.Text = "";


                //BusinessLogicClasses.Client client = new BusinessLogicClasses.


                DataAccessLayer.DataHandler dataHandler = new DataAccessLayer.DataHandler();

                dataHandler.Insert("CLient", new[] { ("Name", nameTextBox.Text), ("Surname", surnameTextBox.Text), ("CellPhoneNumber", cell_NumberTextBox.Text), ("Email", emailTextBox.Text), ("ClientType", client_TypeTextBox.Text) });

            }
            else
            {
                //BusinessLogicClasses.Employee employee = null;

                //switch (textBoxEmployeeType.Text)
                //{                                   
                //    case "Technician":
                //        employee = new BusinessLogicClasses.Technician();
                //        break;
                //    case "Receptionist":
                //        employee = new BusinessLogicClasses.ClientDataManager();
                //        break;
                //    case "Administrator":
                //        employee = new BusinessLogicClasses.ServiceManager();
                //        break;
                //    case "Manager":
                //        employee = new BusinessLogicClasses.ContractManager();
                //        break;                      
                //    default:
                //        MessageBox.Show("Please select an valid employee type");
                //        return;
                //}

                //more correct way commented above this, could not get it working for now              
                DataAccessLayer.DataHandler dataHandler = new DataAccessLayer.DataHandler();

                dataHandler.Insert("Employee", new[] { ("Name", nameTextBox.Text), ("Surname", surnameTextBox.Text), ("CellPhoneNumber", cell_NumberTextBox.Text), ("Email", emailTextBox.Text) });           
            }           
        }
  
    }
}
