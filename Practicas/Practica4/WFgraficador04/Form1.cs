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

namespace WFgraficador04
{
    public partial class Form1 : Form
    {
        double xi, xf, x, y, y1;
        int n;
        string fx;
        string f1x;

        public Form1()
        {
            InitializeComponent();
            xi = 0;
            xf = 0;
            n = 0;
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtFirma_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        }

        private void Btf1x_Click_1(object sender, EventArgs e)
        {
            Entrada();
            Proceso2();
        }

        private void BtGraficarfx_Click_1(object sender, EventArgs e)
        {
            Entrada();
            Proceso();
        }

        public void Entrada()
        {
            try
            {
                xi = double.Parse(Tbxi.Text);
                xf = double.Parse(Tbxf.Text);
                fx = TBfx.Text;
                f1x = Tbf1x.Text;
                n = chart1.Width;
            }

            catch
            {
                MessageBox.Show("Error de datos...");
            }
        }

        public void Proceso()
        {
            double h;
            h = (xf - xi) / n;
            
            chart1.Series["Series1"].Points.Clear();
            chart1.Series["Series2"].Points.Clear();
            
            LbSalida.Items.Clear();
            LbSalida.Items.Add("Tabulación de y=f(x)");
            LbSalida.Items.Add(" ");

            for (int k = 0; k <= n; k++)
            {
                x = xi + k * h;
                y = fu(x, fx);
                chart1.Series["Series1"].Points.AddXY(x, y);
                LbSalida.Items.Add(((float)x) + " \t " + ((float)y));
            }
        }

        public void Proceso2()
        {
            double h;
            h = (xf - xi) / n;
            chart1.Series["Series1"].Points.Clear();
            chart1.Series["Series2"].Points.Clear();

            LbSalida.Items.Clear();
            LbSalida.Items.Add("Tabulación de y=f(x)");
            LbSalida.Items.Add(" ");

            for (int k = 0; k <= n; k++)
            {
                x = xi + k * h;
                y = fu(x, fx);
                chart1.Series["Series1"].Points.AddXY(x, y);
                LbSalida.Items.Add(((float)x) + " \t " + ((float)y));
            }

            LbSalida.Items.Add(" ");
            LbSalida.Items.Add("Tabulación de y=f1(x)");
            LbSalida.Items.Add(" ");

            for (int k = 0; k <= n; k++)
            {
                x = xi + k * h;
                y1 = fu(x, f1x);
                chart1.Series["Series2"].Points.AddXY(x, y1);
                LbSalida.Items.Add(((float)x) + " \t " + ((float)y1));
            }
        }

        public double fu(double x, string fx)
        {
            ExpressionParser parser1 = new ExpressionParser();
            parser1.Values.Add("x", x);
            return (parser1.Parse(fx));
        }
    }
}
