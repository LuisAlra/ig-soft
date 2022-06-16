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

namespace Proyecto4_mascotaVirtual
{
    public partial class Form1 : Form
    {
        int vida=10;
        bool flag1 = true, flag2 = true, flag3 = true, flag4 = true, flag5 = true;
        bool flag6 = true, flag7 = true, flag8 = true, flag9 = true, flag10 = true, flag11=true;

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        }

        public Form1()
        {
            InitializeComponent();
            //vida = int.Parse(textBox11.Text);
            
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbdeTimer.Text = DateTime.Now.ToString("hh:mm:ss-MM/yyyy");
            textBox11.Text = vida.ToString();

            

            if (textBox1.Text == lbdeTimer.Text)
            {
                if (!checkBox1.Checked && flag1)
                {
                    vida = vida - 1;
                    flag1 = false;
                }
            }

            if (textBox2.Text == lbdeTimer.Text)
            {
                if (!checkBox2.Checked && flag2)
                {
                    vida = vida - 1;
                    flag2 = false;
                }
                
            }

            if (textBox3.Text == lbdeTimer.Text)
            {
                if (!checkBox3.Checked && flag3)
                {
                    vida = vida - 1;
                    flag3 = false;
                }

            }

            if (textBox4.Text == lbdeTimer.Text)
            {
                if (!checkBox4.Checked && flag4)
                {
                    vida = vida - 1;
                    flag4 = false;
                }

            }

            if (textBox5.Text == lbdeTimer.Text)
            {
                if (!checkBox5.Checked && flag5)
                {
                    vida = vida - 1;
                    flag5 = false;
                }
            }
            if (textBox6.Text == lbdeTimer.Text)
            {
                if (!checkBox6.Checked && flag6)
                {
                    vida = vida - 1;
                    flag6 = false;
                }
            }
            if (textBox7.Text == lbdeTimer.Text)
            {
                if (!checkBox7.Checked && flag7)
                {
                    vida = vida - 1;
                    flag7 = false;
                }
            }
            if (textBox8.Text == lbdeTimer.Text)
            {
                if (!checkBox8.Checked && flag8)
                {
                    vida = vida - 1;
                    flag8 = false;
                }
            }
            if (textBox9.Text == lbdeTimer.Text)
            {
                if (!checkBox9.Checked && flag9)
                {
                    vida = vida - 1;
                    flag9 = false;
                }
            }
            if (textBox10.Text == lbdeTimer.Text)
            {
                if (!checkBox10.Checked && flag10)
                {
                    vida = vida - 1;
                    flag10 = false;
                }
            }

            if (vida > 7)
            {
                Graphics g = pictureBox1.CreateGraphics();
                Image miImagen1 = Image.FromFile("feliz.jpg");
                g.DrawImage(miImagen1, 0, 0, 300, 300);
            }
            if (vida < 7 && vida > 1)
            {
                Graphics g2 = pictureBox1.CreateGraphics();
                Image miImagen1 = Image.FromFile("maso.jpg");
                g2.DrawImage(miImagen1, 0, 0, 300, 300);
                

            }
            if (vida == 0 && flag11)
            {
                Graphics g3 = pictureBox1.CreateGraphics();
                Image miImagen1 = Image.FromFile("dead.jpg");
                g3.DrawImage(miImagen1, 0, 0, 300, 300);
                flag11 = false;
                MessageBox.Show("Tu mascota ha muerto!!!");
                
            }
        }
    }
}
