using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public class PersonAddress
    {
        private string address, suburb, city, country, PersonId;

        public string Address { get => address; set => address = value; }
        public string Suburb { get => suburb; set => suburb = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }
        public string PersonId1 { get => PersonId; set => PersonId = value; }

        public PersonAddress(string address, string suburb, string city, string country, string personId)
        {
            this.address = address;
            this.suburb = suburb;
            this.city = city;
            this.country = country;
            PersonId = personId;
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
