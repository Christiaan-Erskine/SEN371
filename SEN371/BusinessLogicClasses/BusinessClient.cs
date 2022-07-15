﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public class BusinessClient : Client
    {
        private string clientType, clientInfo, businessName;

        public BusinessClient(PersonAddress clientAddress, string clientName, string clientSurname, string clientNumber, string clientType, string clientInfo, string businessName) : base(clientAddress,clientName, clientSurname, clientNumber)
        {
            this.clientType = clientType;
            this.clientInfo = clientInfo;
            this.businessName = businessName;
        }

        public string ClientType { get => clientType; set => clientType = value; }
        public string ClientInfo { get => clientInfo; set => clientInfo = value; }
        public string BusinessName { get => businessName; set => businessName = value; }

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