using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Muebles.DTO
{
    public class AdministradorDTO
    {
        public int id_ad { get; set; }
        public string nom { get; set; }
        public int tel_ad { get; set; }
        public string correo { get; set; }
        public string clave { get; set; }
        public int estado { get; set; }
        public List<AdministradorDTO> administradores;
        private AdministradorDAO AD;
        private Conexion conexion;

        public AdministradorDTO()
        {
            this.conexion = new Conexion();
            this.AD = new AdministradorDAO();
        }

        public AdministradorDTO(string id_ad, string nom, string tel_ad,string correo,string clave, int estado)
        {
            this.conexion = new Conexion();
            this.AD = new AdministradorDAO(id_ad,nom,tel_ad,correo,clave, estado);
            this.id_ad = int.Parse(id_ad);
            this.nom = nom;
            this.tel_ad = int.Parse(tel_ad);
            this.correo = correo;
            this.clave = clave;
            this.estado = estado;
        }
        public void insertar()
        {
            this.conexion.ejecutar(this.AD.Insercion());
            this.conexion.cerrar();
        }
        public List<AdministradorDTO> consultarTodos()
        {
            administradores = new List<AdministradorDTO>();


            int i = 0;
            this.conexion.ejecutar(this.AD.Consulta_T());
            AdministradorDTO a;
            while (conexion.resultado.Read())
            {
                a = new AdministradorDTO("" + conexion.resultado.GetInt32(0), conexion.resultado.GetString(1), "" + conexion.resultado.GetInt32(2), "" + conexion.resultado.GetString(3), "" + conexion.resultado.GetString(4), conexion.resultado.GetInt32(5));
                administradores.Add(a);
                i++;
            }

            this.conexion.cerrar();
            return administradores;
        }
        public void actualizar()
        {
            this.conexion.ejecutar(this.AD.Actualizacion());
            this.conexion.cerrar();
        }
        public void consultar()
        {
            this.conexion.ejecutar(this.AD.Consultar());
            this.conexion.cerrar();
        }
        public void eliminar()
        {
            this.conexion.ejecutar(this.AD.Eliminar());
            this.conexion.cerrar();
        }
    }
}