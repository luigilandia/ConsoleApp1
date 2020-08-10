using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AlquilerVIP : Alquiler
    {
        public AlquilerVIP(int numero, double importe) : base(numero, importe)
        {
        }

        public override double ImporteTotal()
        {
            return base.ImporteTotal() + 200;
        }
    }
}
