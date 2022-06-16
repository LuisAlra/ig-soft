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

namespace LanzadorGeneral
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

        private void BtPracticas_Click(object sender, RoutedEventArgs e)
        {
            Frame1.Navigate(new Practicas());
        }

        private void BtProyectos_Click(object sender, RoutedEventArgs e)
        {
            Frame1.Navigate (new Proyectos());  
        }
        private void BtExamen_Click(object sender, RoutedEventArgs e)
        {
            Frame1.Navigate(new Examen());
        }

        private void BtClases_Click(object sender, RoutedEventArgs e)
        {
            Frame1.Navigate(new Clases());
        }

        private void BtFirma_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        }
    }
}
