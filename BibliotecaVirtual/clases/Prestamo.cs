using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaVirtual.clases
{
    class Prestamo
    {

   
        private string fechaPrestamo;         //definicion de atributos de clase prestamo.

        public string FechaPrestamo
        {
            get { return fechaPrestamo; }
            set { fechaPrestamo = value; }
        }
 
        private string fechaDevolucion;

        public string FechaDevolucion
        {
            get { return fechaDevolucion; }
            set { fechaDevolucion = value; }
        }


        private string fechaRealDevolucion;

        public string FechaRealDevolucion
        {
            get { return fechaRealDevolucion; }
            set { fechaRealDevolucion = value; }
        }


        private string estadoPrestamo;

        public string EstadoPrestamo
        {
            get { return estadoPrestamo; }
            set { estadoPrestamo = value; }
        }


        public Prestamo(string fechaPrestamo, string fechaDevolucion, string fechaRealDevolucion, string estadoPrestamo)  //constructor de clase prestamo
        {
            this.FechaPrestamo = fechaPrestamo;
            this.FechaDevolucion = fechaDevolucion;
            this.FechaRealDevolucion = fechaRealDevolucion;
            this.EstadoPrestamo = estadoPrestamo;
           
        }

        public Prestamo() // constructor prestamo vacio
        {

        }
      

        public static void setDevolucion()   //metodo
        {



        }

       

    }
}

