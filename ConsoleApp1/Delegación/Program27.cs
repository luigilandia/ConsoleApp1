using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegación
{
    class Program27
    {
        delegate int Operacion(int a, int b);

        static void Main(string[] args)
        {
            Operacion o=new Operacion(Sumar);
            int resultado = o(2, 2);
            //int resultado = Sumar(2, 2);
            Console.WriteLine(resultado);
            Console.ReadLine();
            
        }

        public static int Sumar(int a, int b)
        {
            return a + b;
        }
    }
}
