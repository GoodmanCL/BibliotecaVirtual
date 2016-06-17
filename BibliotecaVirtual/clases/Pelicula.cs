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
    class Pelicula
    {
        public static string tabla = "pelicula";

        private string codigo;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
 
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        private string genero;

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }


        private int duracion;

        public int Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }


        private string formato;

        public string Formato
        {
            get { return formato; }
            set { formato = value; }
        }

        private int valor;

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        
        
        public static List<Pelicula> listaPeliculas = new List<Pelicula>();

        public Pelicula(string codigo, string nombre, string genero, int duracion, string formato, int valor) 
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Genero = genero;
            this.Duracion = duracion;
            this.Formato = formato;
            this.Valor = valor;
        }


        public static void agregarPelicula(Pelicula laPelicula)
        {
            Datos datos = new Datos();
            string sql = "INSERT INTO " + tabla + " (codigo,nombre, genero, duracion ,formato, valor) values('" + laPelicula.Codigo + "','"+ laPelicula.Nombre + "','" + laPelicula.Genero + "','" + laPelicula.Duracion + "','" + laPelicula.Formato + "','" + laPelicula.Valor + "')";
            datos.insertar(sql);
        }

        public static Pelicula buscaPelicula(string codigo)
        {
            Datos datos = new Datos();
            String sql = "SELECT * FROM " + tabla + " WHERE codigo='" + codigo + "'";
            SqlDataReader row = datos.buscar(sql);
            if (!row.Read())
            {
                datos.cn.Close();
                return null;
            }
            var unPelicula = new Pelicula((string)row["codigo"], (string)row["nombre"], (string)row["genero"], (int)row["duracion"], (string)row["formato"], (int)row["valor"]);
            datos.cn.Close();
            return unPelicula;
        }

        public static void modificarPelicula(Pelicula laPelicula)
        {
            Datos datos = new Datos();
            string sql = "UPDATE " + tabla + " SET nombre='" + laPelicula.Nombre + "',genero='" + laPelicula.Genero + "',duracion='" + laPelicula.Duracion + "',formato='" + laPelicula.Formato + "',valor='" + laPelicula.Valor + "' WHERE codigo='" + laPelicula.Codigo + "'";
            datos.insertar(sql);
        }

        public static void eliminarPelicula(String codigo)
        {
            Datos datos = new Datos();
            string sql = "DELETE FROM " + tabla + " WHERE codigo='" + codigo + "'";
            datos.actualizar(sql);
        }

        public static DataTable listaDePeliculas()
        {
            Datos datos = new Datos();

            DataTable dataTable = new DataTable();
            dataTable = datos.consultaTabla(tabla);
            return dataTable;
        }




    }
}

