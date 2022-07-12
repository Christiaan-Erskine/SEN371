using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    public class FieldWorker : Employee
    {
        private int agentId, agreementId, contractId, employeeId, addressId;

        public FieldWorker(int agentId, int contractId, int employeeId, int addressId, string name, string surname) : base(employeeId, addressId, name, surname)
        {
            this.agentId = agentId;
            this.contractId = contractId;
            this.employeeId = employeeId;
            this.addressId = addressId;
            this.name = name;
            this.surname = surname;
        }

        public int AgentID { get => agentId; set => agentId = value; }
        public int AgreementID { get => agreementId; set => agreementId = value; }
        public int ContractID { get => contractId; set => contractId = value; }
    }
}
