using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program16
    {
        static void Main(string[] args)
        {
            //CPU c = new CPU();
            Ordenador or = new Ordenador(new CPU(), new Monitor(15));
            Portatil p = new Portatil(new CPU());
            or.Encender();
            p.Encender();
            
            Console.ReadLine();
        }
    }
}
