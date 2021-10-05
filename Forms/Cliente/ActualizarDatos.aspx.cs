using Muebles.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Muebles.Forms.Cliente
{
    public partial class ActualizarDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            id_cl.Value = Convert.ToString(Session["id"]);
            correo.Value = (string)Session["correo"];
        }
        protected void actualizar_c(object sender, EventArgs e)
        {

            ClienteDTO ob = new ClienteDTO(id_cl.Value, nombre_c.Value,correo.Value, clave_c.Value, 1);
            ob.actualizarn();


        }
    }
}