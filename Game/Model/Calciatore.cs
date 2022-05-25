using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Model
{
    public class Calciatore: iPersonaggio
    {
        public string? Nome { get; set; }
        public string? Ruolo {
            get
            {
                return this.GetType().Name;
            }
        }
        public string? Squadra { get; set; }
        public int? Velocita { get; set; }

        public void Su(int passi) {
            Console.WriteLine("Nome: {0} - {1}", this.Nome, new string("▲".ToCharArray().FirstOrDefault(), passi));
        }
        public void Giu(int passi) {
            Console.WriteLine("Nome: {0} - {1}", this.Nome, new string("▼".ToCharArray().FirstOrDefault(), passi));
        }
        public void Destra(int passi) {
            Console.WriteLine("Nome: {0} - {1}", this.Nome, new string("►".ToCharArray().FirstOrDefault(), passi));
        }
        public void Sinistra(int passi) {
            Console.WriteLine("Nome: {0} - {1}", this.Nome, new string("◄".ToCharArray().FirstOrDefault(), passi));
        }
    }
}
