using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ExamenCalcuNL15
{
    internal class CalcuMatrices
    {
        private int m;
        private int n;
        double[,] elem;

        public CalcuMatrices(int m, int n)
        {
            this.m = m;
            this.n = n;
            elem = new double[m, n];
        }

        public int M
        {
            get { return m; }
            set { m = value; }
        }

        public int N
        {
            get { return n; }
            set { n = value; }
        }

        public double[,] Elem
        {
            get { return elem; }
            set { elem = value; }
        }
    }
}
