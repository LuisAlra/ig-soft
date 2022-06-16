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
    /// Lógica de interacción para Practicas.xaml
    /// </summary>
    public partial class Practicas : Page
    {
        public Practicas()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WFgraficador01.exe");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WFgraficador02.exe");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WFgraficador03.exe");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WFgraficador04.exe");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WFgeneradorControl1.exe");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WFgeneradorControl2.exe");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("practica_Graficador01.exe");

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("practica_Graficador02.exe");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("practica_Graficador03.exe");
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("ConArreglos01.exe");
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("Conmultitipos1.exe");
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WFmatDataGrid01.exe");
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WFmatTextBox.exe");
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WFmatArregloTextBox01.exe");
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmat01.exe");
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmatArregloTextBox01.exe");
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("ConsoleApp1.exe");
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WPFxaml1.exe");
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WPFstackpanel1.exe");
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WPFcanvas1.exe");
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WPFnavegarContenedor.exe");
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WPFalarma.exe");
        }

        private void Button_Click_22(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WPFLanzadorConAlarma.exe");
        }

        private void Button_Click_23(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WPFSenales01.exe");
        }

        private void Button_Click_24(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CircuitoResistencias_consola.exe");
        }

        private void Button_Click_25(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CircuitoResistencias_WF.exe");
        }

        private void Button_Click_26(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CircuitoResistencias_WPF.exe");
        }

        private void Button_Click_27(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WPFNotaMusical01.exe");
        }

        private void Button_Click_28(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WPFNotaMusical02.exe");
        }

        private void Button_Click_29(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WPFOtroInstrumento.exe");
        }

        private void Button_Click_30(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        }
    }
}
