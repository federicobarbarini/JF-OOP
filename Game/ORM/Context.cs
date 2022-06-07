using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.ORM
{
    public static class Context
    {


        public static string DatiPath { get { return System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\dati"); } }

        public static Model.Squadra Load(string nome)
        {
            var nFile = "Squadra." + nome + ".xml";
            var pathXML = System.IO.Path.Combine(DatiPath, nFile);
            if (System.IO.File.Exists(pathXML))
            {
                return Helper.FromXMLFile<Model.Squadra>(nFile);

            } else {
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
            Helper.ToCSV(item.Portieri, "Portieri.csv", ";");
            Helper.ToCSV(item.Difensori, "Difensori.csv", ";");
            Helper.ToCSV(item.Attaccanti, "Attaccanti.csv", ";");
            Helper.ToCSV(item.Centrocampisti, "Centrocampisti.csv", ";");
            Helper.ToCSV(item.Titolari.ToArray(), "Titolari.csv", ";");
            Helper.ToCSV(item.Riserve.ToArray(), "Riserve.csv", ";");

            var nFile = "Squadra." + item.Nome + ".xml";
            item.ToXMLFile(nFile);
        }

    }

    //    private string path = string.Empty;

    //    public Context(string path)
    //    {
    //        this.path = path;
    //    }

    //    public void Save<TEntity>(IEnumerable<Ereditarieta.Model.iEntity> elenco)
    //    {
    //        var toSave = (from x in elenco where x is TEntity select (TEntity)x).ToArray();
    //        var fileName = System.IO.Path.Combine(path, typeof(TEntity).Name + ".xml");
    //        if (System.IO.File.Exists(fileName)) System.IO.File.Delete(fileName);
    //        if (!toSave.Any()) return;

    //        var xml = toSave.Serialize();
    //        System.IO.File.WriteAllText(fileName, xml);
    //    }

    //    public IEnumerable<Ereditarieta.Model.Auto> LoadAuto()
    //    {
    //        var fileName = System.IO.Path.Combine(path, typeof(Ereditarieta.Model.Auto).Name + ".xml");
    //        if (!System.IO.File.Exists(fileName)) return Enumerable.Empty<Ereditarieta.Model.Auto>();

    //        var xml = System.IO.File.ReadAllText(fileName);
    //        if (xml.Trim()==string.Empty) return Enumerable.Empty<Ereditarieta.Model.Auto>();

    //        var elenco = Helper.DeSerialize<List<Ereditarieta.Model.Auto>>(xml);
    //        return elenco;
    //    }

    //}
}
