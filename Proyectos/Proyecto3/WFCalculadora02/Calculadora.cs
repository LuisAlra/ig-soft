using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using info.lundin.math;

namespace WFCalculadora02
{
    internal class Calculadora
    {
        double x, y, r;
        public Calculadora()
        {
            //constructor
        }
        public string Sumaxy(double x, double y, ref double r)
        {
            r = x + y;
            return ("Suma");
        }
        public string Restaxy(double x, double y, ref double r)
        {
            r = x - y;
            return ("Resta");
        }
        public string Multxy(double x, double y, ref double r)
        {
            r = x * y;
            return ("Resta");
        }
        public string Divisionxy(double x, double y, ref double r)
        {
            r = x / y;
            return ("Division");
        }
        public string fcos(double x, ref double r)
        {
            r = Math.Cos(x);
            return ("Funcion Coseno");
        }
        public string fsen(double x, ref double r)
        {
            r = Math.Sin(x);
            return ("Funcion Seno");
        }
        public string ftan(double x, ref double r)
        {
            r = Math.Tan(x);
            return ("Funcion Tangente");
        }
        public string fseni(double x, ref double r)
        {
            r = Math.Asin(x);
            return ("Funcion ArcoSeno");
        }
        public string fcosi(double x, ref double r)
        {
            r = Math.Acos(x);
            return ("Funcion ArcoCoseno");
        }
        public string ftani(double x, ref double r)
        {
            r = Math.Atan(x);
            return ("Funcion ArcoTangente");
        }
        public string fcosh(double x, ref double r)
        {
            r = Math.Cosh(x);
            return ("Funcion Coseno Hiperbólico");
        }
        public string fsenh(double x, ref double r)
        {
            r = Math.Sinh(x);
            return ("Funcion Seno Hiperbólico");
        }
        public string ftanh(double x, ref double r)
        {
            r = Math.Tanh(x);
            return ("Funcion Tangente Hiperbólico");
        }
        public string fsec(double x, ref double r)
        {
            r = 1/Math.Cos(x);
            return ("Funcion Secante");
        }
        public string fcsc(double x, ref double r)
        {
            r = 1/Math.Sin(x);
            return ("Funcion Cosecante");
        }
        public string fcot(double x, ref double r)
        {
            r = Math.Cos(x) / Math.Sin(x);
            return ("Funcion Cotangente");
        }
        public string Fn(double x, string fx, ref double r)
        {
            r = fun(x, fx);
            return ("Funcion f(x)");
        }
        public double fun(double x, string fx)
        {
            ExpressionParser parser = new ExpressionParser();
            parser.Values.Add("x", x);
            return (parser.Parse(fx));
        }
        public string Fn2(double x, double y, string fxy, ref double r)
        {
            r = fun2(x, y, fxy);
            return ("Funcion de f(x,y)");
        }
        public double fun2(double x, double y, string fxy)
        {
            ExpressionParser parser = new ExpressionParser();
            parser.Values.Add("x", x);
            parser.Values.Add("y", y);
            return (parser.Parse(fxy));
        }
    }
}

