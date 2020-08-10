using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program8
    {
        static void Main(string[] args)
        {
            //operador new construye un objeto en memoria
            Factura f = new Factura(5, "ordenador", 500);
            //f.Numero = 5;
            //f.Concepto = "ordenador";
            //f.Importe = 400;
            Console.WriteLine(f.CalcularIVA());
            Console.WriteLine(f.CalcularIVA(10));

            Console.ReadLine();
        }

        //bloque de código reutilizable
        // el cual nosotros podemos invocar

    }
}
