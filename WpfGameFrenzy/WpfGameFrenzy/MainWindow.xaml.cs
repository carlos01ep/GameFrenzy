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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            myFrame.Navigate(new TiendaCarlos());
        }
        private void MyCommands_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
           
        }

        private void NewBazar_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // El contenido central se cambia con la nueva pantalla
            myFrame.Navigate(new Page1());
        }
        /*private void OpenBazar_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // El contenido central se cambia con la nueva pantalla
            myFrame.Navigate(new Page1());
        }*/
        private void CloseCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // Volvemos hacia atrás hasta llegar al contenido inicial y resetear la página central
            while (myFrame.CanGoBack)
            {
                myFrame.GoBack();
            }
            // Otra opción es dejar el Frame a null
            //myFrame.Content= null;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
