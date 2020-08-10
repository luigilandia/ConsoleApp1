using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Perro : Animal
    {
        public string Collar { get; set; }

        public Perro(double peso, string color) : base(peso, color)
        {
        }

        public override void Vacunar()
        {
            Console.WriteLine("Vacunamos al perro con 2 inyecciones");
            estaVacunado = true;
        }
    }
}
