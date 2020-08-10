using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rectangulo
    {
        private double _lado1;
        private double _lado2;

        public Rectangulo(double lado1, double lado2)
        {
            _lado1 = lado1;
            _lado2 = lado2;
        }

        public double Lado1 { get => _lado1; set => _lado1 = value; }
        public double Lado2 { get => _lado2; set => _lado2 = value; }


        public double Area()
        {
            return Lado1 * Lado2;
            //return Rectangulo.Area(this.Lado1, this.Lado2);
        }

        public double Perimetro()
        {
            return 2 * Lado1 + 2 * Lado2;
        }
    }
}
