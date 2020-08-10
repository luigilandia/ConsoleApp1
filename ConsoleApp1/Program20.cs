using ES.Semicrol.LibreriaFundanet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program20
    {
        static void Main(string[] args)
        {
            Dictionary<string, Persona> diccionario = new Dictionary<string, Persona>();
            Persona p1 = new Persona();
            p1.Nombre = "Pedro";
            p1.Apellidos = "Gomez";
            p1.Edad = 50;

            Persona p2 = new Persona();
            p2.Nombre = "Ana";
            p2.Apellidos = "Perez";
            p2.Edad = 30;

            diccionario.Add(p1.Nombre, p1);
            diccionario.Add(p2.Nombre, p2);

            Console.WriteLine(diccionario["Pedro"].Apellidos);

            foreach(Persona p in diccionario.Values)
            {
                Console.WriteLine(p);
            }

            foreach(String nombre in diccionario.Keys)
            {
                Console.WriteLine(nombre);
            }

            Telefono t = new Telefono();
            t.Numero = 123456;
            Console.WriteLine(t.Numero);

            Console.ReadLine();
        }
    }
}
