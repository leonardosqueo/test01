using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GCMSTests.Classes
{
    [DataContract]
    public class ShippingMethod:Base
    {
        [DataMember]
        public int ShippingTypeEnum { get; set; }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Code { get; set; }



        static public new ShippingMethod Parse(string s)
        {
            return (ShippingMethod)Deserialise<ShippingMethod>(s);
        }
    }
}
