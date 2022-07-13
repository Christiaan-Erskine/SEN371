using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    public class FieldWorker : Employee
    {
        private string agentId, agreementId, contractId, employeeId, addressId;

        public FieldWorker(string agentId, string contractId, string employeeId, string addressId, string name, string surname) : base(employeeId, addressId, name, surname)
        {
            this.agentId = agentId;
            this.contractId = contractId;
            this.employeeId = employeeId;
            this.addressId = addressId;
            this.name = name;
            this.surname = surname;
        }

        public string AgentID { get => agentId; set => agentId = value; }
        public string AgreementID { get => agreementId; set => agreementId = value; }
        public string ContractID { get => contractId; set => contractId = value; }
    }
}
