using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace GCMSTests.Classes
{
    [DataContract]
    public class Currency:Base
    {

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string DisplayName { get; set; }

        [DataMember]
        public decimal Value { get; set; }

        [DataMember]
        public bool IsDefault { get; set; }

        [DataMember]
        public int SiteId { get; set; }

        [DataMember]
        public int RefId { get; set; }

        static public new Currency Parse(string s)
        {
            return (Currency)Deserialise<Currency>(s);
        }



    }
}
