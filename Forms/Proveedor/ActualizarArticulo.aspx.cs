using Muebles.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Muebles.Forms.Proveedor
{
    public partial class ActualizarArticulo : System.Web.UI.Page
    {
        public string id = "";
        public string descrip = "";
        public string name = "";
        public string cant = "";
        public string prec = "";
        public int estado = 1;

        private ArticuloDTO articuloDTO;
        protected void Page_Load(object sender, EventArgs e)
        {
            //se obtienen los datos de la url
            id = Convert.ToString(Request.QueryString["ide"]);
            cant = Convert.ToString(Request.QueryString["cant"]);
            prec = Convert.ToString(Request.QueryString["prec"]);
            descrip = Convert.ToString(Request.QueryString["descrip"]);
            name = Convert.ToString(Request.QueryString["name"]);
            estado = Convert.ToInt32(Request.QueryString["estado"]);
            if(estado == 1)
            {
                inputEstado.Value = "Activo";
            } else if(estado == 0)
            {
                inputEstado.Value = "Desactivado";
            } else
            {
                inputEstado.Value = "Indefinido";
            }

            //se asignan los datos al formulario
            idProducto.Value = id;
            precio.Value = prec;
            descripcion.Value = descrip;
            nombre.Value = name;
            
        }

        protected void actualizar_cli(object sender, EventArgs e)
        {   //id,stock, precio, desc, nombre
            if(stock.Value != null)
            {
                articuloDTO = new ArticuloDTO(idProducto.Value, stock.Value, precio.Value, descripcion.Value, nombre.Value,estado);
                articuloDTO.actualizar();
            }
            
        }
    }
}