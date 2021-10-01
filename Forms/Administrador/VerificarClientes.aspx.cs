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
        public static DTO.ClienteDTO cl = new DTO.ClienteDTO();
        DataTable tabla = new DataTable();
        private object tab;

        protected void Page_Load(object sender, EventArgs e)
        {
            tabla.Columns.Add("Id cliente");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Correo");
        }
        public void listarCliente()
        {
            DTO.ClienteDTO cli = new DTO.ClienteDTO();
            cli.consultarTodos();

            String tabla = "<table border=1>";
            String[] col = { "Id", "Nombre", "Correo"};
            tabla = tabla + "<tr>";
            for (int i = 0; i < 3; i++)
            {
                tabla = tabla + "<th>" + col[i] + "</th>";
            }
            tabla = tabla + "</tr>";
            foreach (ClienteDTO dat in cli.consultarTodos())
            {
                tabla = tabla + "<tr>";
                tabla = tabla + "<td>" + cli.id + "</td>";
                tabla = tabla + "<td>" + cli.nomb + "</td>";
                tabla = tabla + "<td>" + cli.correo + "</td>";
                tabla = tabla + "</tr>";
                Response.Write("<td>");
                Response.Write("<a class='btn btn-info' href='./ActualizarCliente.aspx" +
                    "?id=" + cli.id +
                    "&name=" + cli.correo + "'><i>Actualizar</i></a>");
                Response.Write("</td>");

                Response.Write("</tr>");
            }
           
            

        }
    }
}