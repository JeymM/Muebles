using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Muebles.PersistenciaDAO;

namespace Muebles.DTO

{
    public class Tel_ClienteDTO
    {
        private double tel { get; set; }
        private int id_clien { get; set; }
        public List<Tel_ClienteDTO> telclientes { get => telclientes; set => telclientes = value; }
        private  Tel_ClienteDAO TCD;
        private Conexion conexion;

        public Tel_ClienteDTO()
        {
            this.conexion = new Conexion();
            this.TCD = new Tel_ClienteDAO();
        }

        public Tel_ClienteDTO(string tel, string id_clien)
        {
            this.conexion = new Conexion();
            this.TCD = new Tel_ClienteDAO(tel,id_clien);
            this.tel = int.Parse(tel);
            this.id_clien = int.Parse(id_clien);
        }
        public void insertar()
        {
            this.conexion.ejecutar(this.TCD.Insercion());
            this.conexion.cerrar();
        }

        public List<Tel_ClienteDTO> consultarTodos()
        {
            telclientes = new List<Tel_ClienteDTO>();


            int i = 0;
            this.conexion.ejecutar(this.TCD.Consulta_T());
            Tel_ClienteDTO tc;
            while (conexion.resultado.Read())
            {
                tc = new Tel_ClienteDTO("" + conexion.resultado.GetInt32(0), conexion.resultado.GetString(1));
                telclientes.Add(tc);
                i++;
            }

            this.conexion.cerrar();
            return telclientes;
        }

        public void actualizar()
        {
            this.conexion.ejecutar(this.TCD.Actualizacion());
            this.conexion.cerrar();
        }
        public void eliminar()
        {
            this.conexion.ejecutar(this.TCD.Eliminar());
            this.conexion.cerrar();
        }
    }
}