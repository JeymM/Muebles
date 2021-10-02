using Muebles.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Muebles.Forms.Administrador
{
    public partial class ActualizarCliente : System.Web.UI.Page
    {
        public string id_cli = "";
        public string nombre = "";
        public string email = "";
        private ClienteDTO ClienteDTO;
        protected void Page_Load(object sender, EventArgs e)
        {
            //se obtienen los datos de la url
            id_cli = Convert.ToString(Request.QueryString["id"]);
            nombre = Convert.ToString(Request.QueryString["nombre"]);
            email = Convert.ToString(Request.QueryString["email"]);
            //se asignan los datos al formulario
            id_c.Value =id_cli;
            nombre_c.Value = nombre;
            correo.Value = email;
        }
        protected void actualizar_cli(object sender, EventArgs e)
        { 
            if (nombre_c.Value != null)
            {
                ClienteDTO = new ClienteDTO(id_c.Value, nombre_c.Value, correo.Value );
                ClienteDTO.actualizar();
            }

        }
    }
}