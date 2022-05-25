using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Model
{
    public class Difensore: Calciatore
    {
        //public Difensore() : base() { this.Ruolo = "Difensore"; }
        public int Scivolata { get; set; }
        public int Intercettazione  { get; set; }

    }
}
