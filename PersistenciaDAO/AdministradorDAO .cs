using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Muebles
{
    public class AdministradorDAO
    {
        private int id_ad;
        private string nom;
        private int tel_ad;
        private string correo;
        private string clave;

        public AdministradorDAO()
        {

        }

        public AdministradorDAO(string id_ad,string nom,string tel_ad, string correo, string clave)
        {
            this.id_ad = int.Parse(id_ad);
            this.nom = nom;
            this.tel_ad = int.Parse(tel_ad);
            this.correo = correo;
            this.clave = clave;
        }
        public string Buscar(string filtro)
        {
            return "select * from administrador where nombre like'" + filtro + "%'limit 5 ";
        }
        public string Consultar()
        {
            return "Select * from administrador where id_a='" + id_ad + "'";
        }
        public string Consulta_T()
        {
            return "Select * from administrador ";
        }
        public string Insercion()
        {
            return "Insert into administrador(id_a,nombre,tel_admi,correo,clave) values(" + id_ad + ",'" + nom + "', '" + tel_ad + "', '" + correo + "','" + clave + "');";
        }
        public string Actualizacion()
        {
            return "update administrador set " + "nombre='" + nom + "'," + "'tel_admi' = '" + tel_ad + "'," + "'correo' = '" + correo + "'," + "'clave' = '" + clave + "'where id Admin=" + id_ad+"";
        }

        public string Eliminar()
        {
            return "delete from administrador WHERE id_a = '" + id_ad+ "';";
        }

    }
}