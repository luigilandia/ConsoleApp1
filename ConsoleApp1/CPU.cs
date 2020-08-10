using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CPU
    {
        //public string sistemaOperativo { get; set; }
        //public string tarjetaGrafica { get; set; }
        //public string discoDuro { get; set; }
        public string procesador { get; set; }
        public int RAM { get; set; }

        public void Encender()
        {
            Console.WriteLine("La CPU se enciende");
        }

        public void Apagar()
        {
            Console.WriteLine("La CPU se apaga");
        }


    }
}
