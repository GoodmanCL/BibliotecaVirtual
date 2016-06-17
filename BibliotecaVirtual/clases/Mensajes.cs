using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.clases
{
    static class Mensajes
    {
        public const String ERROR_CLIENTE_RUN_INVALIDO      = "Error 100: Run inválido";
        public const String ERROR_CLIENTE_RUN_EXISTE        = "Error 101: Run ya existe";
        public const String ERROR_CLIENTE_RUN_NO_EXISTE     = "Error 102: Run no existe";
        public const String ERROR_CLIENTE_NOMBRE_VACIO      = "Error 103: Campo Nombre vacío";
        public const String ERROR_CLIENTE_APELLIDO_VACIO    = "Error 104: Campo Apellido vacío";
        public const String ERROR_CLIENTE_EMAIL_VACIO       = "Error 105: Campo Email vacío";
        public const String ERROR_CLIENTE_DIRECCION_VACIO   = "Error 106: Campo Dirección vacío";
        
        public const String MSG_CLIENTE_ELIMNAR = "¿Está seguro que desea Eliminar este cliente?";
        public const String MSG_CLIENTE_ELIMNAR_TITULO = "Eliminar cliente";


        // PELICULAS
//        public const String ERROR_PELICULA_RUN_INVALIDO = "Error 100: Run inválido";
        public const String ERROR_PELICULA_CODIGO_EXISTE = "Error 201: Codigo ya existe";
        public const String ERROR_PELICULA_CODIGO_NO_EXISTE = "Error 202: Codigo no existe";
        public const String ERROR_PELICULA_NOMBRE_VACIO = "Error 203: Campo Nombre vacío";
        public const String ERROR_PELICULA_GENERO_VACIO = "Error 204: Campo Género vacío";
        public const String ERROR_PELICULA_DURACION_VACIO = "Error 205: Campo Duración vacío";
        public const String ERROR_PELICULA_FORMATO_VACIO = "Error 206: Campo Formato vacío";


        public const String MSG_PELICULA_ELIMNAR = "¿Está seguro que desea Eliminar esta pelicula?";
        public const String MSG_PELICULA_ELIMNAR_TITULO = "Eliminar pelicula";

        public const String MSG_ARRIENDO_ELIMNAR = "¿Está seguro que desea Eliminar este arriendo?";
        public const String MSG_ARRIENDO_ELIMNAR_TITULO = "Eliminar arriendo";

        public const String ERROR_ARRIENDO_CODIGO_NO_EXISTE = "Error 300: Código de Arriendo no existe";
        public const String ERROR_ARRIENDO_CLIENTE_VACIO = "Error 301: Debe Seleccionar un Cliente";
        public const String ERROR_ARRIENDO_PELICULA_VACIO = "Error 302: Debe Seleccionar una Película";
        public const String ERROR_ARRIENDO_FECHA_VACIO = "Error 302: Debe ingresar la Fecha del Arriendo";
        public const String ERROR_ARRIENDO_DIAS_VACIO = "Error 302: Debe Seleccionar los días de arriendo";


    }
}
