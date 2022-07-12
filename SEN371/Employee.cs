using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    public abstract class Employee : Person
    {
        private int employeeId, addressId;


        protected Employee(int employeeId, int addressId, string name, string surname) : base(name, surname)
        {
            this.EmployeeId = employeeId;
            this.AddressId = addressId;
            this.Name = name;
            this.Surname = surname;
        }

        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public int AddressId { get => addressId; set => addressId = value; }

    }
}
