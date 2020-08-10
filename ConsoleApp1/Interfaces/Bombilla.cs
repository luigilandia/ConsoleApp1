using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    class Bombilla
    {
        public Bombilla(double watios)
        {
            Watios = watios;
        }

        public double Watios { get; set; }

    }
}
