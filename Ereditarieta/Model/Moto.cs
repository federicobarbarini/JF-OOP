using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ereditarieta.Model
{
    public class Moto: Veicoli
    {

        #region --> Costruttori

        public Moto() : this(string.Empty, string.Empty) { }

        public Moto(string marca, string modello) : base(marca, modello, 2) { }

        #endregion

    }
}
