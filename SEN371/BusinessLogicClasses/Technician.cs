using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    internal class Technician
    {
        private string jobList;
        private JOBSTATUS jobStatus;

        public string JobList { get => jobList; set => jobList = value; }
        internal JOBSTATUS JobStatus { get => jobStatus; set => jobStatus = value; }

        public enum JOBSTATUS { }


        public Technician(string JobList, JOBSTATUS JobStatus)
        {
            this.jobList = JobList;
            this.jobStatus = JobStatus;

        }



        public void ReciveJobRequest(string request)
        {
            //Store values to datahandler
        }
        public JOBSTATUS GetJobStatus()
        {
            return jobStatus;
            //Get values from datahandler
        }
        public void SetJobStatus(JOBSTATUS status)
        {
            //update values to datahandler
        }
    }
}
