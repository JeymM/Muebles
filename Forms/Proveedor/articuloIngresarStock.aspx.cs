using Muebles.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Muebles.Forms.Proveedor
{
    public partial class articuloIngresarStock : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void listArticulos()
        {

            ArticuloDTO ar = new ArticuloDTO();

            foreach (ArticuloDTO arti in ar.consultarTodos())
            {
                Response.Write("<tr>");
                Response.Write("<td>" + arti.ide + "</td>");
                Response.Write("<td>" + arti.id_provee + "</td>");
                Response.Write("<td>" + arti.prec + "</td>");
                Response.Write("<td>" + arti.descrip + "</td>");
                Response.Write("<td>" + arti.nombre + "</td>");
                Response.Write("<td>" + arti.estado + "</td>");
                Response.Write("<td>");
                Response.Write("<a class='btn btn-info' href='./ActualizarArticulo.aspx"+
                    "?ide=" + arti.ide+
                    "&cant=" + arti.id_provee+
                    "&prec=" + arti.prec+
                    "&descrip=" + arti.descrip+
                    "&name=" + arti.nombre+
                    "&descrip=" + arti.descrip + "'><i>Actualizar</i></a>");
                Response.Write("</td>");                

                Response.Write("</tr>");

            }
        }

        public void SubmitBtn_Click(Object sender, EventArgs e)
        {
            Console.WriteLine("entre");
            HttpContext.Current.Response.Write("entre");
        }

    }
}
