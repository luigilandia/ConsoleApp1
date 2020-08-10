using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LineaDeCompra
    {
        public LineaDeCompra(int numLinea, double importe, string concepto)
        {
            NumLinea = numLinea;
            Importe = importe;
            Concepto = concepto;
        }

        public int NumLinea { get; set; }
        public double Importe { get; set; }
        public string Concepto { get; set; }
        
        public double ImporteIVA()
        {
            double total = 0;
            
            
                total += Importe * 1.21;
            
            return total;
        }
    }
}
