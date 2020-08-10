using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    class CocinaProfesor
    {
        public List<IEncendibles> Encendibles { get; set; }
        public List<IEncendibleVoz> EncendibleVoz { get; set; }

        public CocinaProfesor()
        {
            Encendibles = new List<IEncendibles>();
            EncendibleVoz = new List<IEncendibleVoz>();
        }

        public void AddEncendible(IEncendibles ic)
        {
            Encendibles.Add(ic);
            if (ic is BombillaSmart)
            {
                EncendibleVoz.Add((IEncendibleVoz)ic);
            }
        }

        public void EncenderTodo()
        {
            foreach (IEncendibles e in Encendibles)
            {
                e.Encender();
            }
        }

        public void EncenderPorVoz(string id)
        {
            foreach (IEncendibles e in Encendibles)
            {
                if (e is IEncendibleVoz)
                {
                    IEncendibleVoz otro = (IEncendibleVoz)e;
                    if (otro.Id.Equals(id))
                    {
                        otro.EncenderConVoz();
                    }
                }
            }
        }
    }
}
