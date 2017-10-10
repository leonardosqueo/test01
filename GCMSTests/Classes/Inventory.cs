using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GCMSTests.Classes
{
    [DataContract]
    public class Inventory:Base
    {

        [DataMember]
        public int InternalId { get; set; }
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public int Stock { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public bool ForSale { get; set; }
        [DataMember]
        public bool Published { get; set; }
        [DataMember]
        public bool IsItem { get; set; }
        [DataMember]
        public int ParentItemId { get; set; }
        [DataMember]
        public string ParentItemCode { get; set; }
        [DataMember]
        public int PriceListId { get; set; }

        [DataMember]
        public int? PriceMode { get; set; }


        [DataMember]
        public string PrecioOriginal { get; set; }

        [DataMember]
        public string DepStock { get; set; }

        [DataMember]
        public ItemExtendedWarranty[] ExtendedWarranty { get; set; }

        static public new Inventory Parse(string s)
        {
            return (Inventory)Deserialise<Inventory>(s);
        }

    }


}
