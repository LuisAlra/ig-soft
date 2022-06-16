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
    /// Lógica de interacción para CalcuBasica.xaml
    /// </summary>
    public partial class CalcuBasica : Page
    {
        double x, y, r;
        Calculadora cal;
        string mensaje, fx, fy, fxy;

        public CalcuBasica()
        {
            InitializeComponent();
            cal = new Calculadora();
        }

        private void BtCosx_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.CosXoY(x, ref r) + "x";
            Salida(r);
        }

        private void BtCosy_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.CosXoY(y, ref r) + "y";
            Salida(r);
        }

        private void BtSinx_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.SinXoY(x, ref r) + "x";
            Salida(r);
        }

        private void BtSiny_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.SinXoY(y, ref r) + "y";
            Salida(r);
        }

        private void BtTanx_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.TanXoY(x, ref r) + "x";
            Salida(r);
        }

        private void BtTany_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.TanXoY(y, ref r) + "y";
            Salida(r);
        }

        private void BtAcosx_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.AcosXoY(x, ref r) + "x";
            Salida(r);
        }

        private void BtAcosy_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.AcosXoY(y, ref r) + "y";
            Salida(r);
        }

        private void BtAsinx_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.AsinXoY(x, ref r) + "x";
            Salida(r);
        }

        private void BtAsiny_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.AsinXoY(y, ref r) + "y";
            Salida(r);
        }

        private void BtAtanx_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.AtanXoY(x, ref r) + "x";
            Salida(r);
        }

        private void BtAtany_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.AtanXoY(y, ref r) + "y";
            Salida(r);
        }

        private void BtCoshx_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.CoshXoY(x, ref r) + "x";
            Salida(r);
        }

        private void BtCoshy_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.CoshXoY(y, ref r) + "y";
            Salida(r);
        }

        private void BtSinhx_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.SinhXoY(x, ref r) + "x";
            Salida(r);
        }

        private void BtSinhy_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.SinhXoY(y, ref r) + "y";
            Salida(r);
        }

        private void BtTanhx_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.TanhXoY(x, ref r) + "x";
            Salida(r);
        }

        private void BtTanhy_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.TanhXoY(y, ref r) + "y";
            Salida(r);
        }

        private void BtCotx_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.CotXoY(x, ref r) + "x";
            Salida(r);
        }

        private void BtCoty_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.CotXoY(y, ref r) + "y";
            Salida(r);
        }

        private void BtSecx_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.SecXoY(x, ref r) + "x";
            Salida(r);
        }

        private void BtSecy_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.SecXoY(y, ref r) + "y";
            Salida(r);
        }

        private void BtCscx_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.CscXoY(x, ref r) + "x";
            Salida(r);
        }

        private void BtCscy_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.CscXoY(y, ref r) + "y";
            Salida(r);
        }

        private void BtExpx_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.ExpXoY(x, ref r) + "x";
            Salida(r);
        }

        private void BtExpy_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.ExpXoY(y, ref r) + "y";
            Salida(r);
        }

        private void BtLnx_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.LnXoY(x, ref r) + "x";
            Salida(r);
        }

        private void BtLny_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.LnXoY(y, ref r) + "y";
            Salida(r);
        }

        private void BtLog10x_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.Log10XoY(x, ref r) + "x";
            Salida(r);
        }

        private void BtLog10y_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.Log10XoY(y, ref r) + "y";
            Salida(r);
        }

        private void BtAbsx_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.AbsXoY(x, ref r) + "x";
            Salida(r);
        }

        private void BtAbsy_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.AbsXoY(y, ref r) + "y";
            Salida(r);
        }

        private void BtRoundx_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.RoundXoY(x, ref r) + "x";
            Salida(r);
        }

        private void BtRoundy_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.RoundXoY(y, ref r) + "y";
            Salida(r);
        }

        private void BtSingx_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.SingXoY(x, ref r) + "x";
            Salida(r);
        }

        private void BtSigny_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.SingXoY(y, ref r) + "y";
            Salida(r);
        }

        private void BtSuma_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.SumaXY(x, y, ref r);
            Salida(r);
        }

        private void BtResta_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.RestaXY(x, y, ref r);
            Salida(r);
        }

        private void BtMulti_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.MultiXY(x, y, ref r);
            Salida(r);
        }

        private void BtDivi_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.DiviXY(x, y, ref r);
            Salida(r);
        }

        private void BtPotxy_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.PotXY(x, y, ref r);
            Salida(r);
        }

        private void BtPotyx_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.PotYX(x, y, ref r);
            Salida(r);
        }

        private void BtFactx_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.FactXoY(x, ref r) + "x";
            Salida(r);
        }

        private void BtFacty_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.FactXoY(y, ref r) + "y";
            Salida(r);
        }

        private void BtSqrtx_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.SqrtXoY(x, ref r) + "x";
            Salida(r);
        }

        private void BtSqrty_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.SqrtXoY(y, ref r) + "y";
            Salida(r);
        }

        private void BtPotx2_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = "x" + cal.PotXoY2(x, ref r);
            Salida(r);
        }

        private void BtPoty2_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = "y" + cal.PotXoY2(y, ref r);
            Salida(r);
        }

        private void BtFx_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.fx(x, fx, ref r);
            Salida(r);
        }

        private void BtFy_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.fy(y, fy, ref r);
            Salida(r);
        }

        private void BtFxy_Click(object sender, RoutedEventArgs e)
        {
            Entrada();
            mensaje = cal.fxy(x, y, fxy, ref r);
            Salida(r);
        }

        private void Bt_Borrar_Click(object sender, RoutedEventArgs e)
        {
            LBsalida.Items.Clear();
        }

        public void Entrada()
        {
            try
            {
                x = double.Parse(Tbx.Text);
                y = double.Parse(Tby.Text);
                fx = Tbfx.Text;
                fy = Tbfy.Text;
                fxy = Tbfxy.Text;
            }
            catch
            {
                MessageBox.Show("Error de entrada de datos...");
            }
        }

        public void Salida(double r)
        {
            LBsalida.Items.Add(r);
            Tbmensaje.Text = mensaje;
        }
    }
}
