using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ManejoExcepciones
{
    class Program26
    {
        static void Main(string[] args)
        {
            try
            {
                Persona p = new Persona("luis", 121);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
