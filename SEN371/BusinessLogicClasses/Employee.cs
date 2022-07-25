using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public abstract class Employee : Person
    {
        private string employeeId;

        private string serviceDeoartmentId;

        protected Employee(string employeeId, string name, string surname) : base(name, surname)
        {
            this.EmployeeId = employeeId;
            this.Name = name;
            this.Surname = surname;
        }

        public string EmployeeId { get => employeeId; set => employeeId = value; }
        public string ServiceDeoartmentId { get => serviceDeoartmentId; set => serviceDeoartmentId = value; }

        public override string toString()
        {
            //Outputs details that all employees have in common
            return "placeholder";
        }

        public void SetDepartmentID(string id)
        {
            this.serviceDeoartmentId = id;            
        }
    }
}
