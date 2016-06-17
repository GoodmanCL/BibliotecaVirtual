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
using ProyectoVideoClub.clases;
using System.Data;

namespace ProyectoVideoClub.arriendos
{
    /// <summary>
    /// Lógica de interacción para UC_EditarArriendo.xaml
    /// </summary>
    public partial class UC_EditarArriendo : UserControl
    {
        public UC_EditarArriendo()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, RoutedEventArgs e)
        {

            
            try
            {
                if (validaFormulario())
                {
                    var unArriendo = Arriendo.buscaArriendo(Convert.ToInt32(txt_id.Text));
                    Arriendo.modificarArriendo(new Arriendo(unArriendo.Id, unArriendo.Codigo, unArriendo.Run, txt_fecha.Text, unArriendo.Dias, unArriendo.ValorDiario, unArriendo.ValorArriendo, unArriendo.Estado));
                    Validaciones.limpiaTextbox(this);
                    txt_id.IsEnabled = true;
                    //txt_run.Clear();
                    //txt_nombre.Clear();
                    //txt_apellido.Clear();
                    //txt_email.Clear();
                    //txt_direccion.Clear();
                }

            }
            catch (Exception ex)
            {

            }
        }

        
        
        
        private void btn_cancelar_Click(object sender, RoutedEventArgs e)
        {

            (this.Parent as Canvas).Children.Remove(this);


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show(txt_id.Text);
                try
                {
                    Arriendo unArriendo = Arriendo.buscaArriendo(Convert.ToInt32(txt_id.Text));

                    if (unArriendo != null)
                    {
                        System.Windows.MessageBox.Show(txt_id.Text);
                        Cliente unCliente = Cliente.buscaCliente(unArriendo.Run);
                        Pelicula unPelicula = Pelicula.buscaPelicula(unArriendo.Codigo);
                        txt_nombre.Text = unCliente.Nombre;
                        txt_pelicula.Text = unPelicula.Nombre;
                        txt_fecha.Text = unArriendo.Fecha;
                        txt_dias.Text = Convert.ToString(unArriendo.Dias);
                        txt_valor.Text = Convert.ToString(unArriendo.ValorArriendo);
                        txt_id.IsEnabled = false;
                    }
                    else
                    {
                        System.Windows.MessageBox.Show(Mensajes.ERROR_ARRIENDO_CODIGO_NO_EXISTE);
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
            //    System.Windows.MessageBox.Show(Mensajes.ERROR_PELICULA_NOMBRE_VACIO);
            //    return false;
            //}
            //if (txt_genero.Text == "")
            //{
            //    txt_genero.Focus();
            //    System.Windows.MessageBox.Show(Mensajes.ERROR_PELICULA_GENERO_VACIO);
            //    return false;
            //}
            //if (txt_duracion.Text == "")
            //{
            //    txt_duracion.Focus();
            //    System.Windows.MessageBox.Show(Mensajes.ERROR_PELICULA_DURACION_VACIO);
            //    return false;
            //}
            //if (txt_formato.Text == "")
            //{
            //    txt_formato.Focus();
            //    System.Windows.MessageBox.Show(Mensajes.ERROR_PELICULA_FORMATO_VACIO);
            //    return false;
            //}
            return true;
        }
     

    }
}
