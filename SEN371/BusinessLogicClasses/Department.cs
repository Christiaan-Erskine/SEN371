using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public abstract class Department
    {

        string clientId;
        string serviceReq;

        public Department(string problemId, string employeId, string clientId, string serviceReq)
        {
            this.clientId = clientId;
            this.serviceReq = serviceReq;
        }


        public string ClientId { get => clientId; set => clientId = value; }
        public string ServiceReq { get => serviceReq; set => serviceReq = value; }
    }
}
