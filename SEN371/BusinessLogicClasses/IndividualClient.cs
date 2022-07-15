using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    internal class IndividualClient : Client
    {
        private string clientType, clientInfo;

        public IndividualClient(string clientType, string clientInfo, PersonAddress clientAddress, string clientName, string clientSurname, string clientNumber) : base(clientAddress, clientName, clientSurname, clientNumber)
        {
            this.clientType = clientType;
            this.clientInfo = clientInfo;
        }

        public string ClientType { get => clientType; set => clientType = value; }
        public string ClientInfo { get => clientInfo; set => clientInfo = value; }

        public void StoreClientInfo()
        {
            //Used to save client data
        }

        public void GetClientInfo()
        {
            //Used to access client data
        }
    }
}
