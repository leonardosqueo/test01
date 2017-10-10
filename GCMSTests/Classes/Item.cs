using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace GCMSTests.Classes
{
    [DataContract(Namespace = "")]
    public class ItemExtendedWarranty:Base
    {

        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public bool Active
        { get; set; }

        static public new ItemExtendedWarranty Parse(string s)
        {
            return (ItemExtendedWarranty)Deserialise<ItemExtendedWarranty>(s);
        }



    }

    [DataContract]
    public class Preference : Base
    {
        [DataMember]
        public string Key { get; set; }
        [DataMember]
        public string Value { get; set; }

        static public new Preference Parse(string s)
        {
            return (Preference)Deserialise<Preference>(s);
        }

    }

    [DataContract]
    public class FilterValue : Base
    {
        [DataMember]
        public int FilterId { get; set; }
        [DataMember]
        public string Value { get; set; }

        static public new FilterValue Parse(string s)
        {
            return (FilterValue)Deserialise<FilterValue>(s);
        }

    }

    [DataContract(Namespace = "")]
    public class ItemCallout:Base
    {

        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string Value { get; set; }
        [DataMember]
        public string Text { get; set; }
        [DataMember]
        public string Class { get; set; }

    }



    [DataContract]
    public class ItemDefaultPices:Base
    {
        [DataMember]
        public decimal Value { get; set; }
        [DataMember]
        public int CurrencyId { get; set; }
    }


    [DataContract]
    public class ItemDiscount: Base
    {
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public decimal Value { get; set; }
        [DataMember]
        public int Mode { get; set; }
        [DataMember]
        public int Multiplier { get; set; }

    }



    [DataContract]
    public class Item : Base
    {

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Ids { get; set; }

        [DataMember]
        public short ItemType { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Index { get; set; }

        [DataMember]
        public string Indexes { get; set; }

        [DataMember]
        public string Text { get; set; }

        [DataMember]
        public string Keywords { get; set; }

        [DataMember]
        public int SiteId { get; set; }

        [DataMember]
        public int CreatorId { get; set; }

        [DataMember]
        public int ModificatorId { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string CreationDate { get; set; }

        [DataMember]
        public string ModificationDate { get; set; }

        [DataMember]
        public short PublishingStatus { get; set; }

        [DataMember]
        public string AllPublishingStatus { get; set; }

        [DataMember]
        public decimal DefaultPrice { get; set; }

        [DataMember]
        public int DefaultStock { get; set; }

        [DataMember]
        public System.Nullable<int> ReferenceId { get; set; }

       

        [DataMember]
        public bool ForSale { get; set; }

        [DataMember]
        public bool Vigency { get; set; }

        [DataMember]
        public string VigencyFrom { get; set; }

        [DataMember]
        public string VigencyTo { get; set; }

        [DataMember]
        public string MetaDescription { get; set; }

        [DataMember]
        public string MetaTitle { get; set; }

        [DataMember]
        public string MetaKeywords { get; set; }

        [DataMember]
        public string MetaLang { get; set; }

        [DataMember]
        public string MetaAuthor { get; set; }

        [DataMember]
        public string Author { get; set; }

        [DataMember]
        public bool AutoMeta { get; set; }

     
        [DataMember]
        public int ParentId { get; set; }

        [DataMember]
        public int Weight { get; set; }

        [DataMember]
        public string Weights { get; set; }

        [DataMember]
        public string Brand { get; set; }

        [DataMember]
        public bool UseRefPictures { get; set; }

        [DataMember]
        public string Manufacturer { get; set; }

        [DataMember]
        public int Depth { get; set; }

        [DataMember]
        public bool IsRepository { get; set; }

        [DataMember]
        public string Tags { get; set; }

        [DataMember]
        public string CustomDate { get; set; }

        [DataMember]
        public bool IncludeOnRss { get; set; }

        [DataMember]
        public bool IncludeOnSitemap { get; set; }

        [DataMember]
        public System.Nullable<int> CurrencyId { get; set; }

        [DataMember]
        public int PriceListId { get; set; }

        [DataMember]
        public string AppendControls { get; set; }

        [DataMember]
        public int ContentOrder { get; set; }

        [DataMember]
        public int ContentDisplay { get; set; }

        [DataMember]
        public bool ContentSort { get; set; }

 

        [DataMember]
        public int ContentRecsPerPage { get; set; }

        [DataMember]
        public int PriceMode { get; set; }

        [DataMember]
        public int FilterGroup { get; set; }

        [DataMember]
        public bool Sync { get; set; }

        [DataMember]
        public decimal Discount { get; set; }

        [DataMember]
        public int DiscountMode { get; set; }


        [DataMember]
        public Currency Currency { get; set; }



        [DataMember]
        public Picture[] Images
        {
            get;
            set;
        }

        [DataMember]
        public ItemExtendedWarranty[] ExtendedWarranty { get; set; }

        [DataMember]
        public FilterValue[] Filters { get; set; }

        [DataMember]
        public Preference[] Properties { get; set; }

        [DataMember]
        public Preference[] DesignProperties { get; set; }


        [DataMember]
        public ItemDefaultPices[] DefaultPrices { get; set; }
        [DataMember]
        public ItemCallout[] Callout { get; set; }

        [DataMember]
        public int DefaultMinStock { get; set; }
        [DataMember]
        public decimal? BoxWeight { get; set; }
        [DataMember]
        public decimal? BoxHeight { get; set; }
        [DataMember]
        public decimal? BoxWidth { get; set; }
        [DataMember]
        public decimal? BoxLength { get; set; }
        [DataMember]
        public short? WeightUnits { get; set; }
        [DataMember]
        public short? LengthUnits { get; set; }

        [DataMember]
        public decimal? DefaultOfferPrice { get; set; }
        [DataMember]
        public bool FreeShipping { get; set; }
        [DataMember]
        public int PriceMultiplier { get; set; }
        [DataMember]
        public int UnitsMultiplier { get; set; }
        [DataMember]
        public decimal? Taxes { get; set; }

        [DataMember]
        public bool IsCombo { get; set; }


        [DataMember]
        public ItemDiscount[] ItemDiscounts { get; set; }

        [DataMember]
        public bool SyncPrice { get; set; }

        public Item() { }


        static public new Item Parse(string s)
        {
            return (Item)Deserialise<Item>(s);
        }

    }
}
