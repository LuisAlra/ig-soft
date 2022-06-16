using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenCalcuNL15
{
    public partial class GraficaLissajous : Form
    {
        double xi, xf, x, y, t, desfase;
        int n;
        double propor, propor2;

        public GraficaLissajous()
        {
            InitializeComponent();
        }

        private void BtLissajous_Click(object sender, EventArgs e)
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
                propor = double.Parse(tBxPropor.Text);
                propor2 = double.Parse(TbxPropor2.Text);
                desfase = double.Parse(tBxdesfase.Text);
                desfase = desfase * Math.PI / 180;

            }
            catch
            {
                MessageBox.Show("Error de datos");
            }
        }

        public void proceso()
        {
            //lissajous
            double h;
            n = chart1.Width;
            h = (xf - xi) / n;
            double A1, B1, w, w1, w2;
            A1 = B1 = 10;
            chart1.Series["Series1"].Points.Clear();
            w = 2 * Math.PI;
            w1 = propor2 * w;
            w2 = propor * w;
            for (int k = 0; k < n; k++)
            {
                t = xi + k * h;
                x = A1 * Math.Cos(w1 * t);
                y = B1 * Math.Cos((w2 * t) + desfase);
                chart1.Series["Series1"].Points.AddXY(x,y);
            }
        }
    }
}
