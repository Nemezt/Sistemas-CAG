using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Sistemas_CAG.Logica
{/// <summary>
/// Clase que gestiona la conexón a la BD SQLite
/// </summary>
    internal class Conexion
    {
        private static string Basedatos = "Data Source=./bd_lanzador.db";
        SQLiteConnection conexion = null;

        public SQLiteConnection conectar() {

            try
            {
                conexion = new SQLiteConnection(@Basedatos);
                conexion.Open();
            }
            catch (SQLiteException ex) {
                MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            return conexion;
        }


        public void desconectar()
        {
            if (conexion != null)
            {
                conexion.Close();
            }
        }
    }
}
