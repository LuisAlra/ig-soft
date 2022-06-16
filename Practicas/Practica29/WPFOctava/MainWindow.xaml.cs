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

        private void btnota2_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer nota1 = new SoundPlayer();
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

        private void btnota4_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer nota1 = new SoundPlayer();
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

        private void btnota6_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer nota1 = new SoundPlayer();
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

        private void btnota3_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer nota1 = new SoundPlayer();
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

        private void btnota5_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer nota1 = new SoundPlayer();
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

        private void btnota7_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer nota1 = new SoundPlayer();
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

        private void btnotasos1_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer nota1 = new SoundPlayer();
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

        private void btnotasos2_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer nota1 = new SoundPlayer();
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

        private void btnotasos3_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer nota1 = new SoundPlayer();
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

        private void btnotasos4_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer nota1 = new SoundPlayer();
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

        private void btnotasos5_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer nota1 = new SoundPlayer();
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
