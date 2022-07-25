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
            //ToDo
            //return record as object
            //Object -> Database record
            //Database record -> Object (x21 for each class)

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

            BusinessLogicClasses.PersonAddress address = new BusinessLogicClasses.PersonAddress("4", "123 Teststreet", "Validation Ville", "Certtain City", "Fakeland");
            address.Country = "South Africa";

           // database.InsertObject(address);

           //address.StoreAddress(address.PersonId, address.StreetAddress, address.Suburb, address.City, address.Country);

            address.UpdateAddress(address.PersonId, address.StreetAddress, address.Suburb,"Johannesburg", address.Country, address.PersonId);

            //where [Store No] is null

            BusinessLogicClasses.BusinessClient client = new BusinessLogicClasses.BusinessClient("John", "Smith", "5", "Business Client", "is a client", "jon@vodamail.co.za", "JohnsKoekeisbak");
            client.ClientNumber = "123 123 1234";
            //client.DeleteClient("2");
            //client.DeleteClient("3");
            client.UpdateClientInfo( "John", "Smith", "089 422 2312", "jon@vodamail.co.za", "4");



            //client.StoreClientInfo();


            //tuple array of Field and Value
            //database.Insert("Client", new[] { ("name", "Andy"),("surname","kennedy") });
            //database.Insert("PersonAddress", new[] { ("streetaddress", "11th_Vaenu"), ("suburb", "Edenvale"), ("City", "Gauteng"), ("country", "South-Africa"), ("personid","1")});

            //database.Update("Service", new[] { ("servicedescription", "Updated") }, "ServiceId = 5");
            //database.Delete("Service", "Serviceid = 3");



            //Example demonstrating the use of objects:

            //database.InsertObject(new BusinessLogicClasses.PersonAddress("9 FlowerStreet", "Edenvale", "Pretoria", "South-Africa", "1"));
            //var results = database.RetrieveObjects(typeof(BusinessLogicClasses.PersonAddress));


            SqlDataAdapter adapter = database.RetrieveData("PersonAddress");//Display Records
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0]; ///// <------ Returned data

   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}