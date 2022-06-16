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
using System.Media;

namespace WPFNotaMusical
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double nota, escala;
        double f;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnota1_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer nota1 = new SoundPlayer();
            nota1.SoundLocation = (@"53(1).wav");
            nota1.Load();
            nota1.Play();
            nota = 1;
            escala = 4;
            f = Frecuencia(nota, escala);
            lB1.Items.Add("Nota = " + nota);
            lB1.Items.Add("Octava = " + escala);
            lB1.Items.Add("Frecuencia = " + f);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        }

        public double Frecuencia(double nota, double escala)
        {
            double exp;
            exp = ((escala - 4)+((nota - 10)/12))*Math.Log(2);
            f = 440*Math.Exp(exp);
            return f;
        }
    }
}
