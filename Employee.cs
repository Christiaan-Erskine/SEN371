using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    public abstract class Employee : Person
    {
        private int employeeID, addressID;


        protected Employee(int employeeID, int addressID, string name, string surname) : base(name, surname)
        {
            this.EmployeeID = employeeID;
            this.AddressID = addressID;
            this.Name = name;
            this.Surname = surname;
        }

        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public int AddressID { get => addressID; set => addressID = value; }

    }
}
