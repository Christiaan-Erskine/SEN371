using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public abstract class Person
    {
        protected string name;
        protected string surname;

        public Person(string Name, string Surname)
        {
            this.name = Name;
            this.surname = Surname;
        }
        public Person() { }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }

        public virtual string toString()
        {
            //Will be used to display a person's details as a string, will be overridden by employee and client child classes
            return "placeholder";
        }

        public string GetAddress()
        {
            //Will be used to find the addresses associated with a specific person
            return "placeholder";
        }
    }
}
