using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegación
{
    class Program29
    {
        static void Main(string[] args)
        {
            List<Persona> lista = new List<Persona>();
            lista.Add(new Persona("pepe", 30));
            lista.Add(new Persona("ana", 40));
            lista.Add(new Persona("maría", 10));
            lista.Add(new Persona("andrés", 50));

            var resultado=lista.Where((personita) => personita.Edad >= 40);
            foreach (Persona p in resultado)
            {
                Console.WriteLine(p.Nombre);
            }

            Console.ReadLine();
        }
    }
}
