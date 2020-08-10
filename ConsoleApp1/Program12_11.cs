using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program12_11
    {
        static void Main(string[] args)
        {
            List<Nota> misNotas = new List<Nota>();
            misNotas.Add(new Nota(3));
            misNotas.Add(new Nota(4));
            misNotas.Add(new Nota(5));
            misNotas.Add(new Nota(6));
            misNotas.Add(new Nota(7));
            misNotas.Add(new Nota(8));

            foreach (Nota n in misNotas)
            {
                Console.WriteLine(n.Valor);
            }

            int i=0;
            double total = 0;
            foreach (Nota n in misNotas)
            {
                //Console.WriteLine(n.Valor);
                total = total+n.Valor;
            }
            Console.WriteLine("La nota media es " +total/misNotas.Count);

            Nota notaMayor = new Nota(0);

            foreach (Nota unaNota in misNotas)
            {
                // usar programación oo
                notaMayor = unaNota.esMayor(notaMayor);
            }

            Console.WriteLine("La nota mayor es " + notaMayor.Valor);

            Console.ReadLine();
        }
    }
}
