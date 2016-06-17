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
using System.Data;

namespace BibliotecaVirtual.prestamos
{
    /// <summary>
    /// Lógica de interacción para UC_PrestamosListar.xaml
    /// </summary>
    public partial class UC_PrestamosListar : UserControl
    {
        public UC_PrestamosListar()
        {
            
            InitializeComponent();

            objetoDataGrid.DataContext = Prestamo.listar();
            objetoDataGrid.IsEnabled = false;
         
            
        }

        
    }
}
