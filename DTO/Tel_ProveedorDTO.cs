using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Muebles.DTO
{
    public class Tel_ProveedorDTO
    {
        private int tele { get; set; }
        private int id_prove { get; set; }
        public List<Tel_ProveedorDTO> telproveedor { get => telproveedor; set => telproveedor = value; }
        private Tel_proveedorDAO TPD;
        private Conexion conexion;
        public Tel_ProveedorDTO()
        {
            this.conexion = new Conexion();
            this.TPD = new Tel_proveedorDAO();
        }
        public Tel_ProveedorDTO(string tele, string id_prove)
        {
            this.conexion = new Conexion();
            this.TPD = new Tel_proveedorDAO(tele,id_prove);
            this.tele = int.Parse(tele);
            this.id_prove = int.Parse(id_prove);
        }
        public void insertar()
        {
            this.conexion.ejecutar(this.TPD.Insercion());
            this.conexion.cerrar();
        }

        public List<Tel_ProveedorDTO> consultarTodos()
        {
            telproveedor = new List<Tel_ProveedorDTO>();


            int i = 0;
            this.conexion.ejecutar(this.TPD.Consulta_T());
            Tel_ProveedorDTO tp;
            while (conexion.resultado.Read())
            {
                tp = new Tel_ProveedorDTO("" + conexion.resultado.GetInt32(0), conexion.resultado.GetString(1));
                telproveedor.Add(tp);
                i++;
            }

            this.conexion.cerrar();
            return telproveedor;
        }

        public void actualizar()
        {
            this.conexion.ejecutar(this.TPD.Actualizacion());
            this.conexion.cerrar();
        }
        public void eliminar()
        {
            this.conexion.ejecutar(this.TPD.Eliminar());
            this.conexion.cerrar();
        }
    }
}