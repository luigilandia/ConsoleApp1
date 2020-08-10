using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    class BombillaSmart:BombillaProfesor, IEncendibleVoz
    {
        public BombillaSmart(string id)
        {
            Id = id;
        }

        public string Id { get; set; }

        public void ApagarConVoz()
        {
            Console.WriteLine("Apagada por voz");
        }

        public void EncenderConVoz()
        {
            Console.WriteLine("Encendida por voz");
        }

        public override bool Equals(object obj)
        {
            var smart = obj as BombillaSmart;
            return smart != null &&
                   Id == smart.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + EqualityComparer<string>.Default.GetHashCode(Id);
        }
    }
}
