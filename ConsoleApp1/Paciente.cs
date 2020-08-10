using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Paciente
    {
        public Paciente(string dNI, string nombre)
        {
            DNI = dNI;
            Nombre = nombre;
        }

        public Paciente(string dNI, string nombre, HistorialMedico historialMedico):this(dNI,nombre)
        {
            //no inicializo los campos porque
            //delego el constructor de dos parámetros
            HistorialMedico = historialMedico;
        }

        public string DNI { get; set; }
        public string Nombre { get; set; }
        public HistorialMedico HistorialMedico { get; set; }
    }
}
