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
            //config.MissingFieldFound = (CsvHelper.MissingFieldFoundArgs args) =>{ };

            using (var r = new System.IO.StreamReader(System.IO.Path.Combine(ORM.Context.DatiPath, nfile)))
            {
                using (var c = new CsvHelper.CsvReader(r, config))
                {
                    return c.GetRecords<t>().ToList();
                };
            };
        }

        /// <summary>
        /// Esporta CSV
        /// </summary>
        /// <typeparam name="t">Tipo di Calsse da importare</typeparam>
        /// <param name="items">Elenco degli oggetti da esportare</param>
        /// <param name="nfile">nome del file</param>
        /// <param name="delimiter">delimitatore di campo</param>
        public static void ToCSV<t>(t[] items,string nFile, string delimiter)
        {
            var config = new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture)
            {
                Delimiter = delimiter
            };
            using (var writer = new StreamWriter(System.IO.Path.Combine(ORM.Context.DatiPath, nFile)))
            {
                using (var csv = new CsvHelper.CsvWriter(writer, config))
                {
                    csv.WriteRecords(items);
                }
            }
        }

        #endregion

        #region --> XML

        public static void ToXMLFile<T>(this T entity, string nFile) where T : class
        {
            var xml = ToXML(entity);
            var filePath = System.IO.Path.Combine(ORM.Context.DatiPath, nFile);   

            if (System.IO.File.Exists(filePath)) System.IO.File.Delete(filePath); 
            System.IO.File.WriteAllText(filePath, xml, System.Text.Encoding.UTF8);
        }

        public static T FromXMLFile<T>(string nFile) where T : class
        {
            var filePath = System.IO.Path.Combine(ORM.Context.DatiPath, nFile);
            if (!System.IO.File.Exists(filePath)) throw new ArgumentNullException(String.Format("Il file {0} non esiste.", filePath));

            var xml = System.IO.File.ReadAllText(filePath, System.Text.Encoding.UTF8);
            return FromXML<T>(xml);
        }


        /// <summary>
        /// Esporta un Entità in una striga XML
        /// </summary>
        /// <typeparam name="T">Tipo di classe</typeparam>
        /// <param name="entity">Oggetto da esportare</param>
        /// <returns>Stringa XML</returns>
        public static string ToXML<T>(this T entity) where T : class
        {
            var objXS = new System.Xml.Serialization.XmlSerializer(entity.GetType());
            using (var objSW = new StringWriter())
            {
                var ns = new System.Xml.Serialization.XmlSerializerNamespaces();
                ns.Add(string.Empty, string.Empty);
                objXS.Serialize(objSW, entity, ns);
                return objSW.ToString().Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", String.Empty);
            }
        }

        /// <summary>
        /// Importa un stringa XML in un oggetto
        /// </summary>
        /// <typeparam name="T">tipo di oggetto da ottenere</typeparam>
        /// <param name="xml">Stringa XML da da importare</param>
        /// <returns>oggetto ottenuto</returns>
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

        #region --> JSON

        public static string ToJSON<T>(this T entity) where T : class
        {
            if (entity == null) return string.Empty;
            return Newtonsoft.Json.JsonConvert.SerializeObject(entity);
        }

        public static T FromJSON<T>(string json) where T : class
        {
            if (string.IsNullOrEmpty(json)) throw new ArgumentNullException("FromJSON json String is null or empty");
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
        }

        public static void ToJSONFile<T>(this T entity, string filePath) where T : class
        {
            var js = ToJSON(entity);
            var fInfo = new System.IO.FileInfo(filePath);
            if (!fInfo.Directory.Exists) throw new Exceptions.DirectoryNotExist(fInfo.DirectoryName);
            
            if (System.IO.File.Exists(filePath)) System.IO.File.Delete(filePath);
            System.IO.File.WriteAllText(filePath, js, System.Text.Encoding.UTF8);
        }

        public static T FromJSONFile<T>(string filePath) where T : class
        {
            if (!System.IO.File.Exists(filePath)) throw new ArgumentNullException(String.Format("Il file {0} non esiste.", filePath));
            var js = System.IO.File.ReadAllText(filePath, System.Text.Encoding.UTF8);
            return FromJSON<T>(js);
        }

        #endregion

    }
}
