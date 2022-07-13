using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    public class PersonAddress
    {
        private string address, suburb, city, country, addressId;

        public PersonAddress(string addressId, string address, string suburb, string city, string country)
        {
            this.AddressID = addressId;
            this.Address = address;
            this.Suburb = suburb;
            this.City = city;
            this.Country = country;
        }
        public PersonAddress(string address, string suburb, string city, string country)
        {
            this.Address = address;
            this.Suburb = suburb;
            this.City = city;
            this.Country = country;
        }

        public string AddressID { get => addressId; set => addressId = value; }
        public string Address { get => address; set => address = value; }
        public string Suburb { get => suburb; set => suburb = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }
    }
}
