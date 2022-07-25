using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//import this to all classes so you can return a sql adapter

namespace Project_1.BusinessLogicClasses
{
    public class IndividualClient : Client
    {
        private string clientType, clientInfo;

        public IndividualClient(string clientType, string clientInfo, string clientName, string clientSurname, string clientNumber) : base(clientName, clientSurname, clientNumber)
        {
            this.clientType = clientType;
            this.clientInfo = clientInfo;
        }

        public string ClientType { get => clientType; set => clientType = value; }
        public string ClientInfo { get => clientInfo; set => clientInfo = value; }

        public void StoreClientInfo(string Name, string Surname, string Cellphone, string Email)
        {
            //Used to save client data            
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Insert("Client", new[] { ("Name", Name), ("Surname", Surname), ("CellPhoneNumber", Cellphone), ("Email", Email), ("ClientType", "IndividualClient") });
        }

        //CRUD methods
        public void UpdateClientInfo(string Name, string Surname, string Cellphone, string Email, string clientId)
        {
            //Used to update ClientInfo
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Update("Client", new[] { ("Name", Name), ("Surname", Surname), ("CellPhoneNumber", Cellphone), ("Email", Email), ("ClientType", "IndividualClient") }, ("ClientId = " + clientId));
        }

        public SqlDataAdapter GetClientInfo(string clientId)
        {
            //Used to access client data
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            return database.RetrieveData("Client", ("ClientId = " + clientId));
        }

        public SqlDataAdapter GetClientInfo()
        {
            //Used to access all clients data
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            return database.RetrieveData("Client");
        }

        public void DeleteClient(string clientId)
        {
            //Used to access client data
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.RetrieveData("Client", ("ClientId = " + clientId));
        }


        //needs implementation
        public override void AcceptAgreement()
        {

        }
    }
}
