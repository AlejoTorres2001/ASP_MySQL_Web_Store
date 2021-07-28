using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Alpaka
{
    //swal correcto
    public partial class Pagar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.txtboxfecha.Visible = false;
            this.txtboxtarj.Visible = false;
            this.txtboxcvv.Visible = false;
            this.lblcvv.Visible = false;
            this.lblfecha.Visible = false;
            this.lbltarj.Visible = false;
            this.Image1.Visible = false;
            SqlDataReader respuesta = Clases.BD.Ejecutar("select telefono,direccion from Usuarios WHERE usuario='" + (string)Session["usuario"] + "'");
            String dir = "";
            String tel = "";
            while (respuesta.Read()) {

                dir = Convert.ToString(respuesta["direccion"]);
                tel = Convert.ToString(respuesta["telefono"]);

            }
            this.txtboxtel.Text = tel;
            this.txtboxdir.Text = dir;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlDataReader IDusrdr = Clases.BD.Ejecutar("Select ID from Usuarios where usuario='" + Convert.ToString(Session["usuario"]) + "'");
            String IDusr = "";
            while (IDusrdr.Read()) {
                IDusr = Convert.ToString(IDusrdr["ID"]);
            
            }
            List<string> carrito = (List<string>)Session["carrito"];
            List<string> cantidad = (List<string>)Session["cantidad"];
            bool sin_stock = false;
            for (int i = 0; i < carrito.Count; i++)
            {
                int stock=0;
                SqlDataReader stock_dr = Clases.BD.Ejecutar("Select stock from Producto where ID='" + carrito[i] + "'");
                while (stock_dr.Read()) {
                    stock = Convert.ToInt32(stock_dr["stock"]);
                }
                if (stock < Convert.ToInt32(cantidad[i]))
                {
                    sin_stock = true; 
                }
            }
            if (sin_stock)
            {
                Session["carrito"] = new List<string>();
                Session["cantidad"] = new List<string>();
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "ups", "ups()", true);

            }
            else {
                Clases.BD.Ejecutar("insert into Ventas(ID_Usuario,total,fecha) values('" + IDusr + "','" + 0 + "',  GETDATE()  )");

                SqlDataReader ID_ventadr = Clases.BD.Ejecutar("select TOP 1 ID from Ventas order by ID DESC");
                String IDvent = "";
                while (ID_ventadr.Read())
                {
                    IDvent = Convert.ToString(ID_ventadr["ID"]);

                }


                for (int i = 0; i < carrito.Count; i++)
                {
                    Clases.BD.Ejecutar("insert into Detalles(ID_Venta,ID_producto,cantidad) values('" + IDvent + "', '" + carrito[i] + "', '" + cantidad[i] + "')");
                    Clases.BD.Ejecutar("UPDATE Producto set stock =((select stock from Producto where ID='" + carrito[i] + "')-'" + cantidad[i] + "') where ID= '" + carrito[i] + "'");
                }
                Clases.BD.Ejecutar("Update Ventas set total=(select SUM(Producto.precio * Detalles.cantidad) from Producto inner JOin Detalles ON Detalles.ID_producto=Producto.ID AND Detalles.ID_Venta='" + IDvent + "') where Ventas.ID='" + IDvent + "'");
                Session["carrito"] = new List<string>();
                Session["cantidad"] = new List<string>();

                ScriptManager.RegisterClientScriptBlock(this, GetType(), "Correcto", "Correcto()", true);
            }

        }
            


        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(this.ListBox1.SelectedItem) == "tarjeta")
            {
                this.txtboxfecha.Visible = true;
                this.txtboxtarj.Visible = true;
                this.txtboxcvv.Visible = true;
                this.lblcvv.Visible = true;
                this.lblfecha.Visible = true;
                this.lbltarj.Visible = true;
                this.Image1.Visible = true;
            }
            else {

                this.txtboxfecha.Visible = false;
                this.txtboxtarj.Visible = false;
                this.txtboxcvv.Visible = false;
                this.lblcvv.Visible = false;
                this.lblfecha.Visible = false;
                this.lbltarj.Visible = false;
                this.Image1.Visible = false;

            }
        }
    }
}