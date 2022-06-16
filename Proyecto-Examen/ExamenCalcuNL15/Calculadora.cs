using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using info.lundin.math;

namespace ExamenCalcuNL15
{

    internal class Calculadora
    {
        public Calculadora()
        {

        }

        public string SumaXY(double x, double y, ref double r)
        {
            r = x + y;
            return ("Suma");
        }

        public string RestaXY(double x, double y, ref double r)
        {
            r = x - y;
            return ("Resta");
        }

        public string MultiXY(double x, double y, ref double r)
        {
            r = x * y;
            return ("Multiplicación");
        }

        public string DiviXY(double x, double y, ref double r)
        {
            r = x / y;
            return ("División");
        }

        public string PotXY(double x, double y, ref double r)
        {
            r = Math.Pow(x, y);
            return ("x elevado a la y");
        }

        public string PotYX(double x, double y, ref double r)
        {
            r = Math.Pow(y, x);
            return ("y elevada a la x");
        }

        public string FactXoY(double xoy, ref double r)
        {
            double fact = 1;
            if (xoy < 0)
            {
                fact = 0;
                MessageBox.Show("No existe factorial de número negativo");
            }

            else if (xoy == 0) fact = 1;

            else
            {
                for (int i = 1; i <= xoy; i++)
                {
                    fact *= i;
                }
            }
            r = fact;
            return ("Factorial de ");
        }

        public string SqrtXoY(double xoy, ref double r)
        {
            r = Math.Sqrt(xoy);
            return ("Raíz cuadrada de ");
        }

        public string PotXoY2(double xoy, ref double r)
        {
            r = Math.Pow(xoy,2);
            return (" elevada al cuadrado");
        }

        public string CosXoY(double xoy, ref double r)
        {
            r = Math.Cos(xoy);
            return ("Coseno de ");
        }

        public string SinXoY(double xoy, ref double r)
        {
            r=Math.Sin(xoy);
            return ("Seno de ");
        }

        public string TanXoY(double xoy, ref double r)
        {
            r = Math.Tan(xoy);
            return ("Tangente de ");
        }

        public string AcosXoY(double xoy, ref double r)
        {
            r = Math.Acos(xoy);
            return ("Arco coseno de ");
        }

        public string AsinXoY(double xoy, ref double r)
        {
            r = Math.Asin(xoy);
            return ("Arco seno de ");
        }

        public string AtanXoY(double xoy, ref double r)
        {
            r = Math.Atan(xoy);
            return ("Arco tangente de ");
        }

        public string CoshXoY(double xoy, ref double r)
        {
            r = Math.Cosh(xoy);
            return ("Coseno hiperbólico de ");
        }

        public string SinhXoY(double xoy, ref double r)
        {
            r = Math.Sinh(xoy);
            return ("Seno hiperbólico de ");
        }

        public string TanhXoY(double xoy, ref double r)
        {
            r = Math.Tanh(xoy);
            return ("Tangente hiperbólica de ");
        }

        public string CotXoY(double xoy, ref double r)
        {
            r = 1 / Math.Tan(xoy);
            return ("Cotangente de ");
        }

        public string SecXoY(double xoy, ref double r)
        {
            r = 1 / Math.Cos(xoy);
            return ("Secante de ");
        }

        public string CscXoY(double xoy, ref double r)
        {
            r = 1 / Math.Sin(xoy);
            return ("Cosecante de ");
        }

        public string ExpXoY(double xoy, ref double r)
        {
            r = Math.Exp(xoy);
            return ("e a la ");
        }

        public string LnXoY(double xoy, ref double r)
        {
            r = Math.Log(xoy);
            return ("Logaritmo natural de ");
        }

        public string Log10XoY(double xoy, ref double r)
        {
            r = Math.Log10(xoy);
            return ("Logaritmo decimal de ");
        }

        public string AbsXoY(double xoy, ref double r)
        {
            r = Math.Abs(xoy);
            return ("Valor absoluto de ");
        }

        public string RoundXoY(double xoy, ref double r)
        {
            r = Math.Round(xoy);
            return ("Valor redondeado de ");
        }

        public string SingXoY(double xoy, ref double r)
        {
            r = Math.Sign(xoy);
            return ("Sing de ");
        }

        public string fx(double x, string fx, ref double r)
        {
            r = funx(x, fx);
            return ("Función f(x)");
        }

        public double funx(double x, string fx)
        {
            ExpressionParser parser = new ExpressionParser();
            parser.Values.Add("x", x);
            return (parser.Parse(fx));
        }

        public string fy(double y, string fy, ref double r)
        {
            r = funy(y, fy);
            return ("Función f(y)");
        }

        public double funy(double y, string fy)
        {
            ExpressionParser parser = new ExpressionParser();
            parser.Values.Add("y", y);
            return (parser.Parse(fy));
        }

        public string fxy(double x, double y, string fxy, ref double r)
        {
            r = funxy(x, y, fxy);
            return ("Función f(x,y)");
        }

        public double funxy(double x, double y, string fxy)
        {
            ExpressionParser parser = new ExpressionParser();
            parser.Values.Add("x", x);
            parser.Values.Add("y", y);
            return (parser.Parse(fxy));
        }
    }
}
