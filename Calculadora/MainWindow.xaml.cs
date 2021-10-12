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

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void entradaRaton(object sender, MouseEventArgs e)
        {
            Button recuadro = (Button)sender;
            recuadro.BorderBrush = Brushes.SkyBlue;
            recuadro.Background = Brushes.LightSkyBlue;
        }

        private void salidaRaton(object sender, MouseEventArgs e)
        {
            Button recuadro = (Button)sender;
            recuadro.BorderBrush = Brushes.Black;
            recuadro.Background = Brushes.LightGray;
        }

        private void onClick(object sender, RoutedEventArgs e)
        {
            displayTextBlock.Text += ((Button) sender).Tag.ToString();
        }
    }
}
