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
    class claseReporte
    {

        public static DataTable top10MasArrendadas()
        {
            Datos datos = new Datos();
            String sql = "SELECT TOP 10\n"
	                    + " MIN(CAST(p.nombre as VARCHAR(max))) 'Pelicula'\n"
	                    + ", MIN(CAST(p.codigo as VARCHAR(max))) 'Codigo'\n" 
                        + ", Count(*) AS 'Arriendos'\n"
                        + ", MIN(CAST(p.genero as VARCHAR(max))) 'Genero'\n"
                        + ", MIN(CAST(p.formato as VARCHAR(max))) 'Formato'\n"
                        + " FROM arriendo AS a\n"
                        + " INNER JOIN pelicula AS p ON p.codigo=a.codigo\n" 
                        + " GROUP BY a.codigo ORDER BY 'Arriendos' DESC, 'Pelicula';\n";
            DataTable dataTable = new DataTable();
            dataTable = datos.consultaSQL(sql);
            return dataTable;
        }


        public static DataTable top10Clientes()
        {
            Datos datos = new Datos();
            String sql = "SELECT  TOP 10\n"
                        + "	c.run 'RUN'\n"
                        + "	, MIN(CAST(c.nombre as VARCHAR(max))) 'Nombre'\n"
                        + "	, MIN(CAST(c.apellido as VARCHAR(max))) 'Apellido'\n"
                        + "	, p.formato 'Formato'\n"
                        + "	, SUM(a.valorArriendo) AS 'Dinero en Arriendos'\n"
                        + "FROM arriendo AS a \n"
                        + "INNER JOIN cliente AS c ON c.run=a.run \n"
                        + "INNER JOIN pelicula AS p ON p.codigo=a.codigo \n"
                        + "GROUP BY c.run, p.formato ORDER BY 'Dinero en Arriendos' DESC, 'Apellido', 'Nombre';\n";
            DataTable dataTable = new DataTable();
            dataTable = datos.consultaSQL(sql);
            return dataTable;
        }



    }
}

