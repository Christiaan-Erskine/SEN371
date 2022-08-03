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
    public partial class Search : Form
    {
        public string activeTable = "Client";
        public Search()
        {
            InitializeComponent();

            DataAccessLayer.DataHandler dh = new DataAccessLayer.DataHandler();
            SqlDataAdapter adapter = dh.RetrieveData("Client");
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvOutput.DataSource = ds.Tables[0]; // On start form shows client table
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void cbbFields_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* cbbFields.Items.Clear();

            for (int i = 0; i < dgvOutput.Columns.Count; i++)
            {
                cbbFields.Items.Add(dgvOutput.Columns[i].HeaderText);
            }*/
        }

        private void cbbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAccessLayer.DataHandler dh = new DataAccessLayer.DataHandler();
            SqlDataAdapter adapter = dh.RetrieveData(cbbTable.Text);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvOutput.DataSource = ds.Tables[0];

            cbbFields.Items.Clear();
            for (int i = 0; i < dgvOutput.Columns.Count; i++)
            {
                cbbFields.Items.Add(dgvOutput.Columns[i].HeaderText);
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string condition = cbbFields.Text + " = '" + tbxSearch.Text + "'";
            //MessageBox.Show(condition);
            try
            {
                DataAccessLayer.DataHandler dh = new DataAccessLayer.DataHandler();
                SqlDataAdapter adapter = dh.RetrieveData(cbbTable.Text, condition);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgvOutput.DataSource = ds.Tables[0];
            }
            catch { }


        }
    }
}
