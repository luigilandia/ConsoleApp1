using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Electrodomestico
    {
        public int NumeroSerie { get; set; }

        public virtual void Encender()
        {
            Console.WriteLine("El electrodoméstico se enciende");
        }

        public virtual void Apagar()
        {
            Console.WriteLine("El electrodoméstico se apaga");
        }
    }
}
