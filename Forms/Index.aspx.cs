using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using Muebles.DTO;
namespace Muebles.Forms
{
    public partial class Index : System.Web.UI.Page
    {
        string url;


        protected void Page_Load(object sender, EventArgs e)
        {
            url = HttpContext.Current.Request.Url.AbsoluteUri;
            Session["url"] = "/Forms";
        }

        protected void BtnIngresar_Click(object sender, EventArgs e)
        {
            string opc = Convert.ToString(Request.Form["dropList"]);
            string corr = Convert.ToString(correo.Value);
            string pass = Convert.ToString(password.Value);
            

            if (opc == "Cliente")
            {
                ClienteDTO cl = new ClienteDTO();
                foreach (ClienteDTO clientes in cl.consultarTodos())
                {
                    if (corr.Equals(clientes.correo) && pass.Equals(clientes.clave))//comparar con correo y clave de la BD
                    {
                        if (clientes.estado == 1)
                        {
                            Session["id"] = clientes.id;
                            Session["nombre"] = clientes.nomb;
                            Session["correo"] = clientes.correo;
                            Session["clave"] = clientes.clave;
                            Response.Redirect(Session["url"] + "/Cliente/sesionsesioncliente.aspx");
                        } else
                        {
                            string script = String.Format(@"<script type='text/javascript'>alert('Usuario desactivado' );</script>", "0033");
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                        }
                    }
                }

            }
            else
            {
                if (opc == "Proveedor")
                {
                    //MessageBox.Show("Correo "+corr + "\nContraseña "+pass);
                    ProveedorDTO p = new ProveedorDTO();
                    foreach (ProveedorDTO proveedores in p.consultarTodos())
                    {
                        if (corr.Equals(proveedores.correo) && pass.Equals(proveedores.clave))//comparar con correo y clave de la BD
                        {
                            if (proveedores.estado == 1)
                            {
                                Session["nit"] = proveedores.nit;
                                Session["contacto"] = proveedores.contac;
                                Session["direccion"] = proveedores.dir;
                                Session["nombre"] = proveedores.nombr;
                                Session["correo"] = proveedores.correo;
                                Session["clave"] = proveedores.clave;

                                Response.Redirect(Session["url"] + "/Proveedor/sesionproveedor.aspx");
                            }
                            else
                            {
                                string script = String.Format(@"<script type='text/javascript'>alert('Usuario desactivado' );</script>", "0033");
                                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                            }

                        }
                        //MessageBox.Show("datos de la db:\n" + proveedores.correo + proveedores.clave);
                    }

                }
                else
                {
                    if (opc == "Administrador")
                    {

                        AdministradorDTO ad = new AdministradorDTO();
                        foreach (AdministradorDTO administradores in ad.consultarTodos())
                        {
                            if (corr.Equals(administradores.correo) && pass.Equals(administradores.clave))//comparar con correo y clave de la BD
                            {
                                if(administradores.estado == 1)
                                {
                                    Session["id_a"] = administradores.id_ad;
                                    Session["nombre"] = administradores.nom;
                                    Session["tel_admi"] = administradores.tel_ad;
                                    Session["correo"] = administradores.correo;
                                    Session["clave"] = administradores.clave;
                                    Response.Redirect(Session["url"] + "/Administrador/sesionsesionadministrador.aspx");
                                }
                                else
                                {
                                    string script = String.Format(@"<script type='text/javascript'>alert('Usuario desactivado' );</script>", "0033");
                                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                                }
                            }
                        }

                    }
                }
            }
        }
        public void btn_Ingresar(object sender, EventArgs e)
        {
            MessageBox.Show("dio click en registrar");
            ClienteDTO obje = new ClienteDTO(idRegistro.Value, nombreRegistro.Value, correoRegistro.Value, passwordRegistro.Value, 1);
            obje.insertar();
            MessageBox.Show("Registro exitoso");
            vaciarCampos();
        }
        protected void vaciarCampos()
        {
            idRegistro.Value = "";
            nombreRegistro.Value = "";
            correo.Value = "";
            passwordRegistro.Value = "";
          
        }
    }
}