using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }



    public abstract class Person
    {
        string name;
        string surname;
    }

    public class Address
    {
        private int addressID;
        private string address, suburb, city, country;
    }

    public abstract class Employee
    {
        private int employeeID;

    }

    public class Contract
    {
        
    }


    public class FieldWorker :Client
    {
        
    }

    public class CallAgent : Client
    {
        
    }

    public class Call
    {
        
    }
    public class Client:Person
    {

    }

    public class ClientProblem
    {
        int ProblemId;

        string description;


    }

    public class ServiceDepartment
    {
        int ProblemId;
        int EmployeId;
        int ClientId;
    }
}
