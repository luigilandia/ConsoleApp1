using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    interface IEncendibleVoz:IEncendibles
    {
        string Id { get; set; }

        void EncenderConVoz();
        void ApagarConVoz();
    }
}
