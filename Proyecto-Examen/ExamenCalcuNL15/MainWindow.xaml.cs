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

namespace ExamenCalcuNL15
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtCalcuBasica_Click(object sender, RoutedEventArgs e)
        {
            Frame1.Navigate(new CalcuBasica());

        }

        private void BtConversiones_Click(object sender, RoutedEventArgs e)
        {
            Frame1.Navigate(new Conversion());
        }

        private void BtMatrices_Click(object sender, RoutedEventArgs e)
        {
            Frame1.Navigate(new Matrices());
        }

        private void BtGraficador_Click(object sender, RoutedEventArgs e)
        {
            Frame1.Navigate(new Graficador());
        }

        private void BtTeoria_Click(object sender, RoutedEventArgs e)
        {
            Frame1.Navigate (new Teoria());
        }

        private void BtFirma_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        }

        private void BtCiclo_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CicloVidaSoft.docx");
        }
    }
}
