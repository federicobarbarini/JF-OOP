using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ereditarieta.Model
{
    public class Persone: iMuoviti, iEntity
    {

        #region --> Dichiarazioni

        private int distanza = 0;

        #endregion

        #region --> Costruttori

        public Persone(string cognome, string nome, string comune, int datanascita) {
            this.Cognome = cognome;
            this.Nome = nome;
            this.Comune= comune;
            this.DataNascita= datanascita;
        }
        public Persone(string cognome, string nome, string comune): this(cognome, nome, comune, 0) {}
        public Persone(string cognome, string nome) : this(cognome, nome, string.Empty) {}

        public Persone() : this(string.Empty, string.Empty) { }

        #endregion

        #region --> Proprietà

        public Guid ID { get; set; } = Guid.NewGuid();

        public string? Nome { get; set; }

        public string? Cognome { get; set; }

        public string? Comune { get; set; }

        public int? DataNascita { get; set; }

        public string? Email { get; set; }

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
            return string.Format("Tipo: {0} - Cognome: {1} - Nome: {2} - Comune: {3} - Data di Nascita: {4} - Email: {5}", this.GetType().Name, this.Cognome, this.Nome, this.Comune, this.DataNascita, this.Email);
        }

        #endregion

    }
}
