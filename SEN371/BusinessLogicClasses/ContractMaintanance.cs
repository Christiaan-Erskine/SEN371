using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    public class ContractMaintanance
    {
        //Renamed from "Contract" to be consistent with the Class Diagram
        private string contractId;
        private string content;
        private string availability;

        public ContractMaintanance(string contractId, string content)
        {
            this.ContractID = contractId;
            this.Content = content;
        }

        public string ContractID { get => contractId; set => contractId = value; }
        public string Content { get => content; set => content = value; }
        public string Availability { get => availability; set => availability = value; }

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
