using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Nota
    {
        private int _valor;

        public Nota()
        {

        }

        public Nota(int valor)
        {
            Valor = valor;
        }

        public int Valor { get => _valor; set => _valor = value; }

        public string Tipo()
        {
            if (_valor < 3)
            {
                return "Muy deficiente";
            } else if (_valor < 5)
            {
                return "Insuficiente";
            }
            else if (_valor <= 6)
            {
                return "Suficiente";
            } else if (_valor < 7)
            {
                return "Bien";
            } else if (_valor < 9)
            {
                return "Notable";
            }
            else {
                return "Sobresaliente";
            }
            
        }

        public string EsMayor(int not1, int not2)
        {
            if (not1 > not2)
            {
                return "La nota sacada es menor que " + not1;
            }
            else
            {
                return "La nota sacada es mayor que " + not1;
            }

            //return Nota.ElegirMayor(this, otra);
        }

        public Nota esMayor(Nota otra)
        {
            if (otra.Valor > Valor)
            {
                return otra;
            }
            else
            {
                return this;
            }
        }
    }
}
