using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace Project_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DataAccessLayer.DataHandler database;

            try
            {
                //database = new DataAccessLayer.DataHandler(@"Server=tcp:sen371.database.windows.net,1433;Initial Catalog=PremierServiceSolutionsDB;Persist Security Info=False;User ID=SEN371Database;Password=Christiaan,Kyle,Hanno,Shammah2022;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                database = new DataAccessLayer.DataHandler();
                lblConnected.Text = "Connected to Database \u2713"; //Successfully connected + ASCII check mark
                lblConnected.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                lblConnected.Text = "Not Connected to Database \u2717"; //n\Not connected + ASCII ballot cross
                lblConnected.ForeColor = System.Drawing.Color.Red;

                return;
            }

            BusinessLogicClasses.PersonAddress address = new BusinessLogicClasses.PersonAddress("4", "123 Teststreet", "Validation Ville", "Certain City", "Fakeland");
            //address.Country = "South Africa";
            //database.InsertObject(address);
            //address.StoreAddress(address.PersonId, address.StreetAddress, address.Suburb, address.City, address.Country);
            //address.UpdateAddress(address.PersonId, address.StreetAddress, address.Suburb,"Johannesburg", address.Country, address.PersonId);

            BusinessLogicClasses.BusinessClient client = new BusinessLogicClasses.BusinessClient("John", "Smith", "5", "Business Client", "is a client", "jon@vodamail.co.za");
            //client.ClientNumber = "123 123 1234";
            //client.DeleteClient("2");
            //client.DeleteClient("3");
            //client.UpdateClientInfo( "John", "Smith", "089 422 2312", "jon@vodamail.co.za", "4");
            //client.StoreClientInfo();

           BusinessLogicClasses.Service service = new BusinessLogicClasses.Service("Test Discription","Service Department");
            //service.ServiceId = "3";
            //database.InsertObject(service);
            //service.StoreService(service.Description);
            //service.UpdateService("1", "This has been updated");
            //database.Delete("3");


            //add new department to database
            BusinessLogicClasses.CallCentre callCenter = new BusinessLogicClasses.CallCentre("request no 1", "Human Resources");
            //callCenter.StoreDepartment(callCenter.DepartmentName);
            //callCenter.UpdateDepartment("New Human Resources", "1");


            //add new technician
            BusinessLogicClasses.Technician technician = new BusinessLogicClasses.Technician("1", "Sarah", "MC-dairmond", "send reports", "Technician", "123 123 123", "tech1@yahoo.com");
            //callCenter.StoreDepartment(callCenter.DepartmentName);
            //technician.CreateTechnician(technician.Name, technician.Surname, "0836454569", "technician@1.co.za");
            //technician.StoreTechnician(technician.Name, technician.Surname, technician.Cell, technician.Email);
            //technician.StoreEmployee(technician.Name, technician.Surname, technician.EmployeeType, technician.Cell, technician.Email);

            BusinessLogicClasses.IndividualClient iclient = new BusinessLogicClasses.IndividualClient("Individual Client", "is a client", "Jack", "Surname", "6", "test@gmail.com");

            //BusinessLogicClasses.Service service = new BusinessLogicClasses.Service("Test Discription")


            SqlDataAdapter adapter = database.RetrieveData("Service");//    <------ Returned data
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0]; ///// <------ Returned data
 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}