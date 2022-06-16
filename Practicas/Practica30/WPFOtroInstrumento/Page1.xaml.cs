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
    /// Lógica de interacción para Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        double nota, escala;
        double f;
        SoundPlayer nota1 = new SoundPlayer();
        public Page1()
        {
            InitializeComponent();
        }

        private void bt_do_Click(object sender, RoutedEventArgs e)
        {
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

        private void bt_dos_Click(object sender, RoutedEventArgs e)
        {
            nota1.SoundLocation = (@"54.wav");
            nota1.Load();
            nota1.Play();
            nota = 2;
            escala = 4;
            f = Frecuencia(nota, escala);
            lB1.Items.Add("Nota = " + nota);
            lB1.Items.Add("Octava = " + escala);
            lB1.Items.Add("Frecuencia = " + f);
        }

        private void bt_re_Click(object sender, RoutedEventArgs e)
        {
            nota1.SoundLocation = (@"55.wav");
            nota1.Load();
            nota1.Play();
            nota = 3;
            escala = 4;
            f = Frecuencia(nota, escala);
            lB1.Items.Add("Nota = " + nota);
            lB1.Items.Add("Octava = " + escala);
            lB1.Items.Add("Frecuencia = " + f);
        }

        private void bt_res_Click(object sender, RoutedEventArgs e)
        {
            nota1.SoundLocation = (@"56.wav");
            nota1.Load();
            nota1.Play();
            nota = 4;
            escala = 4;
            f = Frecuencia(nota, escala);
            lB1.Items.Add("Nota = " + nota);
            lB1.Items.Add("Octava = " + escala);
            lB1.Items.Add("Frecuencia = " + f);
        }

        private void bt_mi_Click(object sender, RoutedEventArgs e)
        {
            nota1.SoundLocation = (@"57.wav");
            nota1.Load();
            nota1.Play();
            nota = 5;
            escala = 4;
            f = Frecuencia(nota, escala);
            lB1.Items.Add("Nota = " + nota);
            lB1.Items.Add("Octava = " + escala);
            lB1.Items.Add("Frecuencia = " + f);
        }

        private void bt_fa_Click(object sender, RoutedEventArgs e)
        {
            nota1.SoundLocation = (@"58.wav");
            nota1.Load();
            nota1.Play();
            nota = 6;
            escala = 4;
            f = Frecuencia(nota, escala);
            lB1.Items.Add("Nota = " + nota);
            lB1.Items.Add("Octava = " + escala);
            lB1.Items.Add("Frecuencia = " + f);
        }

        private void bt_fas_Click(object sender, RoutedEventArgs e)
        {
            nota1.SoundLocation = (@"59.wav");
            nota1.Load();
            nota1.Play();
            nota = 7;
            escala = 4;
            f = Frecuencia(nota, escala);
            lB1.Items.Add("Nota = " + nota);
            lB1.Items.Add("Octava = " + escala);
            lB1.Items.Add("Frecuencia = " + f);
        }

        private void bt_sol_Click(object sender, RoutedEventArgs e)
        {
            nota1.SoundLocation = (@"60.wav");
            nota1.Load();
            nota1.Play();
            nota = 8;
            escala = 4;
            f = Frecuencia(nota, escala);
            lB1.Items.Add("Nota = " + nota);
            lB1.Items.Add("Octava = " + escala);
            lB1.Items.Add("Frecuencia = " + f);
        }

        private void bt_sols_Click(object sender, RoutedEventArgs e)
        {
            nota1.SoundLocation = (@"61.wav");
            nota1.Load();
            nota1.Play();
            nota = 9;
            escala = 4;
            f = Frecuencia(nota, escala);
            lB1.Items.Add("Nota = " + nota);
            lB1.Items.Add("Octava = " + escala);
            lB1.Items.Add("Frecuencia = " + f);
        }

        private void bt_la_Click(object sender, RoutedEventArgs e)
        {
            nota1.SoundLocation = (@"62.wav");
            nota1.Load();
            nota1.Play();
            nota = 10;
            escala = 4;
            f = Frecuencia(nota, escala);
            lB1.Items.Add("Nota = " + nota);
            lB1.Items.Add("Octava = " + escala);
            lB1.Items.Add("Frecuencia = " + f);
        }

        private void bt_las_Click(object sender, RoutedEventArgs e)
        {
            nota1.SoundLocation = (@"63.wav");
            nota1.Load();
            nota1.Play();
            nota = 11;
            escala = 4;
            f = Frecuencia(nota, escala);
            lB1.Items.Add("Nota = " + nota);
            lB1.Items.Add("Octava = " + escala);
            lB1.Items.Add("Frecuencia = " + f);
        }

        private void bt_si_Click(object sender, RoutedEventArgs e)
        {
            nota1.SoundLocation = (@"64.wav");
            nota1.Load();
            nota1.Play();
            nota = 12;
            escala = 4;
            f = Frecuencia(nota, escala);
            lB1.Items.Add("Nota = " + nota);
            lB1.Items.Add("Octava = " + escala);
            lB1.Items.Add("Frecuencia = " + f);
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
