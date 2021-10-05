using Muebles.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Muebles.Forms.Administrador
{
    public partial class VerificarAdministradores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void ListarAdministradores()
        {
            string statusString = "";
            AdministradorDTO ad = new AdministradorDTO();
            foreach (AdministradorDTO da in ad.consultarTodos())
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
                Response.Write("<td>"+da.id_ad+"</td>");
                Response.Write("<td>" + da.nom + "</td>");
                Response.Write("<td>" + da.tel_ad + "</td>");
                Response.Write("<td>" + da.correo + "</td>");
                Response.Write("<td>" + da.clave + "</td>");
                Response.Write("<td>" + statusString + "</td>");
                Response.Write("</td>");
                Response.Write("</tr>");
            }
        }
    }
}