using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Windows;
using System.Web.UI.WebControls;
using Muebles.DTO;

namespace Muebles.Forms.Administrador
{
    public partial class Registro_Usersnew : System.Web.UI.Page
    {
        protected string ingreso { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ingreso = Request.Form["user"];
            
        }
        public void Registrar(object sender,EventArgs e)
        {
            if (ingreso == "Cliente")
            {
                ClienteDTO obj = new ClienteDTO(iduser.Value, nombre.Value, email.Value, clave.Value);
                obj.insertar();
                MessageBox.Show("hello world :");
            }else if (ingreso == "Proveedor")
            {
                ProveedorDTO obj = new ProveedorDTO(iduser.Value,contac.Value,dirección.Value,nombre.Value,email.Value,clave.Value);
                obj.insertar();
                MessageBox.Show("hello world :");
            }else if(ingreso=="Administrador")
            {
                
                AdministradorDTO obj = new AdministradorDTO(iduser.Value,nombre.Value,contac.Value,email.Value,clave.Value);
                obj.insertar();
                MessageBox.Show("hello world :");
            }
            
                   
                       
                       
                    
                   

            }
        }
    }

