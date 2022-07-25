using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//import this to all classes so you can return a sql adapter

namespace Project_1.BusinessLogicClasses
{
    public class Call
    {
        string callId;
        DateTime callStarted;
        DateTime callEnded;
        string agentId;
        string description;

        public Call(string callId, DateTime callStarted, DateTime callEnded, string agentId, string description = "")
        {
            this.callId = callId;
            this.callStarted = callStarted;
            this.callEnded = callEnded;
            this.agentId = agentId;
            this.description = description;
        }
        //TO DO:
        //Convert DateTime to string in format DB uses

        public string CallId { get => callId; set => callId = value; }
        public DateTime CallStarted { get => callStarted; set => callStarted = value; }
        public DateTime CallEnded { get => callEnded; set => callEnded = value; }
        public string AgentId { get => agentId; set => agentId = value; }

        public string dateToString(DateTime date) // C# DateTime to a string in correct SQL format for DateTime
        {
            return date.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }

        public void StoreCall(DateTime start, DateTime end, string descrption, string agentId, string clientId)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Insert("Call", new[] { ("callstarttime", dateToString(start)), ("callendtime", dateToString(end)), ("problemdiscription", descrption), ("employeeid", agentId), ("clientid", clientId) });
        }

        public void StoreCall()
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Insert("Call", new[] { ("callstarttime", dateToString(this.callStarted)), ("callendtime", dateToString(this.callEnded)), ("problemdiscription", this.description), ("employeeid", this.agentId) });
        }

        public void UpdateCall(DateTime start, DateTime end, string descrption, string agentId, string clientId, string callId)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Update("Call", new[] { ("callstarttime", dateToString(start)), ("callendtime", dateToString(end)), ("problemdiscription", descrption), ("employeeid", agentId), ("clientid", clientId) }, ("CallId = " + callId));//Client?
        }

        public void UpdateCall()
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Update("Call", new[] { ("callstarttime", dateToString(this.callStarted)), ("callendtime", dateToString(this.callEnded)), ("problemdiscription", this.description), ("employeeid", this.agentId) }, ("CallId = " + this.callId));
        }

        public SqlDataAdapter GetCallInfo()
        {
            //may be a return type method as it will retrieve values from database
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();

            //a way to get client as a object from db can also pass condition (not nessecary for now)
            //database.RetrieveObjects(this.GetType());

            return database.RetrieveData("Call");
        }

        public SqlDataAdapter GetCallInfo(string callid)
        {
            //may be a return type method as it will retrieve values from database
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();

            //a way to get client as a object from db can also pass condition (not nessecary for now)
            //database.RetrieveObjects(this.GetType());

            return database.RetrieveData("Call", ("ClientId = " + callid));
        }
    }
}