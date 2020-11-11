using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.ServiceModel.Web;
using System.IO;



namespace _20201109___Loja_de_Celulares
{
    public class AjudaJson
    {
        public static string Serializar<T>(T obj)
        {
            DataContractJsonSerializer serializador = new DataContractJsonSerializer(typeof(T));
            MemoryStream ms = new MemoryStream();
            serializador.WriteObject(ms, obj);
            return Encoding.UTF8.GetString(ms.ToArray());
        }

        public static T Deserizalizar<T>(string json)
        {
            DataContractJsonSerializer deserializador = new DataContractJsonSerializer(typeof(T));
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            return (T)deserializador.ReadObject(ms);
        }
    }
}
