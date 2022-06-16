using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFgraficador01
{
    public partial class Form1 : Form
    {
        double xi, xf, x, y;
        int n;

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

        private void BtFirma_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtGraficar_Click(object sender, EventArgs e)
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
            //LbSalida.Items.Clear();
            for (int k = 0; k < n; k++)
            {
                x = xi + k * h;
                y = Math.Cos(x);
                //y=Math.Sin(x); 
                //y=Math.Tan(x);
                chart1.Series["Series1"].Points.AddXY(x, y);
                //LbSalida.Items.Add(((float)x) + " \t " + ((float)y));
            }
        }
    }
}
