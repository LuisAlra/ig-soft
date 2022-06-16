using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFmatArregloTextBox01
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int m, n;
        Matrices matA;
        TextBox[,] TbMat;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtTamaño_Click(object sender, RoutedEventArgs e)
        {
            m = int.Parse(Tbm.Text);
            n = int.Parse(Tbn.Text);
            int x = 0;
            int y = -20;
            matA = new Matrices(m, n);
            TbMat = new TextBox[m,n];
            StackPanel1.Children.Clear();
            TbIndi.Text = "Tamaño de la matriz " + m + "x" + n + " establecido";
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    TbMat[i,j] = new TextBox();
                    TbMat[i, j].Width = 30;
                    TbMat[i, j].Height = 20;
                    TbMat[i, j].HorizontalAlignment = HorizontalAlignment.Left;
                    TbMat[i, j].VerticalAlignment = VerticalAlignment.Top;
                    if (j == 0)
                    {
                        TbMat[i, j].Margin = new Thickness(30 * j, x, 0, 0);
                    }

                    else
                    {
                        TbMat[i, j].Margin = new Thickness(30 * j, y, 0, 0);
                    }

                    StackPanel1.Children.Add(TbMat[i, j]);
                }
            }
            
        }

        private void BtLeerMat_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matA.Elem[i, j] = double.Parse(TbMat[i, j].Text);
                    }
                }

                TbIndi.Text = "Datos de la matriz leídos";
            }

            catch
            {
                MessageBox.Show("Error de datos");
            }
        }

        private void BtFirma_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        }

        private void BtPonerMat_Click(object sender, RoutedEventArgs e)
        {
            string aux;
            for (int i = 0; i < m; i++)
            {
                aux = "";
                for (int j = 0; j < n; j++)
                {
                    aux += matA.Elem[i, j] + "\t";
                }
                aux += "\t";
                LbMat.Items.Add(aux);
            }

            TbIndi.Text = "Mostrando matriz";
        }
    }
}
