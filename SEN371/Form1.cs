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
                DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
                database.Insert("Address", new string[] { "address", "suburb", "city", "country" }, new string[] { "10th Vaenu", "Edenvale", "Gauteng", "South Africa" });
                SqlDataAdapter adapter = database.viewallAddress();
                DataTable ds = new DataTable();
                adapter.Fill(ds);

                foreach (DataRow dr in ds.Rows)
                {
                    ListViewItem list = new ListViewItem(dr["addressid"].ToString());
                    list.SubItems.Add(dr["address"].ToString());
                    list.SubItems.Add(dr["suburb"].ToString());
                    list.SubItems.Add(dr["city"].ToString());
                    list.SubItems.Add(dr["country"].ToString());
                    listView1.Items.Add(list);
                }
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
