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

namespace WPFOtroInstrumento
{
    /// <summary>
    /// Lógica de interacción para Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        double nota, escala;
        double f;
        SoundPlayer nota1 = new SoundPlayer();
        public Page2()
        {
            InitializeComponent();
        }

        private void bt_do_Click(object sender, RoutedEventArgs e)
        {
            nota1.SoundLocation = (@"dog.wav");
            nota1.Load();
            nota1.Play();
            nota = 1;
            escala = 4;
            f = Frecuencia(nota, escala);
            lB2.Items.Add("Nota = " + nota);
            lB2.Items.Add("Octava = " + escala);
            lB2.Items.Add("Frecuencia = " + f);
        }

        private void bt_re_Click(object sender, RoutedEventArgs e)
        {
            nota1.SoundLocation = (@"reg.wav");
            nota1.Load();
            nota1.Play();
            nota = 3;
            escala = 4;
            f = Frecuencia(nota, escala);
            lB2.Items.Add("Nota = " + nota);
            lB2.Items.Add("Octava = " + escala);
            lB2.Items.Add("Frecuencia = " + f);
        }

        private void bt_mi_Click(object sender, RoutedEventArgs e)
        {
            nota1.SoundLocation = (@"mig.wav");
            nota1.Load();
            nota1.Play();
            nota = 5;
            escala = 4;
            f = Frecuencia(nota, escala);
            lB2.Items.Add("Nota = " + nota);
            lB2.Items.Add("Octava = " + escala);
            lB2.Items.Add("Frecuencia = " + f);
        }

        private void bt_fa_Click(object sender, RoutedEventArgs e)
        {
            nota1.SoundLocation = (@"fag.wav");
            nota1.Load();
            nota1.Play();
            nota = 6;
            escala = 4;
            f = Frecuencia(nota, escala);
            lB2.Items.Add("Nota = " + nota);
            lB2.Items.Add("Octava = " + escala);
            lB2.Items.Add("Frecuencia = " + f);
        }

        private void bt_sol_Click(object sender, RoutedEventArgs e)
        {
            nota1.SoundLocation = (@"solg.wav");
            nota1.Load();
            nota1.Play();
            nota = 8;
            escala = 4;
            f = Frecuencia(nota, escala);
            lB2.Items.Add("Nota = " + nota);
            lB2.Items.Add("Octava = " + escala);
            lB2.Items.Add("Frecuencia = " + f);
        }

        private void bt_la_Click(object sender, RoutedEventArgs e)
        {
            nota1.SoundLocation = (@"lag.wav");
            nota1.Load();
            nota1.Play();
            nota = 10;
            escala = 4;
            f = Frecuencia(nota, escala);
            lB2.Items.Add("Nota = " + nota);
            lB2.Items.Add("Octava = " + escala);
            lB2.Items.Add("Frecuencia = " + f);
        }

        private void bt_si_Click(object sender, RoutedEventArgs e)
        {
            nota1.SoundLocation = (@"sig.wav");
            nota1.Load();
            nota1.Play();
            nota = 12;
            escala = 4;
            f = Frecuencia(nota, escala);
            lB2.Items.Add("Nota = " + nota);
            lB2.Items.Add("Octava = " + escala);
            lB2.Items.Add("Frecuencia = " + f);
        }
        public double Frecuencia(double nota, double escala)
        {
            double exp;
            exp = ((escala - 4) + ((nota - 10) / 12)) * Math.Log(2);
            f = 440 * Math.Exp(exp);
            return f;
        }
    }
}
