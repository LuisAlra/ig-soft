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
using System.Windows.Shapes;

namespace WPFnavegarContenedor
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        
        private void Play_Click(object sender, RoutedEventArgs e)
        {
            Media1.Play();
        }

        private void BtPausa_Click(object sender, RoutedEventArgs e)
        {
            Media1.Pause();
        }

        private void BtRegresar_Click(object sender, RoutedEventArgs e)
        {
            Media1.Stop();
            Close();
        }
    }
}
