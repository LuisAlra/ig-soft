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
    /// Lógica de interacción para Graficador.xaml
    /// </summary>
    public partial class Graficador : Page
    {
        bool ban=false;
        public Graficador()
        {
            InitializeComponent();
        }

        private void BtGrafiDeter_Click(object sender, RoutedEventArgs e)
        {
            GraficaEstablecida f1 = new GraficaEstablecida();
            f1.Show();
        }

        private void BtGrafica_Click(object sender, RoutedEventArgs e)
        {
            GraficaIngresada f1 = new GraficaIngresada();
            f1.Show();
        }

        private void BtGraficaPolar_Click(object sender, RoutedEventArgs e)
        {
            GraficaPolar f1 = new GraficaPolar();   
            f1.Show();  
        }

        private void BtGraficaParame_Click(object sender, RoutedEventArgs e)
        {
            GraficaParametrica f1 = new GraficaParametrica();
            f1.Show();
        }

        private void BtGraficaLissajous_Click(object sender, RoutedEventArgs e)
        {
            GraficaLissajous f1 = new GraficaLissajous();
            f1.Show();
        }
    }
}
