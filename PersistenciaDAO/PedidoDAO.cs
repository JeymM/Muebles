using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Muebles.PersistenciaDAO
{
    public class PedidoDAO
    {
        private int id_ped;
        private int id_cliefk;
        private double val_to;
        private DateTime fecha; 
       
        public PedidoDAO()
        {

        }

        public PedidoDAO(string id_ped, string id_cliefk, string val_to, string fecha)
        {
            this.id_ped = int.Parse(id_ped);
            this.id_cliefk = int.Parse(id_cliefk);
            this.val_to = double.Parse(val_to);
            this.fecha = DateTime.Parse(fecha);

        }
        public string Buscar(string filtro)
        {
            return "select * from `pedido` where fecha_pago like'" + filtro + "%'limit 10 ";
        }
        public string Consultar()
        {
            return "Select * from pedido where id_p=" + id_ped + "";
        }
        public string Consulta_T()
        {
            return "Select * from pedido ";
        }
        public string Insercion()
        {
            return "Insert into pedido(id_p,id_cliente_fk,valor_total,fecha_pago) values(" + id_ped + ",'" + id_cliefk + "', '" + val_to + "','" + fecha + "');";
        }
        public string Actualizacion()
        {
            return "update pedido set " + "id_cliente_fk='" + id_cliefk + "'," + "valor_total = '" + val_to + "' where id_p="+id_ped+"";
        }
        public string Eliminar()
        {
            return "delete from pedido WHERE id_p = " + id_ped + ";";
        }
    }
}