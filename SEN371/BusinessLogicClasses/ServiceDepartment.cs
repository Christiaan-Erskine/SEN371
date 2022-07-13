using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public class ServiceDepartment
    {
        string problemId;
        string employeId;
        string clientId;
        string serviceReq;

        public ServiceDepartment(string problemId, string employeId, string clientId, string serviceReq)
        {
            this.problemId = problemId;
            this.employeId = employeId;
            this.clientId = clientId;
            this.serviceReq = serviceReq;
        }

        public string ProblemId { get => problemId; set => problemId = value; }
        public string EmployeId { get => employeId; set => employeId = value; }
        public string ClientId { get => clientId; set => clientId = value; }
        public string ServiceReq { get => serviceReq; set => serviceReq = value; }

        public void AssignReqMT()
        {
            //
        }

        public void CloseRequests()
        {
            //
        }

    }
}
