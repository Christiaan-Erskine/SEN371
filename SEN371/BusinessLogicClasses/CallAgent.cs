using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public class CallAgent : Employee
    {
        string agentId;
        string agentName;
        string agentSurname;
        string adressId;
        string contractId;

        public CallAgent(string agentId, string agentName, string agentSurname, string adressId, string contractId, string employeeID) : base(employeeID, adressId, agentName, agentSurname)
        {
            this.agentId = agentId;
            this.agentName = agentName;
            this.agentSurname = agentSurname;
            this.adressId = adressId;
            this.contractId = contractId;
        }

        public string AgentId { get => agentId; set => agentId = value; }
        public string AgentName { get => agentName; set => agentName = value; }
        public string AgentSurname { get => agentSurname; set => agentSurname = value; }
        public string AdressId { get => adressId; set => adressId = value; }
        public string ContractId { get => contractId; set => contractId = value; }
    }
}
