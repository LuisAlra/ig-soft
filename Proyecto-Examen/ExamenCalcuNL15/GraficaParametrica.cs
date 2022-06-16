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
    public partial class GraficaParametrica : Form
    {
        double xi, xf, t, x, y;
        int n;
        string fx, f1x;

        public GraficaParametrica()
        {
            InitializeComponent();
        }

        private void BtGraParame_Click(object sender, EventArgs e)
        {
            entrada();
            proceso();
        }

        public void entrada()
        {

            try
            {
                xi = double.Parse(tbxi.Text);
                xf = double.Parse(tbxf.Text);
                fx = tbfx.Text;
                f1x = tbf1x.Text;
            }
            catch
            {
                MessageBox.Show("Error de datos");
            }

        }

        public void proceso()
        {
            //parametricas
            double h;
            n = chart1.Width;
            h = (xf - xi) / n;

            chart1.Series["Series1"].Points.Clear();

            for (int k = 0; k < n; k++)
            {

                t = xi + k * h;
                x = fux(t, fx);
                y = fux(t, f1x);
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
