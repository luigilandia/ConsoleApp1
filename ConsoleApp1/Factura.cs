using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Factura
    {
        private int _numero;
        private string _concepto;
        private double _importe;

        public Factura()
        {

        }

        public Factura(int numero)
        {
            Numero = numero;
        }

        public Factura(int numero, string concepto, double importe)
        {
            Numero = numero;
            Concepto = concepto;
            Importe = importe;
        }

        public int Numero { get => _numero; set => _numero = value; }
        public string Concepto { get => _concepto; set => _concepto = value; }
        public double Importe { get => _importe; set => _importe = value; }

        public double CalcularIVA()
        {
            return _importe * 1.21;
        }

        public double CalcularIVA(int porcentaje)
        {
            return _importe +(_importe*porcentaje/100);
        }
    }
}
