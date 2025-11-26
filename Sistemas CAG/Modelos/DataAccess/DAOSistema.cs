using System.Data;
using System.Data.SQLite;



namespace Sistemas_CAG.Modelos.DataAccess
{
    internal class DAOSistema : Conexion
    {
        private static DAOSistema con = null;
        private SQLiteCommand conexionCommand;
        private SQLiteDataReader conexionDataReader;
        private DataTable datos;
        public static DAOSistema GetInstancia()
        {

            if (con == null)
            {
                con = new DAOSistema();
            }
            return con;
        }

        public DataTable ConsultaDatos(string consulta)
        {
            Conectar();

            try
            {
                conexionCommand = new SQLiteCommand(consulta, Conectar());
                conexionDataReader = conexionCommand.ExecuteReader();
                datos = new DataTable();

                datos.Load(conexionDataReader);


            }
            catch (SQLiteException ex)
            {
                File.AppendAllText("C:\\temp\\logErrorLanzador.txt", $"[{DateTime.Now}] ERROR: {ex.Message}\n");
                datos = null;
                throw new Exception("Error al realizar consulta SQL", ex);

            }
            finally
            {
                Desconectar();
            }
            return datos;
        }

        public DataTable ConsultaDatos(string consulta, Dictionary<string, object> parametros)
        {
            DataTable datos = new DataTable();
            Conectar();

            try
            {
                conexionCommand = new SQLiteCommand(consulta, Conectar());

                if (parametros != null)
                {
                    foreach (var param in parametros)
                    {
                        conexionCommand.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                conexionDataReader = conexionCommand.ExecuteReader();
                datos.Load(conexionDataReader);
            }
            catch (SQLiteException ex)
            {
                File.AppendAllText("C:\\temp\\logErrorLanzador.txt", $"[{DateTime.Now}] ERROR: {ex.Message}\n");
                datos = null;
                throw new Exception("Error al realizar consulta SQL", ex);
            }
            finally
            {
                Desconectar();
            }

            return datos;
        }


        public bool EjecutaSQL(string consulta, Dictionary<string, object> parametros)
        {
            bool result = false;
            Conectar();
            try
            {
                conexionCommand = new SQLiteCommand(consulta, Conectar());
                if (parametros != null)
                {
                    foreach (var param in parametros)
                    {
                        conexionCommand.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }
                conexionCommand.ExecuteNonQuery();
                result = true;

            }
            catch (SQLiteException ex)
            {
                File.AppendAllText("C:\\temp\\logErrorLanzador.txt", $"[{DateTime.Now}] ERROR: {ex.Message}\n");
                result = false;

                throw new Exception("Error al realizar consulta SQL", ex);
            }
            finally
            {
                Desconectar();
            }
            return result;
        }




    }
}
