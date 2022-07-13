using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public class Call
    {
        string callId;
        string agentId;
        bool callStarted;
        bool callFinished;

        public Call(string callId, string agentId, bool callStarted, bool callFinished)
        {
            this.callId = callId;
            this.agentId = agentId;
            this.callStarted = callStarted;
            this.callFinished = callFinished;
        }

        public string CallId { get => callId; set => callId = value; }
        public string AgentId { get => agentId; set => agentId = value; }
        public bool CallStarted { get => callStarted; set => callStarted = value; }
        public bool CallFinished { get => callFinished; set => callFinished = value; }
    }
}
