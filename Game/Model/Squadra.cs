using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Model
{
    public class Squadra: List<Calciatore>, iPersonaggio
    {
        public string? Nome { get; set; }
        public void Su(int passi) {
            foreach (var item in this) {
                item.Su(passi);
            }
        }

        public void Giu(int passi) {
            foreach (var item in this) {
                item.Giu(passi);
            }
        }
        public void Destra(int passi) {
         foreach (var item in this)
                    {
                        item.Destra(passi);
                    }
                }
        public void Sinistra(int passi)
        {
            foreach (var item in this)
            {
                item.Sinistra(passi);
            }
        }
        public Portiere[] Portieri { 
            get {
                return (from x in this where x.Ruolo.ToLowerInvariant() == "portiere" select (Portiere)x).ToArray();    
            }
        }
        public Difensore[] Difensori
        {
            get
            {
                return (from x in this where x.Ruolo.ToLowerInvariant() == "difensore" select (Difensore)x).ToArray();
            }
        }
        public Centrocampista[] Centrocampisti
        {
            get
            {
                return (from x in this where x.Ruolo.ToLowerInvariant() == "centrocampista" select (Centrocampista)x).ToArray();
            }
        }

        public Attaccante[] Attaccanti {
            get
            {
                return (from x in this where x.Ruolo.ToLowerInvariant() == "attaccante" select (Attaccante)x).ToArray();
            }
        }

    }
}
