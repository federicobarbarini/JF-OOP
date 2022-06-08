using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Model
{
    public class Squadra: iPersonaggio
    {

        #region --> Proprieta
        public Portiere[] Portieri
        {
            get
            {
                return (from x in this.Rosa where x.Ruolo.ToLowerInvariant() == "portiere" select (Portiere)x).ToArray();
            }
        }
        public Difensore[] Difensori
        {
            get
            {
                return (from x in this.Rosa where x.Ruolo.ToLowerInvariant() == "difensore" select (Difensore)x).ToArray();
            }
        }
        public Centrocampista[] Centrocampisti
        {
            get
            {
                return (from x in this.Rosa where x.Ruolo.ToLowerInvariant() == "centrocampista" select (Centrocampista)x).ToArray();
            }
        }

        public Attaccante[] Attaccanti
        {
            get
            {
                return (from x in this.Rosa where x.Ruolo.ToLowerInvariant() == "attaccante" select (Attaccante)x).ToArray();
            }
        }
        public string? Nome { get; set; }

        public List<Calciatore> Rosa { get; set; } = new List<Calciatore>();

        public List<Calciatore> Titolari { get; set; } = new List<Calciatore>();

        public List<Calciatore> Riserve { get; set; } = new List<Calciatore>();

        #endregion

        #region --> Metodi

        public void Su(int passi) {
            foreach (var item in this.Titolari) {
                item.Su(passi);
            }
        }

        public void Giu(int passi) {
            foreach (var item in this.Titolari) {
                item.Giu(passi);
            }
        }
        public void Destra(int passi) {
         foreach (var item in this.Titolari)
                    {
                        item.Destra(passi);
                    }
                }
        public void Sinistra(int passi)
        {
            foreach (var item in this.Titolari)
            {
                item.Sinistra(passi);
            }
        }

        public void Distinta() { 
            if(this.Titolari.Count() == 0) {
                Console.WriteLine("Non ci sono Titolari vuoi caricarmi la distinta?");
                var r = Console.ReadLine();
                if(r.ToUpperInvariant() == "SI")
                {
                    foreach (var item in this.Rosa)
                    {
                        Console.WriteLine("Ruolo: {0} - Nome: {1} titolare?", item.Ruolo, item.Nome);
                        var x = Console.ReadLine();
                        if (x.ToUpper() == "T") this.Titolari.Add(item);
                        if (x.ToUpper() == "R") this.Riserve.Add(item);
                    }
                }
            };
            Console.WriteLine("Titolari: ");
            foreach (var d in this.Titolari) { 
                Console.WriteLine("Ruolo: {0} - Nome: {1}", d.Ruolo, d.Nome); 
            }
            Console.WriteLine("Riserve: ");
            foreach (var d in this.Riserve)
            {
                Console.WriteLine("Ruolo: {0} - Nome: {1}", d.Ruolo, d.Nome);
            }
        }

        #endregion

    }
}
