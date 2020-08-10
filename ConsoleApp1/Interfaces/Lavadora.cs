using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    class Lavadora
    {
        public Lavadora(string marca)
        {
            Marca = marca;
        }

        public string Marca { get; set; }

    }
}
