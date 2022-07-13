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

        public ContractMaintanance(string contractId, string content)
        {
            this.ContractID = contractId;
            this.Content = content;
        }

        public string ContractID { get => contractId; set => contractId = value; }
        public string Content { get => content; set => content = value; }

        enum CONTRACT_TYPE
        {
            EMPLOYEE, CLIENT
        }
    }
}
