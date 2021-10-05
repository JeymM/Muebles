using Muebles.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Muebles.Forms.Administrador
{
    public partial class Ventas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void listaHistorial()
        {
            string statusString = "";
            ArticuloDTO ar = new ArticuloDTO();
            CompraDTO cp = new CompraDTO();
            string nombreArticulo = "";

                foreach (CompraDTO compra in cp.ConsultarTodasLasVentas())//Convert.ToString(Session["id"])
                {
                    nombreArticulo = ar.obtenerArticuloPorID(compra.id_art_fk + "").nombre;

                    Response.Write("<tr>");
                    Response.Write("<td>" + compra.fecha_pago + "</td>");
                    Response.Write("<td>" + nombreArticulo + "</td>");
                    Response.Write("<td>" + compra.cantidad + "</td>");
                    Response.Write("<td>" + (compra.valor_total / compra.cantidad) + "</td>");
                    Response.Write("<td>" + compra.valor_total + "</td>");
                    Response.Write("<td>" + statusString + "</td>");
                    Response.Write("</tr>");
                }
            


        }
    }
}