using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Model
{
    public class Centrocampista: Calciatore
    {
        //public Centrocampista() : base() { this.Ruolo = "Centrocampista"; }
        public int Visione { get; set; }
        public int Passaggio { get; set; }
        public int Cross { get; set; }
    }
}
