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
    class Arriendo
    {
        public static string tabla = "arriendo";

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string codigo;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string run;

        public string Run
        {
            get { return run; }
            set { run = value; }
        }


        private string fecha;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }


        private int dias;

        public int Dias
        {
            get { return dias; }
            set { dias = value; }
        }

        private int valorDiario;

        public int ValorDiario
        {
            get { return valorDiario; }
            set { valorDiario = value; }
        }

        private int valorArriendo;

        public int ValorArriendo
        {
            get { return valorArriendo; }
            set { valorArriendo = value; }
        }


        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        
        
        public static List<Arriendo> listaArriendos = new List<Arriendo>();

        public Arriendo(int id, string codigo, string run, string fecha, int dias, int valorDiario, int valorArriendo, string estado) 
        {
            this.Id = id;
            this.Codigo = codigo;
            this.Run = run;
            this.Fecha = fecha;
            this.Dias = dias;
            this.ValorDiario = valorDiario;
            this.ValorArriendo = valorArriendo;
            this.Estado = estado;
        }


        public static void nuevoArriendo(Arriendo elArriendo)
        {
            Datos datos = new Datos();
            string sql = "INSERT INTO " + tabla + " (codigo, run, fecha, dias ,valorDiario, valorArriendo,estado) values('" + elArriendo.Codigo + "','" + elArriendo.Run + "','" + elArriendo.Fecha + "','" + elArriendo.Dias + "','" + elArriendo.ValorDiario + "','" + elArriendo.ValorArriendo + "','" + elArriendo.Estado + "')";
            datos.insertar(sql);
        }

        public static Arriendo buscaArriendo(int id)
        {
            Datos datos = new Datos();
            String sql = "SELECT * FROM " + tabla + " WHERE id='" + id + "'";
            SqlDataReader row = datos.buscar(sql);
            if (!row.Read())
            {
                datos.cn.Close();
                return null;
            }

            var unArriendo = new Arriendo((int)row["id"], (String)row["codigo"], (String)row["run"], (String)row["fecha"], (int)row["dias"], (int)row["valorDiario"], (int)row["valorArriendo"], (String)row["estado"]);
            datos.cn.Close();
            return unArriendo;

        }

        public static void modificarArriendo(Arriendo unArriendo)
        {
            Datos datos = new Datos();
            string sql = "UPDATE " + tabla + " SET run='" + unArriendo.Run + "',codigo='" + unArriendo.Codigo + "',fecha='" + unArriendo.Fecha + "',dias='" + unArriendo.Dias + "',estado='" + unArriendo.Estado + "',valorDiario='" + unArriendo.ValorDiario + "',valorArriendo='" + unArriendo.ValorArriendo + "' WHERE id='" + unArriendo.id + "'";
            datos.insertar(sql);
        }

        public static void eliminarArriendo(int id)
        {
            Datos datos = new Datos();
            string sql = "DELETE FROM " + tabla + " WHERE id='" + id + "'";
            datos.actualizar(sql);
        }

        public static DataTable listaDeArriendos()
        {
            Datos datos = new Datos();

            DataTable dataTable = new DataTable();
            dataTable = datos.consultaTabla(tabla);
            return dataTable;
        }


    }
}

