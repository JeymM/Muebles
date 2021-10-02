using Muebles.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Muebles.Forms.Proveedor
{
    public partial class articulo : System.Web.UI.Page
    {
        ArticuloDTO ar;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botonCli_Click(object sender, EventArgs e)
        {   //id,stock, precio, desc, nombre
            ar = new ArticuloDTO(idProducto.Value, stock.Value, precio.Value, descripcion.Value, nombre.Value, 1);
            ar.insertar();
            vaciarCampos();
        }
        protected void vaciarCampos()
        {
            idProducto.Value = "";
            stock.Value = "";
            precio.Value = "";
            descripcion.Value = "";
            nombre.Value = "";
        }
    }
}