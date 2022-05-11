using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ereditarieta.Model
{
    public class Veicoli: MezziTrasp
    {

        #region --> Costruttori

        public Veicoli(string marca, string modello, int ruote) : base()
        {
            this.Merci = "Persone";
            this.UMMovimento = "Km";
            this.Carburante = "Benzina";
            this.NumeroRuote = ruote;
            this.Marca = marca;
            this.Modello = modello;
        }

        #endregion

        #region --> Proprietà

        public string? Marca { get; set; }

        public string? Modello { get; set; }

        public int? NumeroRuote { get;  set; }

        #endregion

        #region --> Metodi

        /// <summary>
        /// Overraide del metodo ToString della classe base object (da cui derivano tutte le classi)
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            return string.Format("{0} - Marca: {1} - Modello: {2} - Ruote: {3}", 
                                 base.ToString(), this.Marca, this.Modello, this.NumeroRuote);
        }

        #endregion

    }
}
