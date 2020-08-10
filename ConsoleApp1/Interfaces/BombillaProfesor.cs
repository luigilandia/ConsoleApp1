using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    class BombillaProfesor : IEncendibles
    {
        public void Apagar()
        {
            Console.WriteLine("Apagar la bombilla");
        }

        public void Encender()
        {
            Console.WriteLine("Encender la bombilla");
        }
    }
}
