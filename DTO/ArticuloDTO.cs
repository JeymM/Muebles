using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Muebles.PersistenciaDAO;

namespace Muebles.DTO
{
    public class ArticuloDTO
    {
        public int ide { get; set; }
        public int id_provee { get; set; }
        public double prec { get; set; }
        public string descrip { get; set; }
        public string nombre { get; set; }
        public int estado { get; set; }

        public List<ArticuloDTO> articulos;
        private ArticuloDAO AD;
        private Conexion conexion;
        public ArticuloDTO()
        {
            this.conexion = new Conexion();
            this.AD = new ArticuloDAO();
        }

        public ArticuloDTO(string ide, string id_provee, string prec, string descrip,string nombre, int estado)
        {
            this.conexion = new Conexion();
            this.AD = new ArticuloDAO(ide, id_provee, prec,descrip,nombre,estado);
            this.ide = int.Parse(ide);
            this.id_provee = int.Parse(id_provee);
            this.prec = double.Parse(prec);
            this.descrip = descrip;
            this.nombre = nombre;
            this.estado = estado;
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
                a = new ArticuloDTO("" + conexion.resultado.GetInt32(0), "" + conexion.resultado.GetInt32(1), "" + conexion.resultado.GetInt32(2), "" + conexion.resultado.GetString(3), "" + conexion.resultado.GetString(4), conexion.resultado.GetInt32(5));
                articulos.Add(a);
                i++;
            }

            this.conexion.cerrar();
            return articulos;
        }
        public List<ArticuloDTO> consultarActivos()
        {
            articulos = new List<ArticuloDTO>();


            int i = 0;
            this.conexion.ejecutar(this.AD.Consultar());
            ArticuloDTO a;
            while (conexion.resultado.Read())
            {
                a = new ArticuloDTO("" + conexion.resultado.GetInt32(0), "" + conexion.resultado.GetInt32(1), "" + conexion.resultado.GetInt32(2), "" + conexion.resultado.GetString(3), "" + conexion.resultado.GetString(4), conexion.resultado.GetInt32(5));
                articulos.Add(a);
                i++;
            }

            this.conexion.cerrar();
            return articulos;
        }
        public ArticuloDTO obtenerArticuloPorID(string idProducto)
        {
            articulos = new List<ArticuloDTO>();


            int i = 0;
            this.conexion.ejecutar(this.AD.obtenerArticuloPorID(idProducto));
            ArticuloDTO a;
            while (conexion.resultado.Read())
            {
                a = new ArticuloDTO("" + conexion.resultado.GetInt32(0), "" + conexion.resultado.GetInt32(1), "" + conexion.resultado.GetInt32(2), "" + conexion.resultado.GetString(3), "" + conexion.resultado.GetString(4), conexion.resultado.GetInt32(5));
                articulos.Add(a);
                i++;
            }

            this.conexion.cerrar();
            return articulos.ElementAt(0);
        }
        public void actualizar()
        {
            this.conexion.ejecutar(this.AD.Actualizacion());
            this.conexion.cerrar();
        }
        public void DescargarStockEnCompra(string stock, string idProducto)
        {
            this.conexion.ejecutar(this.AD.DescargarStockEnCompra(stock, idProducto));
            this.conexion.cerrar();
        }
        public void eliminar()
        {
            this.conexion.ejecutar(this.AD.Eliminar());
            this.conexion.cerrar();
        }
    }
}