﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.clases
{
    class atraso
    {
        public static string tabla = "atraso";


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

  

        public atraso(int id, string sancion, string estado)
        {
            this.Id = id;
            this.Sancion = sancion;
            this.Estado = estado;
          
            
        }

        public atraso()
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

        public static void agregar(atraso elAtraso)
        {
            Datos datos = new Datos();

            string sql = "INSERT INTO atraso (id,sancion,estado) values('" + elAtraso.id + "','" + elAtraso.sancion + "','" + elAtraso.estado +"')";
            datos.insertar(sql);
        }
        public static Prestamo buscarPrestamo(string id)
        {

            Datos dato = new Datos();


            string sql = "SELECT * from prestamo WHERE Id='" + id + "'";

            Prestamo unPrestamo = dato.buscarPrestamo(sql);

            return unPrestamo;
        }

        public static DataTable listarAtraso()
        {
            Datos datos = new Datos();

            DataTable dataTable = new DataTable();
            dataTable = datos.consultaTabla(tabla);
            return dataTable;
        }





    }
}
