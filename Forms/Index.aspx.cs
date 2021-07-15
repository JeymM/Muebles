using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Muebles.DTO;
namespace Muebles.Forms
{
    public partial class Index : System.Web.UI.Page
    {
        string url;
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            url = HttpContext.Current.Request.Url.AbsoluteUri;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ps = "hola";
            string drop = (dropList.SelectedValue);
            string user = txtCorreo.Text;
            string pass = txtContrasena.Text;
            /*if (txtContrasena.Text==ps) {
                lblAviso.Text = "La contraseña es correcta";
            }*/
            /*switch(drop)
            {
                case 1="Administrador"
            deshabilitar las otras dos opciones en este case
            con esto simplemente realizamos la consulta de abajo en la tabla de administrador
                       
            }*/
            ClienteDTO cl = new ClienteDTO();
            foreach (ClienteDTO cliente  in cl.consultarTodos())
            {
                if (user.Equals(cliente.correo) && pass.Equals(cliente.password))//comparar con correo y clave de la BD
                {
                    Session["id"] = cliente.id;
                    Session["nombre"] = cliente.nombre;
                    Session["descuento"] = cliente.desc;

                    switch(drop)
                    {
                        case 1:
                            Response.Redirect(Session["URL"]);
                            break;
                        case 2:
                            Response.Redirect();
                            break;
                        case 4:
                            Response.Redirect();
                            break;
                    }
                }
            }
        }
    }
}