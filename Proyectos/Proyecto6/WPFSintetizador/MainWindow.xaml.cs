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

namespace WPFSintetizador
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SoundPlayer nota1 = new SoundPlayer();
        SoundPlayer ritmo = new SoundPlayer();
        string aux;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            aux = "a";
            tBmusic.Text = "TRANCE";
        }

        private void bt_do_Click(object sender, RoutedEventArgs e)
        {
            switch (aux)
            {
                case "a":
                    nota1.SoundLocation = (@"do1.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "b":
                    nota1.SoundLocation = (@"do2.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "c":
                    nota1.SoundLocation = (@"do3.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "d":
                    nota1.SoundLocation = (@"dog.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "e":
                    nota1.SoundLocation = (@"dob.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "f":
                    nota1.SoundLocation = (@"doo.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "g":
                    nota1.SoundLocation = (@"doc.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "h":
                    nota1.SoundLocation = (@"dol.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                default:
                    break;

            }

        }

        private void bt_2_Click(object sender, RoutedEventArgs e)
        {
            aux = "b";
            tBmusic.Text = "TALK";
        }

        private void bt_3_Click(object sender, RoutedEventArgs e)
        {
            aux = "c";
            tBmusic.Text = "LEAD";
        }

        private void bt_dos_Click(object sender, RoutedEventArgs e)
        {
            switch (aux)
            {
                case "a":
                    nota1.SoundLocation = (@"dos1.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "b":
                    nota1.SoundLocation = (@"dos2.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "c":
                    nota1.SoundLocation = (@"dos3.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "d":
                    nota1.SoundLocation = (@"dosg.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "e":
                    nota1.SoundLocation = (@"dosb.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "f":
                    nota1.SoundLocation = (@"doso.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "g":
                    nota1.SoundLocation = (@"dosc.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "h":
                    nota1.SoundLocation = (@"dosl.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                default:
                    break;

            }
        }

        private void bt_re_Click(object sender, RoutedEventArgs e)
        {
            switch (aux)
            {
                case "a":
                    nota1.SoundLocation = (@"re1.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "b":
                    nota1.SoundLocation = (@"re2.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "c":
                    nota1.SoundLocation = (@"re3.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "d":
                    nota1.SoundLocation = (@"reg.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "e":
                    nota1.SoundLocation = (@"reb.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "f":
                    nota1.SoundLocation = (@"reo.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "g":
                    nota1.SoundLocation = (@"rec.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "h":
                    nota1.SoundLocation = (@"rel.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                default:
                    break;

            }
        }

        private void bt_res_Click(object sender, RoutedEventArgs e)
        {
            switch (aux)
            {
                case "a":
                    nota1.SoundLocation = (@"res1.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "b":
                    nota1.SoundLocation = (@"res2.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "c":
                    nota1.SoundLocation = (@"res3.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "d":
                    nota1.SoundLocation = (@"resg.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "e":
                    nota1.SoundLocation = (@"resb.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "f":
                    nota1.SoundLocation = (@"reso.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "g":
                    nota1.SoundLocation = (@"resc.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "h":
                    nota1.SoundLocation = (@"resl.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                default:
                    break;

            }
        }

        private void bt_mi_Click(object sender, RoutedEventArgs e)
        {
            switch (aux)
            {
                case "a":
                    nota1.SoundLocation = (@"mi1.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "b":
                    nota1.SoundLocation = (@"mi2.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "c":
                    nota1.SoundLocation = (@"mi3.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "d":
                    nota1.SoundLocation = (@"mig.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "e":
                    nota1.SoundLocation = (@"mib.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "f":
                    nota1.SoundLocation = (@"mio.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "g":
                    nota1.SoundLocation = (@"mic.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "h":
                    nota1.SoundLocation = (@"mil.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                default:
                    break;

            }
        }

        private void bt_fa_Click(object sender, RoutedEventArgs e)
        {
            switch (aux)
            {
                case "a":
                    nota1.SoundLocation = (@"fa1.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "b":
                    nota1.SoundLocation = (@"fa2.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "c":
                    nota1.SoundLocation = (@"fa3.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "d":
                    nota1.SoundLocation = (@"fag.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "e":
                    nota1.SoundLocation = (@"fab.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "f":
                    nota1.SoundLocation = (@"fao.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "g":
                    nota1.SoundLocation = (@"fac.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "h":
                    nota1.SoundLocation = (@"fal.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                default:
                    break;

            }
        }

        private void bt_fas_Click(object sender, RoutedEventArgs e)
        {
            switch (aux)
            {
                case "a":
                    nota1.SoundLocation = (@"fas1.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "b":
                    nota1.SoundLocation = (@"fas2.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "c":
                    nota1.SoundLocation = (@"fas3.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "d":
                    nota1.SoundLocation = (@"fasg.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "e":
                    nota1.SoundLocation = (@"fasb.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "f":
                    nota1.SoundLocation = (@"faso.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "g":
                    nota1.SoundLocation = (@"fasc.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "h":
                    nota1.SoundLocation = (@"fasl.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                default:
                    break;

            }
        }

        private void bt_sol_Click(object sender, RoutedEventArgs e)
        {
            switch (aux)
            {
                case "a":
                    nota1.SoundLocation = (@"sol1.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "b":
                    nota1.SoundLocation = (@"sol2.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "c":
                    nota1.SoundLocation = (@"sol3.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "d":
                    nota1.SoundLocation = (@"solg.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "e":
                    nota1.SoundLocation = (@"solb.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "f":
                    nota1.SoundLocation = (@"solo.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "g":
                    nota1.SoundLocation = (@"solc.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "h":
                    nota1.SoundLocation = (@"soll.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                default:
                    break;

            }
        }

        private void bt_sols_Click(object sender, RoutedEventArgs e)
        {
            switch (aux)
            {
                case "a":
                    nota1.SoundLocation = (@"sols1.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "b":
                    nota1.SoundLocation = (@"sols2.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "c":
                    nota1.SoundLocation = (@"sols3.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "d":
                    nota1.SoundLocation = (@"solsg.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "e":
                    nota1.SoundLocation = (@"solsb.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "f":
                    nota1.SoundLocation = (@"solso.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "g":
                    nota1.SoundLocation = (@"solsc.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "h":
                    nota1.SoundLocation = (@"solsl.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                default:
                    break;
            }
        }

        private void bt_la_Click(object sender, RoutedEventArgs e)
        {
            switch (aux)
            {
                case "a":
                    nota1.SoundLocation = (@"la1.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "b":
                    nota1.SoundLocation = (@"la2.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "c":
                    nota1.SoundLocation = (@"la3.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "d":
                    nota1.SoundLocation = (@"lag.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "e":
                    nota1.SoundLocation = (@"lab.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "f":
                    nota1.SoundLocation = (@"lao.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "g":
                    nota1.SoundLocation = (@"lac.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "h":
                    nota1.SoundLocation = (@"lal.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                default:
                    break;

            }
        }

        private void bt_las_Click(object sender, RoutedEventArgs e)
        {
            switch (aux)
            {
                case "a":
                    nota1.SoundLocation = (@"las1.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "b":
                    nota1.SoundLocation = (@"las2.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "c":
                    nota1.SoundLocation = (@"las3.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "d":
                    nota1.SoundLocation = (@"lasg.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "e":
                    nota1.SoundLocation = (@"lasb.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "f":
                    nota1.SoundLocation = (@"laso.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "g":
                    nota1.SoundLocation = (@"lasc.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "h":
                    nota1.SoundLocation = (@"lasl.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                default:
                    break;

            }
        }

        private void bt_si_Click(object sender, RoutedEventArgs e)
        {
            switch (aux)
            {
                case "a":
                    nota1.SoundLocation = (@"si1.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "b":
                    nota1.SoundLocation = (@"si2.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "c":
                    nota1.SoundLocation = (@"si3.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "d":
                    nota1.SoundLocation = (@"sig.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "e":
                    nota1.SoundLocation = (@"sib.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "f":
                    nota1.SoundLocation = (@"sio.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "g":
                    nota1.SoundLocation = (@"sic.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                case "h":
                    nota1.SoundLocation = (@"sil.wav");
                    nota1.Load();
                    nota1.Play();
                    break;
                default:
                    break;

            }
        }

        private void bt_ritmo1_Click(object sender, RoutedEventArgs e)
        {
            ritmo.SoundLocation = (@"ritmo1.wav");
            ritmo.Load();
            ritmo.PlayLooping();
            tBmusic.Text = "RITMO 1";
        }

        private void bt_ritmo2_Click(object sender, RoutedEventArgs e)
        {
            ritmo.SoundLocation = (@"ritmo2.wav");
            ritmo.Load();
            ritmo.PlayLooping();
            tBmusic.Text = "RITMO 2";
        }

        private void bt_stop_Click(object sender, RoutedEventArgs e)
        {
            ritmo.Stop();
            tBmusic.Text = " ";
        }

        private void bt_tumb1_Click(object sender, RoutedEventArgs e)
        {
            nota1.SoundLocation = (@"tom1.wav");
            nota1.Load();
            nota1.Play();
        }

        private void bt_tumb2_Click(object sender, RoutedEventArgs e)
        {
            nota1.SoundLocation = (@"tom2.wav");
            nota1.Load();
            nota1.Play();
        }

        private void bt_tumb3_Click(object sender, RoutedEventArgs e)
        {
            nota1.SoundLocation = (@"tom3.wav");
            nota1.Load();
            nota1.Play();
        }

        private void bt_crash_Click(object sender, RoutedEventArgs e)
        {
            nota1.SoundLocation = (@"crash.wav");
            nota1.Load();
            nota1.Play();
        }

        private void bt_seleccionar_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem inst = (ComboBoxItem)instrumentos.SelectedItem;
            TextBlock nombre = (TextBlock)inst.Content;
            string seleccion = nombre.Text;

            if (seleccion == "Guitarra")
            {
                aux = "d";
                tBmusic.Text = "GUITARRA";
            }
            else if (seleccion == "Bajo")
            {
                aux = "e";
                tBmusic.Text = "BAJO";
            }
            else if (seleccion == "Organo")
            {
                aux = "f";
                tBmusic.Text = "ORGANO";
            }
            else if (seleccion == "Cuerdas")
            {
                aux = "g";
                tBmusic.Text = "CUERDAS";
            }
            else if (seleccion == "Campanas")
            {
                aux = "h";
                tBmusic.Text = "CAMPANAS";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        }
    }
}
