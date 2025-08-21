using Sistemas_CAG.Modelos.DataAccess;
using Sistemas_CAG.Modelos.Entidad;
using System.Data;


namespace Sistemas_CAG.Modelos.Servicios
{
    internal class NegocioRepository
    {
        private static DAOSistema DAOSP = DAOSistema.GetInstancia();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="negocio"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public NegocioDTO ConsultaNegocio(NegocioDTO negocio)
        {
            try
            {
                string consulta = @"SELECT ConfigKinf, Usuario, PalPaso, Servidor, Inventario, Estacion, TipoEstacion 
                            FROM tb_negocios_pos 
                            WHERE Negocio = @Negocio";

                var parametros = new Dictionary<string, object>
                {
                    { "@Negocio", negocio.Negocio }
                };

                DataTable datosNegocios = DAOSP.ConsultaDatos(consulta, parametros);

                foreach (DataRow row in datosNegocios.Rows)
                {
                    negocio.ConfigKinf = row["ConfigKinf"]?.ToString();
                    negocio.Usuario = row["Usuario"]?.ToString();
                    negocio.PalPaso = row["PalPaso"]?.ToString();
                    negocio.Servidor = row["Servidor"]?.ToString();
                    negocio.Inventario = row["Inventario"]?.ToString();
                    negocio.Estacion = row["Estacion"]?.ToString();
                    negocio.TipoEstacion = row["TipoEstacion"]?.ToString();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al consultar negocio: ", ex);
            }

            return negocio;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="negocio"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string ConsultaConfigKinf(string negocio)
        {
            try
            {
                string consulta = @"SELECT ConfigKinf FROM tb_negocios_pos WHERE Negocio = @Negocio";
                var parametros = new Dictionary<string, object>
                {
                    { "@Negocio", negocio }
                };

                DataTable datos = DAOSP.ConsultaDatos(consulta, parametros);
                if (datos.Rows.Count > 0)
                {
                    return datos.Rows[0]["ConfigKinf"]?.ToString();
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar configuraciones", ex);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="negocio"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string ConsultaConfig(string negocio)
        {
            try
            {
                string consulta = @"SELECT Usuario, PalPaso, Servidor FROM tb_negocios_pos WHERE Negocio = @Negocio";
                var parametros = new Dictionary<string, object>
                {
                    { "@Negocio", negocio }
                };

                DataTable datos = DAOSP.ConsultaDatos(consulta, parametros);
                if (datos.Rows.Count > 0)
                {
                    var row = datos.Rows[0];
                    string usuario = row["Usuario"]?.ToString();
                    string palPaso = row["PalPaso"]?.ToString();
                    string servidor = row["Servidor"]?.ToString();

                    return $"{usuario}/{palPaso}@{servidor}";
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar configuraciones", ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataTable ConsultaNegocios()
        {
            try
            {
                string consulta = "SELECT * FROM tb_negocios_pos";
                return DAOSP.ConsultaDatos(consulta);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los negocios", ex);
            }
        }

    }
}
