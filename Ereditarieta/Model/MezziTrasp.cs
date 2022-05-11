using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ereditarieta.Model
{
    public abstract class MezziTrasp: iMuoviti
    {

        #region --> Dichiarazioni

        private int distanza = 0;

        #endregion

        #region --> Costruttori

        public MezziTrasp() : base() { }
        public MezziTrasp(string merci) : this("Gasolio", merci) { }
        public MezziTrasp(string carburante, string merci) : this(carburante, merci, "Km") { }
        public MezziTrasp(string carburante, string merci, string um) : base()
        {
            this.Carburante = carburante;
            this.Merci = merci;
            this.UMMovimento = um;
            this.Muoviti(20);
        }

        #endregion

        #region --> Proprietà

        public string? Carburante { get; set; }

        public string? Merci { get; set; }

        public string? UMMovimento { get; set; }

        #endregion

        #region --> Metodi

        public void Muoviti(int movimento)
        {
            distanza += movimento;
        }

        /// <summary>
        /// Overraide del metodo ToString della classe base object (da cui derivano tutte le classi)
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            return string.Format("Tipo: {0} - Carburante: {1} - Merci: {2} - Distanza: {3} {4}", this.GetType().Name, this.Carburante, this.Merci, this.distanza, this.UMMovimento);
        }

        #endregion

    }
}
