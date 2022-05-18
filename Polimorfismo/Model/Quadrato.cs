using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Model
{
    public class Quadrato: FiguraGeo
    {

        public Quadrato() : base() { this.Fnome = "Quadrato"; }
       
        public override int Base { 
            get
            {
                return base.Base;
            }
            set
            {
                if (base.Base == value) return;
                base.Base = value;
                base.Altezza = value;
            } 
        }
        public override int Altezza
        {
            get
            {
                return base.Altezza;
            }
            set
            {
                if (base.Altezza == value) return;
                base.Base = value;
                base.Altezza = value;
            }
        }

    }
}
