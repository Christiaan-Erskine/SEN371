using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//import this to all classes so you can return a sql adapter

namespace Project_1.BusinessLogicClasses
{
    public class ClientDataManager : Employee
    {
        string clientId;

        DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();

        public ClientDataManager(string employeeId, string name, string surname, string clientId, string employeeType, string cell, string email) : base(employeeId, name, surname, employeeType, cell, email)
        {
            this.ClientId = clientId;
        }

        public string ClientId { get => clientId; set => clientId = value; }


        
        public void SetClientData(string ClientId, string ClientStatus, string AdHocNotes)
        {
            //Used to store client data to an external location
            //Used to save client data
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Insert("ClientManagementInformation", new[] { ("ClientId", ClientId), ("ClientStatus", ClientStatus), ("AdHocNotes", AdHocNotes)});
        }

        //not sure what we wanted to return here
        //public PersonAddress GetClientData()
        //{
        //    DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();

        //    //a way to get client as a object from db can also pass condition (not nessecary for now)
        //    //database.RetrieveObjects(this.GetType());

        //    return database.RetrieveData("Client");
        //}
        public SqlDataAdapter GetClientData()
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();

            //a way to get client as a object from db can also pass condition (not nessecary for now)
            //database.RetrieveObjects(this.GetType());

            return database.RetrieveData("Client");
        }
        public void DeleteClientData(string clientId)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();

            //a way to get client as a object from db can also pass condition (not nessecary for now)
            //database.RetrieveObjects(this.GetType());
            //
            database.Delete("Client", "ClientId = " + clientId);
        }
        public SqlDataAdapter GetClientStatus()
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();

            //a way to get client as a object from db can also pass condition (not nessecary for now)
            //database.RetrieveObjects(this.GetType());

            return database.RetrieveData("ClientManagementInformation");
        }
        public void UpdateClientStatus(string ClientId, string ClientStatus)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();

            //a way to get client as a object from db can also pass condition (not nessecary for now)
            //database.RetrieveObjects(this.GetType());

            database.Update("ClientManagementInformation", new[] { ("ClientId", ClientId), ("ClientStatus", ClientStatus) });
        }
        public void DeleteClientStatus(string clientId)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();

            //a way to get client as a object from db can also pass condition (not nessecary for now)
            //database.RetrieveObjects(this.GetType());

            database.Delete("ClientManagementInformation", "ClientId = " + clientId);
        }
        public SqlDataAdapter GetClientStatus(string clientId)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();

            //a way to get client as a object from db can also pass condition (not nessecary for now)
            //database.RetrieveObjects(this.GetType());

            return database.RetrieveData("ClientManagementInformation", ("ClientId = " + clientId));
        }
    }
        
    
}

