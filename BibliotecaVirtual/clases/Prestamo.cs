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

        private string run;

        public string Run
        {
            get { return run; }
            set { run = value; }
        }
 
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }


        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        
        
        public static List<Prestamo> listaClientes = new List<Prestamo>();

        public Prestamo(string run, string nombre, string apellido, string email, string direccion) 
        {
            this.Run = run;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.Direccion = direccion;
        }


        public static void agregar(Prestamo elObjeto)
        {
            Datos datos = new Datos();
            string sql = "INSERT INTO " + tabla + " (run, nombre, apellido, email ,direccion) values('" + elObjeto.Run + "','" + elObjeto.Nombre + "','" + elObjeto.Apellido + "','" + elObjeto.Email + "','" + elObjeto.Direccion + "')";
            datos.insertar(sql);
        }

        public static Prestamo buscar(string run)
        {
            Datos datos = new Datos();
            String sql = "SELECT * FROM " + tabla + " WHERE run='" + run + "'";
            SqlDataReader row = datos.buscar(sql);
            if (!row.Read())
            {
                datos.cn.Close();
                return null;
            }
            var unCliente = new Prestamo((String)row["run"], (String)row["nombre"], (String)row["apellido"], (String)row["email"], (String)row["direccion"]);
            datos.cn.Close();
            return unCliente;
        }

        public static void modificar(Prestamo elObjeto)
        {
            Datos datos = new Datos();
            string sql = "UPDATE " + tabla + " SET nombre='" + elObjeto.Nombre + "',apellido='" + elObjeto.Apellido + "',email='" + elObjeto.Email + "',direccion='" + elObjeto.Direccion + "' WHERE run='" + elObjeto.Run + "'";
            datos.insertar(sql);
        }

        public static void eliminar(String run)
        {
            Datos datos = new Datos();
            string sql = "DELETE FROM " + tabla + " WHERE run='" + run + "'";
            datos.actualizar(sql);
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

