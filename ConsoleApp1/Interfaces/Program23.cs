using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    class Program23
    {
        static void Main(string[] args)
        {
            List<FrigorificoProfesor> lista = new List<FrigorificoProfesor>();
            lista.Add(new FrigorificoProfesor(20));
            lista.Add(new FrigorificoProfesor(20));
            lista.Add(new FrigorificoProfesor(30));
            lista.Add(new FrigorificoProfesor(60));
            lista.Add(new FrigorificoProfesor(10));
            lista.Sort();
            lista.Sort(new ComparadorPotencia());
            foreach (FrigorificoProfesor f in lista)
            {
                Console.WriteLine(f.Potencia);
            }

            Console.ReadLine();
        }
    }
}
