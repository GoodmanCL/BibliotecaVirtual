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
using BibliotecaVirtual.prestamos;


namespace BibliotecaVirtual
{
    /// <summary>
    /// Lógica de interacción para UC_Prestamos.xaml
    /// </summary>
    public partial class UC_Prestamos : UserControl
    {
        public UC_Prestamos()
        {
            InitializeComponent();

            UC_PrestamosListar frmLista = new UC_PrestamosListar();

            pcanvas_marcoFormularios.Children.Clear();
            pcanvas_marcoFormularios.Children.Add(frmLista);

        }

        private void btn_Nuevo_click(object sender, RoutedEventArgs e)
        {
            UC_PrestamosNuevo frmNuevo = new UC_PrestamosNuevo();

            pcanvas_marcoFormularios.Children.Clear();
            pcanvas_marcoFormularios.Children.Add(frmNuevo);
        }

        private void btn_Listar_click(object sender, RoutedEventArgs e)
        {
            UC_PrestamosListar frmLista = new UC_PrestamosListar();

            pcanvas_marcoFormularios.Children.Clear();
            pcanvas_marcoFormularios.Children.Add(frmLista);
        }

        private void btn_Modificar_Click(object sender, RoutedEventArgs e)
        {

            UC_PrestamosEditar frmEditar = new UC_PrestamosEditar();
            pcanvas_marcoFormularios.Children.Clear();
            pcanvas_marcoFormularios.Children.Add(frmEditar);
        }

        private void btn_Eliminar_Click(object sender, RoutedEventArgs e)
        {
            UC_PrestamosEliminar frmEliminar = new UC_PrestamosEliminar();
            pcanvas_marcoFormularios.Children.Clear();
            pcanvas_marcoFormularios.Children.Add(frmEliminar);
        }


    }
}
