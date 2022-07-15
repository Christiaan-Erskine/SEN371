using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public class ServiceLevelAgreement : Contract
    {
        string sla; //content => service level agreement

        public ServiceLevelAgreement(string sla, string contractType) : base(contractType)
        {
            this.Sla = sla;
        }

        public string Sla { get => sla; set => sla = value; }

        void AddInformation()
        {
            //Used to add aditional information to a stored contract
        }
        void GetInformation()
        {
            //returns contract information from an external location
        }

    }
}
