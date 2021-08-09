using Muebles.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

                Response.Write("</tr>");

            }
        }

    }
}
