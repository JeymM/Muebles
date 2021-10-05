using Muebles.PersistenciaDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Muebles.DTO
{
    public class CompraDTO
    {
        private int id_cliente_fk { get; set; }
        private int id_art_fk { get; set; }
        private double valor_total { get; set; }
        private DateTime fecha_pago { get; set; }
        private int cantidad { get; set; }
        public List<CompraDTO> compras { get => compras; set => compras = value; }
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
            this.fecha_pago = DateTime.Parse(fecha_pago);
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
                pe = new CompraDTO("" + conexion.resultado.GetInt32(0), "" + conexion.resultado.GetInt32(1), "" + conexion.resultado.GetInt32(2), conexion.resultado.GetString(3), "" + conexion.resultado.GetInt32(4));
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
            while (conexion.resultado.Read())
            {
                pe = new CompraDTO("" + conexion.resultado.GetInt32(0), "" + conexion.resultado.GetInt32(1), "" + conexion.resultado.GetInt32(2), conexion.resultado.GetString(3), "" + conexion.resultado.GetInt32(4));
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
                pe = new CompraDTO("" + conexion.resultado.GetInt32(0), "" + conexion.resultado.GetInt32(1), "" + conexion.resultado.GetInt32(2), conexion.resultado.GetString(3), "" + conexion.resultado.GetInt32(4));
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
                pe = new CompraDTO("" + conexion.resultado.GetInt32(0), "" + conexion.resultado.GetInt32(1), "" + conexion.resultado.GetInt32(2), conexion.resultado.GetString(3), "" + conexion.resultado.GetInt32(4));
                compras.Add(pe);
                i++;
            }

            this.conexion.cerrar();
            return compras;
        }
    }
}