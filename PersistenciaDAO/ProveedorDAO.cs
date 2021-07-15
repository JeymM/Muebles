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
        public ProveedorDAO()
        {

        }
        public ProveedorDAO(string nit, string contac, string dir, string nombr,string correo,string clave)
        {
            this.nit = int.Parse(nit);
            this.contac = contac;
            this.dir = dir;
            this.nombr = nombr;
            this.correo = correo;
            this.clave = clave;
        }
        public string Buscar(string filtro)
        {
            return "select * from `proveedor` where nombre like'" + filtro + "%'limit 7 ";
        }
        public string Consultar()
        {
            return "Select * from proveedor where nit='" + nit + "'";
        }
        public string Consulta_T()
        {
            return "Select * from proveedor ";
        }
        public string Insercion()
        {
            return "Insert into proveedor(nit,contacto,direccion,nombre) values(" + nit + ",'" + contac + "', '" + dir + "','"+nombr + "','" + correo + "','" + clave + "');";
        }
        public string Actualizacion()
        {
            return "update proveedor set " + "nombre='" + nombr + "'," + "contacto = '" + contac + "', "+"direccion='"+dir+"',"+"nombre='"+nombr+ "'," + "correo='" + correo + "'," + "clave='" + clave + "' where nit=" + nit+"";
        }
        public string Eliminar()
        {
            return "delete from proveedor WHERE  nit = " + nit + ";";
        }

    }
     
    
}