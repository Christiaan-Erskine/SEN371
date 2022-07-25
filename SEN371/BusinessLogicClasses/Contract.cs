using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            database.Insert("Contract", new[] { ("clientId", clientId), ("contacttypeid", contactType) });
        }

        public void UpdateContact(string contractId, string contactType, string userId)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Update("Contract", new[] { ("clientId", userId), ("contacttypeid", contactType) }, ("ContractId = " + contractId));
        }

        public void DeleteContract(string id)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Delete("Contract", ("ServiceId = " + id));
        }

    }
}
