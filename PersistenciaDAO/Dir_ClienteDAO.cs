using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Muebles
{
    public class Dir_ClienteDAO
    {
        private string direc;
        private int id_f;

        public Dir_ClienteDAO()
        {

        }

        public Dir_ClienteDAO(string direc,string id_f)
        {
            this.direc = direc;
            this.id_f = int.Parse(id_f);
        }
        public string Buscar(string filtro)
        {
            return "select * from `dir_cliente` where direccion like'" + filtro + "%'limit 2 ";
        }
        public string Consultar()
        {
            return "Select * from dir_cliente where id_fk='" + id_f + "'";
        }
        public string Consulta_T()
        {
            return "Select * from dir_cliente ";
        }
        public string Insercion()
        {
            return "Insert into dir_cliente (direccion,id_fk) values('" + direc + "','" + id_f + "');";
        }
        public string Actualizacion()
        {
            return "update dir_cliente set " + "direccion=" + direc + "where id="+id_f+"";
        }
        public string Eliminar()
        {
            return "delete from dir_cliente WHERE id_fk = " + id_f ;
        }
    }
}