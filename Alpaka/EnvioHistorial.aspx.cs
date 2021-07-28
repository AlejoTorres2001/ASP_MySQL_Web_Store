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
    /*TODO 
     *           crear un email de alpaka para la presentacion*/
    public partial class EnvioHistorial : System.Web.UI.Page
    {
        String body = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataReader IDdr = Clases.BD.Ejecutar("select Ventas.ID from Ventas where ID_Usuario=(Select Usuarios.ID from Usuarios where Usuarios.usuario='" + (string)Session["usuario"] + "') ");
            List<String> re = new List<String>() ;
            List<String> listadocompras = new List<string>();
            while (IDdr.Read()) {
                re.Add(Convert.ToString(IDdr["ID"]));

            }
            
            for (int i = 0; i <re.Count(); i++)
            {
                String productos = "";
                String total = "";
                String fecha= "";
                String cantidad = "";
                SqlDataReader prod_total_fechadr = Clases.BD.Ejecutar("select Producto.nombre,Ventas.total,Ventas.fecha,Detalles.cantidad from Producto inner join Detalles ON Detalles.ID_producto=Producto.ID inner join Ventas ON Ventas.ID='" + re[i] + "' where Detalles.ID_Venta='" + re[i] + "'");
                while (prod_total_fechadr.Read()) {
                    cantidad = Convert.ToString(prod_total_fechadr["cantidad"]);
                    productos += Convert.ToString(prod_total_fechadr["nombre"]) +"(cantidad:"+cantidad+")" +",";
                    total = Convert.ToString(prod_total_fechadr["total"]);
                    fecha = Convert.ToString(prod_total_fechadr["fecha"]);
                    
                }
                String cont = "* En la fecha'" + fecha + "',se realizo una compra por '" + total + "',por los siguientes productos: '" + productos + "'\n\n\n";
                listadocompras.Add(cont);

            }
            body = "";
            for (int i = 0; i < listadocompras.Count(); i++)
            {
                body = body + listadocompras[i];
            }
            this.TextBox1.Text = body;
            this.TextBox1.ReadOnly = true;
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Clases.email.EnviarCorreo((string)Session["usuario"], "Historial de Compras", body);
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "Correcto", "Correcto();", true);
        }
    }
}