using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Alpaka.Clases
{
    public class BD
    {

        public static SqlDataReader Ejecutar(string sql)
        {

            SqlConnection conexion = new SqlConnection("connection string");
            SqlCommand command = new SqlCommand(sql, conexion);
            conexion.Open();
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        public static void Insertar(string sql) {
            SqlConnection conexion = new SqlConnection("connection string");
            SqlDataAdapter da;
            conexion.Open();
            SqlCommand command = new SqlCommand(sql, conexion);
            command.ExecuteNonQuery();


        }
    }
}