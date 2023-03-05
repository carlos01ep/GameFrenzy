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
    /// Lógica de interacción para CarritoAlberto.xaml
    /// </summary>
    public partial class CarritoAlberto : Page
    {
        
        public CarritoAlberto()
        {
            InitializeComponent();
        }
        private MainWindow mainWindow;
        private void MyCommands_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
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
        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // El contenido central se cambia con la nueva pantalla
            mainWindow.myFrame.Navigate(new BibliotecaHector());
           // MainWindow.myFrame.Navigate(new CarritoAlberto());
        }
        private void CloseCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // Volvemos hacia atrás hasta llegar al contenido inicial y resetear la página central
            
            // Otra opción es dejar el Frame a null
            //myFrame.Content= null;
        }
    }
}
