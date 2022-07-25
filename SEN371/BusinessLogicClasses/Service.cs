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

        public string JobSpecification { get => jobSpecification; set => jobSpecification = value; }
        public TimeSpan ExpectedDuration { get => expectedDuration; set => expectedDuration = value; }
        internal ServiceRequest ServiceReq { get => serviceReq; set => serviceReq = value; }


        public void StoreService(string description)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();   // Fix Person Id
            database.Insert("Service", new[] { ("servicedescription", description) });
        }

        public void UpdateService(string serviceId, string description)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Update("Service", new[] { ("serviceid", serviceId), ("servicedescription", description) }, ("ServiceId = " + serviceId));
        }

        public void DeleteService(string id)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Delete("Service", ("ServiceId = " + id));
        }



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
