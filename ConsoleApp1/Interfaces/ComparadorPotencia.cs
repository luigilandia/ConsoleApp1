using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    class ComparadorPotencia : IComparer<FrigorificoProfesor>
    {
        public int Compare(FrigorificoProfesor x, FrigorificoProfesor y)
        {
            if (x.Potencia > y.Potencia)
            {
                return 1;
            }
            else if (x.Potencia==y.Potencia)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
