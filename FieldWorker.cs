using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    public class FieldWorker : Employee
    {
        private int agentID, agreementID, contractID, employeeID, addressID;
        private string name, surname;

        public FieldWorker(int agentID, int contractID, int employeeID, int addressID, string name, string surname) : base(employeeID, addressID, name, surname)
        {
            this.agentID = agentID;
            this.agreementID = agreementID;
            this.contractID = contractID;
            this.employeeID = employeeID;
            this.addressID = addressID;
            this.name = name;
            this.surname = surname;
        }

        public int AgentID { get => agentID; set => agentID = value; }
        public int AgreementID { get => agreementID; set => agreementID = value; }
        public int ContractID { get => contractID; set => contractID = value; }
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public int AddressID { get => addressID; set => addressID = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
    }
}
