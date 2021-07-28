using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;

namespace Alpaka
{
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!Page.IsPostBack)
            {
                String usuario = (string)Session["usuario"];
                SqlDataReader respuesta = Clases.BD.Ejecutar("select * from Usuarios where usuario='" + usuario + "'");
                String email = "";
                String contraseña = "";
                String tel = "";
                String direccion = "";
                String imagen = "";
                while (respuesta.Read())
                {
                    email = Convert.ToString(respuesta["usuario"]);
                    contraseña = Convert.ToString(respuesta["contraseña"]);
                    tel = Convert.ToString(respuesta["telefono"]);
                    direccion = Convert.ToString(respuesta["direccion"]);
                    imagen = Convert.ToString(respuesta["imagen"]);

                }
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "CargarPerfil", "CargarPerfil('" + email + "','" + contraseña + "','" + tel + "','" + direccion + "');", true);
                this.Image1.ImageUrl = imagen;
            }
            if (Page.IsPostBack)
            {
                String email = this.Request.Form["email"];
                String contraseña = this.Request.Form["contraseña"];
                String telefono = this.Request.Form["tel"];
                String direccion = this.Request.Form["direccion"];
                string img = this.Request.Form["file"];
                Clases.BD.Insertar("UPDATE  Usuarios set usuario='" + email + "', contraseña='" + contraseña + "', telefono='" + telefono + "', direccion='" + direccion + "' where usuario='" + email + "' ");
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "Actualizacion", "Actualizacion();", true);
            }
            if ((string)Session["usuario"] == "" || Session["usuario"] == null)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "NoPuedeEntrar", "NoPuedeEntrar()", true);

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlDataReader respuesta = Clases.BD.Ejecutar("delete from Carrito where ID_Usuario=(select ID from Usuarios where Usuarios.usuario='" + (string)Session["usuario"] + "' )");
            for (int i = 0; i < ((List<string>)Session["carrito"]).Count; i++)
            {
                Clases.BD.Ejecutar("insert into Carrito values((select ID from Usuarios where Usuarios.usuario='" + (string)Session["usuario"] + "'),'" + Convert.ToInt32(((List<string>)Session["carrito"])[i]) + "','" + Convert.ToInt32(((List<string>)Session["cantidad"])[i]) + "')");
            }
            Session["usuario"] = "";
            Session["carrito"] = new List<string>();
            Session["cantidad"] = new List<string>();
            Response.Redirect("Login.aspx");
            
        }

        protected void guardarfoto_Click(object sender, EventArgs e)
        {
            string strFileName;
            string strFilePath;
            string strFolder;
            string res;
            strFolder = Server.MapPath("./resources/usuarios/");
            // Get the name of the file that is posted.
            strFileName = oFile.PostedFile.FileName;
            strFileName = Path.GetFileName(strFileName);
            if (oFile.Value != "")
            {
                // Create the directory if it does not exist.
                if (!Directory.Exists(strFolder))
                {
                    Directory.CreateDirectory(strFolder);
                }
                // Save the uploaded file to the server.
                strFilePath = strFolder + strFileName;
                if (File.Exists(strFilePath))
                {
                    
                }
                else
                {
                    oFile.PostedFile.SaveAs(strFilePath);
                    



                }
                string ruta = "/resources/usuarios/" + strFileName;
                Clases.BD.Ejecutar("UPDATE Usuarios set imagen='" + ruta + "' where usuario='" + (string)Session["usuario"] + "'");
                


            }
            else
            {
                
            }
           
        }
    }
}
