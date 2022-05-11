using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ereditarieta.Model
{
    public class Auto: Veicoli
    {

        #region --> Costruttori

        public Auto(string marca, string modello): base(marca, modello, 4) {}

        #endregion

    }
}
