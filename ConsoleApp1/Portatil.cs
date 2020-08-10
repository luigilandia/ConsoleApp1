using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Portatil : Ordenador
    {
        public Portatil(CPU cpu) : base(cpu, new Monitor(15))
        {

        }
        public override void Encender()
        {
            Console.WriteLine("El portátil se enciende despacio");
            //llama al constructor de la clase superior
            base.EncenderMonitor();
            base.EncenderCPU();
            Console.WriteLine("El portátil terminó de encender");
        }
    }
}
