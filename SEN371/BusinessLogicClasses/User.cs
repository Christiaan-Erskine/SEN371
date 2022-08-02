using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public class User
    {
        private string username, password, employeeType;

        public User(string username, string password, string employeeType)
        {
            this.Username = username;
            this.Password = password;
            this.EmployeeType = employeeType;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string EmployeeType { get => employeeType; set => employeeType = value; }
    }
}
