using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.ORM
{
    public static class Context
    {

        #region --> Proprietà

        public static string DatiPath { get { return System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\dati"); } }

        #endregion

        #region --> Metodi

        public static Model.Squadra Load(string nome)
        {
            var nFile = "Squadra." + nome;
            var pathXML = System.IO.Path.Combine(DatiPath, nFile+".xml");
            var pathJS = System.IO.Path.Combine(DatiPath, nFile + ".json");
            if (System.IO.File.Exists(pathJS))
            {
                return Helper.FromJSONFile<Model.Squadra>((new System.IO.FileInfo(pathJS)).Name);
            }
            else if (System.IO.File.Exists(pathXML))
            {
                return Helper.FromXMLFile<Model.Squadra>((new System.IO.FileInfo(pathXML)).Name);
            } 
            else 
            {
                var item = new Model.Squadra() { Nome = nome};
                item.Rosa.AddRange((from x in Game.Helper.FromCSV<Game.Model.Portiere>("Portieri.csv") where x.Squadra == item.Nome select x).ToArray());
                item.Rosa.AddRange((from x in Game.Helper.FromCSV<Game.Model.Difensore>("Difensori.csv") where x.Squadra == item.Nome select x).ToArray());
                item.Rosa.AddRange((from x in Game.Helper.FromCSV<Game.Model.Centrocampista>("Centrocampisti.csv") where x.Squadra == item.Nome select x).ToArray());
                item.Rosa.AddRange((from x in Game.Helper.FromCSV<Game.Model.Attaccante>("Attaccanti.csv") where x.Squadra == item.Nome select x).ToArray());
                item.Titolari.AddRange((from x in Game.Helper.FromCSV<Game.Model.Calciatore>("Titolari.csv") where x.Squadra == item.Nome select x).ToArray());
                item.Riserve.AddRange((from x in Game.Helper.FromCSV<Game.Model.Calciatore>("Riserve.csv") where x.Squadra == item.Nome select x).ToArray());

                return item;
            }
        }

        public static void Save(Model.Squadra item)
        {
            //Helper.ToCSV(item.Portieri, "Portieri.csv", ";");
            //Helper.ToCSV(item.Difensori, "Difensori.csv", ";");
            //Helper.ToCSV(item.Attaccanti, "Attaccanti.csv", ";");
            //Helper.ToCSV(item.Centrocampisti, "Centrocampisti.csv", ";");
            //Helper.ToCSV(item.Titolari.ToArray(), "Titolari.csv", ";");
            //Helper.ToCSV(item.Riserve.ToArray(), "Riserve.csv", ";");
            //
            //var nFile = "Squadra." + item.Nome + ".xml";
            //item.ToXMLFile(nFile);
            var nFile = "Squadra." + item.Nome + ".json";
            item.ToJSONFile(nFile);
        }

        #endregion

    }

}
