﻿using Muebles.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Muebles.Forms.Cliente
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void Registrarse(object sender, EventArgs e)
        {
            ClienteDTO obj = new ClienteDTO(idc.Value, namec.Value, emailc.Value, clavec.Value, 1);
            obj.insertar();
            string script = String.Format(@"<script type='text/javascript'>alert('Registro exitoso' );</script>", "0033");
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            //MessageBox.Show("Registro exitoso");
            Response.Redirect(Session["url"] + "/index.aspx");
        }
      
    }
}