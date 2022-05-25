using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Model
{
    public class Portiere: Calciatore
    {
        public Portiere() : base() { this.Ruolo = "Portiere"; }
        public int Tuffo { get; set; }
        public int Parata { get; set; }
        public int Riflessi { get; set; }

        
    }
}
