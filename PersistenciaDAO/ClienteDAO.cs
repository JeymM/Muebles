using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Muebles
{
    public class ClienteDAO
    {
        public int id;
        public string nomb;
        public string correo;
        public string clave;
        public ClienteDAO()
        {

        }

        public ClienteDAO(string id="",string nomb="",string correo="",string clave="")
        {
            this.id = int.Parse(id);
            this.nomb = nomb;
            this.correo = correo;
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
            return "Insert into cliente(id,nombre,correo,clave) values(" + id + ",'" + nomb + "', '" + correo + "','" + clave + "');";
        }
        public string Actualizacion()
        {
            return "update cliente set " + "nombre='" + correo + "','" + clave + "' where id = " + id + "";

        }
        public string Eliminar()
        {
            return "DELETE FROM cliente WHERE id="+id + ";";
        }
    }
}


        

        