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
    /// Lógica de interacción para UC_NuevoArriendo.xaml
    /// </summary>
    public partial class UC_NuevoArriendo : UserControl
    {
        public static int valor = 0;

        public UC_NuevoArriendo()
        {
            InitializeComponent();

            dataGridClientes.DataContext = Cliente.listaDeClientes();
            dataGridPeliculas.DataContext = Pelicula.listaDePeliculas();
            cbox_dias.SelectedIndex = 0;
        }

        private void btn_guardar_Click(object sender, RoutedEventArgs e)
        {


                try
                {
                    if (validaFormulario())
                    {
                        DataRowView dataRow = (DataRowView)dataGridPeliculas.SelectedItem;
                        DataRowView dataRowCliente = (DataRowView)dataGridClientes.SelectedItem;
                        int valorPelicula = Convert.ToInt32(dataRow.Row.ItemArray[5].ToString());
                        String codigo = dataRow.Row.ItemArray[0].ToString();
                        String run = dataRowCliente.Row.ItemArray[0].ToString();
                        Arriendo.nuevoArriendo(new Arriendo(0, codigo, run, txt_fecha.Text, Convert.ToInt32(cbox_dias.SelectedIndex), valorPelicula, valorPelicula * cbox_dias.SelectedIndex, "OK"));
                        Validaciones.limpiaTextbox(this);
                        txt_valorArriendo.Text = "";
                        cbox_dias.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show(ex.Message);
                }
           
            
        }

        private Boolean validaFormulario()
        {
            if (dataGridClientes.SelectedIndex == -1)
            {
                System.Windows.MessageBox.Show(Mensajes.ERROR_ARRIENDO_CLIENTE_VACIO);
                return false;
            }
            if (dataGridPeliculas.SelectedIndex == -1)
            {
                System.Windows.MessageBox.Show(Mensajes.ERROR_ARRIENDO_PELICULA_VACIO);
                return false;
            }
            if (txt_fecha.Text == "")
            {
                txt_fecha.Focus();
                System.Windows.MessageBox.Show(Mensajes.ERROR_ARRIENDO_FECHA_VACIO);
                return false;
            }
            if (cbox_dias.SelectedIndex == 0)
            {
                cbox_dias.Focus();
                System.Windows.MessageBox.Show(Mensajes.ERROR_ARRIENDO_DIAS_VACIO);
                return false;
            }
            return true;
        }
        
        
        private void btn_cancelar_Click(object sender, RoutedEventArgs e)
        {

            (this.Parent as Canvas).Children.Remove(this);


        }

        private void calculaValor(object sender, SelectionChangedEventArgs e)
        {
            try {
                if (dataGridPeliculas.SelectedItem != null)
                {
                    DataRowView dataRow = (DataRowView)dataGridPeliculas.SelectedItem;
                    int valorPelicula = Convert.ToInt32(dataRow.Row.ItemArray[5].ToString());
                    txt_valorArriendo.Text = Convert.ToString(cbox_dias.SelectedIndex * valorPelicula);
                }

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
                txt_valorArriendo.Text = "0";

            }
        }


    }
}
