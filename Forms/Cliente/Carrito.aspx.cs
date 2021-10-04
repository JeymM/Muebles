using Muebles.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Muebles.Forms.Cliente
{
    public partial class Carrito : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        public void listaCarrito()
        {
            string statusString = "";
            ArticuloDTO ar = new ArticuloDTO();

            foreach (ArticuloDTO arti in ar.consultarActivos())
            {
                if (arti.estado == 1)
                {
                    statusString = "Activo";
                }
                else if (arti.estado == 0)
                {
                    statusString = "Desactivado";
                }
                else
                {
                    statusString = "Indefinido";
                }

                Response.Write("<tr>");
                Response.Write("<td>" + arti.ide + "</td>");
                Response.Write("<td>" + arti.prec + "</td>");
                Response.Write("<td>" + arti.descrip + "</td>");
                Response.Write("<td>" + arti.nombre + "</td>");
                Response.Write("<td><input id=c type=number </td>");
                Response.Write("<td>");
                Response.Write("</tr>");

            }
        }
        protected void registrar_com(object sender, EventArgs e)
        {   
            MessageBox.Show("Si entra");

        }

    }
}