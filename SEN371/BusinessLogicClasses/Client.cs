using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project_1.BusinessLogicClasses
{
    public abstract class Client : Person
    {    
        private string clientNumber, clientType, email, clientId;

        public Client(string Name, string Surname,string clientType, string clientNumber, string email) : base(Name, Surname)
        {
            this.clientNumber = clientNumber;
            this.clientType = clientType;
            this.email = email;
        }

        public string ClientNumber { get => clientNumber; set => clientNumber = value; }
        public string ClientType { get => clientType; set => clientType = value; }
        public string Email { get => email; set => email = value; }
        public string ClientId { get => clientId; set => clientId = value; }



        public void StoreClient(string Name, string Surname, string Cellphone, string Email, string clientType)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Insert("Client", new[] { ("Name", Name), ("Surname", Surname), ("CellPhoneNumber", Cellphone), ("Email", Email), ("ClientType", clientType) });
        }

        public void StoreClient()   // Default Save This
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Insert("Client", new[] { ("Name", this.Name), ("Surname", this.Surname), ("CellPhoneNumber", this.ClientNumber), ("Email", this.Email), ("ClientType", this.clientType) });

        }

        public void UpdateClient(string Name, string Surname, string Cellphone, string Email, string ClientId) 
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Update("Client", new[] { ("Name", Name), ("Surname", Surname), ("CellPhoneNumber", Cellphone), ("Email", Email), ("ClientType", clientType) }, ("ClientId = " + ClientId));
        }

        public void DeleteClient(string clientId)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Delete("Client", ("ClientId = " + clientId));
        }


        public SqlDataAdapter GetInfo()
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            return database.RetrieveData(this.GetType().Name);
        }


        public SqlDataAdapter GetInfo(string clientId)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            return database.RetrieveData(this.GetType().Name, ("ClientId = " + clientId));
        }



        public override string ToString()
        {
            //Returns the details of a specific client, inherits from person, but different to employees
            return "placeholder";
        }

        public abstract void AcceptAgreement();
    }
}
