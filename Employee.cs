using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    public abstract class Employee : Person
    {
        private string employeeId, addressId;


        protected Employee(string employeeId, string addressId, string name, string surname) : base(name, surname)
        {
            this.EmployeeId = employeeId;
            this.AddressId = addressId;
            this.Name = name;
            this.Surname = surname;
        }

        public string EmployeeId { get => employeeId; set => employeeId = value; }
        public string AddressId { get => addressId; set => addressId = value; }

    }
}
