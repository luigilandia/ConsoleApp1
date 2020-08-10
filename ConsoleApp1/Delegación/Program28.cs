using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegación
{
    class Program28
    {
        //recibe 2 parametros t1 y t2 y devuelve t3
        //public delegate int Operacion(int a, int b);
        static void Main(string[] args)
        {
            //Func<int, int, int> mifuncion=Sumar;
            Func<int, int, int> mifuncion = (a, b)=>a*b;
            OperarPorPantalla(2, 3, Sumar);
            OperarPorPantalla(2, 3, Restar);
            OperarPorPantalla(2, 3, mifuncion);
            OperarPorPantalla(3, 3, (a,b)=>a/b);
            //SumarPorPantalla(2,3);
            Console.ReadLine();
        }
        public static int Sumar(int a, int b)
        {
            return a + b;
        }

        public static int Restar(int a, int b)
        {
            return a - b;
        }

        public static void OperarPorPantalla(int a, int b, Func<int, int, int> tipoOperacion)
        {
            Console.WriteLine("**************");
            /*if (tipoOperacion.Equals("sumar"))
            {
                Console.WriteLine(a + b);
            }
            else
            {
                Console.WriteLine(a - b);
            }*/
            Console.WriteLine(tipoOperacion(a, b));
            
            Console.WriteLine("**************");
        }

        /*public static void SumarPorPantalla(int a, int b)
        {
            Console.WriteLine("**************");
            Console.WriteLine(a+b);
            Console.WriteLine("**************");
        }

        public static void RestarPorPantalla(int a, int b)
        {
            Console.WriteLine("**************");
            Console.WriteLine(a - b);
            Console.WriteLine("**************");
        }*/
    }
}
