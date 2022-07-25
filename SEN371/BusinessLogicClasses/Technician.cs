﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project_1.BusinessLogicClasses
{
    public class Technician : Employee
    {
        private string jobList;

        public string JobList { get => jobList; set => jobList = value; }



        public Technician(string employeeId, string name, string surname, string jobList) : base( employeeId, name, surname)
        {
            this.jobList = jobList;
        }



        //CRUD methods
        public void CreateTechnitian(string name, string surname, string cellPhoneNumber, string email)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Insert("Employee", new[] {("Name", name), ("Surname", surname), ("EmployeeType", "Technician"), ("CellPhoneNumber", cellPhoneNumber), ("Email", email) });
        }

        public void UpdateTechnitian(string technicianId, string name, string surname, string cellPhoneNumber, string email)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Update("Employee", new[] {("Name", name), ("Surname", surname), ("EmployeeType", "Technician"), ("CellPhoneNumber", cellPhoneNumber), ("Email", email) }, ("EmployeeId = " + technicianId));
        }

        public void DeleteTechnitian(string technitianId)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Delete("Employee", ("EmployeeId = " + technitianId));
        }

        public SqlDataAdapter getTechnitianInfo(string technitianId)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            return database.RetrieveData("Employee", ("EmployeeId = " + technitianId));
        }
        
        

        public void AssignJobRequest(string requestId, string technicianId)
        {
            //Assigns a job request to a technitian
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Update("ServiceRequest",new [] {("TechnicianId" , technicianId)}, ("RequestId = "  + requestId));
        }

        public void ViewAllJobRequest(string technicianId)
        {
            //Shows the job request for the spesific Technitian
            
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.RetrieveData("ServiceRequest", ("TechnicianId == "  + technicianId));
        }

        public SqlDataAdapter GetJobStatus(string requestId)
        {         
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            return database.RetrieveData("ServiceRequest", ("RequestId == "  + requestId));          
        }

        public void SetJobStatus(string requestId, string jobStatus)
        {
            //update values to datahandler
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Update("ServiceRequest",new [] {("JobStatus" , jobStatus)}, ("RequestId == "  + requestId));
        }
    }
}
