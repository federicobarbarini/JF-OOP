using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulamento
{
    public class Test3
    {
        private int result = 0;
        private enum tipoOperazione: byte
        {
            Addizione = 0,
            Sottrazione = 1,
            Moltiplica = 2
        };

        private int Operazione(int value, tipoOperazione tipo)
        {
            switch (tipo)
            {
                case tipoOperazione.Addizione:
                    result += value;
                    break;

                case tipoOperazione.Sottrazione:
                    result -= value;
                    break;

                case tipoOperazione.Moltiplica:
                    result *= value;
                    break;

                default:
                    result += value;
                    break;
            };
            return result;
        }

        public int Incrementa(int value)
        {
            return this.Operazione(value, tipoOperazione.Addizione);
        }

        public int Decrementa(int value)
        {
            return this.Operazione(value, tipoOperazione.Sottrazione);
        }
        public int Moltiplica(int value)
        {
            return this.Operazione(value, tipoOperazione.Moltiplica);
        }


    }
}
