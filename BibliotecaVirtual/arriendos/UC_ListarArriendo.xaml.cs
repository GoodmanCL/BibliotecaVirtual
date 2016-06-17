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
    /// Lógica de interacción para UC_ListarArriendo.xaml
    /// </summary>
    public partial class UC_ListarArriendo : UserControl
    {
        public UC_ListarArriendo()
        {
            
            InitializeComponent();


            //List<claseArriendo> listaArriendos = claseArriendo.listaArriendos;

            dataGridArriendos.DataContext = Arriendo.listaDeArriendos();
            dataGridArriendos.IsEnabled = false;
            
   
        }

        private void dataGridArriendos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        
    }
}
