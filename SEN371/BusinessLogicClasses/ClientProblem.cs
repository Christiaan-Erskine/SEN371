using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public class ClientProblem
    {
        string problemId;
        string clientId;
        string description;

        List<int> callList;

        public ClientProblem(string problemId, string clientId, string description, List<int> callList)
        {
            this.ProblemId = problemId;
            this.ClientId = clientId;
            this.Description = description;
            this.CallList = callList;
        }

        public string ProblemId { get => problemId; set => problemId = value; }
        public string ClientId { get => clientId; set => clientId = value; }
        public string Description { get => description; set => description = value; }
        public List<int> CallList { get => callList; set => callList = value; }

        enum STATUS
        {
            PENDING, IN_PROGRES, RESOLVED
        }
    }
}
