using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BibliotecaVirtual.clases
{
    class Datos
    {


        private string cadena = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Datos\Biblioteca.mdf;Integrated Security=True;Connect Timeout=30";
        public SqlConnection cn;
        public SqlCommand comando;


        public SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;

        private void conectar()
        {
            cn = new SqlConnection(cadena);
        }

        public Datos()
        {
            conectar();
        }


        //insertar
        public void insertar(string sql)
        {
            try
            {
                cn.Open();
                comando = new SqlCommand(sql, cn);
                int i = comando.ExecuteNonQuery();
                cn.Close();
                if (i > 0)
                {
                    System.Windows.MessageBox.Show("Datos insertados correctamente", "", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    System.Windows.MessageBox.Show("Error en la consulta", "", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show("Error: " + e.Message, "", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        public void actualizar(string sql)
        {
            try
            {
                cn.Open();
                comando = new SqlCommand(sql, cn);
                int i = comando.ExecuteNonQuery();
                cn.Close();
                if (i > 0)
                {
                    System.Windows.MessageBox.Show("Datos actualizados correctamente", "", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    System.Windows.MessageBox.Show("Error en la consulta", "", MessageBoxButton.OK, MessageBoxImage.Error);


                }
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show("Error: " + e.Message, "", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        ////consultar tabla
        public DataTable consultaTabla(string tabla)
        {
            cn.Open();
            string sql = "select * from " + tabla;
            da = new SqlDataAdapter(sql, cn);
            DataSet dts = new DataSet();
            da.Fill(dts, tabla);
            DataTable dt = new DataTable();
            dt = dts.Tables[tabla];
            cn.Close();
            return dt;
        }



        public SqlDataReader buscar(String sql)
        {
            cn.Open();
            comando = new SqlCommand(sql, cn);
            SqlDataReader reader = comando.ExecuteReader();
            return reader;
        }



        public bool existe(string Id)
        {
            cn.Open();
            string query = "SELECT COUNT(*) FROM prestamo WHERE Id='" + Id + "'";
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("Id", Id);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            cn.Close();
            if (count == 0)
            {

                return false;
            }
            else
            {

                return true;
            }
        }




        public SqlDataReader consulta(String sql)
        {
            cn.Open();
            comando = new SqlCommand(sql, cn);
            SqlDataReader reader = comando.ExecuteReader();
            return reader;
        }

        public DataTable consultaSQL(String sql)
        {
            cn.Open();
            da = new SqlDataAdapter(sql, cn);
            DataSet dts = new DataSet();
            da.Fill(dts, "consulta");
            DataTable dt = new DataTable();
            dt = dts.Tables["consulta"];
            cn.Close();
            return dt;
        }

    }
}
