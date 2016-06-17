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
    class Cliente
    {
        public static string tabla = "cliente";

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

        
        
        public static List<Cliente> listaClientes = new List<Cliente>();

        public Cliente(string run, string nombre, string apellido, string email, string direccion) 
        {
            this.Run = run;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.Direccion = direccion;
        }


        public static void agregarCliente(Cliente elCliente)
        {
            Datos datos = new Datos();
            string sql = "INSERT INTO " + tabla + " (run, nombre, apellido, email ,direccion) values('" + elCliente.Run + "','" + elCliente.Nombre + "','" + elCliente.Apellido + "','" + elCliente.Email + "','" + elCliente.Direccion + "')";
            datos.insertar(sql);
        }

        public static Cliente buscaCliente(string run)
        {
            Datos datos = new Datos();
            String sql = "SELECT * FROM " + tabla + " WHERE run='" + run + "'";
            SqlDataReader row = datos.buscar(sql);
            if (!row.Read())
            {
                datos.cn.Close();
                return null;
            }
            var unCliente = new Cliente((String)row["run"],(String)row["nombre"],(String)row["apellido"],(String)row["email"],(String)row["direccion"]);
            datos.cn.Close();
            return unCliente;
        }

        public static void modificarCliente(Cliente elCliente)
        {
            Datos datos = new Datos();
            string sql = "UPDATE " + tabla + " SET nombre='" + elCliente.Nombre + "',apellido='" + elCliente.Apellido + "',email='" + elCliente.Email + "',direccion='" + elCliente.Direccion + "' WHERE run='" + elCliente.Run + "'";
            datos.insertar(sql);
        }

        public static void eliminarCliente(String run)
        {
            Datos datos = new Datos();
            string sql = "DELETE FROM " + tabla + " WHERE run='" + run + "'";
            datos.actualizar(sql);
        }


        public static DataTable listaDeClientes()
        {
            Datos datos = new Datos();
            DataTable dataTable = new DataTable();
            dataTable = datos.consultaTabla(tabla);
            return dataTable;
        }


    }
}

