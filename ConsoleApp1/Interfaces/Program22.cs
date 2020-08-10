using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    class Program22
    {
        static void Main(string[] args)
        {
            IEncendibles cocina = new Cocina();
            cocina.Encender();
            

            List<Bombilla> bombillas = new List<Bombilla>();
            Bombilla bom = new Bombilla(20);
            bombillas.Add(bom);
            Lavadora l = new Lavadora("Balay");
            Frigorífico f = new Frigorífico("Samsung");
            IEncendibles cocina2 = new Cocina(l, f, bombillas);
            cocina2.Apagar();
            GoogleHome gh = new GoogleHome();
            CocinaProfesor c = new CocinaProfesor();
            c.AddEncendible(new BombillaProfesor());
            c.AddEncendible(new BombillaSmart("1"));
            c.AddEncendible(new FrigorificoProfesor(20));
            c.AddEncendible(new EnchufeSmartAdaptador("2", new FrigorificoProfesor(20)));
            c.EncenderTodo();
            c.EncenderPorVoz("2");
            
            Console.ReadLine();
        }

        public static void ListaBombillas()
        {
            List<Bombilla> bomb = new List<Bombilla>();
            foreach (Bombilla bm in bomb)
            {
                Console.WriteLine(bm.Watios);
            }
        }
    }
}
