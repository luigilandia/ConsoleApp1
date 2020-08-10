using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Compra
    {

        public int Id { get; set; }

        public Compra(int id)
        {
            Id = id;
            lineaDeCompra = new List<LineaDeCompra>();
        }

        public double _ImporteTotal;
        public List<LineaDeCompra> lineaDeCompra { get; set; }
        
        public void AddLinea(LineaDeCompra linea)
        {
            this.lineaDeCompra.Add(linea);
        }

        public double ImporteTotal
        {
            get

            {
                double total = 0;

                foreach(LineaDeCompra linea in lineaDeCompra)
                {
                   total += linea.Importe;
                }

                return total;
            }
        }

        public double ImporteIva()
        {

            double total = 0;
            foreach(LineaDeCompra linea in lineaDeCompra)
            {
                total += linea.ImporteIVA();
            }

            return total;
        }

        
    }
}
