using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Alpaka.Clases;
namespace Alpaka
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["usuario"] == "" || Session["usuario"] == null)
            {
                this.Button1.Text = "Iniciar Sesion";

            }
          
            else {
                this.Button1.Text = "Usuario Conectado";

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (this.Button1.Text.Equals("Iniciar Sesion"))
            {
                Response.Redirect("Login.aspx");

            }
            else {
                Response.Redirect("Perfil.aspx");
            }
        }
    }
}