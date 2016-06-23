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
    /// Lógica de interacción para UC_Atraso.xaml
    /// </summary>
    public partial class UC_Atraso : UserControl
    {
        public UC_Atraso()
        {
            InitializeComponent();
        }

        private void btn_guardad_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                int s = Convert.ToInt16(txt_id.Text);

                atraso.agregar(new atraso(s,txt_Sancion.Text,txt_estado.Text));
                   // atraso.agregar(new atraso(Convert.ToInt16(txt_id.Text),txt_Sancion.Text,txt_estado.Text));
                    Validaciones.limpiaTextbox(this);
                
            }
            catch (Exception ex)
            {

            }



        }

   

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Datos datos = new Datos();
            if (datos.existe(txt_id.Text) == true)
            {
                Prestamo unPrestamo = Prestamo.buscar(Convert.ToInt16(txt_id.Text));

                txt_id.Text = Convert.ToString(unPrestamo.Id);
                txt_fechaPrestamo.Text = unPrestamo.FechaPrestamo;
                txt_fechaDevolucion.Text = unPrestamo.FechaDevolucion;
                txt_fechaRealDevolucion.Text = unPrestamo.FechaRealDevolucion;
                txt_estadoPrestamo.Text = unPrestamo.EstadoPrestamo;
                
              
            }
            else
            {
                txt_id.Clear();
                MessageBox.Show("no registrado");
            }



        }

        private void btn_cancelar_Click_1(object sender, RoutedEventArgs e)
        {
            txt_id.Clear();
            txt_Sancion.Clear();
            txt_fechaRealDevolucion.Text = string.Empty;
            txt_fechaPrestamo.Text = string.Empty;
            txt_fechaDevolucion.Text = string.Empty;
            txt_estadoPrestamo.Clear();
            txt_estado.Clear();
            MessageBox.Show("Cancelado.");
        }

     

     
    }
}
