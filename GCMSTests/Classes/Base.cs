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
    [DataContract]
    public abstract  class Base
    {

        

        /* METODOS PARA SERIALIZAR JSON */
        public  static T Deserialise<T>(string json)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
            /*
            T obj = Activator.CreateInstance<T>();
            using (MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
                obj = (T)serializer.ReadObject(ms);
                return obj;
            }
            */
            
        }

        protected static string Serialize<T>(T obj)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
            using (MemoryStream ms = new MemoryStream())
            {
                serializer.WriteObject(ms, obj);
                return Encoding.Default.GetString(ms.ToArray());
            }
        }



        static public Base Parse(string s){
            return (Base)Deserialise<Base>(s);
        }


        public override string ToString()
        {


            DataContractJsonSerializer serializer = new DataContractJsonSerializer(this.GetType());
            using (MemoryStream ms = new MemoryStream())
            {
                serializer.WriteObject(ms, this);
                return Encoding.Default.GetString(ms.ToArray());
            }
        }
    }
}
