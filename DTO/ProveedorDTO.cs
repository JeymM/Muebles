using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Muebles.DTO
{
    public class ProveedorDTO
    {
        private int nit { get; set; }
        private string contac { get; set; }
        private string dir { get; set; }
        private string nombr { get; set; }
        private string correo { get; set; }
        private string clave { get; set; }
        public List<ProveedorDTO> proveedores { get => proveedores; set => proveedores = value; }
        private ProveedorDAO PD;
        private Conexion conexion;
        public ProveedorDTO()
        {
            this.conexion = new Conexion();
            this.PD = new ProveedorDAO();
        }
        public ProveedorDTO(string nit, string contac, string dir, string nombr,string correo,string clave)
        {
            this.conexion = new Conexion();
            this.PD = new ProveedorDAO(nit,contac,dir,nombr,correo,clave);
            this.nit = int.Parse(nit);
            this.contac = contac;
            this.dir = dir;
            this.nombr = nombr;
        }
        public void insertar()
        {
            this.conexion.ejecutar(this.PD.Insercion());
            this.conexion.cerrar();
        }

        public List<ProveedorDTO> consultarTodos()
        {
            proveedores = new List<ProveedorDTO>();


            int i = 0;
            this.conexion.ejecutar(this.PD.Consulta_T());
            ProveedorDTO p;
            while (conexion.resultado.Read())
            {
                p = new ProveedorDTO("" + conexion.resultado.GetInt32(0), conexion.resultado.GetString(1), "" + conexion.resultado.GetInt32(2), "" + conexion.resultado.GetInt32(3), "" + conexion.resultado.GetInt32(4), "" + conexion.resultado.GetInt32(5));
                proveedores.Add(p);
                i++;
            }

            this.conexion.cerrar();
            return proveedores;
        }

        public void actualizar()
        {
            this.conexion.ejecutar(this.PD.Actualizacion());
            this.conexion.cerrar();
        }
        public void eliminar()
        {
            this.conexion.ejecutar(this.PD.Eliminar());
            this.conexion.cerrar();
        }
    }
}