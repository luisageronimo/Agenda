using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aplicacion1_4taunidad
{
    class Program
    {
        static void Main(string[] args)
        {

            string archivo;
            int p;
            string R = "s";
            while (R == "s")
            { 
                Console.WriteLine("Que desea hacer\n1. Crear \n2. Salir");
                 p = int.Parse(Console.ReadLine());


                if (p==1)
                { 
                 StreamWriter ar;
                 archivo = Console.ReadLine();
                 Console.WriteLine("Escribe el nombre del arhivo: ");
                 ar = File.CreateText(Console.ReadLine() + ".txt");
                 ar.Close();
                }
               Console.Clear();

              if (p == 2)
              {
                Console.WriteLine("Usted a deseado salir");
              }
              Console.Clear();
              Console.WriteLine("Quieres crear otro archivo?");
              Console.WriteLine("s/n");
              R = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
