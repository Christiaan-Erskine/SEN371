using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public class Service : Department
    {
        DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
        /*
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
        */
        string description, serviceId;

        public string Description { get => description; set => description = value; }
        public string ServiceId { get => serviceId; set => serviceId = value; }

        public Service(string description, string department) : base(department)
        {
            this.Description = description;
        }


        public void StoreService(string description)
        {          
            database.Insert("Service", new[] { ("servicedescription", description) });
        }

        public void UpdateService(string serviceId, string serviceDescription)
        {         
            database.Update("Service", new[] { ("servicedescription", serviceDescription) }, ("ServiceId = " + serviceId));
        }

        public void DeleteService(string id)
        {          
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
