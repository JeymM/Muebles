using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Muebles
{
    public class ClienteDAO
    {
        public string id;
        public string nomb;
        public string correo;
        public string clave;
        public int estado;
        public ClienteDAO()
        {

        }

        public ClienteDAO(string id,string nomb,string correo,string clave, int estado)
        {
            this.id = id;
            this.nomb = nomb;
            this.correo = correo;
            this.clave = clave;
            this.estado = estado;
        }

        //no se utiliza
        public string Buscar(string filtro)
        {
            return "select * from `cliente` where nombre like'" + filtro + "%'limit 7 ";
        }


        public string Consultar()
        {
            return "Select * from cliente where estado=" + 1 + "";
        }
        public string Consulta_T()
        {
            return "select * from cliente ";
        }
        public string Insercion ()
        {
            return "Insert into cliente(id,nombre,correo,clave,estado) values(" + id + ",'" + nomb + "', '" + correo + "','" + clave + "',"+estado+");";
        }
        public string Actualizacion()
        {
            return "update cliente set " + "estado="+ estado + " where id=" + id + "";
        }
        public string Actualizacionn()
        {
            return "update cliente set " + "nombre='" + nomb + "'," + "clave = '" + clave +  "' where id=" + id + "";
        }
        public string Eliminar()
        {
            return "DELETE FROM cliente WHERE id="+id + ";";
        }
    }
}


        

        