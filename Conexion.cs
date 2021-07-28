using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows;
using MySql.Data.MySqlClient;

namespace Muebles
{
    public class Conexion
    {
        MySqlCommand Query = new MySqlCommand();
        public MySqlDataReader resultado;
        public MySqlConnection conexionBD;
        public void abrir()
        {
           
            string datos = "";
            string cadenaConexion = "server=localhost;port=3306; user id=root;password=;database=tienda;";
            conexionBD = new MySqlConnection(cadenaConexion);

            try
            {
                conexionBD.Open();
                
                /*
                MySqlDataReader reader = null;
                MySqlCommand cmd = new MySqlCommand("show databases", conexionBD);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    datos += reader.GetString(0) + "\n";
                }
                */

            }
            catch (MySqlException ex)
            {
                Console.Write(ex.ToString());
            }
            Console.Write(datos);
        }

        public void cerrar()
        {
            //cerramos conexion
            conexionBD.Close();
        }
        public void ejecutar(string sentencia)
        {
            try
            {
                abrir();
                Query.CommandText = sentencia;
                Query.Connection = conexionBD;
                resultado = Query.ExecuteReader();
                //cerrar();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public int numFilas()
        {
            abrir();
            if (resultado != null)
            {
                int cont = 0;
                while (resultado.Read())
                {
                    cont++;
                }
                cerrar();
                return cont;
            }
            else
            {
                cerrar();
                return 0;
            }
        }

        public bool sentenciaEjecutada()
        {
            if (resultado.HasRows == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}