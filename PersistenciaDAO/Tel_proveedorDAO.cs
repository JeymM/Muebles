using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Muebles
{
    public class Tel_proveedorDAO
    {
        private int tele;
        private int id_prove;
        public Tel_proveedorDAO()
        {

        }
        public Tel_proveedorDAO(string tele,string id_prove)
        {
            this.tele = int.Parse(tele);
            this.id_prove = int.Parse(id_prove);

        }
        public string Buscar(string filtro)
        {
            return "select * from `tel_prov` where telefono like'" + filtro + "%'limit 5 ";
        }
        public string Consultar()
        {
            return "Select * from tel_prov where nit_fk='" + id_prove + "'";
        }
        public string Consulta_T()
        {
            return "Select * from tel_prov ";
        }
        public string Insercion()
        {
            return "Insert into tel_prov (telefono,nit_fk) values(" + tele + ",'" + id_prove + "');";
        }
        public string Actualizacion()
        {
            return "update tel_prov set " + "telefono='" + tele + "'where nit="+id_prove+"";
        }
        public string Eliminar()
        {
            return "delete from tel_prov WHERE nit_fk = " +id_prove + ";";
        }
    }
}