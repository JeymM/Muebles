using Muebles.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Muebles.Forms.Administrador
{
    public partial class Inventario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void listaInventario()
        {
            ArticuloDTO inv = new ArticuloDTO();
            String col;

            foreach (ArticuloDTO pro in inv.consultarTodos())
            {

                Response.Write("<tr>");
                Response.Write("<td>"+pro.ide+"</td>");
                Response.Write("<td>"+pro.id_provee+"</td>");
                Response.Write("<td>"+pro.prec+"</td>");
                Response.Write("<td>"+pro.descrip+"</td>");
                Response.Write("<td>"+pro.nombre+"</td>");
                Response.Write("<td>");
                Response.Write("<a class='btn btn-info'><i>Eliminar</i></a>") ;
                inv.eliminar();
                //inv.eliminar(pro.ide,pro.id_provee,pro.prec,pro.descrip,pro.nombre);
                Response.Write("</td>");
                Response.Write("</tr>");
            }
        }
        public void eliminar()
        {
            ArticuloDTO inv = new ArticuloDTO();
            inv.eliminar();
        }
    }
}