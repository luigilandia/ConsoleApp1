using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ClaseGenerica
{
    class Program24
    {
        static void Main(string[] args)
        {
            Bolsa<Golosina> bolsa = new Bolsa<Golosina>(5);
            bolsa.AddElemento(new Golosina("fresa"));
            bolsa.AddElemento(new Golosina("limón"));
            bolsa.AddElemento(new Golosina("naranja"));
            bolsa.AddElemento(new Golosina("platano"));
            bolsa.AddElemento(new Golosina("limón"));
            bolsa.AddElemento(new Golosina("naranja"));
            bolsa.AddElemento(new Golosina("platano"));
            /*foreach (Golosina g in bolsa.Elementos)
            {
                Console.WriteLine(g.Sabor);
                Console.WriteLine(g.ToString());
            }*/

            Golosina a = new Golosina("limon");
            Golosina b = new Golosina("fresa");
            Pack<Golosina, Golosina> mipack = new Pack<Golosina, Golosina>(a, b);

            Console.WriteLine(mipack.Elemento1.Sabor);
            Console.WriteLine(mipack.Elemento2.Sabor);

            Console.ReadLine();

        }
    }
}
