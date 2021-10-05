using Muebles.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Muebles.Forms.Administrador
{
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ida.Value = Convert.ToString(Session["id_a"]);
            name.Value = (string)Session["nom"];
            correo.Value = (string)Session["correo"];
        }
        protected void actualizar_adm(object sender, EventArgs e)
        {

            AdministradorDTO obje = new AdministradorDTO(ida.Value, name.Value,tel.Value, correo.Value, clave_a.Value, 1);
            obje.actualizar();


        }
    }
}