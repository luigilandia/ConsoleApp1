using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program19
    {
        static void Main(string[] args)
        {
            bool verdadero = true;
            //inboxing
            Boolean otroVerdadero = verdadero;
            //outboxing
            bool otromasverdadero = otroVerdadero;
            Console.WriteLine(verdadero);
            int numero = 7;
            Console.WriteLine(numero);
            Int32 numero2 = 2000;
            Console.WriteLine(numero2);
            int numero6=Int32.Parse("30");
            Console.WriteLine(numero6 + 1);
            List<Int32> lista = new List<Int32>();
            lista.Add(5);
            lista.Add(4);
            lista.Add(7);

            foreach(Int32 n in lista)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
}
