using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public class Service : Department
    {
        ServiceRequest serviceReq;
        string jobSpecification;
        TimeSpan expectedDuration;

        public Service(ServiceRequest serviceReq, string JobSpecification, TimeSpan ExpectedDuration, string department) : base(department)
        {
            this.ServiceReq = serviceReq;
            this.jobSpecification = JobSpecification;
            this.expectedDuration = ExpectedDuration;
        }

        public string JobSpecification1 { get => jobSpecification; set => jobSpecification = value; }
        public TimeSpan ExpectedDuration1 { get => expectedDuration; set => expectedDuration = value; }
        internal ServiceRequest ServiceReq { get => serviceReq; set => serviceReq = value; }


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
            //Onse a request has been completed it can be closed and stored
        }

    }
}
