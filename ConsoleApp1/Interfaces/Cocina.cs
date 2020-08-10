using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    class Cocina:IEncendibles
    {
        public Lavadora Lavadora { get; set; }
        public Frigorífico Frigorifico { get; set; }
        public List<Bombilla> Bombillas { get; set; }

        public Cocina()
        {

        }

        public Cocina(Lavadora lavadora, Frigorífico frigorifico, List<Bombilla> bombillas)
        {
            Lavadora = lavadora;
            Frigorifico = frigorifico;
            Bombillas = bombillas;
        }

        public void Apagar()
        {
            Console.WriteLine("La cocina se ha encendido");
        }

        public void Encender()
        {
            Console.WriteLine("La cocina se ha apagado");
        }

        
    }
}
