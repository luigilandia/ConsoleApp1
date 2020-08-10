using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    class GoogleHome : IEncendibles
    {
        public List<Bombilla> BombillaSmart { get; set; }

        public void Apagar()
        {
            Console.WriteLine("Las bombillas se han apagado");
        }

        public void Encender()
        {
            Console.WriteLine("Las bombillas se han encendido");
        }

    }
}
