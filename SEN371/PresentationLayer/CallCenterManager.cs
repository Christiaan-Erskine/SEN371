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
        //active = display table
        string activeTable = "Client"; //The active table will be used to CRUD with the correct table, can be used for dynamic fields with on click if statement
       
        //seleceted = usert selected insert option
        string selectedTable = "Client";

        
        BusinessLogicClasses.BusinessClient BusinessClient = new BusinessLogicClasses.BusinessClient();
        BusinessLogicClasses.Employee employee = new BusinessLogicClasses.ClientDataManager();


        void SetData()
        {
            if(activeTable == "Client")
            {
                dgvOutput.DataSource = clientBindingSource;
                bindingNavigator1.BindingSource = clientBindingSource;
                selectedTable = radioButtonClient.Checked ? "Client" : "Employee";
            }
            else if (activeTable == "Employee")
            {
                dgvOutput.DataSource = employeeBindingSource;
                bindingNavigator1.BindingSource = employeeBindingSource;
                selectedTable = radioButtonClient.Checked ? "Client" : "Employee";
            }
        }
    
        

        public CallCenterManager()
        {
            InitializeComponent();

            SetData();
        }
  

      
        private void CallCenterManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'premierServiceSolutionsDBDataSet1.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.premierServiceSolutionsDBDataSet1.Employee);
            // TODO: This line of code loads data into the 'premierServiceSolutionsDBDataSet1.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.premierServiceSolutionsDBDataSet1.Client);

        }
    


        private void btnSQL_Click(object sender, EventArgs e)
        {
            ManageCall call = new ManageCall();
            call.Show();
        }

        private void btnProblem_Click(object sender, EventArgs e)
        {
            Problem problem = new Problem();
            problem.Show();
        }
        

        private void clientsTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeTable = "Client";
            SetData();
        }

        private void employeeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeTable = "Employee";
            SetData();
        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedTable == "Client")
            {
                BusinessClient.StoreClient(clientNameTextBox.Text,clientSurnameTextBox.Text,clientCellPhoneNumberTextBox.Text,clientEmailTextBox.Text,clientTypeTextBox.Text);
            }
            else if (selectedTable == "Employee")
            {
                employee.StoreEmployee(employeeNameTextBox.Text, employeeSurnameTextBox.Text, employeeCellPhoneNumberTextBox.Text, employeeEmailTextBox.Text);
            }
        }

        private void dgvOutput_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (activeTable == "Client")
            {
                BusinessClient.ClientId = dgvOutput.CurrentRow.Cells[0].Value.ToString();
            }
            else if (activeTable == "Employee")
            {
                employee.EmployeeId = dgvOutput.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void radioButtonClient_CheckedChanged(object sender, EventArgs e)
        {
            selectedTable = radioButtonClient.Checked ? "Client" : "Employee";
        }

        private void radioButtonEmployee_CheckedChanged(object sender, EventArgs e)
        {
            selectedTable = radioButtonClient.Checked ? "Client" : "Employee";
        }

        private void btnUpdateSelected_Click(object sender, EventArgs e)
        {
            if (activeTable == "Client")
            {
                //MessageBox.Show("Newly Created Client Object:\n" + bclient.ClientId + " " + bclient.Name + " " + bclient.Surname + " " + bclient.ClientNumber + " " + bclient.Email + " " + bclient.ClientType);
                BusinessClient.UpdateClient(clientNameTextBox.Text, clientSurnameTextBox.Text, clientCellPhoneNumberTextBox.Text, clientEmailTextBox.Text, clientTypeTextBox.Text,BusinessClient.ClientId); //User has no ability to change id
                //(string Name, string Surname, string Cellphone, string Email, string NewType, string ClientId)

                //Update shows valid SQL query, but does not make changes in the database
            }
            else if (activeTable == "Employee")
            {                   
                employee.UpdateEmployee(employee.EmployeeId,employeeNameTextBox.Text, employeeSurnameTextBox.Text, employeeCellPhoneNumberTextBox.Text, employeeEmailTextBox.Text);
            }
            
            MessageBox.Show(activeTable);
            //To see changes in database, has no effect
            //System.Threading.Thread.Sleep(5000);
            this.Refresh();
            dgvOutput.Update();
            dgvOutput.Refresh();
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (activeTable == "Client")
            {
                BusinessClient.DeleteClient(BusinessClient.ClientId);
                //Doesn't delete due to Person Address, ask Christiaan
            }
            else if (activeTable == "Employee")
            {
                employee.DeleteEmployee(employee.EmployeeId);
            }

            this.Refresh();
            dgvOutput.Update();
            dgvOutput.Refresh();
        }
    }
}
