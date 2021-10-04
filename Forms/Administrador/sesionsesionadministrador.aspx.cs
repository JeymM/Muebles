using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Muebles.Forms.Administrador
{
    public partial class sesionsesionadministrador : System.Web.UI.Page
    {
        string url;
        protected void Page_Load(object sender, EventArgs e)
        {
            url = HttpContext.Current.Request.Url.AbsoluteUri;
          
        }

        protected void salir(object sender, EventArgs e)
        {   //id,stock, precio, desc, nombre
            Response.Redirect(Session["url"] + "Index.aspx");

        }
    }
}