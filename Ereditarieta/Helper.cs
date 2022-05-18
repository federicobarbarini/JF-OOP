using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;


namespace Ereditarieta
{
    internal static class Helper
    {
        public static string Serialize<T>(this T entity) where T : class
        {
            var objXS = new System.Xml.Serialization.XmlSerializer(entity.GetType());
            using (var objSW = new StringWriter())
            {
                var ns = new System.Xml.Serialization.XmlSerializerNamespaces();
                ns.Add(string.Empty, string.Empty);
                objXS.Serialize(objSW, entity, ns);
                return objSW.ToString().Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", "");
            }
        }

        public static T DeSerialize<T>(string xml) where T : class
        {
            return (T)DeSerialize(typeof(T), xml);
        }

        public static object DeSerialize(Type type, string xml)
        {
            if (string.IsNullOrEmpty(xml))
                throw new ArgumentNullException("xml");

            // --> Deserializzo la risposta
            var objXS = new System.Xml.Serialization.XmlSerializer(type);
            using (var objSR = new StringReader(xml))
            {
                return objXS.Deserialize(objSR);
            }
        }
    }
}
