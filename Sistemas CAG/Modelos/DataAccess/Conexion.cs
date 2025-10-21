using System.Data;
using System.Data.SQLite;


namespace Sistemas_CAG.Modelos.DataAccess
{
    /// <summary>
    /// Clase que gestiona la conexón a la BD SQLite
    /// </summary>
    internal class Conexion
    {
        static string baseDir = AppDomain.CurrentDomain.BaseDirectory;
        private static string Basedatos = $"Data Source={Path.Combine(baseDir, "bd_lanzador.db")}";
        SQLiteConnection conexion = null;
        
        public SQLiteConnection Conectar()
        {
            if (conexion == null)
            {
                conexion = new SQLiteConnection(Basedatos);
            }
            if (conexion.State != ConnectionState.Open)
            {
                try
                {
                    conexion = new SQLiteConnection(@Basedatos);
                    conexion.Open();
                }
                catch (SQLiteException ex)
                {
                    File.AppendAllText("C:\\temp\\logErrorLanzador.txt", $"[{DateTime.Now}] ERROR: {ex.Message}\n");
                    throw new Exception("Error al conectarse a la base de datos:", ex);

                }

            }

            return conexion;
        }

        public void Desconectar()
        {
            if (conexion != null)
            {
                conexion.Close();
            }
        }
    }
}
