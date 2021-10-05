using Muebles.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;

namespace Muebles.Forms.Cliente
{
    public partial class Carrito : System.Web.UI.Page
    {

        List<ArticuloDTO> listaProductos = new List<ArticuloDTO>();
        List<String> listID = new List<string>();
        List<String> listName = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int i = 0;
                ArticuloDTO ar = new ArticuloDTO();
                foreach (ArticuloDTO arti in ar.consultarActivos())
                {
                    listaProductos.Add(arti);
                    listID.Add("id" + i);
                    i = i++;
                }
            }
            

        }
        public void listaCarrito()
        {
            ArticuloDTO ar = new ArticuloDTO();
            int i = 0;
            foreach (ArticuloDTO arti in ar.consultarActivos())
            {

                Response.Write("<tr>");
                Response.Write("<td>" + arti.ide + "</td>");
                Response.Write("<td>" + arti.prec + "</td>");
                Response.Write("<td>" + arti.nombre + "</td>");
                Response.Write("<td>" + arti.descrip + "</td>");
                Response.Write("<td>" + arti.id_provee + "</td>");
                Response.Write("</tr>");

                
                System.Diagnostics.Debug.WriteLine("nombre "+arti.nombre);
                
                

                i = i + 1;
            }

            foreach (string name in listName)
            {
                System.Diagnostics.Debug.WriteLine(name);
            }
        }
        public void showItems()
        {
            foreach (string name in listName)
            {
                Response.Write(name);
            }
        }
        protected void registrar_com(object sender, EventArgs e)
        {

            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (
                    Convert.ToInt32(idProducto.Value) == listaProductos.ElementAt(i).ide &&
                    Convert.ToInt32(stock.Value) <= listaProductos.ElementAt(i).id_provee
                    )
                {
                    System.Diagnostics.Debug.WriteLine("el id ingresado existe!! id: " + idProducto.Value);
                    listName.Add(listaProductos.ElementAt(i).nombre + " x " + stock.Value);
                    //aca toca hacer de registrar el producto

                    //se crea un pedido (si creas un capo para idarticulo dentro de la tabla pedido, 
                    //y añades ese campo en dao y dto te ahorras usar tambien el articulo_pedido que usa una llave compuesta)

                    //se crea un articulo_pedido

                    //se hace un update que elimine el stock que sacamos del producto, es decir que haga
                    //un update que reste la cantidad de stock que se saco.
                }

            }

        }

        

    }
}