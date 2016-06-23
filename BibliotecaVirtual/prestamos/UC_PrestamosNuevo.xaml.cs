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
using BibliotecaVirtual.clases;

namespace BibliotecaVirtual.prestamos
{
    /// <summary>
    /// Lógica de interacción para UC_PrestamosNuevo.xaml
    /// </summary>
    public partial class UC_PrestamosNuevo : UserControl
    {
        public UC_PrestamosNuevo()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (validaFormulario())
                {
<<<<<<< HEAD
                    Prestamo.agregar(new Prestamo(0,txt_fechaPrestamo.Text, txt_fechaDevolucion.Text, txt_fechaRealDevolucion.Text, txt_estadoPrestamo.Text));
=======
                    Prestamo.agregar(new Prestamo(0, Convert.ToInt32(txt_idBibliotecario.Text), Convert.ToInt32(txt_idUsuario.Text), txt_fechaPrestamo.Text, txt_fechaDevolucion.Text, txt_fechaRealDevolucion.Text, txt_estadoPrestamo.Text));
>>>>>>> origin/master
                    Validaciones.limpiaTextbox(this);
                }
            }
            catch (Exception ex)
            {

            }

            
            
        }

        private Boolean validaFormulario()
        {
            //if (txt_nombre.Text == "")
            //{
            //    txt_nombre.Focus();
            //    System.Windows.MessageBox.Show(Mensajes.ERROR_CLIENTE_NOMBRE_VACIO);
            //    return false;
            //}
            //if (txt_apellido.Text == "")
            //{
            //    txt_apellido.Focus();
            //    System.Windows.MessageBox.Show(Mensajes.ERROR_CLIENTE_APELLIDO_VACIO);
            //    return false;
            //}
            //if (txt_email.Text == "")
            //{
            //    txt_email.Focus();
            //    System.Windows.MessageBox.Show(Mensajes.ERROR_CLIENTE_EMAIL_VACIO);
            //    return false;
            //}
            //if (txt_direccion.Text == "")
            //{
            //    txt_direccion.Focus();
            //    System.Windows.MessageBox.Show(Mensajes.ERROR_CLIENTE_DIRECCION_VACIO);
            //    return false;
            //}
            return true;
        }
        
        
        private void btn_cancelar_Click(object sender, RoutedEventArgs e)
        {

            (this.Parent as Canvas).Children.Remove(this);


        }
    }
}
