using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public class BusinessClient : Client
    {
        private string content;

        public BusinessClient(string clientName, string clientSurname, string adressId, string agentId, string agreemendId, string content) : base(clientName, clientSurname, adressId, agentId, agreemendId)
        {
            this.Content = content;
        }

        public string Content { get => content; set => content = value; }

        public void ClientMaintanance()
        {
            //Used to maintain and update client data
        }
    }
}
