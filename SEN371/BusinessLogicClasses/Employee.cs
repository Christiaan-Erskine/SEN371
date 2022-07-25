using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project_1.BusinessLogicClasses
{
    public abstract class Employee : Person
    {
        private string employeeId, employeeType, cell, email;

        private string serviceDeoartmentId;

        protected Employee
            (
            string employeeId,
            string name,
            string surname,
            string employeeType,
            string cell,
            string email) : base(name, surname)
        {
            this.EmployeeId = employeeId;
            this.Name = name;
            this.Surname = surname;
            this.email = email;
            this.EmployeeType = employeeType;
            this.Cell = cell;
        }

        public string EmployeeId { get => EmployeeId1; set => EmployeeId1 = value; }
        public string ServiceDeoartmentId { get => serviceDeoartmentId; set => serviceDeoartmentId = value; }
        public string EmployeeId1 { get => employeeId; set => employeeId = value; }
        public string EmployeeType { get => employeeType; set => employeeType = value; }
        public string Cell { get => cell; set => cell = value; }
        public string Email { get => email; set => email = value; }

        public override string toString()
        {
            //Outputs details that all employees have in common
            return "placeholder";
        }

        public void SetDepartmentID(string id)
        {
            this.serviceDeoartmentId = id;            
        }

        public void StoreEmployee(string name, string surname, string employeeType, string cellPhoneNumber, string email)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Insert("Employee", new[] { ("Name", name), ("Surname", surname), ("EmployeeType", employeeType), ("CellPhoneNumber", cellPhoneNumber), ("Email", email) });
        }

        public void UpdateEmployee(string technicianId, string name, string surname, string employeeType, string cellPhoneNumber, string email)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Update("Employee", new[] { ("Name", name), ("Surname", surname), ("EmployeeType", employeeType), ("CellPhoneNumber", cellPhoneNumber), ("Email", email) }, ("EmployeeId = " + technicianId));
        }

        public void DeleteEmployee(string Id)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Delete("Employee", ("EmployeeId = " + Id));
        }




        public SqlDataAdapter GetInfo()
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            return database.RetrieveData(this.GetType().Name);
        }

        public SqlDataAdapter GetInfo(string employeeId)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            return database.RetrieveData(this.GetType().Name, ("employeeId = " + employeeId));
        }

    }
}
