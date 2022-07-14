using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public class CallCentre : Department
    {
        private string CallRequest;

        public CallCentre(string problemId, string employeId, string clientId, string serviceReq) : base(problemId, employeId, clientId, serviceReq)
        {
            CallRequest = problemId;
        }

        public void ViewCustomerAgreement()
        {
            //Outputs specific service level agreement
        }
        public void SubmitWorkRequest()
        {
            //Stores the work request to an external location
        }

        public void ViewCallHistory()
        {
            //Outputs details of previous calls 
        }
    }
}
