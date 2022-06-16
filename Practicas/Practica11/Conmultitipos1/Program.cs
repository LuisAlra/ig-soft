using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conmultitipos1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practica: Multitipos var y object");
            Console.WriteLine("");

            Console.WriteLine("Variable var x tipo double inicial:");
            var x = 2.5;
            Console.WriteLine("x = "+x);
            x = 2;
            Console.WriteLine("x = " + x);
            x = 3.6F;
            Console.WriteLine("x = " + x);
            Console.WriteLine("");
            
            Console.WriteLine("Variable var y tipo int inicial:");
            var y = 45;
            Console.WriteLine("y = " + y);
            //y = 3.5;  No se pueden reasignar a un tipo int inicial
            //y = 7.9F; No se pueden reasignar a un tipo int inicial
            y = 'A';
            Console.WriteLine("y = " + y);
            Console.WriteLine("");
            
            Console.WriteLine("Variable var q tipo string inicial:");
            var q = "ICE";
            Console.WriteLine("q = " + q);
            q = "ESIME";
            Console.WriteLine("q = " + q);
            //q = 4.6;  No se pueden reasignar a un tipo string inicial
            //q = 3;    No se pueden reasignar a un tipo string inicial
            Console.WriteLine("");

            Console.WriteLine("Variable object a:");
            object a;
            a = 3;
            Console.WriteLine("a = " + a);
            a = 4.5F;
            Console.WriteLine("a = " + a);
            a = 2.6;
            Console.WriteLine("a = " + a);
            a = 'A';
            Console.WriteLine("a = " + a);
            a = "ESIME";
            Console.WriteLine("a = " + a);

            System.Diagnostics.Process.Start("WPFmanuels.exe");
            Console.ReadLine();
        }
    }
}
