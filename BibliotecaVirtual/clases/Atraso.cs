﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.clases
{
    class Atraso
    {
        public static string tabla = "atraso";


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
            set { Estado = value; }
        }


        public Atraso(string sancion, string estado)
        {
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


    }
}