using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConArreglos01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practica: Arreglos");
            Console.WriteLine("");

            int[] x= new[] { 1, 3, -2, 4 };
            Console.WriteLine("Arreglo tipo int de 1 dimensión:");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + "\t");
            }
            Console.WriteLine("");
            Console.WriteLine("");

            double[] y = new[] { 1.1, -2.5, 4.3 };
            Console.WriteLine("Arreglo tipo double de 1 dimensión:");
            for (int i = 0; i < y.Length; i++)
            {
                Console.Write(y[i] + "\t");
            }
            Console.WriteLine("");
            Console.WriteLine("");

            double[,] a = new[,] {{-1.1, 2.1, 3.1},
                                   {2.1, 1.1, 3.1 },
                                 };
            Console.WriteLine("Arreglo tipo double de 2 dimensiones:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

            int[][] b= new [] { new [] {1, 2, 3 },
                                new [] {1},
                                new [] {1, 2, 3, 4},
            };
            Console.WriteLine("Arreglo irregular tipo int:");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(b[0][j] + "\t");
            }
            Console.WriteLine("");

            Console.Write(b[1][0] + "\t");
            Console.WriteLine("");
                
            for (int j = 0; j < 4; j++)
            {
                Console.Write(b[2][j] + "\t");
            }
            Console.WriteLine("");

            System.Diagnostics.Process.Start("WPFmanuels.exe");
            Console.ReadLine(); 
        }
    }
}
