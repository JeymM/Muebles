using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Muebles.Forms
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string url;
        protected void Page_Load(object sender, EventArgs e)
        {
            url = HttpContext.Current.Request.Url.AbsoluteUri;
        }

        protected void UserName_TextChanged(object sender, EventArgs e)
        {
            String passw = (password1.Value);
            String corr = correo.Value;
        }
    }
}