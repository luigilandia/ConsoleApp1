using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ClaseGenerica
{
    class Chocolatina:IPrecio
    {
        public Chocolatina(string tipoChocolate)
        {
            TipoChocolate = tipoChocolate;
        }

        public string TipoChocolate { get; set; }
        public double Importe { get; set; }
    }
}
