using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulamento
{
    public class Test2
    {
        private int result = 0;

        public int Incrementa(int value)
        {
            result +=value;
            return result;
        }

        public int Decrementa(int value)
        {
            result -= value;
            return result;
        }
    }
}
