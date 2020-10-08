using System;

namespace Serializer
{
    [Serializable]
    public class Address
    {
        public string Type { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Country { get; set; }

        public Address() : this("", "", "", "", 0, "") { }

        public Address(string type, string street, string city, string state, int zip, string country)
        {
            Type = type;
            Street = street;
            City = city;
            State = state;
            Zip = zip;
            Country = country;
        }
    }
}