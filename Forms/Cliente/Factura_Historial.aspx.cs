using Muebles.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Muebles.Forms.Cliente
{
	public partial class Factura_Historial : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		public void listaHistorial()
        {
            string statusString = "";
            ArticuloDTO ar = new ArticuloDTO();
            CompraDTO cp = new CompraDTO();

            if(Session["id"] != null)
            {
                foreach (CompraDTO compra in cp.VentasPorCliente(Convert.ToString(Session["id"])))//Convert.ToString(Session["id"])
                {


                    Response.Write("<tr>");
                    Response.Write("<td>" + compra.fecha_pago+ "</td>");
                    Response.Write("<td>" + compra.id_art_fk + "</td>");
                    Response.Write("<td>" + compra.cantidad + "</td>");
                    Response.Write("<td>" + (compra.valor_total/compra.cantidad) + "</td>");
                    Response.Write("<td>" + compra.valor_total + "</td>");
                    Response.Write("<td>" + statusString + "</td>");
                    Response.Write("</tr>");
                }
            }


        }
	}
}