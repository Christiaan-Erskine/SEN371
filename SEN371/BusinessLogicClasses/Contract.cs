using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public class Contract
    {
        private string ContractType;

        public Contract(string contractType)
        {
            ContractType = contractType;
        }

        public string ContractType1 { get => ContractType; set => ContractType = value; }

    }
}
