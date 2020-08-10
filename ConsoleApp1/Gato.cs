using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Gato : Animal
    {
        
        public string Cascabel { get; set; }

        public Gato(double peso, string color) : base(peso, color)
        {
        }

        public override void Vacunar()
        {
            Console.WriteLine("Vacunamos al gato con una inyección");
            estaVacunado = true;
        }
    }
}
