using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Televisor:Electrodomestico
    {
        public int pulgadas { get; set; }

        public override void Encender()
        {
            //base.Encender();
            Console.WriteLine("El televisor se enciende");
        }

        public override void Apagar()
        {
            base.Encender();
            Console.WriteLine("El televisor se apaga");
        }
    }
}
