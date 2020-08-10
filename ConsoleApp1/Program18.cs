using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program18
    {
        static void Main(string[] args)
        {
            Alquiler a1 = new AlquilerJoven(1, 200);
            Alquiler a2 = new AlquilerJoven(2, 300);
            Alquiler a3 = new AlquilerJoven(3, 400);
            Alquiler a4 = new AlquilerJoven(4, 500);

            Empresa e = new Empresa();
            e.AddAlquiler(a1);
            e.AddAlquiler(a2);
            e.AddAlquiler(a3);
            e.AddAlquiler(a4);

            e.RemoveAlquiler(a4);

            Console.WriteLine(e.CalcularSumaTotal());
            Alquiler elegido = e.DevuelveMasCaro();
            Console.WriteLine(elegido.Numero);
            Console.WriteLine(e.DevuelveMasCaro().ImporteTotal());
            Console.WriteLine(e.ContieneAlquiler(a4));

            Console.ReadLine();
        }

    }
}
