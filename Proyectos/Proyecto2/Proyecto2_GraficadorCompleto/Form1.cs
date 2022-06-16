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

        public Form1()
        {
            InitializeComponent();
            xi = 0;     //inicializar propiedades
            xf = 0;
            x = 0;
            y = 0;

            //n = 0;
            n = chart1.Width; //n vale el numero de puntos para graficar
        }

        private void graffx_Click(object sender, EventArgs e)
        {
            entrada();
            proceso();
            salida();

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

        private void btf1x_Click(object sender, EventArgs e)
        {
            entrada();
            proceso2();
            salida();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void btga_Click(object sender, EventArgs e)
        {
            entrada();
            proceso3();
            salida();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            entrada();
            proceso5();
            salida();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            entrada();
            proceso4();
            salida();
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        }

        private void lbsalida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void proceso()
        {
            double h;
            h = (xf - xi) / n;
            chart2.Series["Series1"].Points.Clear();
            lbsalida.Items.Clear();
            lbsalida.Items.Add("x     \t\t\t    y");
            for (int k = 0; k < n; k++)
            {
                x = xi + k * h;
                y = fux(x,fx);                           
                chart2.Series["Series1"].Points.AddXY(x,y); //esta linea hace un mapeo 
                lbsalida.Items.Add(x + "  \t  " + y);

            }                                               

        
        }

        public void proceso2()
        {
            double h;
            h = (xf - xi) / n;

            chart1.Series["Series1"].Points.Clear();
            for (int k = 0; k < n; k++)
            {
                x = xi + k * h;
                y = fux(x, fx);  
                y1 = fux(x, f1x);
                chart1.Series["Series1"].Points.AddXY(x, y);
                chart1.Series["Series2"].Points.AddXY(x,y1);


            }


        }

        public double fux(double x, string fx)
        { 
            ExpressionParser parser1=new ExpressionParser();
            parser1.Values.Add("x",x);
            return (parser1.Parse(fx));
        
        }
        public void salida()
        {


        }
        public void proceso3()
        {
            double h;
            h = (xf - xi) / n;

            chart3.Series["Series1"].Points.Clear();
            lbsalida.Items.Clear();
            lbsalida.Items.Add("a     \t\t\t    r");
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

        public void proceso4()
        {
            double h;
            h = (xf - xi) / n;

            chart4.Series["Series1"].Points.Clear();
            lbsalida.Items.Clear();

            for (int k = 0; k < n; k++)
            {

                t= xi + k * h;
                x = fux(t, fx);
                y = fux(t, f1x);
                chart4.Series["Series1"].Points.AddXY(x, y); //esta linea hace un mapeo 
                lbsalida.Items.Add(((float)t) + "  \t  " + ((float)x) + "\t " +((float)y));

            }


        }

        public void proceso5()
        {
            double h;
            h = (xf - xi) / n;
            double A1, B1, w, w1, w2;
            A1  = B1 = 10;
            chart5.Series["Series1"].Points.Clear();
            lbsalida.Items.Clear();
            w=2*Math.PI;
            w1 = propor2*w;
            w2 = propor * w;
            for (int k = 0; k < n; k++)
            {

                t = xi + k * h;
                x = A1 * Math.Cos(w1 * t);
                y = B1 * Math.Cos((w2 * t) + desfase);
                chart5.Series["Series1"].Points.AddXY(x, y); //esta linea hace un mapeo 
                lbsalida.Items.Add(((float)x) + "  \t  " + ((float)y));

            }


        }
    }
}
