using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Alpaka.Clases;
using System.Web.Script.Serialization;
using System.Text.RegularExpressions;

namespace Alpaka
{
    /*TODO 
           Sweet alerts
            */
    public partial class Busqueda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                JavaScriptSerializer js = new JavaScriptSerializer(); // serializer comun a todos los catalogos

                List<string> IDs = new List<string>();
                List<string> nombres = new List<string>();
                List<string> talle = new List<string>();
                List<string> color = new List<string>();
                List<string> composicion = new List<string>();
                List<string> precios = new List<string>();
                

                String[] bus = ((List<string>)Session["Busqueda"]).ToArray();
                foreach (String id in bus)
                {

                    SqlDataReader respuesta = Clases.BD.Ejecutar("SELECT * from Producto where ID='" + id + "'");
                    while (respuesta.Read())
                    {
                        IDs.Add(Convert.ToString(respuesta["ID"]));
                        nombres.Add(Convert.ToString(respuesta["nombre"]));
                        precios.Add(Convert.ToString(respuesta["precio"]));
                        talle.Add(Convert.ToString(respuesta["talle"]));
                        color.Add(Convert.ToString(respuesta["color"]));
                        composicion.Add(Convert.ToString(respuesta["composicion"]));

                    }
                   
                    

                }
                List<string> imagenes = Clases.Catalogo.CargarImagenes(IDs);
                String[] arIDs = IDs.ToArray();
                String[] arnombres = nombres.ToArray();
                String[] arprecios = precios.ToArray();
                String[] artalles = talle.ToArray();
                String[] arcolores = color.ToArray();
                String[] arcomposiciones = composicion.ToArray();
                String[] arimagenes = imagenes.ToArray();
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "CargarBusquedas", "CargarBusquedas('" + js.Serialize(arIDs) + "','" + js.Serialize(arnombres) + "','" + js.Serialize(arprecios) + "','" + js.Serialize(artalles) + "','" + js.Serialize(arcolores) + "','" + js.Serialize(arcomposiciones) + "','" + js.Serialize(arimagenes) + "');", true);
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                //SWAL
            }
            else
            {
                String IDs = Request.Form["carrito"];
                String cantidades = Request.Form["cantidad"];
                if (IDs != null)
                {
                    IDs = Regex.Replace(IDs, "[/]", string.Empty);
                    String[] identificadores = IDs.Split(',');
                    String[] cant = cantidades.Split(',');
                    cant = cant.Where(val => val != "").ToArray();
                    bool negativos = cant.Any(i => Convert.ToInt32(i) < 0);
                    if (!negativos)
                    {
                        for (int i = 0; i < identificadores.Length; i++)
                        {
                            if (((List<string>)Session["carrito"]).Contains(identificadores[i]))
                            {
                                int indice = ((List<string>)Session["carrito"]).IndexOf(identificadores[i]);
                                String valor_anterior = ((List<string>)Session["cantidad"]).ElementAt(indice);
                                int suma = Convert.ToInt32(valor_anterior) + Convert.ToInt32(cant[i]);
                                ((List<string>)Session["cantidad"]).Insert(indice, Convert.ToString(suma));
                            }
                            else
                            {
                                ((List<string>)Session["carrito"]).Add(identificadores[i]);
                                ((List<string>)Session["cantidad"]).Add(cant[i]);
                            }
                        }
                        Response.Redirect("Catalogo.aspx");
                    }
                    else { 
                    //Swal  no pueden ser numeros negativos
                    }

                }
                else { 
                    //Swal debe seleccionar algo
                }

                
               



            }
        }
    }
            
}