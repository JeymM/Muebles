using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Muebles.PersistenciaDAO
{
    public class CompraDAO
    {

        private int id_cliente_fk;
        private int id_art_fk;
        private double valor_total;
        private DateTime fecha_pago;
        private int cantidad;

        public CompraDAO()
        {

        }

        public CompraDAO(string id_cliente_fk, string id_art_fk, string valor_total, string fecha_pago, string cantidad)
        {
            this.id_cliente_fk = int.Parse(id_cliente_fk);
            this.id_art_fk = int.Parse(id_art_fk);
            this.valor_total = double.Parse(valor_total);
            this.fecha_pago = DateTime.Parse(fecha_pago);
            this.cantidad = int.Parse(cantidad);

        }
        public string VentasPorCliente(string idCliente)
        {
            return "select * from `compra` where id_cliente_fk=" + idCliente + "";
        }
        public string VentasPorProducto(string idProducto)
        {
            return "select * from `compra` where id_art_fk=" + idProducto + "";
        }
        public string VentasPorFecha(string Fecha)
        {
            return "select * from `compra` where fecha_pago='" + Fecha + "'";
        }
        public string ConsultarTodasLasVentas()
        {
            return "Select * from compra";
        }
        public string Insercion()
        {
            return "INSERT INTO `compra` (`id_cliente_fk`, `id_art_fk`, `valor_total`, `fecha_pago`, `cantidad`) VALUES(" + this.id_cliente_fk + "," + this.id_art_fk + ", " + this.valor_total + ",'" + this.fecha_pago + "',"+this.cantidad+");";
        }
        //actualizar y eliminar no son necesarios por cuestiones de seguridad
    }
}