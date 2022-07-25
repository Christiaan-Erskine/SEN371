using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//import this to all classes so you can return a sql adapter

namespace Project_1.BusinessLogicClasses
{
    public class BusinessClient : Client
    {
        private string clientInfo, clientEmail;

        public BusinessClient(string clientName, string clientSurname, string clientNumber, string clientType, string clientInfo, string clientEmail) : base(clientName, clientSurname, clientNumber, clientType, clientEmail)
        {
            this.clientInfo = clientInfo;
            this.clientEmail = clientEmail;
        }

        public string ClientInfo { get => clientInfo; set => clientInfo = value; }

        public void StoreClientInfo(string Name, string Surname, string Cellphone, string Email)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Insert("Client", new[] { ("Name", Name), ("Surname", Surname), ("CellPhoneNumber", Cellphone), ("Email", Email), ("ClientType", "BusinessClient") });
        }

        public void StoreClientInfo()   // Default Save This
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Insert("Client", new[] { ("Name", this.Name), ("Surname", this.Surname), ("CellPhoneNumber", this.ClientNumber), ("Email", this.clientEmail), ("ClientType", "BusinessClient") });

            //more generic => database.InsertObject(this);
        }

        public void UpdateClientInfo(string Name, string Surname, string Cellphone, string Email, string ClientId)  //
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Update("Client", new[] { ("Name", Name), ("Surname", Surname), ("CellPhoneNumber", Cellphone), ("Email", Email), ("ClientType", "BusinessClient") }, ("ClientId = " + ClientId));
        }

        public void DeleteClient(string clientId)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Delete("Client", ("ClientId = " + clientId));
        }

        public SqlDataAdapter GetClientInfo()
        {
            //Used to access client data
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();

            //a way to get client as a object from db can also pass condition (not nessecary for now)
            //database.RetrieveObjects(this.GetType());

            return database.RetrieveData("Client");
        }

        public SqlDataAdapter GetClientInfo(string clientid)
        {
            //Used to access client data
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();

            //database.RetrieveObjects(this.GetType());

            return database.RetrieveData("Client", ("ClientId = " + clientid));
        }

        //needs implementation
        public override void AcceptAgreement()
        {

        }
    }
}
