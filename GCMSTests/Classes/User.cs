using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GCMSTests.Classes
{
    [DataContract]
    public class User : Base
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public int SiteId { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string EMail { get; set; }
        [DataMember]
        public bool Access { get; set; }
        [DataMember]
        public string UILang { get; set; }
        [DataMember]
        public DateTime CurrentLoginDate { get; set; }
        [DataMember]
        public DateTime LastLoginDate { get; set; }
        [DataMember]
        public string CurrentLoginIp { get; set; }
        [DataMember]
        public string LastLoginIp { get; set; }
        [DataMember]
        public DateTime CreationDate { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string State { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string PostalCode { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string Mobile { get; set; }
        [DataMember]
        public string IdNumber { get; set; }
        [DataMember]
        public int ProfileId { get; set; }
        [DataMember]
        public int PriceListId { get; set; }
        [DataMember]
        public string InternalCode { get; set; }
        [DataMember]
        public string Town { get; set; }
        [DataMember]
        public string ExternalLoginCode { get; set; }
        [DataMember]
        public string StreetNumber { get; set; }
        [DataMember]
        public string AddressLine1 { get; set; }
        [DataMember]
        public string AddressLine2 { get; set; }
        [DataMember]
        public List<Preference> Preferences { get; set; }
        [DataMember]
        public List<AccountInfo> AccountInfo { get; set; }



        static public new User Parse(string s)
        {
            return (User)Deserialise<User>(s);
        }
    }
}
