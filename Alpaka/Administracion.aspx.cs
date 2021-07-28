using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Alpaka
{
    /*TODO 
     *    mejorar la estetica
          Busqueda de productos o modificaciones*/
    public partial class Administracion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["usuario"] != "torres.alejo2001@gmail.com" || Session["usuario"]==null) {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "add", "Incorrecto()", true);
               
            }
            if (!Page.IsPostBack)
            {
                txtnombre.Text = "";
                txtprecio.Text = "";
                txtimagen.Text = "";
                txtcolor.Text = "";
                txtcomp.Text = "";
                txttalle.Text = "";
                txtstock.Text = "";

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //cargar el producto a la bd
            String nombre = txtnombre.Text;
            string precio=this.txtprecio.Text;
            string comp=this.txtcomp.Text;
            string talle= this.txttalle.Text;
            string color= this.txtcolor.Text ;
            string img= this.txtimagen.Text ;
            string cat = this.dplistcat.SelectedValue;
            string sub_cat=this.dplistsubcat.SelectedValue;
            int stock = Convert.ToInt32(this.txtstock.Text);
            int prec = Convert.ToInt32(precio);
            
            Clases.BD.Ejecutar("insert into Producto(nombre,talle,color,composicion,precio,Categoria,sub_categoria,imagen,stock) values('" + nombre + "','" + talle + "','" + color + "','" + comp + "','" + prec + "','" + cat + "','" + sub_cat + "','" + img + "','" + stock + "')");
            this.txtprecio.Text = "";
            this.txtcomp.Text = "";
            this.txttalle.Text = "";
            this.txtcolor.Text = "";
            this.txtimagen.Text = "";
            this.dplistcat.SelectedValue = "";
            this.dplistsubcat.SelectedValue = "";
            this.txtstock.Text = "";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.TextBox5.Text = "";
            SqlDataReader res = Clases.BD.Ejecutar("Select usuario from Usuarios");
            List<String> lista = new List<String>();
            while (res.Read()) {
                lista.Add(Convert.ToString(res["usuario"]));
            
            }
            for (int i = 0; i < lista.Count; i++)
            {
                TextBox5.Text += lista[i] + "\n";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            String nombre = txtnombre.Text;
            Clases.BD.Ejecutar("delete from Producto where nombre='" + nombre + "'");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            String nombre = this.txtnombre.Text;
            SqlDataReader resp = Clases.BD.Ejecutar("select * from Producto where nombre='" + nombre + "'");
            String talle = "";
            String comp = "";
            String precio = "";
            String img = "";
            String color = "";
            String cat = "";
            String sub_cat = "";
            int stock=0;
            while (resp.Read()) {
                precio = Convert.ToString(resp["precio"]);
                talle = Convert.ToString(resp["talle"]);
                comp = Convert.ToString(resp["composicion"]);
                img = Convert.ToString(resp["imagen"]);
                color= Convert.ToString(resp["color"]);
                cat = Convert.ToString(resp["Categoria"]);
                sub_cat = Convert.ToString(resp["sub_categoria"]);
                stock = Convert.ToInt32(resp["stock"]);

            }
            this.txtprecio.Text = precio;
            this.txtcomp.Text = comp;
            this.txttalle.Text = talle;
            this.txtcolor.Text = color;
            this.txtimagen.Text = img;
            this.dplistcat.SelectedValue = cat;
            this.dplistsubcat.SelectedValue = sub_cat;
            this.txtstock.Text = Convert.ToString(stock);

           
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string precio = this.txtprecio.Text;
            string comp = this.txtcomp.Text;
            string talle = this.txttalle.Text;
            string color = this.txtcolor.Text;
            string img = this.txtimagen.Text;
            string cat = this.dplistcat.SelectedValue;
            string sub_cat = this.dplistsubcat.SelectedValue;
            int stock = Convert.ToInt32(this.txtstock.Text);
            SqlDataReader resp = Clases.BD.Ejecutar("UPDATE Producto set nombre='" + nombre + "',talle='" + talle + "',color='" + color + "',Categoria='" + cat + "',sub_categoria='" + sub_cat + "', imagen='" + img + "', precio='" + precio + "', composicion='" + comp + "', stock='" + stock + "' where nombre='" + nombre + "'");
            this.txtprecio.Text = "";
            this.txtcomp.Text = "";
            this.txttalle.Text = "";
            this.txtcolor.Text = "";
            this.txtimagen.Text = "";
            this.dplistcat.SelectedValue = "";
            this.dplistsubcat.SelectedValue = "";
            this.txtstock.Text = "";

        }
    }
}