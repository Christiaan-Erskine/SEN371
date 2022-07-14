using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public class Service : Department
    {
        string problemId;
        string employeId;
        string JobSpecification;
        TimeSpan ExpectedDuration;

        public Service(string problemId, string employeId, string clientId, string serviceReq, string JobSpecification, TimeSpan ExpectedDuration) : base(problemId, employeId, clientId, serviceReq)
        {
            this.problemId = problemId;
            this.employeId = employeId;
            this.JobSpecification = JobSpecification;
            this.ExpectedDuration = ExpectedDuration;
        }

        public string ProblemId1 { get => problemId; set => problemId = value; }
        public string EmployeId1 { get => employeId; set => employeId = value; }

        public void AddRequest()
        {
            //Ads a new request
        }

        public void AssignRequest()
        {
            //Assigns a request to this object
        }

        public void CloseRequests()
        {
            //
        }

    }
}
