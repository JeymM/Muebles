using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Muebles
{
    public class ArticuloDAO
    {
        private int ide;
        private int id_provee;
        private double prec;
        private string descrip;
        private string nombre;
        public string estado;

        public ArticuloDAO()
        {

        }
        
        public ArticuloDAO(string ide,string id_provee,string prec,string descrip,string nombre,string estado)
        {
            this.ide = int.Parse(ide);
            this.id_provee = int.Parse(id_provee);
            this.prec = double.Parse(prec);
            this.descrip = descrip;
            this.nombre = nombre;
            this.estado = estado;
        }
        public string Buscar(string filtro)
        {
            return "select * from `articulo` where id like'" + filtro + "%'limit 10 ";
        }
        public string Consultar()
        {
            return "Select * from articulo where id='" + ide + " '";
        }
        public string Consulta_T()
        {
            return "Select * from articulo ";
        }
        public string Insercion()
        {
            return "Insert into articulo(id,nit_fk,precio,descripcion,nombre,estado) values(" + ide + ",'" + id_provee + "', '" + prec + "','" + descrip + "','" + nombre + "','"+ estado +"');";
        }
        public string Actualizacion()
        {
            return "update articulo set " + "nit_fk='" + id_provee + "'," + "precio = '" + prec + "', " + "descripcion='" + descrip + "', " + "nombre='" + nombre + "'," + "estado = '" + estado + "' where id=" + ide + "";
        }
        public string Eliminar()
        {
            return "delete from articulo WHERE id = " + ide + ";";
        }
    }
}