using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    class FrigorificoProfesor : IEncendibles, IComparable<FrigorificoProfesor>
    {
        public FrigorificoProfesor(int potencia)
        {
            Potencia = potencia;
        }

        public int Potencia { get; set; }

        public void Apagar()
        {
            Console.WriteLine("El frigorifico se apaga");
        }

        public int CompareTo(FrigorificoProfesor otroFrigo)
        {
            if (otroFrigo.Potencia < this.Potencia)
            {
                return -1;
            }
            else if (otroFrigo.Potencia == this.Potencia)
            {
                return 0;
            }
            else
            {
                return 1;
            }
            
        }

        public void Encender()
        {
            Console.WriteLine("El frigorifico se enciende");
        }
    }
}
