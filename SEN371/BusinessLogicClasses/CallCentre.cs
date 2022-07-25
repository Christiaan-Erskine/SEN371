using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//import this to all classes so you can return a sql adapter

namespace Project_1.BusinessLogicClasses
{
    public class CallCentre : Department
    {
        private string CallRequest;

        public CallCentre(string CallRequest, string department) : base(department)
        {
            this.CallRequest = CallRequest;
        }

        public SqlDataAdapter ViewCustomerAgreement()
        {
            //Outputs specific service level agreement
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();

            //a way to get client as a object from db can also pass condition (not nessecary for now)
            //database.RetrieveObjects(this.GetType());

            return database.RetrieveData("ContractType");
        }
        public void SubmitWorkRequest()
        {
            //Stores the work request to an external location
        }

        public SqlDataAdapter ViewCallHistory(string callid)
        {
            //Outputs details of previous calls 
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();

            //a way to get client as a object from db can also pass condition (not nessecary for now)
            //database.RetrieveObjects(this.GetType());

            return database.RetrieveData("Call", ("ClientId = " + callid));
        }
    }
        
}
