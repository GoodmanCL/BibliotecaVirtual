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
using BibliotecaVirtual.clientes;


namespace BibliotecaVirtual
{
    /// <summary>
    /// Lógica de interacción para UC_Clientes.xaml
    /// </summary>
    public partial class UC_Clientes : UserControl
    {
        public UC_Clientes()
        {
            InitializeComponent();

            UC_ListarClientes frmLista = new UC_ListarClientes();

            pcanvas_marcoFormularios.Children.Clear();
            pcanvas_marcoFormularios.Children.Add(frmLista);

        }

        private void nuevoCliente_click(object sender, RoutedEventArgs e)
        {
            UC_NuevoCliente frmNuevoCliente = new UC_NuevoCliente();

            pcanvas_marcoFormularios.Children.Clear();
            pcanvas_marcoFormularios.Children.Add(frmNuevoCliente);
        }

        private void listarClientes_click(object sender, RoutedEventArgs e)
        {
            UC_ListarClientes frmLista = new UC_ListarClientes();

            pcanvas_marcoFormularios.Children.Clear();
            pcanvas_marcoFormularios.Children.Add(frmLista);
        }

        private void btn_Modificar_Click(object sender, RoutedEventArgs e)
        {

            UC_EditarCliente frmEditarCliente = new UC_EditarCliente();
            pcanvas_marcoFormularios.Children.Clear();
            pcanvas_marcoFormularios.Children.Add(frmEditarCliente);
        }

        private void btn_Eliminar_Click(object sender, RoutedEventArgs e)
        {
            UC_EliminarCliente frmEliminarCliente = new UC_EliminarCliente();
            pcanvas_marcoFormularios.Children.Clear();
            pcanvas_marcoFormularios.Children.Add(frmEliminarCliente);
        }
    }
}
