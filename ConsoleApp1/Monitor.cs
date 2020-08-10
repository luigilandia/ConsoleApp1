using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Monitor
    {
        public Monitor(int pulgadas)
        {
            this.pulgadas = pulgadas;
        }

        public int pulgadas { get; set; }

        public void Encender()
        {
            Console.WriteLine("El monitor se enciende");
        }

        public void Apagar()
        {
            Console.WriteLine("El monitor se apaga");
        }
    }
}
