using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Project_1.BusinessLogicClasses
{
    public class Technician : Employee
    {
        private string jobList;
        private string employeeId;

        public string JobList { get => jobList; set => jobList = value; }
        public string EmployeeId2 { get => employeeId; set => employeeId = value; }

        public Technician(string employeeId, string name, string surname, string jobList, string cell, string email) : base( employeeId, name, surname, cell, email)
        {
            this.jobList = jobList;
        }

        public Technician(string employeeId):base(employeeId)
        {
            this.EmployeeId2 = employeeId;
            SqlDataAdapter empID = getTechnicianInfo(employeeId);
            DataSet EmpTable = new DataSet();
            empID.Fill(EmpTable, "Employee");
            //var adaptor = RetrieveData(type.Name, condition);
            //adaptor.Fill(ds);
            DataTable table = EmpTable.Tables[0];
            var col = table.Columns[0];
            MessageBox.Show(col.ToString());

            //empID.
        }


        //CRUD methods
        public void StoreTechnician(/*string employeeId,*/ string name, string surname, /*string jobList,*/ string cellPhoneNumber, string email)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Insert("Employee", new[] {("Name", name), ("Surname", surname), ("CellPhoneNumber", cellPhoneNumber), ("Email", email) });
        }

        public void UpdateTechnician(string technicianId, string name, string surname, string cellPhoneNumber, string email)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Update("Employee", new[] {("Name", name), ("Surname", surname), ("CellPhoneNumber", cellPhoneNumber), ("Email", email) }, ("EmployeeId = " + technicianId));
        }

        public void DeleteTechnician(string technitianId)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Delete("Employee", ("EmployeeId = " + technitianId));
        }

        public SqlDataAdapter getTechnicianInfo(string technicianId)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            return database.RetrieveData("Employee", ("EmployeeId = " + technicianId));
        }



        public SqlDataAdapter GetInfo()
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            return database.RetrieveData("Employee");
        }
        public SqlDataAdapter GetInfo(string technicianId)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            return database.RetrieveData("Employee", ("technicianId = " + technicianId));
        }



        public void AssignJobRequest(string requestId, string technicianId)
        {
            //Assigns a job request to a technitian
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Update("ServiceRequest",new [] {("TechnicianId" , technicianId)}, ("RequestId = "  + requestId));
        }

        public SqlDataAdapter GetJobStatus(string requestId)
        {         
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            return database.RetrieveData("ServiceRequest", ("RequestId == "  + requestId));          
        }

        public void SetJobStatus(string requestId, string jobStatus)
        {
            //update values to datahandler
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Update("ServiceRequest",new [] {("JobStatus" , jobStatus)}, ("RequestId == "  + requestId));
        }
    }
}
