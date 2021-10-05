using Muebles.PersistenciaDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Muebles.DTO
{
    public class CompraDTO
    {
        public int id_cliente_fk { get; set; }
        public int id_art_fk { get; set; }
        public double valor_total { get; set; }
        public string fecha_pago { get; set; }
        public int cantidad { get; set; }
        public List<CompraDTO> compras;
        private CompraDAO PED;
        private Conexion conexion;
        public CompraDTO()
        {
            this.conexion = new Conexion();
            this.PED = new CompraDAO();
        }

        public CompraDTO(string id_cliente_fk, string id_art_fk, string valor_total, string fecha_pago, string cantidad)
        {
            this.conexion = new Conexion();
            this.PED = new CompraDAO(id_cliente_fk, id_art_fk, valor_total, fecha_pago, cantidad);
            this.id_cliente_fk = int.Parse(id_cliente_fk);
            this.id_art_fk = int.Parse(id_art_fk);
            this.valor_total = double.Parse(valor_total);
            this.fecha_pago = fecha_pago + "";
            this.cantidad = int.Parse(cantidad);

        }
        public void insertar()
        {
            this.conexion.ejecutar(this.PED.Insercion());
            this.conexion.cerrar();
        }

        public List<CompraDTO> ConsultarTodasLasVentas()
        {
            compras = new List<CompraDTO>();


            int i = 0;
            this.conexion.ejecutar(this.PED.ConsultarTodasLasVentas());
            CompraDTO pe;
            while (conexion.resultado.Read())
            {
                pe = new CompraDTO("" + conexion.resultado.GetInt32(1), "" + conexion.resultado.GetInt32(2), "" + conexion.resultado.GetDouble(3), "" + conexion.resultado.GetMySqlDateTime(4), "" + conexion.resultado.GetInt32(5));
                compras.Add(pe);
                i++;
            }


            this.conexion.cerrar();
            return compras;
        }

        public List<CompraDTO> VentasPorCliente(string idCliente)
        {
            compras = new List<CompraDTO>();


            int i = 0;
            this.conexion.ejecutar(this.PED.VentasPorCliente(idCliente));
            CompraDTO pe;
            System.Diagnostics.Debug.WriteLine(conexion.resultado.HasRows);
            while (conexion.resultado.Read())
            {
                pe = new CompraDTO("" + conexion.resultado.GetInt32(1), "" + conexion.resultado.GetInt32(2), "" + conexion.resultado.GetDouble(3), "" + conexion.resultado.GetMySqlDateTime(4), "" + conexion.resultado.GetInt32(5));
                compras.Add(pe);
                i++;
            }

            this.conexion.cerrar();
            return compras;
        }
        public List<CompraDTO> VentasPorProducto(string idProducto)
        {
            compras = new List<CompraDTO>();


            int i = 0;
            this.conexion.ejecutar(this.PED.VentasPorProducto(idProducto));
            CompraDTO pe;
            while (conexion.resultado.Read())
            {
                pe = new CompraDTO("" + conexion.resultado.GetInt32(1), "" + conexion.resultado.GetInt32(2), "" + conexion.resultado.GetDouble(3), "" + conexion.resultado.GetMySqlDateTime(4), "" + conexion.resultado.GetInt32(5));
                compras.Add(pe);
                i++;
            }

            this.conexion.cerrar();
            return compras;
        }
        public List<CompraDTO> VentasPorFecha(string Fecha)
        {
            compras = new List<CompraDTO>();


            int i = 0;
            this.conexion.ejecutar(this.PED.VentasPorFecha(Fecha));
            CompraDTO pe;
            while (conexion.resultado.Read())
            {
                pe = new CompraDTO("" + conexion.resultado.GetInt32(1), "" + conexion.resultado.GetInt32(2), "" + conexion.resultado.GetDouble(3), "" + conexion.resultado.GetMySqlDateTime(4), "" + conexion.resultado.GetInt32(5));
                compras.Add(pe);
                i++;
            }

            this.conexion.cerrar();
            return compras;
        }
    }
}