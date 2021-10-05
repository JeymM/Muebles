using Muebles.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Muebles.Forms.Proveedor
{
    public partial class Actualizacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            id_p.Value=Convert.ToString(Session["nit"]);
            nombre_p.Value = (string)Session["nombr"];
            correo.Value =(string) Session["correo"];
            

        }
        protected void actualizar_pro(object sender, EventArgs e)
        {
           
            ProveedorDTO obj = new ProveedorDTO(id_p.Value,contact.Value,dir_p.Value,nombre_p.Value,correo.Value,clave_p.Value,1);
            obj.actualizar();


        }
    }
}