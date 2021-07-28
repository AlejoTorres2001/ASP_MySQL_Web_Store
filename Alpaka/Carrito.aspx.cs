using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Alpaka
{
    /*TODO 
           Sweet alerts
           Parte de pagar:Efectivo,tarjeta luego se registra la compra
           registrar la venta, mandarlo a que direccion
            validar que ingrese un numero*/

    public partial class Carrito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
        
                if (Session["usuario"]==null) {
                    //Swal
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    String[] carrito=((List<string>)Session["carrito"]).ToArray();
                    

                    List<string> IDs = new List<string>();
                    List<string> nombres = new List<string>();
                    List<string> talle = new List<string>();
                    List<string> color = new List<string>();
                    List<string> composicion = new List<string>();
                    List<string> precios = new List<string>();



                    foreach (String id in carrito)
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
                    String[] arcantidades = ((List<string>)Session["cantidad"]).ToArray();
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "CargarCarrito", "CargarCarrito('" + js.Serialize(arIDs) + "','" + js.Serialize(arcantidades) + "','"+ js.Serialize(arnombres) + "','" + js.Serialize(arprecios) + "','" + js.Serialize(artalles) + "','" + js.Serialize(arcolores) + "','" + js.Serialize(arcomposiciones) + "','" + js.Serialize(arimagenes) + "');", true);

                }
                
            }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<string> carrito_historico = ((List<string>)Session["carrito"]);
            List<string> cantidades_historico = ((List<string>)Session["cantidad"]);

            List<string> nuevo_carrito = new List<string>();
            List<string> nuevas_cantidades = new List<string>();

            String IDs = Request.Form["carrito"];
            if (IDs != null)
            {

                String cantidades = Request.Form["cantidad"];
                IDs = Regex.Replace(IDs, "[/]", string.Empty);
                String[] IDs_a_borrar = IDs.Split(',');
                String[] cantidades_a_borrar = cantidades.Split(',');
                cantidades_a_borrar = cantidades_a_borrar.Where(val => val != "").ToArray();
                bool negativos = cantidades_a_borrar.Any(i => Convert.ToInt32(i) < 0);
                if (!negativos)
                {
                    int i = 0;
                    foreach (String id_a_borrar in IDs_a_borrar)
                    {
                        int indice_en_carrito = carrito_historico.IndexOf(id_a_borrar);
                        int cantidad_historica = Convert.ToInt32(cantidades_historico.ElementAt(indice_en_carrito));
                        int cantidad_a_borrar = Convert.ToInt32(cantidades_a_borrar.ElementAt(i));
                        int resultado = cantidad_historica - cantidad_a_borrar;
                        if (resultado > 0)
                        {
                            nuevo_carrito.Add(carrito_historico.ElementAt(carrito_historico.IndexOf(id_a_borrar)));
                            nuevas_cantidades.Add(Convert.ToString(resultado));

                        }
                        i += 1;

                    }
                    foreach (String ID in carrito_historico) {
                        if (!IDs_a_borrar.Contains(ID)) {

                            nuevo_carrito.Add(ID);
                            nuevas_cantidades.Add(cantidades_historico.ElementAt(carrito_historico.IndexOf(ID)));
                        }
                    
                    
                    }
                    Session["carrito"] = nuevo_carrito;
                    Session["cantidad"] = nuevas_cantidades;
                    Response.Redirect(Request.RawUrl);
                }
                else {
                    //Swal negativos
                    Response.Redirect(Request.RawUrl);
                }
            }
            else {
                //Swal selecionar
                Response.Redirect(Request.RawUrl);

            }
            
        }
    }
}


        
