using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    public class Contract
    {
        private int contractID;
        private string content;

        public Contract(int contractID, string content)
        {
            this.ContractID = contractID;
            this.Content = content;
        }

        public int ContractID { get => contractID; set => contractID = value; }
        public string Content { get => content; set => content = value; }
    }
}
