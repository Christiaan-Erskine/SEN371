using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public class PersonAddress
    {
        private string streetAddress, suburb, city, country, personId;

        public string PersonId { get => personId; set => personId = value; }
        public string StreetAddress { get => streetAddress; set => streetAddress = value; }
        public string Suburb { get => suburb; set => suburb = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }
       

        public PersonAddress(string personId, string streetAddress, string suburb, string city, string country)
        {
            this.streetAddress = streetAddress;
            this.suburb = suburb;
            this.city = city;
            this.country = country;
            PersonId = personId;
        }

        public void StoreAddress(string personId, string streetAddress, string suburb, string city, string country)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Insert("PersonAddress", new[] { ("personid", personId), ("streetaddress", streetAddress), ("suburb", suburb), ("city", city), ("country", country) });
        }

        public void UpdateAddress(string streetAddress, string suburb, string city, string country, string id)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Update("PersonAddress", new[] { ("streetaddress", streetAddress), ("suburb", suburb), ("city", city), ("country", country) }, ("ClientId = " + id) );
        }

        public void DeleteAddress(string id)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            database.Delete("PersonAddress", ("ClientId = " + id) );
        }
        
        public void DisplayInfo()//||Getinfo
        {
            //Outputs a specific address for an employee or a client
        }
        public void SetInfo(string address, string suburb, string city, string country, string personId)
        {
            //set employee information
        }
        
        
    }
}
