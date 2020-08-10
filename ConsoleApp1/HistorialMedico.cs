using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HistorialMedico
    {
        public HistorialMedico(int numHistorial, DateTime fecha, Paciente paciente)
        {
            this.numHistorial = numHistorial;
            this.fecha = fecha;
            this.paciente = paciente;
        }

        public int numHistorial { get; set; }
        public DateTime fecha { get; set; }
        public Paciente paciente { get; set; }
    }
}
