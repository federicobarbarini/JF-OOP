using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Model
{
    public abstract class FiguraGeo: iArea
    {

        public virtual int Base { get; set; }
        public virtual int Altezza { get; set; }
        public string Fnome { get; set; }
        public virtual int CalcolaArea()
        {
            return this.Base * this.Altezza;
        }

    }
}
