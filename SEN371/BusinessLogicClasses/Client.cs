﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public abstract class Client : Person
    {    
        private string clientNumber;

        public Client(string Name, string Surname, string clientNumber) : base(Name, Surname)
        {
            this.clientNumber = clientNumber;
        }

        public string ClientNumber { get => clientNumber; set => clientNumber = value; }

        public override string ToString()
        {
            //Returns the details of a specific client, inherits from person, but different to employees
            return "placeholder";
        }

        public abstract void AcceptAgreement();
    }
}
