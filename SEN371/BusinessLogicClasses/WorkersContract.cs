using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public class WorkersContract : Contract
    {
        private string wc; //content

        public WorkersContract(string content, bool signed, string wc) : base(content, signed)
        {
            this.Wc = wc;
        }

        public string Wc { get => wc; set => wc = value; }
    }
}
