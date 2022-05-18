using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Model
{
    public class Triangolo: FiguraGeo
    {
        public Triangolo() : base() { this.Fnome = "Triangolo"; }
        public override int CalcolaArea()
        {
            return  base.CalcolaArea()/2;
        }
    }
}
