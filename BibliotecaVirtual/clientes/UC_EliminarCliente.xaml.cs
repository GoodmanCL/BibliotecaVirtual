﻿using System;
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
    /// Lógica de interacción para UC_EliminarCliente.xaml
    /// </summary>
    public partial class UC_EliminarCliente : UserControl
    {
        public UC_EliminarCliente()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, RoutedEventArgs e)
        {
            Boolean buscar = Validaciones.validarRut(txt_run.Text);

            if (buscar)
            {
                try
                {
                    if (txt_nombre.Text != "")
                    {
                        MessageBoxResult resultado = System.Windows.MessageBox.Show(Mensajes.MSG_CLIENTE_ELIMNAR, Mensajes.MSG_CLIENTE_ELIMNAR_TITULO, System.Windows.MessageBoxButton.YesNo, MessageBoxImage.Question);
                        if (resultado == MessageBoxResult.No) //pregunto si el resultado es no para que cancele el evento, de lo contrario seguirá haciendo lo que le corresponde (cerrar la app)
                        {
                            return;
                        }
                        Cliente.eliminarCliente(txt_run.Text);

                        txt_run.Clear();
                        txt_nombre.Clear();
                        txt_apellido.Clear();
                        txt_email.Clear();
                        txt_direccion.Clear();

                    }
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                System.Windows.MessageBox.Show(Mensajes.ERROR_CLIENTE_RUN_INVALIDO);

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

                Cliente unCliente = Cliente.buscaCliente(txt_run.Text);

                txt_nombre.Text = unCliente.Nombre;
                txt_apellido.Text = unCliente.Apellido;
                txt_email.Text = unCliente.Email;
                txt_direccion.Text = unCliente.Direccion;
            }
            catch (Exception ex)
            {

            }


        }
    }
}
