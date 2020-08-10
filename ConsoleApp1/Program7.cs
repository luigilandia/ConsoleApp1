using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program7
    {
        static void Main(string[] args)
        {
            //operador new construye un objeto en memoria
            Persona p1 = new Persona();
            p1.Nombre = "pedro";
            p1.Apellidos = "gomez";
            p1.Edad = 20;

            Console.WriteLine(p1.Nombre);
            Console.WriteLine(p1.Apellidos);
            Console.WriteLine(p1.Edad);
            Console.ReadLine();
        }

        //bloque de código reutilizable
        // el cual nosotros podemos invocar

    }
}
