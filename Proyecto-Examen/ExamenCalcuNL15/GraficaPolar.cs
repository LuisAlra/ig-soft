using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using info.lundin.math;

namespace ExamenCalcuNL15
{
    public partial class GraficaPolar : Form
    {
        double xi, xf, x, y, a, r;
        int n;
        string fx;

        public GraficaPolar()
        {
            InitializeComponent();
        }

        private void BtGraficarr_Click(object sender, EventArgs e)
        {
            entrada();
            proceso();
        }

        public void entrada()
        {
            try
            {
                xi = double.Parse(Tbxi.Text);
                xf = double.Parse(Tbxf.Text);
                fx = TBfx.Text;
            }
            catch
            {
                MessageBox.Show("Error de datos");
            }
        }

        public void proceso()
        {
            double h;
            n = chart1.Width;
            h = (xf - xi) / n;
            chart1.Series["Series1"].Points.Clear();
            for (int k = 0; k < n; k++)
            {
                a = xi + k * h;
                r = fux(a, fx);
                x = r * Math.Cos(a);
                y = r * Math.Sin(a);
                chart1.Series["Series1"].Points.AddXY(x, y);
            }
        }

        public double fux(double x, string fx)
        {
            ExpressionParser parser1 = new ExpressionParser();
            parser1.Values.Add("x", x);
            return (parser1.Parse(fx));
        }
    }
}
