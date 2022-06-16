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
using System.Windows.Xps.Packaging;

namespace ExamenCalcuNL15
{
    /// <summary>
    /// Lógica de interacción para Teoria.xaml
    /// </summary>
    public partial class Teoria : Page
    {
        public Teoria()
        {
            InitializeComponent();
        }

        private void BtCalcu_Click(object sender, RoutedEventArgs e)
        {
            string file = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/Calculadora.xps";
            XpsDocument documento = new XpsDocument(file, System.IO.FileAccess.Read);
            Teoria1.Document = documento.GetFixedDocumentSequence();
        }

        private void BtConversiones_Click(object sender, RoutedEventArgs e)
        {
            string file = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/Conversiones.xps";
            XpsDocument documento = new XpsDocument(file, System.IO.FileAccess.Read);
            Teoria1.Document = documento.GetFixedDocumentSequence();
        }

        private void BtConverEjem_Click(object sender, RoutedEventArgs e)
        {
            string file = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/ConversionesEjemplos.xps";
            XpsDocument documento = new XpsDocument(file, System.IO.FileAccess.Read);
            Teoria1.Document = documento.GetFixedDocumentSequence();
        }

        private void BtMatrices_Click(object sender, RoutedEventArgs e)
        {
            string file = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/Matrices.xps";
            XpsDocument documento = new XpsDocument(file, System.IO.FileAccess.Read);
            Teoria1.Document = documento.GetFixedDocumentSequence();
        }

        private void BtMatEjem_Click(object sender, RoutedEventArgs e)
        {
            string file = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/MatricesEjemplos.xps";
            XpsDocument documento = new XpsDocument(file, System.IO.FileAccess.Read);
            Teoria1.Document = documento.GetFixedDocumentSequence();
        }

        private void BtGraficador_Click(object sender, RoutedEventArgs e)
        {
            string file = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/Graficador.xps";
            XpsDocument documento = new XpsDocument(file, System.IO.FileAccess.Read);
            Teoria1.Document = documento.GetFixedDocumentSequence();
        }

        private void BtGrafiEjem_Click(object sender, RoutedEventArgs e)
        {
            string file = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/GraficadorEjemplos.xps";
            XpsDocument documento = new XpsDocument(file, System.IO.FileAccess.Read);
            Teoria1.Document = documento.GetFixedDocumentSequence();
        }
    }
}
