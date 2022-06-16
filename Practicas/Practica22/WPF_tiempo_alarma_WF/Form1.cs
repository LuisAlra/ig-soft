using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPF_tiempo_alarma_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss:f-dddd,dd,MMMM,yyyy");
            if (rBalarma.Checked)
            { 
                if (label1.Text == tBxalarma.Text)
                {
                    System.Diagnostics.Process.Start("Nightcall.mp3");
                    MessageBox.Show("Alarma");
                }
            }

        }
    }
}
