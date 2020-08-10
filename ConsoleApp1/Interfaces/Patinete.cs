using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    class Patinete : IConducibleConectable
    {
        public void Arrancar()
        {
            Console.WriteLine("El patinete arranca");
        }

        public void Avanzar()
        {
            Console.WriteLine("El patinete avanza");
        }

        public void Conectar()
        {
            Console.WriteLine("Conecto el patinete");
        }

        public void Desconectar()
        {
            Console.WriteLine("Desconecto el patinete");
        }

        public void Girar()
        {
            Console.WriteLine("El patinete gira");
        }

        public void Parar()
        {
            Console.WriteLine("El patinete para");
        }
    }
}
