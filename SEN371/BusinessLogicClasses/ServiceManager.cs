using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    internal class ServiceManager : Employee
    {
        private string service;
        private string employeeID;

        public string Service { get => service; set => service = value; }
        public string EmployeeID { get => employeeID; set => employeeID = value; }

        public ServiceManager(string service, string employeeID, string employeeId, string managerName, string managerSurname, PersonAddress managerAddress) : base(employeeId, managerName, managerSurname, managerAddress)
        {
            this.service = service;
            this.EmployeeID = employeeID;
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
