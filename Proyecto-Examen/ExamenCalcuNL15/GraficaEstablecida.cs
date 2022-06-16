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
    public partial class GraficaEstablecida : Form
    {
        double xi, xf, x, y, h;
        int n;

        public GraficaEstablecida()
        {
            InitializeComponent();
            
        }

        private void BtCos_Click(object sender, EventArgs e)
        {
            xf = 10;
            xi = -10;
            n = chart1.Width;
            h = (xf - xi) / n;
            chart1.Series["Series1"].Points.Clear();
            for (int k = 0; k < n; k++)
            {
                x = xi + k * h;
                y = Math.Cos(x);
                chart1.Series["Series1"].Points.AddXY(x, y);
            }
            Titulo.Text = "Gráfica función Coseno";
        }

        private void BtSen_Click(object sender, EventArgs e)
        {
            xf = 10;
            xi = -10;
            n = chart1.Width;
            h = (xf - xi) / n;
            chart1.Series["Series1"].Points.Clear();
            for (int k = 0; k < n; k++)
            {
                x = xi + k * h;
                y = Math.Sin(x);
                chart1.Series["Series1"].Points.AddXY(x, y);
            }
            Titulo.Text = "Gráfica función Seno";
        }

        private void BtTan_Click(object sender, EventArgs e)
        {
            xf = 10;
            xi = -10;
            n = chart1.Width;
            h = (xf - xi) / n;
            chart1.Series["Series1"].Points.Clear();
            for (int k = 0; k < n; k++)
            {
                x = xi + k * h;
                y = Math.Tan(x);
                chart1.Series["Series1"].Points.AddXY(x, y);
            }
            Titulo.Text = "Gráfica función Tangente";
        }

        private void BtAcos_Click(object sender, EventArgs e)
        {
            xf = 10;
            xi = -10;
            n = chart1.Width;
            h = (xf - xi) / n;
            chart1.Series["Series1"].Points.Clear();
            for (int k = 0; k < n; k++)
            {
                x = xi + k * h;
                y = Math.Acos(x);
                chart1.Series["Series1"].Points.AddXY(x, y);
            }
            Titulo.Text = "Gráfica función Arcocoseno";
        }

        private void BtAsen_Click(object sender, EventArgs e)
        {
            xf = 10;
            xi = -10;
            n = chart1.Width;
            h = (xf - xi) / n;
            chart1.Series["Series1"].Points.Clear();
            for (int k = 0; k < n; k++)
            {
                x = xi + k * h;
                y = Math.Asin(x);
                chart1.Series["Series1"].Points.AddXY(x, y);
            }
            Titulo.Text = "Gráfica función Arcoseno";
        }

        private void BtAtan_Click(object sender, EventArgs e)
        {
            xf = 10;
            xi = -10;
            n = chart1.Width;
            h = (xf - xi) / n;
            chart1.Series["Series1"].Points.Clear();
            for (int k = 0; k < n; k++)
            {
                x = xi + k * h;
                y = Math.Atan(x);
                chart1.Series["Series1"].Points.AddXY(x, y);
            }
            Titulo.Text = "Gráfica función Arcotangente";
        }

        private void BtCosh_Click(object sender, EventArgs e)
        {
            xf = 10;
            xi = -10;
            n = chart1.Width;
            h = (xf - xi) / n;
            chart1.Series["Series1"].Points.Clear();
            for (int k = 0; k < n; k++)
            {
                x = xi + k * h;
                y = Math.Cosh(x);
                chart1.Series["Series1"].Points.AddXY(x, y);
            }
            Titulo.Text = "Gráfica función Coseno hiperbólico";
        }

        private void BtSenh_Click(object sender, EventArgs e)
        {
            xf = 10;
            xi = -10;
            n = chart1.Width;
            h = (xf - xi) / n;
            chart1.Series["Series1"].Points.Clear();
            for (int k = 0; k < n; k++)
            {
                x = xi + k * h;
                y = Math.Sinh(x);
                chart1.Series["Series1"].Points.AddXY(x, y);
            }
            Titulo.Text = "Gráfica función Seno hiperbólico";
        }

        private void BtTanh_Click(object sender, EventArgs e)
        {
            xf = 10;
            xi = -10;
            n = chart1.Width;
            h = (xf - xi) / n;
            chart1.Series["Series1"].Points.Clear();
            for (int k = 0; k < n; k++)
            {
                x = xi + k * h;
                y = Math.Tanh(x);
                chart1.Series["Series1"].Points.AddXY(x, y);
            }
            Titulo.Text = "Gráfica función Tangente hiperbólica";
        }

        private void BtExp_Click(object sender, EventArgs e)
        {
            xf = 10;
            xi = -10;
            n = chart1.Width;
            h = (xf - xi) / n;
            chart1.Series["Series1"].Points.Clear();
            for (int k = 0; k < n; k++)
            {
                x = xi + k * h;
                y = Math.Exp(x);
                chart1.Series["Series1"].Points.AddXY(x, y);
            }
            Titulo.Text = "Gráfica función Exponencial";
        }
    }
}
