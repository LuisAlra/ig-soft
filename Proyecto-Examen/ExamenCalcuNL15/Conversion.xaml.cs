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
using System.Numerics;

namespace ExamenCalcuNL15
{
    /// <summary>
    /// Lógica de interacción para Conversion.xaml
    /// </summary>
    public partial class Conversion : Page
    {
        Conversiones Conver;
        string bin, hexa, octal;
        double cel, far, ran, kel;
        int dec;

        public Conversion()
        {
            InitializeComponent();
            Conver = new Conversiones();
        }

        private void RbtDec_Checked(object sender, RoutedEventArgs e)
        {
            Lb1.Content = "Decimal";
            Lb2.Content = "Binario";
            Lb3.Content = "Hexadecimal";
            Lb4.Content = "Octal";
        }

        private void RbtBin_Checked(object sender, RoutedEventArgs e)
        {
            Lb1.Content = "Binario";
            Lb2.Content = "Decimal";
            Lb3.Content = "Hexadecimal";
            Lb4.Content = "Octal";
        }

        private void RbtHexa_Checked(object sender, RoutedEventArgs e)
        {
            Lb1.Content = "Hexadecimal";
            Lb2.Content = "Decimal";
            Lb3.Content = "Binario";
            Lb4.Content = "Octal";
        }

        private void RbtOctal_Checked(object sender, RoutedEventArgs e)
        {
            Lb1.Content = "Octal";
            Lb2.Content = "Decimal";
            Lb3.Content = "Binario";
            Lb4.Content = "Hexadecimal";
        }

        private void BtConvertir_Click(object sender, RoutedEventArgs e)
        {
            if (RbtDec.IsChecked == true)
            {
                EntradaDec();
                Conver.Dec2Bin(dec, ref bin);
                Conver.Dec2Hexa(dec, ref hexa);
                Conver.Dec2Octal(dec, ref octal);
                SalidaDec2(bin, hexa, octal);
            }
            
            if(RbtBin.IsChecked == true)
            {
                EntradaBin();
                Conver.Bin2Dec(bin, ref dec);
                Conver.Dec2Hexa(dec, ref hexa);
                Conver.Dec2Octal(dec, ref octal);
                SalidaBin2(dec, hexa, octal);
            }

            if (RbtHexa.IsChecked == true)
            {
                EntradaHexa();
                Conver.Hexa2Dec(hexa, ref dec);
                Conver.Dec2Bin(dec, ref bin);
                Conver.Dec2Octal(dec, ref octal);
                SalidaHexa2(dec, bin, octal);
            }

            if (RbtOctal.IsChecked == true)
            {
                EntradaOctal();
                Conver.Octal2Dec(octal, ref dec);
                Conver.Dec2Bin(dec, ref bin);
                Conver.Dec2Hexa(dec, ref hexa);
                SalidaOctal2(dec, bin, hexa);
            }
        }

        public void EntradaDec()
        {
            try
            {
                dec = int.Parse(Tb1.Text);
            }
            catch
            {
                MessageBox.Show("Error de entrada de datos...");
            }
        }

        public void EntradaBin()
        {
            try
            {
                bin = Tb1.Text;
            }
            catch
            {
                MessageBox.Show("Error de entrada de datos...");
            }
        }

        public void EntradaHexa()
        {
            try
            {
                hexa = Tb1.Text;
            }
            catch
            {
                MessageBox.Show("Error de entrada de datos...");
            }
        }

        public void EntradaOctal()
        {
            try
            {
                octal = Tb1.Text;
            }
            catch
            {
                MessageBox.Show("Error de entrada de datos...");
            }
        }

        public void SalidaDec2(string bin, string hexa, string octal)
        {
            Tb2.Text = bin;
            Tb3.Text = hexa;
            Tb4.Text = octal;
        }

        public void SalidaBin2(int dec, string hexa, string octal)
        {
            Tb2.Text = dec.ToString();
            Tb3.Text = hexa;
            Tb4.Text = octal;
        }

        public void SalidaHexa2(int dec, string bin, string octal)
        {
            Tb2.Text = dec.ToString();
            Tb3.Text= bin;
            Tb4.Text = octal;   
        }

        public void SalidaOctal2(int dec, string bin, string hexa)
        {
            Tb2.Text = dec.ToString();
            Tb3.Text = bin;
            Tb4.Text = hexa;
        }

        private void RbtCelsius_Checked(object sender, RoutedEventArgs e)
        {
            Lb5.Content = "Celsius";
            Lb6.Content = "Fahrenheit";
            Lb7.Content = "Rankine";
            Lb8.Content = "Kelvin";
        }

        private void RbtFahrenheit_Checked(object sender, RoutedEventArgs e)
        {
            Lb5.Content = "Fahrenheit";
            Lb6.Content = "Celsius";
            Lb7.Content = "Rankine";
            Lb8.Content = "Kelvin";
        }

        private void RbtRankine_Checked(object sender, RoutedEventArgs e)
        {
            Lb5.Content = "Rankine";
            Lb6.Content = "Celsius";
            Lb7.Content = "Fahrenheit";
            Lb8.Content = "Kelvin";
        }

        private void RbtKelvin_Checked(object sender, RoutedEventArgs e)
        {
            Lb5.Content = "Kelvin";
            Lb6.Content = "Celsius";
            Lb7.Content = "Fahrenheit";
            Lb8.Content = "Rankine";
        }

        private void BtConvertirTempe_Click(object sender, RoutedEventArgs e)
        {
            if(RbtCelsius.IsChecked == true)
            {
                EntradaCel();
                Conver.Cel2Far(cel, ref far);
                Conver.Cel2Ran(far, ref ran);
                Conver.Cel2Kel(cel, ref kel);
                SalidaCel(far, ran, kel);
            }

            if(RbtFahrenheit.IsChecked == true)
            {
                EntradaFar();
                Conver.Far2Cel(far, ref cel);
                Conver.Cel2Ran(far, ref ran);
                Conver.Cel2Kel(cel, ref kel);
                SalidaFar(cel, ran, kel);
            }

            if(RbtRankine.IsChecked == true)
            {
                EntradaRan();
                Conver.Ran2Cel(ran, ref cel);
                Conver.Cel2Far(cel, ref far);
                Conver.Cel2Kel(cel, ref kel);
                SalidaRan(cel, far, kel);
            }

            if(RbtKelvin.IsChecked == true)
            {
                EntradaKel();
                Conver.Kel2Cel(kel, ref cel);
                Conver.Cel2Far(cel, ref far);
                Conver.Cel2Ran(far, ref ran);
                SalidaKel(cel, far, ran);
            }
        }

        public void EntradaCel()
        {
            try
            {
                cel = double.Parse(Tb5.Text);
            }
            catch
            {
                MessageBox.Show("Error de entrada de datos...");
            }
        }

        public void SalidaCel(double far, double ran, double kel)
        {
            Tb6.Text = far.ToString() + " °F";
            Tb7.Text = ran.ToString() + " °R";
            Tb8.Text = kel.ToString() + " °K";
        }

        public void EntradaFar()
        {
            try
            {
                far = double.Parse(Tb5.Text);
            }
            catch
            {
                MessageBox.Show("Error de entrada de datos...");
            }
        }

        public void SalidaFar(double cel, double ran, double kel)
        {
            Tb6.Text = cel.ToString() + " °C";
            Tb7.Text = ran.ToString() + " °R";
            Tb8.Text = kel.ToString() + " °K";
        }

        public void EntradaRan()
        {
            try
            {
                ran = double.Parse(Tb5.Text);
            }
            catch
            {
                MessageBox.Show("Error de entrada de datos...");
            }
        }

        public void SalidaRan(double cel, double far, double kel)
        {
            Tb6.Text = cel.ToString() + " °C";
            Tb7.Text = far.ToString() + " °F";
            Tb8.Text = kel.ToString() + " °K";
        }

        public void EntradaKel()
        {
            try
            {
                kel = double.Parse(Tb5.Text);
            }
            catch
            {
                MessageBox.Show("Error de entrada de datos...");
            }
        }

        public void SalidaKel(double cel, double far, double ran)
        {
            Tb6.Text = cel.ToString() + " °C";
            Tb7.Text = far.ToString() + " °F";
            Tb8.Text = ran.ToString() + " °R";
        }
    }
}
