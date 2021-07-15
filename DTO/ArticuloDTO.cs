using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Muebles.PersistenciaDAO;

namespace Muebles.DTO
{
    public class ArticuloDTO
    {
        private int ide { get; set; }
        private int id_provee { get; set; }
        private double prec { get; set; }
        private string descrip { get; set; }
        private string nombre { get; set; }
        public List<ArticuloDTO> articulos { get => articulos; set => articulos = value; }
        private ArticuloDAO AD;
        private Conexion conexion;
        public ArticuloDTO()
        {
            this.conexion = new Conexion();
            this.AD = new ArticuloDAO();
        }

        public ArticuloDTO(string ide, string id_provee, string prec, string descrip,string nombre)
        {
            this.conexion = new Conexion();
            this.AD = new ArticuloDAO(ide, id_provee, prec,descrip,nombre);
            this.ide = int.Parse(ide);
            this.id_provee = int.Parse(id_provee);
            this.prec = double.Parse(prec);
            this.descrip = descrip;
        }
        public void insertar()
        {
            this.conexion.ejecutar(this.AD.Insercion());
            this.conexion.cerrar();
        }

        public List<ArticuloDTO> consultarTodos()
        {
            articulos = new List<ArticuloDTO>();


            int i = 0;
            this.conexion.ejecutar(this.AD.Consulta_T());
            ArticuloDTO a;
            while (conexion.resultado.Read())
            {
                a = new ArticuloDTO("" + conexion.resultado.GetInt32(0), conexion.resultado.GetString(1), "" + conexion.resultado.GetInt32(2), "" + conexion.resultado.GetInt32(3), "" + conexion.resultado.GetInt32(4));
                articulos.Add(a);
                i++;
            }

            this.conexion.cerrar();
            return articulos;
        }

        public void actualizar()
        {
            this.conexion.ejecutar(this.AD.Actualizacion());
            this.conexion.cerrar();
        }public void eliminar()
        {
            this.conexion.ejecutar(this.AD.Eliminar());
            this.conexion.cerrar();
        }
    }
}