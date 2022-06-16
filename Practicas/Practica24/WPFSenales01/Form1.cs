using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPFSenales01
{
    public partial class Form1 : Form
    {
        double ti,tf,g,t;
        int n; //numero de puntos de la grafica
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double h, T, w, A, q;
            ti = -5;
            tf = 5;
            n = chart1.Width; //n toma el ancho de la chart
            h = (tf - ti) / n;
            q = tBr3.Value; //velocidad
            w = tBr1.Value;
            A = tBr2.Value;
            T = DateTime.Now.Second * q * 0.1;
            chart1.Series["Series1"].Points.Clear();
            for(int k = 0; k < n; k++)
            {
                t = ti + k * h;
                if (cBox1.Text == "cos")
                    g = A * Math.Cos(w * t - T);
                else if (cBox1.Text == "sen")
                    g = A * Math.Sin(w * t - T);
                else if (cBox1.Text == "tan")
                    g = A * Math.Tan(w * t - T);
                chart1.Series["Series1"].Points.AddXY(t, g);
            }
        }
    }
}
