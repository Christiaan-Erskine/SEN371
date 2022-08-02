using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1.PresentationLayer
{
    public partial class CallCenterEmployee : Form
    {
        public CallCenterEmployee()
        {
            InitializeComponent();
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
        {/*
            BusinessLogicClasses.Call call = new BusinessLogicClasses.Call();
            SqlDataAdapter call = bclient.GetInfo();
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvOutput.DataSource = ds.Tables[0]; */
        }
    }
}
