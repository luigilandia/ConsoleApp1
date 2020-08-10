using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program15
    {
        static void Main(string[] args)
        {
            Televisor t = new Televisor();
            t.NumeroSerie = 100;
            t.pulgadas = 50;
            t.Encender();
            Console.ReadLine();
        }
    }
}
