using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Alpaka
{
    public partial class register : System.Web.UI.Page
    {
        /*TODO 
               Sweet alerts*/
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                String email = this.Request.Form["emailregistro"];
                String password = this.Request.Form["contraseñaregistro"];
                SqlDataReader respuesta = Clases.BD.Ejecutar("SELECT * FROM Usuarios where usuario = '" + email + "'");
                if (!respuesta.HasRows)
                {
                    //se registra
                    Clases.BD.Insertar("insert into Usuarios(usuario,contraseña,admin) values('" + email + "','" + password + "',0)");
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "regCorrecto", "regCorrecto();", true);
                }
                else
                {
                    //el usuario ya existe
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "regIncorrecto", "regIncorrecto();", true);
                }
            }
        }
    }
}
