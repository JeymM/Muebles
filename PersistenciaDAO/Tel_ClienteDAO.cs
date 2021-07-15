using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Muebles
{
    public class Tel_ClienteDAO
    {
        private double tel;
        private int id_clien;

        public Tel_ClienteDAO()
        {

        }

        public Tel_ClienteDAO(string tel,string id_clien)
        {
            this.tel = int.Parse(tel);
            this.id_clien = int.Parse(id_clien);
        }
        public string Buscar(string filtro)
        {
            return "select * from `tel_cliente` where telefono like'" + filtro + "%'limit 5 ";
        }
        public string Consultar()
        {
            return "Select * from tel_cliente where id_fk='" + id_clien + "'";
        }
        public string Consulta_T()
        {
            return "Select * from tel_cliente ";
        }
        public string Insercion()
        {
            return "Insert into tel_cliente (telefono,id_fk) values(" + tel + ",'" + id_clien + "');";
        }
        public string Actualizacion()
        {
            return "update 'tel_cliente' set " + "'telefono'='" + tel + "'where id_fk="+id_clien+"";
        }
        public string Eliminar()
        {
            return "DELETE   FROM tel_cliente WHERE id_fk="+id_clien+";";
        }
        
    }
}