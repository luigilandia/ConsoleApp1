using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Alquiler
    {
        public int Numero { get; set; }
        public double Importe { get; set; }

        public Alquiler(int numero, double importe)
        {
            Numero = numero;
            Importe = importe;
        }

        public virtual double ImporteTotal()
        {
            return Importe * 1.21;
        }

        public override bool Equals(object obj)
        {
            var alquiler = obj as Alquiler;
            return alquiler != null &&
                   Numero == alquiler.Numero &&
                   Importe == alquiler.Importe;
        }

        public override int GetHashCode()
        {
            var hashCode = -1858188936;
            hashCode = hashCode * -1521134295 + Numero.GetHashCode();
            hashCode = hashCode * -1521134295 + Importe.GetHashCode();
            return hashCode;
        }

        public Alquiler MasCaro(Alquiler otro)
        {
            if (otro.ImporteTotal() > ImporteTotal())
            {
                return otro;
            }
            else
            {
                return this;
            }
        }
    }




}
