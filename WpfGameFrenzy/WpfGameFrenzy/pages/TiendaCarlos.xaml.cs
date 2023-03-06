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

namespace WpfGameFrenzy
{
    /// <summary>
    /// Lógica de interacción para TiendaCarlos.xaml
    /// </summary>
    public partial class TiendaCarlos : Page
    {
        public TiendaCarlos()
        {
            InitializeComponent();
        }

        /*eventos 'OnClick' para cambiar la imagen de la cabecera*/
        private void myButton1_Click(object sender, RoutedEventArgs e)
        {
            myImage.Source = new BitmapImage(new Uri("viedeojuego1.jpg", UriKind.Relative));
        }

        private void myButton2_Click(object sender, RoutedEventArgs e)
        {
            myImage.Source = new BitmapImage(new Uri("viedeojuego2.jpg", UriKind.Relative));
        }

        private void myButton3_Click(object sender, RoutedEventArgs e)
        {
            myImage.Source = new BitmapImage(new Uri("viedeojuego3.jpg", UriKind.Relative));
        }

        private void myButton4_Click(object sender, RoutedEventArgs e)
        {
            myImage.Source = new BitmapImage(new Uri("viedeojuego4.jpg", UriKind.Relative));
        }

        private void myButton5_Click(object sender, RoutedEventArgs e)
        {
            myImage.Source = new BitmapImage(new Uri("viedeojuego5.jpg", UriKind.Relative));
        }
    }

}