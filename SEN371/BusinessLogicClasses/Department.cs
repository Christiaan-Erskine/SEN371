using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public abstract class Department
    {
        string dep; //identifies the department by name

        public Department(string department)
        {
            this.dep = department;
        }

        public string department
        { 
            get => dep; 
            set => dep = value; 
        }
    }
}
