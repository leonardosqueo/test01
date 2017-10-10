using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;


namespace GCMSTests.Classes
{
    [DataContract(Namespace = "")]
    public class Picture:Base
    {
        [DataMember]
        public string Url
        {
            get;
            set;
        }


        [DataMember]
        public string ColorId
        {
            get;
            set;
        }

        [DataMember]
        public bool Thumbnail
        {
            get;
            set;
        }


        static public new Picture Parse(string s)
        {
            return (Picture)Deserialise<Picture>(s);
        }



    }

}
