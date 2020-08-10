using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program25
    {
        static void Main(string[] args)
        {
            string ruta = @"C:\Users\formacion\Desktop\prueba.txt";
            //StreamReader sr=null;
            try
            {
                //File.Create(ruta);
                using(StreamReader sr = File.OpenText(ruta))
                {
                    //sr = File.OpenText(ruta);
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Ha ocurrido una excepción");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

            }
            /*finally
            {
                //sr.Close();
                Console.WriteLine("Todo terminó");
            }*/
            
            Console.ReadLine();
        }
    }
}
