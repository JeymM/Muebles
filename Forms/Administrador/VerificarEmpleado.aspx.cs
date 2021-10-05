using Muebles.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Muebles.Forms.Administrador
{
    public partial class VerificarEmpleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void listaTrabajadores()
        {
            string statusString = "";
            ProveedorDTO pr = new ProveedorDTO();
            foreach (ProveedorDTO da in pr.consultarTodos())
            {
                if (da.estado == 1)
                {
                    statusString = "Activo";
                }
                else if (da.estado == 0)
                {
                    statusString = "Desactivado";
                }
                else
                {
                    statusString = "Indefinido";
                }
                Response.Write("<tr>");
                Response.Write("<td>"+da.nit+"</td>");
                Response.Write("<td>" + da.contac + "</td>");
                Response.Write("<td>" + da.dir+ "</td>");
                Response.Write("<td>" + da.nombr + "</td>");
                Response.Write("<td>" + da.correo + "</td>");
                Response.Write("<td>" + da.clave + "</td>");
                Response.Write("<td>" + statusString+ "</td>");
                Response.Write( "</td>");
                Response.Write("</tr>");
            }
        }
    }
}