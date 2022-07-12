using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    public abstract class Employee
    {
        private int employeeID, addressID;
        private string name, surname;

        protected Employee(int employeeID, int addressID, string name, string surname)
        {
            this.EmployeeID = employeeID;
            this.AddressID = addressID;
            this.Name = name;
            this.Surname = surname;
        }

        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public int AddressID { get => addressID; set => addressID = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
    }
}
