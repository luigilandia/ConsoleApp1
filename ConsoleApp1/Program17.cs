using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program17
    {
        static void Main(string[] args)
        {
            Animal a1 = new Perro(40, "negro");
            a1.Vacunar();
            //no puedo poner a1.Collar porque eso es
            // un atributo específico del gato
            Perro p1 = new Perro(30, "blanco");
            p1.Vacunar();
            Console.WriteLine(p1.estaVacunado);
            Gato g1 = new Gato(30, "blanco");
            g1.Vacunar();
            Console.WriteLine(g1.estaVacunado);
            VacunarAnimal(p1);
            VacunarAnimal(g1);
            Animal g2 = FactoriaAnimales.GetAnimal("Gato", 40, "negro");
            Animal p2 = FactoriaAnimales.GetAnimal("Perro", 40, "negro");
            Perro miperro = (Perro)p2;
            
            Console.WriteLine(p2.GetType().Name);
            VacunarAnimal(g2);
            VacunarAnimal(p2);

            Perro p3 = new Perro(20, "marron");
            Perro p4 = new Perro(20, "marron");
            //los objetos en .NET se comparan de esta manera
            Console.WriteLine(p3.Equals(p4));

            Console.ReadLine();

        }

        public static void VacunarAnimal(Animal a)
        {
            a.Vacunar();
            Console.WriteLine(a.estaVacunado);
        }
    }
}
