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

namespace CircuitoResistencias_WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double r1, r2, r3, r4;
        double Ve, Vab;
        public MainWindow()
        {
            InitializeComponent();
            r1 = 0;
            r2 = 0;
            r3 = 0;
            r4 = 0;
            Ve = 5;
            Vab = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        }

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            Proceso();
            Salida();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
        public void Entrada()
        {
            try
            {
                r1 = double.Parse(Tbx1.Text);
                r2 = double.Parse(Tbx2.Text);
                r3 = double.Parse(Tbx3.Text);
                r4 = double.Parse(Tbx4.Text);
            }
            catch
            {

                MessageBox.Show("Error de datos!!");
            }

        }
        public void Proceso()
        {
            double rx, ry, delta, i1, i2;
            rx = r1 + r3;
            ry = r2 + r3 + r4;
            delta = rx * ry - r3 * r3;
            i1 = Ve * ry / delta;
            i2 = r3 * Ve / delta;
            Vab = r4 * i2;
            Vab = Math.Round(Vab, 4);

        }
        public void Salida()
        {
            Tbx6.Text = Vab.ToString();

        }
    }
}
