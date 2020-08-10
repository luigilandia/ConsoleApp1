using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ordenador
    {
        public Ordenador(CPU cpu, Monitor monitor)
        {
            this.cpu = cpu;
            this.monitor = monitor;
        }

        public string marca { get; set; }
        public string modelo { get; set; }
        //public int año { get; set; }
        //public double precio { get; set; }
        public CPU cpu { get; set; }
        public Monitor monitor { get; set; }

        public virtual void Encender()
        {
            //Console.WriteLine("El ordenador se ha encendido");
            cpu.Encender();
            monitor.Encender();
        }

        protected virtual void EncenderCPU()
        {
            cpu.Encender();
        }

        protected virtual void EncenderMonitor()
        {
            cpu.Encender();
        }

        public virtual void Apagar()
        {
            Console.WriteLine("El ordenador se ha apagado");
        }

        public virtual void Actualizar()
        {
            Console.WriteLine("El ordenador se ha actualizado");
        }
    }
}
