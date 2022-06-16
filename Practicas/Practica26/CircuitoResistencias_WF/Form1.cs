using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircuitoResistencias_WF
{
    public partial class Form1 : Form
    {
        double r1,r2, r3,r4;
        double Ve,Vab;
        public Form1()
        {
            InitializeComponent();
            r1 = 0;
            r2 = 0;
            r3 = 0;
            r4 = 0;
            Ve = 5;
            Vab = 0;    
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entrada();
            Proceso();
            Salida();
        }
        public void Entrada()
        {
            try
            {
                r1 = double.Parse(textBox1.Text);
                r2 = double.Parse(textBox2.Text);
                r3 = double.Parse(textBox3.Text);
                r4 = double.Parse(textBox4.Text);
            }
            catch {

                MessageBox.Show("Error de datos!!");
            }
       
            }
        public void Proceso()
        {
            double rx, ry, delta, i1,i2;
            rx = r1 + r3;
            ry = r2 + r3 + r4;
            delta = rx * ry - r3 * r3;
            i1 = Ve * ry / delta;
            i2 = r3*Ve/ delta;
            Vab = r4 * i2;
            Vab = Math.Round(Vab,4);
        
        }
        public void Salida()
        { 
            textBox6.Text = Vab.ToString();
        
        }
        

    }
}
