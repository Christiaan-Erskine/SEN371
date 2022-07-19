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
            try
            {
                //ToDo
                //return record as object
                //Object -> Database record
                //Database record -> Object (x21 for each class)


                DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler(@"Data Source=software-engineering371.database.windows.net;Initial Catalog=PremierServiceSolutions;User ID=SEN371Database;Password=Christiaan,Kyle,Hanno,Shammah2022;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


                //database.Insert("Address", new string[] {"streetaddress", "suburb", "city", "country" }, new string[] {"10th_Vaenu", "Edenvale", "Gauteng", "South Africa" });
                //var t = database.Insert("Service", new string[] { "servicedescription" }, new string[] {"AppelKoos"});
                // Insert works, Update Works, Retrieve Works
                //database.oldInsert("Service", new string[] { "servicedescription" }, new string[] { "Orange" });

                database.Update("Service", new DataAccessLayer.FieldValue[] { new DataAccessLayer.FieldValue("servicedescription", "Updated") }, "ServiceId = 5");



                /*UPDATE Customers
                  SET ContactName = 'Alfred Schmidt', City= 'Frankfurt'
                  WHERE CustomerID = 1;*/


                //database.Delete("Service", "Serviceid = 3");

                SqlDataAdapter adapter = database.RetrieveData("Service");//Display Records
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0]; ///// <------ Returned data



                /*foreach (DataTable table in dataSet.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        foreach (object item in row.ItemArray)
                        {
                            // read item
                        }
                    }
                }foreach (DataTable table in dataSet.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        foreach (object item in row.ItemArray)
                        {
                            // read item
                        }
                    }
                }*/




                lblConnected.Text = "Connected to Database \u2713"; //Successfully connected + ASCII check mark
                lblConnected.ForeColor = System.Drawing.Color.Green;
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
                lblConnected.Text = "Not Connected to Database \u2717"; //n\Not connected + ASCII ballot cross
                lblConnected.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    
    }
}
