using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public class Contract
    {
        private string content;
        private bool signed;

        public Contract(string content, bool signed)
        {
            this.Content = content;
            this.Signed = signed;
        }

        public string Content { get => content; set => content = value; }
        public bool Signed { get => signed; set => signed = value; }

        public void ClientMaintanance()
        {
            //Used to maintain and update client data
        }
    }
}
