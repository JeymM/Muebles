using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Windows;
using System.Web.UI.WebControls;

namespace Muebles.Forms.Administrador
{
    public partial class Registro_Usersnew : System.Web.UI.Page
    {
        protected string ingreso { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ingreso = Request.Form["user"];
            MessageBox.Show("El usuario registrado es :" , ingreso );
        }
        public void Registrar(object sender,EventArgs e)
        {
            if (ingreso.Equals("Cliente"))
            {
                MessageBox.Show("El usuario registrado es :", ingreso);
            }
        }
    }
}
