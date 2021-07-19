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
            string corr = txtCorreo.Text;
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
            foreach (ClienteDTO clientes  in cl.consultarTodos())
            {       
                if (corr.Equals(clientes.email) && pass.Equals(clientes.clave))//comparar con correo y clave de la BD
                {
                    Session["id"] = clientes.id;
                    Session["nombre"] = clientes.nomb;
                    Session["descuento"] = clientes.dcto;
                    Session["correo"] = clientes.email;
                    Session["clave"] = clientes.clave;

                    switch(drop)
                    {
                        
                        
                    }
                }
            }
        }
    }
}