using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Alumno
    {
        public string Nombre { get; set; }
        //añadir notas poco a poco
        private List<Nota> _notas = new List<Nota>();

        public List<Nota> Notas
        {
            get
            {
                return _notas;
            }
            set
            {
                _notas = value;
            }
        }

        public Alumno(string nombre)
        {
            Nombre = nombre;
        }

        public void AddNota (Nota nota)
        {
            this.Notas.Add(nota);
        }

        public Nota Media()
        {
            int total = 0;
            foreach (Nota n in Notas)
            {
                total = total + n.Valor;
            }
            int media = total / Notas.Count;
            return new Nota(media);
        }

        public Nota NotaMayor()
        {
            Nota notaMayor = new Nota(0);
            foreach (Nota unaNota in Notas)
            {
                notaMayor = unaNota.esMayor(notaMayor);
            }

            return notaMayor;
        }

    }
}
