using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program10
    {
        static void Main(string[] args)
        {

            Nota n = new Nota(8);

            Console.WriteLine(n.Valor);
            Console.WriteLine(n.Tipo());
            Console.WriteLine(n.EsMayor(5, n.Valor));

            Console.ReadLine();

        }
    }
}
