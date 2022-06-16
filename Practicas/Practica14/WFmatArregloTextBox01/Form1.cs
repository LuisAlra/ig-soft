using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFmatArregloTextBox01
{
    public partial class Form1 : Form
    {
        int m, n;
        double[,] elem;
        TextBox[,] TbMat;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtTamaño_Click(object sender, EventArgs e)
        {
            m = int.Parse(Tbm.Text);
            n = int.Parse(Tbn.Text);
            elem = new double[m, n];
            TbMat = new TextBox[m, n];
            panel1.Controls.Clear();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    
                    TbMat[i, j] = new TextBox();
                    TbMat[i, j].Width = 60;
                    TbMat[i, j].Height = 20;
                    TbMat[i, j].Location = new Point(j * 60, i * 20);
                    panel1.Controls.Add(TbMat[i, j]);
                }
            }
            Tbindi.Text = "Tamaño de la matriz " + m + "x" + n + " establecido";
        }

        private void BtLeerMat_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        elem[i, j] = double.Parse(TbMat[i, j].Text);
                    }
                }
                
                Tbindi.Text = "Datos de la matriz leídos";
            }
            catch
            {
                MessageBox.Show("Error de datos");
            }
        }

        private void BtPonerMat_Click(object sender, EventArgs e)
        {
            string aux;
            for (int i = 0; i < m; i++)
            {
                aux = "";
                for (int j = 0; j < n; j++)
                {
                    aux+=elem[i,j] + "\t";
                }
                aux += "\t";
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
