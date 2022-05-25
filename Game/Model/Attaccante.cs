using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Model
{
    public class Attaccante: Calciatore
    {

        public Attaccante() : base() { this.Ruolo = "Attaccante"; }
        public int Tiro { get; set; }
        public int Dribbling { get; set; }
        public int Colpo_Di_Testa { get; set; }
        public int Freddezza { get; set; }
    }
}
