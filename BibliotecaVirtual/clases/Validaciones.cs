using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using BibliotecaVirtual.clases;

namespace BibliotecaVirtual.clases
{
    class Validaciones
    {
        public static void limpiaTextbox(DependencyObject obj)
            {
                TextBox tb = obj as TextBox;
                if (tb != null)
                {
                    tb.Text = "";
                }

                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj as DependencyObject); i++)
                {
                    limpiaTextbox(VisualTreeHelper.GetChild(obj, i));
                }
            }



        public static Boolean validarRut(string rut)
        {
            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
            }
            return validacion;
        }

        //  Este Metodo captura una fecha inicial la que le pasa el usuario y la compara con la fecha actual
        //  luego a la fecha actual le resta la ingresada y saca la diferencia de dias entre ambos y la
        //  devuelve en un int.

        public static int diferenciaDias(String fechaInicial, String fechaFinal)
        {

            DateTime diasingresados = Convert.ToDateTime(fechaInicial);
            DateTime newDate = DateTime.Now;

            // Difference in days, hours, and minutes.
            TimeSpan ts = newDate - diasingresados;

            // Difference in days.
            int dias = ts.Days;

            return dias;

        }

        // Este metodo resive la fecha inicial y le suma los dias que fueron guardados en el metodo
        // de diferenciaDias.

        public static DateTime Fechas_entrega(string fechaInicial, int diferenciaDias){
           

            DateTime fecha = Convert.ToDateTime(fechaInicial).AddDays(diferenciaDias);

            return fecha;
        }


    
}}
