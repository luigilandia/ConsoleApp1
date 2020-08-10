using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program14
    {
        static void Main(string[] args)
        {
            //LineaDeCompra lc = new LineaDeCompra(1, 15.12, "pan");
            Compra compra = new Compra(1);
            compra.Id = 1;
            compra.AddLinea(new LineaDeCompra(1, 500, "ordenador"));
            compra.AddLinea(new LineaDeCompra(1, 300, "tablet"));

            Console.WriteLine(compra.ImporteTotal);
            Console.ReadLine();
        }
    }
}
