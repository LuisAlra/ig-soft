
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitoResistencias_consola
{
    internal class Program
    {
        public static double Ve=5, Vab;
        public static double r1, r2, r3, r4;
        static void Main(string[] args)
        {
            Entrada();
            Proceso();
            Salida();

            Console.ReadKey();
        }

        public static void Entrada()
        {
            
            
            string aux;

            Console.WriteLine("Valor de R1 =");
            aux = Console.ReadLine();
            r1 = double.Parse(aux);

            Console.WriteLine("Valor de R2 =");
            aux = Console.ReadLine();
            r2 = double.Parse(aux);
            Console.WriteLine("Valor de R3 =");
            aux = Console.ReadLine();
            r3 = double.Parse(aux);
            Console.WriteLine("Valor de R4 =");
            aux = Console.ReadLine();
            r4 = double.Parse(aux);
        }

        public static void Proceso()
        {
            Console.WriteLine("Procesando...");
            double rx, ry, delta, i1, i2;
            rx = r1 + r3;
            ry = r2 + r3 + r4;
            delta = rx * ry - r3 * r3;
            i1 = Ve * ry / delta;
            i2 = r3 * Ve / delta;
            Vab = r4 * i2;
            Vab = Math.Round(Vab, 5);

        }
        public static void Salida()
        {
            Console.WriteLine("\nVab = {0}",Vab);
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        
        }
    }
}
