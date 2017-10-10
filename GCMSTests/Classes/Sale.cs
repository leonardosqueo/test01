using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GCMSTests.Classes
{
    [DataContract]
    public class Sale : Base
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string InternalCode { get; set; }
        [DataMember]
        public int PayMethodId { get; set; }
        [DataMember]
        public PayMethod PayMethod { get; set; }
        [DataMember]
        public decimal Total { get; set; }
        [DataMember]
        public int Status { get; set; }
        [DataMember]
        public string StatusText { get; set; }
        [DataMember]
        public int OperationStatus { get; set; }
        [DataMember]
        public string OperationStatusText { get; set; }
        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public User UserData { get; set; }
        [DataMember]
        public Address BillingAddress { get; set; }
        [DataMember]
        public Address ShippingAddress { get; set; }
        [DataMember]
        public DateTime CreationDate { get; set; }
        [DataMember]
        public string ModificationDate { get; set; }
        [DataMember]
        public string Obeservations { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public int SiteId { get; set; }
        [DataMember]
        public decimal ShippingCost { get; set; }
        [DataMember]
        public int ShippingId { get; set; }
        [DataMember]
        public string GatewayResponseCode { get; set; }
        [DataMember]
        public string GatewayResponseMessage { get; set; }
        [DataMember]
        public int RetryAttempt { get; set; }
        [DataMember]
        public string IpFrom { get; set; }
        [DataMember]
        public int Payments { get; set; }
        [DataMember]
        public string GatewayOrderNumber { get; set; }
        [DataMember]
        public double OtherCost { get; set; }
        [DataMember]
        public int CurrencyId { get; set; }
        [DataMember]
        public Currency Currency { get; set; }
        [DataMember]
        public int VendorId { get; set; }
        [DataMember]
        public double Taxes { get; set; }
        [DataMember]
        public double Discount { get; set; }
        [DataMember]
        public string InvoiceNumber { get; set; }
        [DataMember]
        public string TrackingCode { get; set; }
        [DataMember]
        public string CardName { get; set; }
        [DataMember]
        public DateTime? DeliveryDate { get; set; }
        [DataMember]
        public List<SaleItem> Items { get; set; }
        [DataMember]
        public string Company { get; set; }
        
        
        [DataMember]
        public string GatewayMessage { get; set; }
        
        [DataMember]
        public List<Preference> Preferences { get; set; }
        [DataMember]
        public ShippingMethod ShippingMethod { get; set; }


        static public new Sale Parse(string s)
        {
            return (Sale)Deserialise<Sale>(s);
        }
    }


}
