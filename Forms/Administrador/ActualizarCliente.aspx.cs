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
        public string id_client = "";
        public string nombreClient = "";
        public string emailClient = "";
        public int estado = -1;
        private ClienteDTO ClienteDTO;
        string inputEstado = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //se obtienen los datos de la url
            id_client = Convert.ToString(Request.QueryString["id"]);
            nombreClient = Convert.ToString(Request.QueryString["name"]);
            emailClient = Convert.ToString(Request.QueryString["correo"]);
            estado = Convert.ToInt32(Request.QueryString["estado"]);
            

            //se asigna al input el estado actual
            if (estado == 1)
            {
                inputEstado = "Activo";
            }
            else if (estado == 0)
            {
                inputEstado = "Desactivado";
            }
            else
            {
                inputEstado = "Indefinido";
            }

            //se asignan los datos al formulario
            id_c.Value = id_client;
            nombre_c.Value = nombreClient;
            correo.Value = emailClient;
        }
        protected void actualizar_cli(object sender, EventArgs e)
        {
            inputEstado = Request.Form["selectedState"];
            if (inputEstado == "Activo")
            {
                estado = 1;
            }
            else if (inputEstado == "Desactivado")
            {
                estado = 0;
            }


            ClienteDTO = new ClienteDTO(id_client, nombreClient, emailClient, "", estado);
            ClienteDTO.actualizar();


        }
    }
}