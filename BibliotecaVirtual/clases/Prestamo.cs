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
        public static string tabla = "prestamo";

        //definicion de atributos de clase prestamo.

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int idBibliotecario;

        public int IdBibliotecario
        {
            get { return idBibliotecario; }
            set { idBibliotecario = value; }
        }
        private int idUsuario;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        private string fechaPrestamo;     

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


        public Prestamo(int id, int idBibliotecario, int idUsuario, string fechaPrestamo, string fechaDevolucion, string fechaRealDevolucion, string estadoPrestamo)  //constructor de clase prestamo
        {
            this.Id = id;
            this.IdBibliotecario = idBibliotecario;
            this.IdUsuario = idUsuario;            this.FechaPrestamo = fechaPrestamo;
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


        public static Prestamo buscar(int id)
        {
            Datos datos = new Datos();
            String sql = "SELECT * FROM " + tabla + " WHERE id='" + id + "'";
            SqlDataReader row = datos.buscar(sql);
            if (!row.Read())
            {
                datos.cn.Close();
                return null;
            }

            var unPrestamo = new Prestamo( (int)row["idBibliotecario"], (int)row ["idUsuario"], (int)row["id"], (String)row["fechaPrestamo"], (String)row["fechaDevolucion"], (String)row["fechaRealDevolucion"], (String)row["estadoPrestamo"]);
            datos.cn.Close();
            return unPrestamo;

        }

        public static void agregar(Prestamo elPrestamo)
        {
            Datos datos = new Datos();

            string sql = "INSERT INTO " + tabla + " (fechaPrestamo, fechaDevolucion, fechaRealDevolucion, estadoPrestamo) values('" + elPrestamo.FechaPrestamo + "','" + elPrestamo.FechaDevolucion+ "','" + elPrestamo.FechaRealDevolucion+ "','" + elPrestamo.EstadoPrestamo + "')";
            datos.insertar(sql);
        }

        public static void modificar(Prestamo elPrestamo)
        {
            Datos datos = new Datos();
            string sql = "UPDATE " + tabla + " SET fechaPrestamo='" + elPrestamo.FechaPrestamo + "',apellidfechaDevolucion" + elPrestamo.FechaDevolucion + "',fechaRealDevolucion='" + elPrestamo.FechaRealDevolucion + "',estadoPrestamo='" + elPrestamo.EstadoPrestamo + "' WHERE id='" + elPrestamo.Id + "'";
            datos.insertar(sql);
        }

        public static DataTable listar()
        {
            Datos datos = new Datos();

            DataTable dataTable = new DataTable();
            dataTable = datos.consultaTabla(tabla);
            return dataTable;
        }

    }
}

