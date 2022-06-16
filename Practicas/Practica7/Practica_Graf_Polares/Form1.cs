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
        double xi, xf, x,y,y1,a,r;
        int n;
        string fx;
        string f1x;

        private void BtFirma_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
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

        public void entrada()
        {

            try
            {
                xi = double.Parse(tbxi.Text);
                xf = double.Parse(tbxf.Text);
                fx = tbfx.Text;
                f1x=tbf1x.Text;
            }
            catch
            {
                MessageBox.Show("Error de datos"); 
            }
        
        }

        private void btga_Click(object sender, EventArgs e)
        {
            entrada();
            proceso3();
        }

        public double fux(double x, string fx)
        { 
            ExpressionParser parser1=new ExpressionParser();
            parser1.Values.Add("x",x);
            return (parser1.Parse(fx));
        
        }
     
        public void proceso3()
        {
            double h;
            n = chart3.Width;
            h = (xf - xi) / n;

            chart3.Series["Series1"].Points.Clear();
            lbsalida.Items.Clear();
            lbsalida.Items.Add("x     \t\t\t    y");
            for (int k = 0; k < n; k++)
            {
                a= xi + k * h;
                r=fux(a, fx);
                x=r*Math.Cos(a);
                y=r*Math.Sin(a);
                chart3.Series["Series1"].Points.AddXY(x, y); //esta linea hace un mapeo 
                lbsalida.Items.Add(((float)a) + "  \t  " + ((float)r));

            }
        }
    }
}
