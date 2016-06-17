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

namespace BibliotecaVirtual
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

        private void Clientes_Click(object sender, RoutedEventArgs e)
        {
            UC_Clientes frmClientes = new UC_Clientes();

            exp_menu.IsExpanded = false;

            pcanvas_marcoPrincipal.Children.Clear();
            pcanvas_marcoPrincipal.Children.Add(frmClientes);
        }

        private void menu_collapsed(object sender, RoutedEventArgs e)
        {
            pcanvas_marcoPrincipal.Margin = new Thickness(20, 30, 0, 0);
        }

        private void menu_expanded(object sender, RoutedEventArgs e)
        {
            if (pcanvas_marcoPrincipal != null)
            {
                pcanvas_marcoPrincipal.Margin = new Thickness(20, 120, 0, 0);
            }

        }

        private void home_click(object sender, RoutedEventArgs e)
        {
            pcanvas_marcoPrincipal.Children.Clear(); //Limpia el marco principal
        }



        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e) // se dispara el evento cuando hace click en la x para cerrar o en ALT + F4
        {
            //Texto del mensaje             Titulo      Botones por defecto el el mensaje      imagen que se mostrará
            MessageBoxResult resultado = System.Windows.MessageBox.Show("¿Está seguro que desea Salir?", "Salir", System.Windows.MessageBoxButton.YesNo, MessageBoxImage.Question);
            //Guardo el resultado del cuadro de dialogo en la variable "resultado"

            if (resultado == MessageBoxResult.No) //pregunto si el resultado es no para que cancele el evento, de lo contrario seguirá haciendo lo que le corresponde (cerrar la app)
            {
                e.Cancel = true; //la e captura el evento en el que está
            }
        }


    }
}
