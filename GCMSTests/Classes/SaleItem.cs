using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GCMSTests.Classes
{
    [DataContract]
    public class SaleItem:Base
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int ItemId { get; set; }
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string PriceCode { get; set; }
        [DataMember]
        public int PriceId { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public int SaleId { get; set; }
        [DataMember]
        public int CurrencyId { get; set; }
        [DataMember]
        public bool IsItem { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int ReferenceId { get; set; }
        [DataMember]
        public int SaleItemType { get; set; }
        [DataMember]
        public Currency Currency { get; set; }
        [DataMember]
        public bool IsCombo { get; set; }

        static public new SaleItem Parse(string s)
        {
            return (SaleItem)Deserialise<SaleItem>(s);
        }
    }
}
