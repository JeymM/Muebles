using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Muebles
{
    public class Articulo_pedidoDAO
    {
        private int id_arti;
        private int id_pedi;
        private int cant;
        private double total_pag;

        public Articulo_pedidoDAO()
        {

        }
        public Articulo_pedidoDAO(string id_arti, string id_pedi,string cant,string total_pag)
        {
            this.id_arti = int.Parse(id_arti);
            this.id_pedi = int.Parse(id_pedi);
            this.cant = int.Parse(cant);
            this.total_pag = double.Parse(total_pag);
        }

        public string Buscar(string filtro1,string filtro2)
        {
            return "select * from `articulo_pedido` where id_art_fk,id_ped_fk like'" + filtro1 + "%','" + filtro2 + "%',limit 10 ";
        }
        public string Consultar()
        {
            return "Select * from articulo_pedido where id_ped_fk='" + id_pedi + "'";
        }
        public string Consulta_T()
        {
            return "Select * from articulo_pedido ";
        }
        public string Insercion()
        {
            return "Insert into articulo_pedido(id_art_fk,id_ped_fk,cantidad,valor_total) values(" + id_arti + ",'" + id_pedi + "', '" + cant + "','" + total_pag + "');";
        }
        public string Actualizacion()
        {
            return "update articulo_pedido set " + "'id_art_fk'='" + id_arti + "'," + "'id_ped_fk' = '" + id_pedi + "', " + "'valor_total'='" + total_pag + "'where id Arti="+id_arti+"";
        }
        public string Eliminar()
        {
            return "delete from articulo_pedido WHERE id_art_fk = '" + id_arti + "';";
        }
    }
}