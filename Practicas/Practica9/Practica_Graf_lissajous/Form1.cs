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
namespace practica_Graficador
{
    public partial class Form1 : Form
    {
        double xi, xf, x,y,y1,a,r,t;
        int n;
        string fx;
        string f1x;
        double propor, propor2;
        double desfase;

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        }         

        public Form1()
        {
            InitializeComponent();
            xi = 0;     //inicializar propiedades
            xf = 0;
            x = 0;
            y = 0;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void entrada2()
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
        private void button2_Click(object sender, EventArgs e)
        {
            entrada2();
            proceso5();
        }
        

        public void proceso5()
        {
            //lissajous
            double h;
            n = chart5.Width;
            h = (xf - xi) / n;
            double A1, B1, w, w1, w2;
            A1  = B1 = 10;
            chart5.Series["Series1"].Points.Clear();
            lbsalida.Items.Clear();
            w = 2*Math.PI;
            w1 = propor2*w;
            w2 = propor * w;
            for (int k = 0; k < n; k++)
            {

                t = xi + k * h;
                x = A1 * Math.Cos(w1 * t);
                y = B1 * Math.Cos((w2 * t)+desfase);
                chart5.Series["Series1"].Points.AddXY(x, y); //esta linea hace un mapeo 
                lbsalida.Items.Add(((float)x) + "  \t  " + ((float)y));

            }
        }
    }
}
