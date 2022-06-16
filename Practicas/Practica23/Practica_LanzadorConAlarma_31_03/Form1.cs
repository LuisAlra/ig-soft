using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_LanzadorConAlarma_31_03
{
    public partial class Form1 : Form
    {
        bool F1=true, F2=true,F3=true,F4=true,F5=true;
        bool F6 = true, F7 = true, F8 = true, F9 = true, F10 = true;

        private void BtFirma_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lBbloc.Text = DateTime.Now.ToString("hh:mm:ss-MM/yyyy"); //me da el tiempo real

            if (checkBox1.Checked)
            {
                if (lBbloc.Text == textBox1.Text && F1)
                {
                    //MessageBox.Show("Bloc de notas");
                    System.Diagnostics.Process.Start("notepad.exe");
                    F1 = false;
                }
            }
            if (checkBox2.Checked)
            {
                if (lBbloc.Text == textBox2.Text && F2)
                {
                    System.Diagnostics.Process.Start("Winword.exe");
                    F2 = false;
                }

            }
            if (checkBox3.Checked)
            {
                if (lBbloc.Text == textBox3.Text && F3)
                {
                    System.Diagnostics.Process.Start("D:/Cisco Packet Tracer 6.2sv/bin/PacketTracer6.exe");
                    F3 = false;
                }

            }
            if (checkBox4.Checked)
            {
                if (lBbloc.Text == textBox4.Text && F4)
                {
                    System.Diagnostics.Process.Start("C:/Program Files/Mozilla Firefox/firefox.exe");
                    F4 = false;
                }

            }
            if (checkBox5.Checked)
            {
                if (lBbloc.Text == textBox5.Text && F5)
                {
                    System.Diagnostics.Process.Start("LosCabos.mp4");
                    F5 = false;
                }

            }
            if (checkBox6.Checked)
            {
                if (lBbloc.Text == textBox6.Text && F6)
                {
                    System.Diagnostics.Process.Start("Nightcall.mp3");
                    F6 = false;
                }
            }
            if (checkBox7.Checked)
            {
                if (lBbloc.Text == textBox7.Text && F7)
                {
                    System.Diagnostics.Process.Start("WPFmanuels.exe");
                    F7 = false;               
                }

            }
            if (checkBox8.Checked)
            {
                if (lBbloc.Text == textBox8.Text && F8)
                {
                    System.Diagnostics.Process.Start("Practica_LanzadorConAlarma_31_03.exe");
                    F8 = false;
                }
            }
        }
    }
}
