using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BibliotecaVirtual.clases
{
    class Atraso
    {
        public static string tabla = "atraso";
        public static int factorPenalizacion = 5;


        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string sancion;

        public string Sancion
        {
            get { return sancion; }
            set { sancion = value; }
        }


        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private int idPrestamo;

        public int IdPrestamo
        {
            get { return idPrestamo; }
            set { idPrestamo = value; }
        }

  

        public Atraso(int id, int idPrestamo, string sancion, string estado)
        {
            this.Id = id;
            this.IdPrestamo = idPrestamo;
            this.Sancion = sancion;
            this.Estado = estado;
        }

        public Atraso()
        {

        }

        public static void setVigente()
        {

        }


        public static void setCumplido()
        {

        }

        public static Boolean isVigente()
        {
            return true;
        }

        public static void setDB()
        {

        }


        // incio consultas sql

        public static void agregar(Atraso elAtraso)
        {
            Datos datos = new Datos();
            string sql = "INSERT INTO " + tabla + " (id,idPrestamo,sancion,estado) VALUES('" + elAtraso.Id + "','" + elAtraso.IdPrestamo + "','" + elAtraso.sancion + "','" + elAtraso.estado + "')";
            datos.insertar(sql);
        }


        public static DataTable listarAtraso()
        {
            Datos datos = new Datos();

            DataTable dataTable = new DataTable();
            dataTable = datos.consultaTabla(tabla);
            return dataTable;
        }

        public static Atraso busca(string buscarID)
        {
            string con = "SELECT * FROM " + tabla + " WHERE id='" + buscarID + "'";

            Datos datos = new Datos();

            SqlDataReader row = datos.buscar(con);

            var unAtraso = new Atraso((int)row["id"], (int)row["idPrestamo"], (String)row["sancion"], (String)row["estado"]);

            return unAtraso;


        }





    }
}
