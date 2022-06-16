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

namespace WPFmat01
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int m, n;
        Matrices matA;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtTamaño_Click(object sender, RoutedEventArgs e)
        {
            m = int.Parse(Tbm.Text);
            n = int.Parse(Tbn.Text);
            matA = new Matrices(m, n);
            TbMatA.Text = "";
            TbIndi.Text = "Tamaño de la matriz " + m + "x" + n + " establecido";
        }

        private void BtLeer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string[] split;
                for (int i = 0; i < m; i++)
                {
                    split = TbMatA.GetLineText(i).Split(',');
                    for (int j = 0; j < n; j++)
                    {
                        matA.Elem[i, j] = double.Parse(split[j]);
                    }
                }

                TbIndi.Text = "Datos de la matriz leídos";
            }
            catch
            {
                MessageBox.Show("Error de datos");
            }

        }

        private void BtPoner_Click(object sender, RoutedEventArgs e)
        {
            string aux;
            for (int i = 0; i < m; i++)
            {
                aux="";
                for (int j = 0; j < n; j++)
                {
                    aux+=matA.Elem[i,j]+"\t";
                }
                aux += "\t";
                LbmatA.Items.Add(aux);
            }

            TbIndi.Text = "Mostrando matriz";
        }

        private void Bt_Firma_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        }
    }
}
