using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Alpaka
{
 
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String email = this.Request.Form["email"];
            String password = this.Request.Form["password"];

            if (Page.IsPostBack) {
                
                SqlDataReader respuesta= Clases.BD.Ejecutar("SELECT * FROM Usuarios where usuario = '" + email + "'");
                String contraseña = "";
                String usuario = "";
                while (respuesta.Read()) {
                    contraseña = Convert.ToString(respuesta["contraseña"]);
                    usuario = Convert.ToString(respuesta["usuario"]);

                }
                if (contraseña.Equals(password))
                {
                    //se logueo bien
                    Session["usuario"] = usuario;
                    List<String> Carrito = new List<string>();
                    List<String> precios = new List<string>();
                    Session["carrito"] = new List<string>();
                    Session["cantidad"] = new List<string>();
                    SqlDataReader carrito = Clases.BD.Ejecutar("select * from Carrito where ID_Usuario=(select ID from Usuarios where Usuarios.usuario='" + email + "' )");
                    while (carrito.Read()) {
                        ((List<string>)Session["carrito"]).Add(Convert.ToString(carrito["ID_producto"]));
                        ((List<string>)Session["cantidad"]).Add(Convert.ToString(carrito["cantidad"]));

                    }
                    Response.Redirect("Index.aspx");
                    //ScriptManager.RegisterClientScriptBlock(this, GetType(), "Correcto", "Correcto()", true);


                }
                else {
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "Incorrecto", "Incorrecto();", true);
                }
            }
        }
    }
}