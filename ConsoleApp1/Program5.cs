using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program5
    {
        static void Main(string[] args)
        {
            double resultado = sumarNumeros(2, 2);
            Console.WriteLine(resultado);
            double resultado2 = sumarNumeros(3, 3);
            Console.WriteLine(resultado2);
            Console.ReadLine();
        }
        //bloque de código reutilizable
        // el cual nosotros podemos invocar

        static double sumarNumeros(double a, double b)
        {
            return a + b;
        }
    }
}
