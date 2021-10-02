using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Muebles.PersistenciaDAO;

namespace Muebles.DTO
{
    public class ClienteDTO
    {
        public string id { get; set; }
        public string nomb { get; set; }
        public string correo { get; set; }
        public string clave { get; set; }
        public int estado { get; set; }
        public List<ClienteDTO> clientes;
        private ClienteDAO CD;
        private Conexion conexion;
        public ClienteDTO()
        {
            this.conexion = new Conexion();
            this.CD = new ClienteDAO();
        }

        public ClienteDTO(string id, string nomb,string correo,string clave, int estado)
        {
            this.conexion = new Conexion();
            this.id = id;
            this.nomb = nomb;
            this.correo = correo;
            this.clave = clave;
            this.estado = estado;
            this.CD = new ClienteDAO(id, nomb, correo, clave, estado);
        }
        
        public void insertar()
        {
            this.conexion.ejecutar(this.CD.Insercion());
            this.conexion.cerrar();
        }

        public List<ClienteDTO> consultarTodos()
        {
            clientes = new List<ClienteDTO>();


            int i = 0;
            this.conexion.ejecutar(this.CD.Consulta_T());
            ClienteDTO c;
            while (conexion.resultado.Read())
            {
                c = new ClienteDTO("" + conexion.resultado.GetString(0), conexion.resultado.GetString(1), "" + conexion.resultado.GetString(2), "" + conexion.resultado.GetString(3), conexion.resultado.GetInt32(4));
                clientes.Add(c);
                i++;
            }

            this.conexion.cerrar();
            return clientes;
        }

        public void actualizar()
        {
            this.conexion.ejecutar(this.CD.Actualizacion());
            this.conexion.cerrar();
        }
        public void eliminar()
        {
            this.conexion.ejecutar(this.CD.Eliminar());
            this.conexion.cerrar();
        }
    }
}