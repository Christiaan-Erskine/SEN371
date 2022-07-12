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
        private int employeeID, addressID;

    }

    public class Contract
    {
        
    }


    public class FieldWorker : Employee
    {
        
    }

    public class CallAgent : Employee
    {
        int agentId;
        string agentName;
        string agentSurname;
        string adressId;
        string contractId;

        public CallAgent(int agentId, string agentName, string agentSurname, string adressId, string contractId)
        {
            this.agentId = agentId;
            this.agentName = agentName;
            this.agentSurname = agentSurname;
            this.adressId = adressId;
            this.contractId = contractId;
        }

        public int AgentId { get => agentId; set => agentId = value; }
        public string AgentName { get => agentName; set => agentName = value; }
        public string AgentSurname { get => agentSurname; set => agentSurname = value; }
        public string AdressId { get => adressId; set => adressId = value; }
        public string ContractId { get => contractId; set => contractId = value; }
    }

    public class Call
    {
        int callId;
        int agentId;
        bool callStarted;
        bool callFinished;

        public Call(int callId, int agentId, bool callStarted, bool callFinished)
        {
            this.callId = callId;
            this.agentId = agentId;
            this.callStarted = callStarted;
            this.callFinished = callFinished;
        }

        public int CallId { get => callId; set => callId = value; }
        public int AgentId { get => agentId; set => agentId = value; }
        public bool CallStarted { get => callStarted; set => callStarted = value; }
        public bool CallFinished { get => callFinished; set => callFinished = value; }
    }
    public class Client : Person
    {
        string clientName;
        string ClientSurname;

        int adressId;
        int agentId;
        int agreemendId;

        public Client(string clientName, string clientSurname, int adressId, int agentId, int agreemendId)
        {
            this.clientName = clientName;
            ClientSurname = clientSurname;
            this.adressId = adressId;
            this.agentId = agentId;
            this.agreemendId = agreemendId;
        }

        public string ClientName { get => clientName; set => clientName = value; }
        public string ClientSurname1 { get => ClientSurname; set => ClientSurname = value; }
        public int AdressId { get => adressId; set => adressId = value; }
        public int AgentId { get => agentId; set => agentId = value; }
        public int AgreemendId { get => agreemendId; set => agreemendId = value; }

        enum CLIENT_TYPE
        {
            BUSINESS,INDIVIDUAL
        }
    }

    public class ClientProblem
    {
        int problemId;
        int clientId;
        string description;

        List<int> callList;

        public ClientProblem(int problemId, int clientId, string description, List<int> callList)
        {
            this.ProblemId = problemId;
            this.ClientId = clientId;
            this.Description = description;
            this.CallList = callList;
        }

        public int ProblemId { get => problemId; set => problemId = value; }
        public int ClientId { get => clientId; set => clientId = value; }
        public string Description { get => description; set => description = value; }
        public List<int> CallList { get => callList; set => callList = value; }

        enum STATUS
        {
            PENDING,IN_PROGRES,RESOLVED
        }
    }

    public class ServiceDepartment
    {
        int problemId;
        int employeId;
        int clientId;

        public ServiceDepartment(int problemId, int employeId, int clientId)
        {
            this.problemId = problemId;
            this.employeId = employeId;
            this.clientId = clientId;
        }

        public int ProblemId { get => problemId; set => problemId = value; }
        public int EmployeId { get => employeId; set => employeId = value; }
        public int ClientId { get => clientId; set => clientId = value; }
    }
}
