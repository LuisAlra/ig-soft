using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFmatDataGrid01
{
    public partial class Form1 : Form
    {
        int m, n;
        double[,] elem;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtTamaño_Click(object sender, EventArgs e)
        {
            m =int.Parse(Tbm.Text);
            n=int.Parse(Tbn.Text);
            elem = new double[m,n];
            DGMat.RowCount = m;
            DGMat.ColumnCount = n;
            Tbindi.Text = "Tamaño de la matriz "+m+"x"+n+" establecido";
        }

        private void BtLeer_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        elem[i, j] = double.Parse(DGMat.Rows[i].Cells[j].Value.ToString());
                    }
                }

                Tbindi.Text = "Datos de la matriz leídos";
            }
            catch
            {
                MessageBox.Show("Error de datos");

            }
        }

        private void BtPoner_Click(object sender, EventArgs e)
        {
            string aux;
            for (int i = 0; i< m; i++)
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

        private void BtFirma_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        }
    }
}
