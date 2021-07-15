using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Muebles.DTO
{
    public class Dir_ClienteDTO
    {
        private string direc { get; set; }
        private int id_f { get; set; }
        public List<Dir_ClienteDTO> direcciones { get => direcciones; set => direcciones = value; }
        private Dir_ClienteDAO DCD;
        private Conexion conexion;

        public Dir_ClienteDTO()
        {
            this.conexion = new Conexion();
            this.DCD = new Dir_ClienteDAO();
        }

        public Dir_ClienteDTO(string direc, string id_f)
        {
            this.conexion = new Conexion();
            this.DCD = new Dir_ClienteDAO(direc,id_f);
            this.direc = direc;
            this.id_f = int.Parse(id_f);
        }
        public void insertar()
        {
            this.conexion.ejecutar(this.DCD.Insercion());
            this.conexion.cerrar();
        }

        public List<Dir_ClienteDTO> consultarTodos()
        {
            direcciones = new List<Dir_ClienteDTO>();


            int i = 0;
            this.conexion.ejecutar(this.DCD.Consulta_T());
            Dir_ClienteDTO dc;
            while (conexion.resultado.Read())
            {
                dc = new Dir_ClienteDTO("" + conexion.resultado.GetInt32(0), conexion.resultado.GetString(1));
                direcciones.Add(dc);
                i++;
            }

            this.conexion.cerrar();
            return direcciones;
        }

        public void actualizar()
        {
            this.conexion.ejecutar(this.DCD.Actualizacion());
            this.conexion.cerrar();
        }
        public void eliminar()
        {
            this.conexion.ejecutar(this.DCD.Eliminar());
            this.conexion.cerrar();
        }
    }
}