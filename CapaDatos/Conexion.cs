using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaDatos
{
    public static class Conexion
    {
        private static string server = @"PC94\SQLEXPRESS";
        private static string db = @"MotoMensajeria";
        private static string usuario = @"AlejoDB";
        private static string clave = @"alejo3898";

        public static string DarStrConexion()
        {
            return string.Concat(@"Data Source=", server, ";Initial Catalog=", db,
                ";Persist Security Info=False;User ID=", usuario, ";Password=", clave);
        }

    }
}
