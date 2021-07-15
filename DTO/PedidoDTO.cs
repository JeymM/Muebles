using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Muebles.PersistenciaDAO;

namespace Muebles.DTO
{
    public class PedidoDTO
    {
        private int id_ped { get; set; }
        private int id_cliefk { get; set; }
        private double val_to { get; set; }
        private DateTime fecha { get; set; }
        public List<PedidoDTO> pedidos { get => pedidos; set => pedidos = value; }
        private PedidoDAO PED;
        private Conexion conexion;
        public PedidoDTO()
        {
            this.conexion = new Conexion();
            this.PED = new PedidoDAO();
        }

        public PedidoDTO(string id_ped, string id_cliefk, string val_to, string fecha)
        {
            this.conexion = new Conexion();
            this.PED = new PedidoDAO(id_ped,id_cliefk,val_to,fecha);
            this.id_ped = int.Parse(id_ped);
            this.id_cliefk = int.Parse(id_cliefk);
            this.val_to = double.Parse(val_to);
            this.fecha = DateTime.Parse(fecha);

        }
        public void insertar()
        {
            this.conexion.ejecutar(this.PED.Insercion());
            this.conexion.cerrar();
        }

        public List<PedidoDTO> consultarTodos()
        {
            pedidos = new List<PedidoDTO>();


            int i = 0;
            this.conexion.ejecutar(this.PED.Consulta_T());
            PedidoDTO pe;
            while (conexion.resultado.Read())
            {
                pe= new PedidoDTO("" + conexion.resultado.GetInt32(0), conexion.resultado.GetString(1), "" + conexion.resultado.GetInt32(2), "" + conexion.resultado.GetInt32(3));
                pedidos.Add(pe);
                i++;
            }

            this.conexion.cerrar();
            return pedidos;
        }

        public void actualizar()
        {
            this.conexion.ejecutar(this.PED.Actualizacion());
            this.conexion.cerrar();
        }
        public void eliminar()
        {
            this.conexion.ejecutar(this.PED.Eliminar());
            this.conexion.cerrar();
        }
    }
}