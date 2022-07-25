using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project_1.BusinessLogicClasses
{
    public class Contract
    {
        private string contractId;
        private string contractType;
        private string userId;

        public Contract(string contractId, string contractType, string userId)
        {
            this.ContractId = contractId;
            this.ContractType = contractType;
            this.UserId = userId;
        }

        public string ContractId { get => contractId; set => contractId = value; }
        public string ContractType { get => contractType; set => contractType = value; }
        public string UserId { get => userId; set => userId = value; }



        public void StoreContract(string contactType, string clientId)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();   // Fix Person Id
            database.Insert("Contract", new[] { ("clientId", clientId), ("contractTypeid", contactType) });
        }

        public void UpdateContract(string contractId, string contactType, string userId)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Update("Contract", new[] { ("clientId", userId), ("contractTypeid", contactType) }, ("ContractId = " + contractId));
        }

        public void DeleteContract(string id)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Delete("Contract", ("ServiceId = " + id));
        }


        public SqlDataAdapter GetInfo()
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            return database.RetrieveData(this.GetType().Name);
        }


        public SqlDataAdapter GetInfo(string ContractId)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            return database.RetrieveData(this.GetType().Name, ("ContractId = " + contractId));
        }


    }
}
