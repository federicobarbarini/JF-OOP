using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ereditarieta.Model
{
    public class Bici: Veicoli
    {

        #region --> Costruttori
        public Bici() : this(string.Empty, string.Empty) { }

        public Bici(string marca, string modello) : base(marca, modello, 2) { }

        #endregion

    }
}
