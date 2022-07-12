using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    public class ClientAddress
    {
        private int addressID;
        private string address, suburb, city, country;

        public ClientAddress(int addressID, string address, string suburb, string city, string country)
        {
            this.AddressID = addressID;
            this.Address = address;
            this.Suburb = suburb;
            this.City = city;
            this.Country = country;
        }
        public ClientAddress(string address, string suburb, string city, string country)
        {
            this.Address = address;
            this.Suburb = suburb;
            this.City = city;
            this.Country = country;
        }

        public int AddressID { get => addressID; set => addressID = value; }
        public string Address { get => address; set => address = value; }
        public string Suburb { get => suburb; set => suburb = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }
    }
}
