using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using Alpaka.Clases;

namespace Alpaka
{
 
    public partial class Catalogo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            JavaScriptSerializer js = new JavaScriptSerializer(); // serializer comun a todos los catalogos
            //Carga catalogo de las mujeres
            SqlDataReader respuesta = Clases.BD.Ejecutar("select * from Producto where Categoria='mujeres' and sub_categoria='pantalones'");
            List<string> IDs = new List<string>();
            List<string> nombres= new List<string>();
            List<string> talle = new List<string>();
            List<string> color = new List<string>();
            List<string> composicion = new List<string>();
            List<string> precios=new List<string>();
           
            while (respuesta.Read())
            {
                IDs.Add(Convert.ToString(respuesta["ID"]));
                nombres.Add(Convert.ToString(respuesta["nombre"]));
                precios.Add(Convert.ToString(respuesta["precio"]));
                talle.Add(Convert.ToString(respuesta["talle"]));
                color.Add(Convert.ToString(respuesta["color"]));
                composicion.Add(Convert.ToString(respuesta["composicion"]));

            }
            List<String> imagenes = Clases.Catalogo.CargarImagenes(IDs);
            String[] arIDs = IDs.ToArray();
            String[] arnombres = nombres.ToArray();
            String[] arprecios = precios.ToArray();
            String[] artalles = talle.ToArray();
            String[] arcolores = color.ToArray();
            String[] arcomposiciones = composicion.ToArray();
            String[] arimagenes = imagenes.ToArray();
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "CargarCatalogoMujeresPantalones", "CargarCatalogoMujeresPantalones('" + js.Serialize(arIDs) + "','" + js.Serialize(arnombres) + "','" + js.Serialize(arprecios) + "','" + js.Serialize(artalles) + "','" + js.Serialize(arcolores) + "','" + js.Serialize(arcomposiciones) + "','" + js.Serialize(arimagenes) + "');", true);


            //Carga catalogo de las mujeres
            respuesta = Clases.BD.Ejecutar("select * from Producto where Categoria='mujeres' and sub_categoria='remeras'");
             IDs = new List<string>();
             nombres = new List<string>();
             talle = new List<string>();
             color = new List<string>();
             composicion = new List<string>();
             precios = new List<string>();
            while (respuesta.Read())
            {
                IDs.Add(Convert.ToString(respuesta["ID"]));
                nombres.Add(Convert.ToString(respuesta["nombre"]));
                precios.Add(Convert.ToString(respuesta["precio"]));
                talle.Add(Convert.ToString(respuesta["talle"]));
                color.Add(Convert.ToString(respuesta["color"]));
                composicion.Add(Convert.ToString(respuesta["composicion"]));

            }
            imagenes = Clases.Catalogo.CargarImagenes(IDs);
            arIDs = IDs.ToArray();
             arnombres = nombres.ToArray();
             arprecios = precios.ToArray();
             artalles = talle.ToArray();
             arcolores = color.ToArray();
             arcomposiciones = composicion.ToArray();
            arimagenes = imagenes.ToArray();
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "CargarCatalogoMujeresRemeras", "CargarCatalogoMujeresRemeras('" + js.Serialize(arIDs) + "','" + js.Serialize(arnombres) + "','" + js.Serialize(arprecios) + "','" + js.Serialize(artalles) + "','" + js.Serialize(arcolores) + "','" + js.Serialize(arcomposiciones) + "','" + js.Serialize(arimagenes) + "');", true);



            //Carga catalogo de los hombres
            respuesta = Clases.BD.Ejecutar("select * from Producto where Categoria='hombre' and sub_categoria='pantalones'" );
            IDs = new List<string>();
            nombres = new List<string>();
             talle = new List<string>();
             color = new List<string>();
             composicion = new List<string>();
             precios = new List<string>();
            
            while (respuesta.Read())
            {
                IDs.Add(Convert.ToString(respuesta["ID"]));
                nombres.Add(Convert.ToString(respuesta["nombre"]));
                precios.Add(Convert.ToString(respuesta["precio"]));
                talle.Add(Convert.ToString(respuesta["talle"]));
                color.Add(Convert.ToString(respuesta["color"]));
                composicion.Add(Convert.ToString(respuesta["composicion"]));

            }
            imagenes = Clases.Catalogo.CargarImagenes(IDs);
            arIDs = IDs.ToArray();
             arnombres = nombres.ToArray();
             arprecios = precios.ToArray();
             artalles = talle.ToArray();
             arcolores = color.ToArray();
             arcomposiciones = composicion.ToArray();
            arimagenes = imagenes.ToArray();
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "CargarCatalogoHombresPantalones", "CargarCatalogoHombresPantalones('" + js.Serialize(arIDs) + "','" + js.Serialize(arnombres) + "','" + js.Serialize(arprecios) + "','" + js.Serialize(artalles) + "','" + js.Serialize(arcolores) + "','" + js.Serialize(arcomposiciones) + "','" + js.Serialize(arimagenes) + "');", true);


            respuesta = Clases.BD.Ejecutar("select * from Producto where Categoria='hombre' and sub_categoria='remeras'");
            IDs = new List<string>();
            nombres = new List<string>();
            talle = new List<string>();
            color = new List<string>();
            composicion = new List<string>();
            precios = new List<string>();
            while (respuesta.Read())
            {
                IDs.Add(Convert.ToString(respuesta["ID"]));
                nombres.Add(Convert.ToString(respuesta["nombre"]));
                precios.Add(Convert.ToString(respuesta["precio"]));
                talle.Add(Convert.ToString(respuesta["talle"]));
                color.Add(Convert.ToString(respuesta["color"]));
                composicion.Add(Convert.ToString(respuesta["composicion"]));

            }
            imagenes = Clases.Catalogo.CargarImagenes(IDs);
            arIDs = IDs.ToArray();
            arnombres = nombres.ToArray();
            arprecios = precios.ToArray();
            artalles = talle.ToArray();
            arcolores = color.ToArray();
            arcomposiciones = composicion.ToArray();
            arimagenes = imagenes.ToArray();
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "CargarCatalogoHombresRemeras", "CargarCatalogoHombresRemeras('" + js.Serialize(arIDs) + "','" + js.Serialize(arnombres) + "','" + js.Serialize(arprecios) + "','" + js.Serialize(artalles) + "','" + js.Serialize(arcolores) + "','" + js.Serialize(arcomposiciones) + "','" + js.Serialize(arimagenes) + "');", true);



            //Carga catalogo de Accesorios
            respuesta = Clases.BD.Ejecutar("select * from Producto where Categoria='accesorios'");
            IDs = new List<string>();
            nombres = new List<string>();
            talle = new List<string>();
            color = new List<string>();
            composicion = new List<string>();
            precios = new List<string>();
            List<string> subcat = new List<string>(); 
            while (respuesta.Read())
            {
                IDs.Add(Convert.ToString(respuesta["ID"]));
                nombres.Add(Convert.ToString(respuesta["nombre"]));
                precios.Add(Convert.ToString(respuesta["precio"]));
                talle.Add(Convert.ToString(respuesta["talle"]));
                color.Add(Convert.ToString(respuesta["color"]));
                composicion.Add(Convert.ToString(respuesta["composicion"]));
                subcat.Add(Convert.ToString(respuesta["sub_categoria"]));

            }
            imagenes = Clases.Catalogo.CargarImagenes(IDs);
            arIDs = IDs.ToArray();
            arnombres = nombres.ToArray();
            arprecios = precios.ToArray();
            artalles = talle.ToArray();
            arcolores = color.ToArray();
            arcomposiciones = composicion.ToArray();
            arimagenes = imagenes.ToArray();
            String[] arsubcat = subcat.ToArray();

            ScriptManager.RegisterClientScriptBlock(this, GetType(), "CargarCatalogoAccsesorios", "CargarCatalogoAccsesorios('" + js.Serialize(arIDs) + "','" + js.Serialize(arnombres) + "','" + js.Serialize(arprecios) + "','" + js.Serialize(artalles) + "','" + js.Serialize(arcolores) + "','" + js.Serialize(arcomposiciones) + "','" + js.Serialize(arsubcat) + "','" + js.Serialize(arimagenes) + "');", true);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if ((string)Session["usuario"] == "" || Session["usuario"] == null)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "DebeRegistrarse", "DebeRegistrarse()", true);

            }
            else {
                String IDs = Request.Form["carrito"];
                String cantidades = Request.Form["cantidad"];

                IDs = Regex.Replace(IDs, "[/]", string.Empty);
                String[] identificadores = IDs.Split(',');
                String[] cant = cantidades.Split(',');
                cant = cant.Where(val => val != "").ToArray();
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
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            System.Web.HttpContext.Current.Session["Busqueda"] = new List<string>();

           // List<String> urls = Clases.Catalogo.CargarImgMujer();
            String categoria = this.ListBox1.SelectedValue;
            if (this.TextBox1.Text != "" && this.TextBox2.Text != "") //busca las dos
            {
                String nombre = this.TextBox1.Text;
                String strtalle = this.TextBox2.Text;

                SqlDataReader respuesta = Clases.BD.Ejecutar("select ID from Producto where nombre like( '%' + '" + nombre + "' + '%' ) and talle='" + strtalle + "' and Categoria='" + categoria + "'");
                while (respuesta.Read())
                {
                    ((List<string>)Session["Busqueda"]).Add(Convert.ToString(respuesta["ID"]));
                }
                String[] bus = ((List<string>)Session["Busqueda"]).ToArray();
                Response.Redirect("Busqueda.aspx");
            }
            else { 
                if (this.TextBox1.Text != "" && this.TextBox2.Text == "") //busca solo por nombre
                {
                    String nombre = this.TextBox1.Text;
                    
                    SqlDataReader respuesta = Clases.BD.Ejecutar("select ID from Producto where nombre like( '%' + '" + nombre + "' + '%' ) and Categoria='" + categoria + "'");
                    while (respuesta.Read())
                    {
                        ((List<string>)Session["Busqueda"]).Add(Convert.ToString(respuesta["ID"]));
                    }
                    String[] bus = ((List<string>)Session["Busqueda"]).ToArray();
                    Response.Redirect("Busqueda.aspx");

                }
                else {
                    if (this.TextBox1.Text == "" && this.TextBox2.Text != "") // busca solo por talle
                    {
                        String strtalle = this.TextBox2.Text;

                        SqlDataReader respuesta = Clases.BD.Ejecutar("select ID from Producto where talle='" + strtalle + "' and Categoria='" + categoria + "'");
                        while (respuesta.Read())
                        {
                            ((List<string>)Session["Busqueda"]).Add(Convert.ToString(respuesta["ID"]));
                        }
                        String[] bus = ((List<string>)Session["Busqueda"]).ToArray();
                        Response.Redirect("Busqueda.aspx");

                    }
                    else { if (this.TextBox1.Text == "" && this.TextBox2.Text == "" || Convert.ToString(this.ListBox1.SelectedItem).Equals("")) { 
                        //Swal: debe ingresar algo
                        } }
                }
            }
            

            
        }
    }
}