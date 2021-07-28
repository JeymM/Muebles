using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows;

namespace Muebles.DTO
{
    public class ProveedorDTO
    {
        public int nit { get; set; }
        public string contac { get; set; }
        public string dir { get; set; }
        public string nombr { get; set; }
        public string correo { get; set; }
        public string clave { get; set; }
        public List<ProveedorDTO> proveedores;
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
            this.correo = correo;
            this.clave = clave;
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
                p = new ProveedorDTO("" + conexion.resultado.GetInt32(0), conexion.resultado.GetString(1), "" + conexion.resultado.GetString(2), "" + conexion.resultado.GetString(3), "" + conexion.resultado.GetString(4), "" + conexion.resultado.GetString(5));
                proveedores.Add(p);
                //MessageBox.Show("datos de la db:\n" + proveedores[i].correo + proveedores[i].clave);
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