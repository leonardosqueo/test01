using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GCMSTests.Classes
{
    [DataContract]
    public class Address : Base
    {
        [DataMember]
        public int Type { get; set; }
        [DataMember]
        public bool Default { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Street { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string State { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string Town { get; set; }
        [DataMember]
        public string PostalCode { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string Observations { get; set; }
        [DataMember]
        public string StreetNumber { get; set; }
        [DataMember]
        public string AddressLine1 { get; set; }
        [DataMember]
        public string AddressLine2 { get; set; }
        [DataMember]
        public string CountryName { get; set; }
        [DataMember]
        public string StateName { get; set; }
        [DataMember]
        public string CityName { get; set; }
        [DataMember]
        public string TownName { get; set; }



        static public new Address Parse(string s)
        {
            return (Address)Deserialise<Address>(s);
        }
    }
}
