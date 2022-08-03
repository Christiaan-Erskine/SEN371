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
    public partial class RunQuery : Form
    {
        public RunQuery()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            DataAccessLayer.DataHandler dh = new DataAccessLayer.DataHandler();
            SqlDataAdapter adapter = dh.RetrieveData("EmployeeDetails", "DepartmentName = 'Contract Maintenance'");
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            
            try
            {
                dh.sqlQuery(richTextBox1.Text);
                richTextBox2.AppendText(Environment.NewLine + "Success");
            }
            catch(Exception ex)
            {
                dh.sqlQuery(richTextBox1.Text);
                richTextBox2.AppendText(Environment.NewLine + "Failure");
                MessageBox.Show(ex.Message);
            }

        }
    }
}
