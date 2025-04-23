using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistemas_CAG.Entidad;

namespace Sistemas_CAG.Logica
{
    internal class DAOSistemaParam:Conexion
    {
        private static DAOSistemaParam con = null;
        private SQLiteCommand conexionCommand;
        private SQLiteDataReader conexionDataReader;
        private DataTable datos;

        public static DAOSistemaParam getInstancia()
        {

            if (con == null)
            {
                con = new DAOSistemaParam();
            }
            return con;
        }


        /// <summary>
        /// Consulta de datos Select
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        public DataTable consultaDatos(string consulta)
        {
            conectar();

            try
            {               
                conexionCommand = new SQLiteCommand(consulta, conectar());
                conexionDataReader = conexionCommand.ExecuteReader();
                datos = new DataTable();

                datos.Load(conexionDataReader);


            }
            catch (SQLiteException ex)
            {
                datos = null;
                MessageBox.Show("Error al realizar consulta SQL: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            finally
            {
                desconectar();
            }
            return datos;
        }

        /// <summary>
        /// Ejecución de sentencias SQL, CRUD
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>

        public bool ejecutaConsulta(string consulta)
        {
            bool result = false;
            conectar();
            try
            {
                int filas = 0;
                conexionCommand = new SQLiteCommand(consulta, conectar());
                filas = conexionCommand.ExecuteNonQuery();

                if (filas > 0)
                {
                    result = true;
                }
                
            }
            catch (SQLiteException ex)
            {
                result = false;
                MessageBox.Show("Error al ejecutar sentencia SQL: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                desconectar();
            }
            return result;
        }




    }
}
