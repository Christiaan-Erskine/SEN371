using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public class ClientMaintanance : Department
    {
        Client IndividualClient, BusinessClient;
        Contract ServiceAgreement;
        ContractMaintanance ManagementInformation;

        public ClientMaintanance(string problemId, string employeId, string clientId, string serviceReq, Contract serviceAgreement, ContractMaintanance managementInformation) : base(problemId, employeId, clientId, serviceReq)
        {
            ServiceAgreement1 = serviceAgreement;
            ManagementInformation1 = managementInformation;
        }

        public Client IndividualClient1 { get => IndividualClient; set => IndividualClient = value; }
        public Client BusinessClient1 { get => BusinessClient; set => BusinessClient = value; }
        public Contract ServiceAgreement1 { get => ServiceAgreement; set => ServiceAgreement = value; }
        public ContractMaintanance ManagementInformation1 { get => ManagementInformation; set => ManagementInformation = value; }

        public void SubmitWorkRequest()
        {
            //Used to submit a completed work request
        }

        public void AddServiceDetails()
        {
            //Used to add details to a service contract
        }
    }
}
