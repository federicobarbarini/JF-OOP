using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Model
{
    public class Cerchio: iArea
    {
        public Cerchio() : base() { this.Fnome = "Cerchio";  }
        public string Fnome { get; set; }
        public int Raggio { get; set; }

        public virtual int CalcolaArea()
        {
            return (int)(this.Raggio * this.Raggio * 3.14);
        }

    }
}
