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
    /// Lógica de interacción para UC_PrestamosEditar.xaml
    /// </summary>
    public partial class UC_PrestamosEditar : UserControl
    {
        public UC_PrestamosEditar()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, RoutedEventArgs e)
        {
            if (txt_id.Text.Length == 0)
            {
                MessageBox.Show("No ha ingresado Ningun ID");

            }
            else
            {
                
                    try
                    {
                        Atraso unAtraso = Atraso.busca(txt_id.Text);

                        txt_id.IsEnabled = false;
                        txt_fechaPrestamo.IsEnabled = false;
                        txt_fechaDevolucion.IsEnabled = false;
                        txt_fechaRealDevolucion.IsEnabled = true;
                        txt_estadoPrestamo.IsEnabled = false;
                       
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Rut no Encontrado");
                        txt_id.Clear();
                    }

                }
            }

           
        

            
            
        

        
        
        
        private void btn_cancelar_Click(object sender, RoutedEventArgs e)
        {

            (this.Parent as Canvas).Children.Remove(this);


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Prestamo unObjeto = Prestamo.buscar(Convert.ToInt32(txt_id.Text));
                if (unObjeto != null)
                {
                    txt_id.IsEnabled = false;
                    txt_fechaPrestamo.IsEnabled = false;
                    txt_fechaDevolucion.IsEnabled = false;
                    txt_fechaRealDevolucion.IsEnabled = true;
                    txt_estadoPrestamo.IsEnabled = false;
                }
                else
                {
                    System.Windows.MessageBox.Show(Mensajes.ERROR_CLIENTE_RUN_NO_EXISTE);
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
     

    }
}
