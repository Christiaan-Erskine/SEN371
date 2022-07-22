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
        DateTime callStarted;
        DateTime callEnded;
        string agentId;

        public Call(string callId, DateTime callStarted, DateTime callEnded, string agentId)
        {
            this.callId = callId;
            this.callStarted = callStarted;
            this.callEnded = callEnded;
            this.agentId = agentId;
        }

        public string CallId { get => callId; set => callId = value; }
        public DateTime CallStarted { get => callStarted; set => callStarted = value; }
        public DateTime CallEnded { get => callEnded; set => callEnded = value; }
        public string AgentId { get => agentId; set => agentId = value; }

        public void GetDuration()
        {
            //may be a return type method as it will retrieve values from database
        }

        public void StoreDuration()
        {
            //Store Values from database
        }
    }
}