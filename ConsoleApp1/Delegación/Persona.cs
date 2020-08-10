using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegación

{
    class Persona
    {
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public string Nombre { get; set; }
        private int _edad;

        public int Edad
        {
            get
            {
                return _edad;
            }
            set
            {
                if (value>120 || value < 0)
                {
                    throw new Exception("Esa edad es imposible");
                }
                else
                {
                    _edad = value;
                }
            }
        }

    }
}
