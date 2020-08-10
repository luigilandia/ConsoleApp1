using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    class Moto : IConducible
    {
        public void Arrancar()
        {
            Console.WriteLine("La moto arranca");
        }

        public void Avanzar()
        {
            Console.WriteLine("La moto avanza");
        }

        public void Girar()
        {
            Console.WriteLine("La moto gira");
        }

        public void Parar()
        {
            Console.WriteLine("La moto para");
        }
    }
}
