using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GCMSTests.Classes
{
    [DataContract]
    public class PayMethod:Base
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string SiteControlName { get; set; }
        [DataMember]
        public string ConfigControlName { get; set; }
        [DataMember]
        public bool Enable { get; set; }

        static public new PayMethod Parse(string s)
        {
            return (PayMethod)Deserialise<PayMethod>(s);
        }
    }
}
