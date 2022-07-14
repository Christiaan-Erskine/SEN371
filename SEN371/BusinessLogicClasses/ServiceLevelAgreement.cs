using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public class ServiceLevelAgreement : Contract
    {
        string sla; //content

        public ServiceLevelAgreement(string content, bool signed, string sla) : base(content, signed)
        {
            this.Sla = sla;
        }

        public string Sla { get => sla; set => sla = value; }
    }
}
