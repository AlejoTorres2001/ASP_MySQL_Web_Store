using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace Alpaka.Clases
{
    public class Catalogo
    {
        public static List<String> CargarImagenes(List<String>IDs) {
            List<String>  url_imagenes = new List<String>();
            for (int i = 0; i < IDs.Count; i++)
            {
                SqlDataReader respuesta = Clases.BD.Ejecutar("select imagen from Producto where ID='" + IDs[i] + "'");
                while (respuesta.Read()) {

                    url_imagenes.Add(Convert.ToString(respuesta["imagen"]));
                }

            }
            return url_imagenes;
        }
    }
}