using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GCMSTests.Classes
{
    [DataContract]
    public class AccountInfo:Base
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string CreationDate { get; set; }
        [DataMember]
        public string DueDate { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string Data1 { get; set; }
        [DataMember]
        public string Data2 { get; set; }
        [DataMember]
        public string Data3 { get; set; }
        [DataMember]
        public double Ammount { get; set; }



        static public new AccountInfo Parse(string s)
        {
            return (AccountInfo)Deserialise<AccountInfo>(s);
        }
    }

}
