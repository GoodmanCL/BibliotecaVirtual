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

namespace BibliotecaVirtual.clientes
{
    /// <summary>
    /// Lógica de interacción para UC_NuevoCliente.xaml
    /// </summary>
    public partial class UC_NuevoCliente : UserControl
    {
        public UC_NuevoCliente()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, RoutedEventArgs e)
        {
            Boolean existe = false;
            Boolean buscar = Validaciones.validarRut(txt_run.Text);
            if (buscar)
            {
                try
                {
                    Cliente unCliente = Cliente.buscaCliente(txt_run.Text);
                    if (unCliente != null) {
                        existe = true;
                        System.Windows.MessageBox.Show(Mensajes.ERROR_CLIENTE_RUN_EXISTE);       
                    }
                }
                catch (Exception ex)
                {
                    
                }
                if (!existe)
                {
                    try
                    {
                        if (validaFormulario())
                        {
                            Cliente.agregarCliente(new Cliente(txt_run.Text, txt_nombre.Text, txt_apellido.Text, txt_email.Text, txt_direccion.Text));
                            Validaciones.limpiaTextbox(this);
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            else
            {
                System.Windows.MessageBox.Show(Mensajes.ERROR_CLIENTE_RUN_INVALIDO);
            }
           

            
            
        }

        private Boolean validaFormulario()
        {
            if (txt_nombre.Text == "")
            {
                txt_nombre.Focus();
                System.Windows.MessageBox.Show(Mensajes.ERROR_CLIENTE_NOMBRE_VACIO);
                return false;
            }
            if (txt_apellido.Text == "")
            {
                txt_apellido.Focus();
                System.Windows.MessageBox.Show(Mensajes.ERROR_CLIENTE_APELLIDO_VACIO);
                return false;
            }
            if (txt_email.Text == "")
            {
                txt_email.Focus();
                System.Windows.MessageBox.Show(Mensajes.ERROR_CLIENTE_EMAIL_VACIO);
                return false;
            }
            if (txt_direccion.Text == "")
            {
                txt_direccion.Focus();
                System.Windows.MessageBox.Show(Mensajes.ERROR_CLIENTE_DIRECCION_VACIO);
                return false;
            }
            return true;
        }
        
        
        private void btn_cancelar_Click(object sender, RoutedEventArgs e)
        {

            (this.Parent as Canvas).Children.Remove(this);


        }
    }
}
