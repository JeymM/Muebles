using Muebles.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Muebles.Forms.Administrador
{
    public partial class VerificarClientes : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        public void listarCliente()
        {
            string statusString = "";
            ClienteDTO cli = new ClienteDTO();
            
            foreach (ClienteDTO dat in cli.consultarTodos())
            {
                if (dat.estado == 1)
                {
                    statusString = "Activo";
                }
                else if (dat.estado == 0)
                {
                    statusString = "Desactivado";
                }
                else
                {
                    statusString = "Indefinido";
                }


                Response.Write("<tr>");
                Response.Write("<td>" + dat.id + "</td>");
                Response.Write("<td>" + dat.nomb + "</td>");
                Response.Write("<td>" + dat.correo + "</td>");
                Response.Write("<td>" + statusString + "</td>");
                Response.Write("<td>");
                Response.Write("<a class='btn btn-info' href='./ActualizarCliente.aspx" +
                    "?id=" + dat.id +
                    "&name=" + dat.nomb +
                    "&correo=" + dat.correo +
                    "&estado=" + dat.estado + "'><i>Actualizar Estado</i></a>");
                Response.Write("</td>");

                Response.Write("</tr>");

            }


        }

        }
    }
