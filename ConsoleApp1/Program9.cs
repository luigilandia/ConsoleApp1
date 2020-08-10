using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program9
    {
        static void Main(string[] args)
        {

            Rectangulo r = new Rectangulo(2, 3);
           
            Console.WriteLine(r.Area());
            Console.WriteLine(r.Perimetro());

            Console.ReadLine();

        }

    }
}
