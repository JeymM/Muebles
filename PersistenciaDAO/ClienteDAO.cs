using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Muebles
{
    public class ClienteDAO
    {
        private int id;
        private string nomb;
        private int dcto;
        private string email;
        private string clave;
        public ClienteDAO()
        {

        }

        public ClienteDAO(string id="",string nomb="",string dcto = "",string email="",string clave="")
        {
            this.id = int.Parse(id);
            this.nomb = nomb;
            this.dcto = int.Parse(dcto);
            this.email = email;
            this.clave = clave;
        }

        //no se utiliza
        public string Buscar(string filtro)
        {
            return "select * from `cliente` where nombre like'" + filtro + "%'limit 7 ";
        }


        public string Consultar()
        {
            return "Select * from cliente where id=" + id + "";
        }
        public string Consulta_T()
        {
            return "select * from cliente ";
        }
        public string Insercion ()
        {
            return "insert into cliente (id,nombre,descuento,correo,clave) values (" + id + ",'" + nomb + "', " + dcto + "," + correo + "," + clave + ");";
        }
        public string Actualizacion()
        {
            return "update cliente set " + "nombre='"+nomb+"',"+ "descuento = '"+dcto+ "'," + "correo = '" + correo + "'," + "clave = '" + clave + "' where id=" + id+"";

        }
        public string Eliminar()
        {
            return "DELETE FROM cliente WHERE id="+id + ";";
        }
    }
}


        

        