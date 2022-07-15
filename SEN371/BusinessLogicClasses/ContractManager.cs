using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public class ContractManager : Employee
    {
        private string contractID;
        private string content;

        private SERVICE_CONTRACT_TYPE ServiceContractType;  //  <--- Populate
        private CONTRACT_STATE ContractState;               //  <--- Populate

        public ContractManager(string contractID, string content,string employeeId,string managerName, string managerSurname, PersonAddress managerAddress) : base(employeeId, managerName, managerSurname, managerAddress)
        {
            this.contractID = contractID;
            this.content = content;
        }

        public string ContractID { get => contractID; set => contractID = value; }
        public string Content { get => content; set => content = value; }
        private SERVICE_CONTRACT_TYPE ServiceContractType1 { get => ServiceContractType; set => ServiceContractType = value; }
        private CONTRACT_STATE ContractState1 { get => ContractState; set => ContractState = value; }



        public enum SERVICE_CONTRACT_TYPE { };
        public enum CONTRACT_STATE { };


        
        void ContractMaintanance()
        {
            //Used to store / update contract data in an external location
        }
    }


}
