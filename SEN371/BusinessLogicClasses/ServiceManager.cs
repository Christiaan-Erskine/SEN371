using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project_1.BusinessLogicClasses
{
    internal class ServiceManager : Employee
    {
        private string service;
        private string employeeID;

        public string Service { get => service; set => service = value; }
        public string EmployeeID { get => employeeID; set => employeeID = value; }

        public ServiceManager(string service, string employeeID, string employeeId, string managerName, string managerSurname, string employeeType, string cell, string email) : base(employeeId, managerName, managerSurname, employeeType, cell, email)
        {
            this.service = service;
            this.EmployeeID = employeeID;
        }

       //CRUD methods
        public void CreateServiceManager(string name, string surname,  string cellPhoneNumber, string email)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Insert("Employee", new[] {("Name", name), ("Surname", surname), ("EmployeeType", "ServiceManager"), ("CellPhoneNumber", cellPhoneNumber), ("Email", email) });
        }

        public void UpdateServiceManager(string serviceManagerId, string name, string surname, string cellPhoneNumber, string email)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Update("Employee", new[] {("Name", name), ("Surname", surname), ("EmployeeType", "ServiceManager"), ("CellPhoneNumber", cellPhoneNumber), ("Email", email) }, ("EmployeeId = " + serviceManagerId));
        }

        public void DeleteServiceManager(string serviceManagerId)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Delete("Employee", ("EmployeeId = " + serviceManagerId));
        }
       

        public SqlDataAdapter GetInfo()
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            return database.RetrieveData("Contract");
        }
        public SqlDataAdapter GetInfo(string serviceManagerId)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            return database.RetrieveData("Employee", ("EmployeeId = " + serviceManagerId));
        }






        public void GetServiceStatus()
        {
            //return type statement to get values from datahandler
        }
        public void GetEmplyeeServices(string EmployeeId)
        {
            //return type statement to get values from datahandler for specific employee
        }
    }
}
