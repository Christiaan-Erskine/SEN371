using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void ViewServices()
        {
            //Outputs services
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
