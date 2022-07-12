using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    public abstract class Person
    {
        protected string name;
        protected string surname;

        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
    }
}
