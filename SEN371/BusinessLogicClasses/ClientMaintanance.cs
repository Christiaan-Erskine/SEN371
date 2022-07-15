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
        ContractMaintanance ManagementInformation;  // <--- Correct datatype?

        public ClientMaintanance(Client IndividualClient, Client BusinessClient, Contract serviceAgreement, ContractMaintanance managementInformation, string department) : base(department)
        {
            this.IndividualClient = IndividualClient;
            this.BusinessClient = BusinessClient;
            this.ServiceAgreement = serviceAgreement;
            this.ManagementInformation = managementInformation;
        }

        public Client individualClient { get => IndividualClient; set => IndividualClient = value; }
        public Client businessClient1 { get => BusinessClient; set => BusinessClient = value; }
        public Contract serviceAgreement { get => ServiceAgreement; set => ServiceAgreement = value; }
        public ContractMaintanance managementInformation { get => ManagementInformation; set => ManagementInformation = value; }

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
