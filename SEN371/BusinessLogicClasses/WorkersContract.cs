using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public class WorkersContract : Contract
    {
        private string wc; //content => workers contract
        public WorkersContract(string content, bool signed, string wc,string contractType, string contractId, string userId) : base(contractId, contractType, userId)
        {
            this.Wc = wc;
        }

        public string Wc { get => wc; set => wc = value; }

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
