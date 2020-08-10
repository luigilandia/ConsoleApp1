using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Empresa
    {
        public List<Alquiler> Alquileres { get; set; }
        
        public Empresa()
        {
            Alquileres = new List<Alquiler>();
        }

        public void AddAlquiler(Alquiler a)
        {
            this.Alquileres.Add(a);
        }

        public double CalcularSumaTotal()
        {
            double total = 0;
            foreach (Alquiler a in Alquileres)
            {
                total += a.ImporteTotal();
            }
            return total;
        }

        public Alquiler DevuelveMasCaro()
        {
            Alquiler mayor = Alquileres[0];
            foreach (Alquiler a in Alquileres)
            {
                if (mayor.ImporteTotal() < a.ImporteTotal())
                {
                    mayor = a;
                }
            }
            return mayor;
        }

        public void RemoveAlquiler(Alquiler a)
        {
            this.Alquileres.Remove(a);
        }

        public int NumAlquileres()
        {
            return this.Alquileres.Count();
        }

        public bool ContieneAlquiler(Alquiler a)
        {
            return this.Alquileres.Contains(a);
        }
    }
}
