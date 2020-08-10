using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    class Segway:IConducible, IConectable
    {
        public void Arrancar()
        {
            Console.WriteLine("El segway arranca");
        }

        public void Avanzar()
        {
            Console.WriteLine("El segway avanza");
        }

        public void Conectar()
        {
            Console.WriteLine("Conectando el segway");
        }

        public void Desconectar()
        {
            Console.WriteLine("Desconectando el segway");
        }

        public void Girar()
        {
            Console.WriteLine("El segway gira");
        }

        public void Parar()
        {
            Console.WriteLine("El segway para");
        }
    }
}
