using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net.Mail;

namespace Alpaka
{
    /*TODO Sweet alert*/
    public partial class forget : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) {

                String email = this.Request.Form["email"];
                SqlDataReader respuesta = Clases.BD.Ejecutar("Select contraseña from Usuarios where usuario='" + email + "'");
                String contraseña = "";
                if (respuesta.HasRows)
                {
                    while (respuesta.Read())
                    {

                        contraseña = Convert.ToString(respuesta["contraseña"]);

                    }
                    Clases.email.EnviarCorreo(email, "Recupero de contraseña", "su contraseña es: " + contraseña);
                    //Sweet alert se envio correctamente
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "correcto", "EnvioCorrecto();", true);

                }
                else {
                    //Sweet alert no estas registrado
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "incorrecto", "EnvioIncorrecto();", true);
                }
            
            }
        }
    }
}