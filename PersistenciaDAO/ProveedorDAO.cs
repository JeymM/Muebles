using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Muebles
{
    public class ProveedorDAO
    {
        private int nit;
        private string contac;
        private string dir;
        private string nombr;
        private string correo;
        private string clave;
        private int estado;
        public ProveedorDAO()
        {

        }
        public ProveedorDAO(string nit, string contac, string dir, string nombr,string correo,string clave, int estado)
        {
            this.nit = int.Parse(nit);
            this.contac = contac;
            this.dir = dir;
            this.nombr = nombr;
            this.correo = correo;
            this.clave = clave;
            this.estado = estado;
        }
        public string Buscar(string filtro)
        {
            return "select * from `proveedor` where nombre like'" + filtro + "%'limit 7 ";
        }
        public string ConsultarActivos()
        {
            return "Select * from proveedor where estado=" + 1 + "";
        }
        public string Consulta_T()
        {
            return "Select * from proveedor ";
        }
        public string Insercion()
        {
            return "Insert into proveedor(nit,contacto,direccion,nombre,correo,clave, estado) values(" + nit + ",'" + contac + "', '" + dir + "','"+nombr + "','" + correo + "','" + clave + "',"+estado+");";
        }
        public string Actualizacion()
        {
            return "update proveedor set " + "nombre='" + nombr + "'," + "contacto = '" + contac + "', "+"direccion='"+dir+"',"+"nombre='"+nombr+ "'," + "correo='" + correo + "'," + "clave='" + clave + "', estado=" + estado +" where nit=" + nit+"";
        }
        public string ActualizacionEstado()
        {
            return "update proveedor set " + "estado=" + estado + " where nit=" + nit + "";
        }
        public string Eliminar()
        {
            return "delete from proveedor WHERE  nit = " + nit + ";";
        }

    }
     
    
}