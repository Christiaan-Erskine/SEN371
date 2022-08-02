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
    public partial class Technician : Form
    {
        public Technician()
        {
            InitializeComponent();
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Technician_Load(object sender, EventArgs e)
        {

        }

        private void cbbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbManagement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbReq_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Problem problem = new Problem();
            problem.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RunQuery runQuery = new RunQuery();
            runQuery.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //BusinessLogicClasses.Technician technician = new BusinessLogicClasses.Technician();
            //callCenter.StoreDepartment(callCenter.DepartmentName);
            //technician.CreateTechnician(technician.Name, technician.Surname, "0836454569", "technician@1.co.za");
            //technician.StoreTechnician(technician.Name, technician.Surname, technician.Cell, technician.Email);
            //technician.StoreEmployee(technician.Name, technician.Surname, technician.EmployeeType, technician.Cell, technician.Email);
        }
    }
}
