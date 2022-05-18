using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ereditarieta.ORM
{
    public class Context
    {

        private string path = string.Empty;

        public Context(string path)
        {
            this.path = path;
        }

        public void Save<TEntity>(IEnumerable<Ereditarieta.Model.iEntity> elenco)
        {
            var toSave = (from x in elenco where x is TEntity select (TEntity)x).ToArray();
            var fileName = System.IO.Path.Combine(path, typeof(TEntity).Name + ".xml");
            if (System.IO.File.Exists(fileName)) System.IO.File.Delete(fileName);
            if (!toSave.Any()) return;

            var xml = toSave.Serialize();
            System.IO.File.WriteAllText(fileName, xml);
        }

        public IEnumerable<Ereditarieta.Model.Auto> LoadAuto()
        {
            var fileName = System.IO.Path.Combine(path, typeof(Ereditarieta.Model.Auto).Name + ".xml");
            if (!System.IO.File.Exists(fileName)) return Enumerable.Empty<Ereditarieta.Model.Auto>();

            var xml = System.IO.File.ReadAllText(fileName);
            if (xml.Trim()==string.Empty) return Enumerable.Empty<Ereditarieta.Model.Auto>();

            var elenco = Helper.DeSerialize<List<Ereditarieta.Model.Auto>>(xml);
            return elenco;
        }

    }
}
