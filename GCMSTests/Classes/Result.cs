using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace GCMSTests.Classes
{
    public class Result: Base
    {
        [DataMember]
        public string status
        { get; set; }

        [DataMember]
        public string message
        { get; set; }


        [DataMember]
        public string data
        { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

        static public new  Result Parse(string s)
        {
            return (Result)Deserialise<Result>(s);
        }
    }
}
