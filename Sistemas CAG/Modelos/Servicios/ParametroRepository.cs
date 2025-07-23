using Sistemas_CAG.Modelos.DataAccess;
using Sistemas_CAG.Modelos.Entidad;
using System.Data;


namespace Sistemas_CAG.Modelos.Servicios
{
    internal class ParametroRepository
    {
        private static DAOSistema DAOSP = new DAOSistema();
        public static ParametrosDTO ConsultaParametros()
        {
            var parametrosDTO = new ParametrosDTO();
            string consulta = @"SELECT Oracle, Java, Servidor, Navegador, COD_CIA, Log, Sistema, Actualiza, 
                               DefOracle, DefJava, DefNavegador
                        FROM tb_parametros 
                        WHERE Sistema = @Sistema";

            var parametros = new Dictionary<string, object>
            {
                { "@Sistema", "Lanzador" }
            };

            try
            {
                DataTable datos = DAOSP.ConsultaDatos(consulta, parametros);

                if (datos.Rows.Count > 0)
                {
                    DataRow row = datos.Rows[0];

                    parametrosDTO.OracleForms = row["Oracle"]?.ToString();
                    parametrosDTO.JavaHome = row["Java"]?.ToString();
                    parametrosDTO.ServidorActualizacion = row["Servidor"]?.ToString();
                    parametrosDTO.NavegadorWeb = row["Navegador"]?.ToString();
                    parametrosDTO.COD_CIA = row["COD_CIA"]?.ToString();
                    parametrosDTO.LogSistema = row["Log"]?.ToString();
                    parametrosDTO.Sistema = row["Sistema"]?.ToString();
                    parametrosDTO.Actualiza = row["Actualiza"]?.ToString();
                    parametrosDTO.DefOracle = row["DefOracle"]?.ToString();
                    parametrosDTO.DefJava = row["DefJava"]?.ToString();
                    parametrosDTO.DefNavegador = row["DefNavegador"]?.ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los parámetros generales", ex);
            }

            return parametrosDTO;
        }

        /// <summary>
        /// Actualiza los parámetros configurables del sistema.
        /// </summary>
        /// <param name="parametros">DTO con los parámetros a actualizar</param>
        /// <returns>true si la operación fue exitosa</returns>
        public static bool ActualizaParametros(ParametrosDTO parametros)
        {
            string consulta = @"UPDATE tb_parametros SET 
                            Oracle = @Oracle, 
                            Java = @Java, 
                            Servidor = @Servidor, 
                            Navegador = @Navegador, 
                            Log = @Log, 
                            DefOracle = @DefOracle, 
                            DefJava = @DefJava, 
                            DefNavegador = @DefNavegador,
                            Actualiza = @Actualiza
                        WHERE Sistema = @Sistema";

            var valores = new Dictionary<string, object>
            {
                { "@Actualiza", parametros.Actualiza },
                { "@Sistema", parametros.Sistema },
                { "@Oracle", parametros.OracleForms },
                { "@Java", parametros.JavaHome },
                { "@Servidor", parametros.ServidorActualizacion },
                { "@Navegador", parametros.NavegadorWeb },
                { "@Log", parametros.LogSistema },
                { "@DefOracle", parametros.DefOracle },
                { "@DefJava", parametros.DefJava },
                { "@DefNavegador", parametros.DefNavegador }
            };

            try
            {
                return DAOSP.EjecutaSQL(consulta, valores);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar los parámetros", ex);
            }
        }
    }
}
