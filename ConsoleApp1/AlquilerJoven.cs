using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AlquilerJoven : Alquiler
    {

        public AlquilerJoven(int numero, double importe) : base(numero, importe)
        {
        }

        public override double ImporteTotal()
        {
            return base.ImporteTotal() - 200;
        }
    }
}
