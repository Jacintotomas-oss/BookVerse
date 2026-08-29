using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
namespace BookVerse.DATA
{
    public static class ConexionDB
    {
        private static readonly string cadena =
            "Server=DESKTOP-8TB9QBU;Database=Libreria;Trusted_Connection=True;TrustServerCertificate=True;";
        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}
