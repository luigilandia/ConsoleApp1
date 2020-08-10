using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program6
    {
        static void Main(string[] args)
        {
            //operador new construye un objeto en memoria
            Madalena m1 = new Madalena();
            m1.Color = "amarilla";
            m1.Peso = 2;
            m1.Precio = 3;

            Console.WriteLine(m1.Precio);
            Console.WriteLine(m1.Color);
            Console.WriteLine(m1.Peso);
            Console.ReadLine();
        }

        //bloque de código reutilizable
        // el cual nosotros podemos invocar

    }
}
