using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//import this to all classes so you can return a sql adapter

namespace Project_1.BusinessLogicClasses
{
    public class ContractManager : Employee
    {
        private string contractID;
        private string content;

        private SERVICE_CONTRACT_TYPE ServiceContractType;  //  <--- Populate
        private CONTRACT_STATE ContractState;               //  <--- Populate

        public ContractManager(string contractID, string content,string employeeId,string managerName, string managerSurname, string employeeType, string cell, string email) : base(employeeId, managerName, managerSurname, employeeType, cell, email)
        {
            this.contractID = contractID;
            this.content = content;
        }

        public string ContractID { get => contractID; set => contractID = value; }
        public string Content { get => content; set => content = value; }
        private SERVICE_CONTRACT_TYPE ServiceContractType1 { get => ServiceContractType; set => ServiceContractType = value; }
        private CONTRACT_STATE ContractState1 { get => ContractState; set => ContractState = value; }



        //CRUD methods
        public void CreateContractManager(string name, string surname, string cellPhoneNumber, string email)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Insert("Employee", new[] {("Name", name), ("Surname", surname), ("EmployeeType", "ContractManager"), ("CellPhoneNumber", cellPhoneNumber), ("Email", email) });
        }

        public void UpdateContractManager(string contractManagerId, string name, string surname, string cellPhoneNumber, string email)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Update("Employee", new[] {("Name", name), ("Surname", surname), ("EmployeeType", "ContractManager"), ("CellPhoneNumber", cellPhoneNumber), ("Email", email) }, ("EmployeeId = " + contractManagerId));
        }

        public void DeleteContractManager(string contractManagerId)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Delete("Employee", ("EmployeeId = " + contractManagerId));
        }
     
        public enum SERVICE_CONTRACT_TYPE { };
        public enum CONTRACT_STATE { };


        
        void ContractMaintanance()
        {
            //Used to store / update contract data in an external location
        }

        public void SetContract(string ContractTypeId, string ContractTypeDescription, string Availability)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Insert("ContractType", new[] { ("ContractTypeId", ContractTypeId), ("ContractTypeDescription", ContractTypeDescription), ("AvailabilityStatus", Availability) });
        }
      
        public void DeleteContractData(string ContractId)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Delete("ContractType",  ("ClientTypeId = " + ContractId) );
        }



        public SqlDataAdapter GetContractTypeData()
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            return database.RetrieveData("ContractType");
        }
        public SqlDataAdapter GetContractServicesData()
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            return database.RetrieveData("ContractServices");
        }
        public SqlDataAdapter getContractManagerInfo(string contractManagerId)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            return database.RetrieveData("Employee", ("EmployeeId = " + contractManagerId));
        }


    }


}
