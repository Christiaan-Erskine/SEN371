using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public class ServiceRequest
    {
        DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();

        string clientId, callAgentId, technicianId, callId, jobStatus;

        public string ClientId { get => clientId; set => clientId = value; }
        public string CallAgentId { get => callAgentId; set => callAgentId = value; }
        public string TechnicianId { get => technicianId; set => technicianId = value; }
        public string CallId { get => callId; set => callId = value; }
        public string JobStatus { get => jobStatus; set => jobStatus = value; }

        public ServiceRequest(string clientId, string callAgentId, string technicianId, string callId, string jobStatus)
        {
            this.clientId = clientId;
            this.callAgentId = callAgentId;
            this.technicianId = technicianId;
            this.callId = callId;
            this.jobStatus = jobStatus;
        }


        public void StoreServiceRequest(string clientId,string callAgentId, string technicianId, string callId,string jobStatus)
        {        
            database.Insert("ServiceRequest", new[] { ("clientid", clientId), ("callagentid", callAgentId), ("technicianid", technicianId), ("callid", callId), ("jobstatus", jobStatus) });
        }

        public void UpdateServiceRequest(string clientId, string callAgentId, string technicianId, string callId, string jobStatus,string requestId)
        {
            database.Update("ServiceRequest", new[] { ("clientid", clientId), ("callagentid", callAgentId), ("technicianid", technicianId), ("callid", callId), ("jobstatus", jobStatus) }, "RequestId = " + requestId);
        }

        public void DeleteServiceRequest(string id)
        {       
            database.Delete("ServiceRequest", ("RequestId = " + id));
        }




        public void CloseRequest() 
        {
            //Once a request is completed it can be closed and stored
        }
        public void AssignRequest()
        {
            //Used to assign requests from a call to technicians
        }
        public void AddServiceRequest()
        {
            //queue request
        }

    }
}
