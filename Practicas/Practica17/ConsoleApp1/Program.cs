using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practica: Relación indirecta entre clases");
            Console.WriteLine("");

            Ci oi = new Ci();
            Console.WriteLine("Modificando la propiedad pi de la clase Ci desde la clase Program con el código 'oi.Pi=10.5', nos muestra:");
            oi.Pi = 10.5;
            Console.WriteLine("pi = " + oi.Pi);
            Console.WriteLine("");

            Console.WriteLine("Creando el método Meti en la clase Ci que asigna un valor a pi=100.8 y llamando el método Meti desde la" );
            Console.WriteLine("clase Program con el código 'oi.Meti()', nos muestra:");

            oi.Meti();
            Console.WriteLine("pi = " + oi.Pi);

            System.Diagnostics.Process.Start("WPFmanuels.exe");
            Console.ReadKey();
        }
    }
}
