using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TablaDel5
    {
        static void Main(string[] args)
        {
            int numero = 1;
            while (numero <= 10)
            {
                int num = numero * 5;
                Console.WriteLine(num);
                numero++;
            }

            Console.ReadLine();
        }
    }
}
