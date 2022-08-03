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
        public CallCenterManager()
        {
            InitializeComponent();
            //DataAccessLayer.DataHandler dh = new DataAccessLayer.DataHandler();
            //SqlDataAdapter adapter = dh.RetrieveData("Client");
            //DataSet ds = new DataSet();
            //adapter.Fill(ds);
            //dgvOutput.DataSource = ds.Tables[0];
            //activeTable = "Client";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CallCenterManager_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Problem problem = new Problem();
            problem.Show();
        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            ManageCall call = new ManageCall();
            call.Show();
        }

        private void toolStriRequests_Click(object sender, EventArgs e)
        {
          
        }
    }
}
