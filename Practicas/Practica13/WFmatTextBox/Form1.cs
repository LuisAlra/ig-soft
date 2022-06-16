using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFmatTextBox
{
    public partial class Form1 : Form
    {
        int m, n;
        double[,] elem;
        string[] split;

        public Form1()
        {
            InitializeComponent();
        }

        private void TbTamaño_Click(object sender, EventArgs e)
        {
            
            m = int.Parse(Tbm.Text);
            n = int.Parse(Tbn.Text);
            elem = new double[m, n];
            TbMat.Text = "";
            Tbindi.Text = "Tamaño de la matriz " + m + "x" + n + " establecido";
        }

        private void TbLeerMat_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < m; i++)
                {
                    split = TbMat.Lines[i].Split(',');
                    for (int j = 0; j < n; j++)
                    {
                        elem[i, j] = double.Parse(split[j]);
                    }
                }

                Tbindi.Text = "Datos de la matriz leídos";
            }
            catch
            {
                MessageBox.Show("Error de datos");
            }
        }

        private void TbPonerMat_Click(object sender, EventArgs e)
        {
            string aux;
            for (int i = 0; i < m; i++)
            {
                aux = "";
                for (int j = 0; j < n; j++)
                {
                    aux = aux + elem[i, j] + "\t";
                }
                aux = aux + "\t";
                LbMat.Items.Add(aux);
            }

            Tbindi.Text = "Mostrando matriz";
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
    }
}
