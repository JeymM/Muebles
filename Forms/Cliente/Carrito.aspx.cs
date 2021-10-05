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
        private const string Format = "yyyy-MM-dd HH:mm:ss";
        List<ArticuloDTO> listaProductos = new List<ArticuloDTO>();
        List<String> listID = new List<string>();
        List<String> listName = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
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
                    //creamos el objeto comprar del producto
                    double valorTotal = Convert.ToInt32(listaProductos.ElementAt(i).prec) * Convert.ToInt32(stock.Value);
                    string fechaCompra = DateTime.Now.ToString(Format);

                    System.Diagnostics.Debug.WriteLine("id cliente: " + Session["id"] + "" +
                        "\nfechaCompra: " + fechaCompra + " \nvalorTotal: " + valorTotal);

                    CompraDTO obj = new CompraDTO(Convert.ToString(Session["id"]), idProducto.Value, Convert.ToString(valorTotal), Convert.ToString(fechaCompra), stock.Value);
                    obj.insertar();

                    int stockActual = listaProductos.ElementAt(i).id_provee - Convert.ToInt32(stock.Value);
                    //se hace un update que elimine el stock que sacamos del producto, es decir que haga
                    //un update que reste la cantidad de stock que se saco.
                    ArticuloDTO ar = new ArticuloDTO();
                    ar.DescargarStockEnCompra(Convert.ToString(stockActual), idProducto.Value);
                }

            }

        }

        

    }
}