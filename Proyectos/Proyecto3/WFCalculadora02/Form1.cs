using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCalculadora02
{
    public partial class Form1 : Form
    {
        double x, y, r;
        Calculadora mical;
        string mensaje;
        string fx;
        string fxy;

        public Form1()
        {
            InitializeComponent();
            mical = new Calculadora();
        }

        private void btsuma_Click(object sender, EventArgs e)
        {
            Entrada();
            mensaje = mical.Sumaxy(x, y, ref r);
            Salida(r);
        }

        private void btresta_Click(object sender, EventArgs e)
        {
            Entrada();
            mensaje = mical.Restaxy(x, y, ref r);
            Salida(r);
        }

        private void btmult_Click(object sender, EventArgs e)
        {
            Entrada();
            mensaje = mical.Multxy(x, y, ref r);
            Salida(r);
        }

        private void btdiv_Click(object sender, EventArgs e)
        {
            Entrada();
            mensaje = mical.Divisionxy(x, y, ref r);
            Salida(r);
        }

        private void btsen_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                mensaje = mical.fsen(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de Entrada-Proces-Salida");
            }
        }

        private void btcos_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                mensaje = mical.fcos(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de Entrada-Proces-Salida");
            }
        }

        private void bttan_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                mensaje = mical.ftan(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de Entrada-Proces-Salida");
            }
        }

        private void btseni_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                mensaje = mical.fseni(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de Entrada-Proces-Salida");
            }
        }

        private void btcosi_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                mensaje = mical.fcosi(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de Entrada-Proces-Salida");
            }
        }

        private void bttani_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                mensaje = mical.ftani(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de Entrada-Proces-Salida");
            }
        }

        private void btsenh_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                mensaje = mical.fsenh(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de Entrada-Proces-Salida");
            }
        }

        private void btcosh_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                mensaje = mical.fcosh(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de Entrada-Proces-Salida");
            }
        }

        private void bttanh_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                mensaje = mical.ftanh(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de Entrada-Proces-Salida");
            }
        }

        private void btsec_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                mensaje = mical.fsec(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de Entrada-Proces-Salida");
            }
        }

        private void btcsc_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                mensaje = mical.fcsc(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de Entrada-Proces-Salida");
            }
        }

        private void btcot_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                mensaje = mical.fcot(x, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de Entrada-Proces-Salida");
            }
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        }

        private void btfx_Click(object sender, EventArgs e)
        {
            Entrada();
            mensaje = mical.Fn(x, fx, ref r);
            Salida(r);
        }

        private void btfxy_Click(object sender, EventArgs e)
        {
            Entrada();
            mensaje = mical.Fn2(x, y, fxy, ref r);
            Salida(r);
        }

        private void btfl_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtFirma_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        }

        private void BtGraficador_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("practica_Graficador.exe");
        }

        public void Entrada()
        {
            try
            {
                x = double.Parse(tBx.Text);
                y = double.Parse(tBy.Text);
                fx = tBfx.Text;
                fxy = tBfxy.Text;

            }
            catch
            {
                MessageBox.Show("Error de entrada de datos");
            }
        }
        public void Salida(double r)
        {
            resultado.Items.Add(r);
            tBmensaje.Text = mensaje;

        }


    }
}
