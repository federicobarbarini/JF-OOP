using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;


namespace Game
{
    internal static class Helper
    {
        #region --> CSV

        /// <summary>
        /// Importa un file CSV
        /// </summary>
        /// <typeparam name="t">Tipo di Calsse da importare</typeparam>
        /// <param name="nfile">nome del file</param>
        /// <returns>
        /// Restituisce la lista di classi lette dal file
        /// </returns>
        public static IEnumerable<t> FromCSV<t>(string nfile)
        {
            return FromCSV<t>(nfile, ";");
        }

        /// <summary>
        /// Importa un file CSV
        /// </summary>
        /// <typeparam name="t">Tipo di Calsse da importare</typeparam>
        /// <param name="nfile">nome del file</param>
        /// <param name="delimiter">delimitatore di campo</param>
        /// <returns>
        /// Restituisce la lista di classi lette dal file
        /// </returns>
        public static IEnumerable<t> FromCSV<t>(string nfile, string delimiter)
        {
            var config = new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture)
            {
                Delimiter = delimiter
            };

            using (var r = new System.IO.StreamReader(System.IO.Path.Combine("../../../dati", nfile)))
            {
                using (var c = new CsvHelper.CsvReader(r, config))
                {
                    return c.GetRecords<t>().ToList();
                };
            };
        }

        public static void ToCSV<t>(t[] items,string nFile, string delimiter)
        {
            var config = new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture)
            {
                Delimiter = delimiter
            };
            using (var writer = new StreamWriter(System.IO.Path.Combine("../../../dati", nFile)))
            {
                using (var csv = new CsvHelper.CsvWriter(writer, config))
                {
                    csv.WriteRecords(items);
                }
            }
        }




        #endregion

        #region --> XML

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static string ToXML<T>(this T entity) where T : class
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

        public static T FromXML<T>(string xml) where T : class
        {
            return (T)FromXML(typeof(T), xml);
        }

        public static object FromXML(Type type, string xml)
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

        #endregion

    }
}
