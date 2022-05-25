using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Model
{
    public interface iPersonaggio
    {
        public string? Nome { get; set; }
        public void Su (int passi) { }
        public void Giu (int passi) { }
        public void Destra (int passi) { }  
        public void Sinistra (int passi) { }


    }
}
