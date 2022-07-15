using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public class ServiceRequest
    {
        string agentId, addressId, agreementId, contractId;

        public string AgentId { get => agentId; set => agentId = value; }
        public string AddressId { get => addressId; set => addressId = value; }
        public string AgreementId { get => agreementId; set => agreementId = value; }
        public string ContractId { get => contractId; set => contractId = value; }

        public ServiceRequest(string agentId, string addressId, string agreementId, string contractId)
        {
            this.AgentId = agentId;
            this.AddressId = addressId;
            this.AgreementId = agreementId;
            this.ContractId = contractId;
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
