using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    class EnchufeSmartAdaptador : IEncendibleVoz
    {
        public string Id { get; set; }
        public IEncendibles Encendible;

        public EnchufeSmartAdaptador(string id, IEncendibles encendible)
        {
            Id = id;
            Encendible = encendible;
        }

        public void Apagar()
        {
            Encendible.Apagar();
        }

        public void ApagarConVoz()
        {
            Encendible.Apagar();
        }

        public void Encender()
        {
            Encendible.Encender();
        }

        public void EncenderConVoz()
        {
            Encendible.Encender();
        }
    }
}
