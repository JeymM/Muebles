using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Muebles.PersistenciaDAO;

namespace Muebles.DTO
{
    public class Articulo_PedidoDTO
    {
        private int id_arti { get; set; }
        private int id_pedi { get; set; }
        private int cant { get; set; }
        private double total_pag { get; set; }
        public List<Articulo_PedidoDTO> ArtPed { get => ArtPed; set => ArtPed = value; }
        private Articulo_pedidoDAO APD;
        private Conexion conexion;

        public Articulo_PedidoDTO()
        {
            this.conexion = new Conexion();
            this.APD = new Articulo_pedidoDAO();
        }
        public Articulo_PedidoDTO(string id_arti, string id_pedi, string cant, string total_pag)
        {
            this.conexion = new Conexion();
            this.APD = new Articulo_pedidoDAO(id_arti,id_pedi,cant,total_pag);
            this.id_arti = int.Parse(id_arti);
            this.id_pedi = int.Parse(id_pedi);
            this.cant = int.Parse(cant);
            this.total_pag = double.Parse(total_pag);
        }
        public void insertar()
        {
            this.conexion.ejecutar(this.APD.Insercion());
            this.conexion.cerrar();
        }

        public List<Articulo_PedidoDTO> consultarTodos()
        {
           ArtPed = new List<Articulo_PedidoDTO>();


            int i = 0;
            this.conexion.ejecutar(this.APD.Consulta_T());
            Articulo_PedidoDTO ap;
            while (conexion.resultado.Read())
            {
                ap = new Articulo_PedidoDTO("" + conexion.resultado.GetInt32(0), conexion.resultado.GetString(1), "" + conexion.resultado.GetInt32(2), "" + conexion.resultado.GetInt32(3));
                ArtPed.Add(ap);
                i++;
            }

            this.conexion.cerrar();
            return ArtPed;
        }

        public void actualizar()
        {
            this.conexion.ejecutar(this.APD.Actualizacion());
            this.conexion.cerrar();
        }
        public void eliminar()
        {
            this.conexion.ejecutar(this.APD.Eliminar());
            this.conexion.cerrar();
        }
    }
}