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
    /// Lógica de interacción para Examen.xaml
    /// </summary>
    public partial class Examen : Page
    {
        public Examen()
        {
            InitializeComponent();
        }

        private void BtExamen_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("ExamenCalcuNL15.exe");
        }

        private void BtCiclo_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CicloVidaSoft.docx");
        }
    }
}
