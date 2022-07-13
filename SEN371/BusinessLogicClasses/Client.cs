using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public class Client : Person
    {
        string clientName;
        string ClientSurname;

        string adressId;
        string agentId;
        string agreemendId;

        public Client(string clientName, string clientSurname, string adressId, string agentId, string agreemendId) : base(clientName, clientSurname)
        {
            this.clientName = clientName;
            ClientSurname = clientSurname;
            this.adressId = adressId;
            this.agentId = agentId;
            this.agreemendId = agreemendId;
        }

        public string ClientName { get => clientName; set => clientName = value; }
        public string ClientSurname1 { get => ClientSurname; set => ClientSurname = value; }
        public string AdressId { get => adressId; set => adressId = value; }
        public string AgentId { get => agentId; set => agentId = value; }
        public string AgreemendId { get => agreemendId; set => agreemendId = value; }

        enum CLIENT_TYPE
        {
            BUSINESS, INDIVIDUAL
        }
    }
}
