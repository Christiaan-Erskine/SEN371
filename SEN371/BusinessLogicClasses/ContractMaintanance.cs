using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//import this to all classes so you can return a sql adapter

namespace Project_1.BusinessLogicClasses
{
    public class ContractMaintanance : Department
    {
        //Renamed from "Contract" to be consistent with the Class Diagram
        private string contractAvailability;

        public ContractMaintanance(string contractAvailability, string department) : base(department)
        {
            this.contractAvailability = contractAvailability;
        }

        public string ContractAvailability { get => contractAvailability; set => contractAvailability = value; }

        enum CONTRACT_TYPE
        {
            EMPLOYEE, CLIENT
        }

        public SqlDataAdapter ViewServices()
        {
            //Outputs services
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();

            //a way to get client as a object from db can also pass condition (not nessecary for now)
            //database.RetrieveObjects(this.GetType());

            return database.RetrieveData("ContractId");
        }
        public void ViewPerformanceTypes()
        {
            //Outputs performance types
        }
        public void SetAvailibility()
        {
            //Similar to accessor method, changes availibility between predefined values
        }
    }
}
