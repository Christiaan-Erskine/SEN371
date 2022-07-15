using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public class ClientDataManager : Employee
    {
        string clientId;

       
        public ClientDataManager(string employeeId, string name, string surname, PersonAddress address, string clientId) : base(employeeId, name, surname, address)
        {
            this.ClientId = clientId;
            this.address = address;
        }

        public string ClientId { get => clientId; set => clientId = value; }
        public PersonAddress PersonAddress { get => address; set => address = value; }

        public void SetClientData()
        {
            //Used to store client data to an external location
        }

        public PersonAddress GetClientData()
        {
            //Used to retrieve client data from an external location
            return address; // <---- Placeholder, used to remove errors
        }
    }
}

