using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//import this to all classes so you can return a sql adapter

namespace Project_1.BusinessLogicClasses
{
    public class ServiceLevelAgreement : Contract
    {
        DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();

        string sla; //content => service level agreement

        public ServiceLevelAgreement(string sla, string contractType, string userId, string contractId) : base(contractId, contractType, userId)
        {
            this.Sla = sla;
        }

        public string Sla { get => sla; set => sla = value; }

        
        public void AddInformation(string description, string AvailabilityStatus)
        {              
            database.Insert("ContractType", new[] { ("ContractTypeDescription", description), ("AvailabilityStatus", AvailabilityStatus) });
        }

        public void UpdateService(string serviceId, string description)
        {        
            database.Update("ContractType", new[] { ("serviceid", serviceId), ("servicedescription", description) }, ("ServiceId = " + serviceId));
        }
        public SqlDataAdapter GetInformation()
        {
            //returns contract information from an external location        
            return database.RetrieveData("ContractType");
        }
        public void DeleteService(string id)
        {       
            database.Delete("ContractType", ("ContractTypeId = " + id));
        }
    }
}
