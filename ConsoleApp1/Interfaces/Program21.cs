using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    class Program21
    {
        static void Main(string[] args)
        {
            IConducible mimoto = new Moto();
            mimoto.Avanzar();
            IConducible mipatinete = new Patinete();
            IConectable mipatinete2 = new Patinete();
            IConducibleConectable mipatinete3 = new Patinete();
            mipatinete3.Avanzar();
            mipatinete2.Conectar();
            mipatinete2.Desconectar();
            mipatinete.Avanzar();
            mover(mipatinete);
            
            Console.ReadLine();
        }

        public static void mover(IConducible c)
        {
            c.Arrancar();
            c.Avanzar();
            c.Girar();
            c.Avanzar();
            c.Parar();
        }
    }
}
