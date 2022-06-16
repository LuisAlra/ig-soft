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

namespace WPF_tiempo_alarma_WF
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

        private void bTalarma_Click(object sender, RoutedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();

        }

        private void BtFirma_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        }
    }
}
