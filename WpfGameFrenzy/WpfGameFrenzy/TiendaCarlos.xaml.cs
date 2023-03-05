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
        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TabControl tabControl = sender as TabControl;
            if (tabControl != null && tabControl.SelectedItem != null)
            {
                TabItem tabItem = tabControl.ItemContainerGenerator.ContainerFromItem(tabControl.SelectedItem) as TabItem;
                if (tabItem != null)
                {
                    tabItem.Background = Brushes.Black;
                }
            }
        }

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
