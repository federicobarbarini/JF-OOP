using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Model
{
    public interface iArea
    {
        public int CalcolaArea() { return 0; }
        public string Fnome { get; set; }
    }
}
