using Sistemas_CAG.Modelos.DataAccess;
using Sistemas_CAG.Modelos.Entidad;
using System.Data;


namespace Sistemas_CAG.Modelos.Servicios
{

    internal class SistemaRepository
    {
        private static DAOSistema DAOS = new DAOSistema();

        public SistemaDTO ConsultaSistema(string nombreSistema)
        {
            var sistema = new SistemaDTO();
            try
            {
                string consulta = @"SELECT Nombre, Parametros, Ejecutable, Tipo, IniciarEn, CarpetaSistema 
                            FROM tb_sistemas 
                            WHERE Nombre = @Nombre";

                var parametros = new Dictionary<string, object>
                {
                    { "@Nombre", nombreSistema }
                };

                DataTable datos = DAOS.ConsultaDatos(consulta, parametros);

                if (datos.Rows.Count > 0)
                {
                    DataRow row = datos.Rows[0];
                    sistema.NombreSistema = row["Nombre"]?.ToString();
                    sistema.Parametros = row["Parametros"]?.ToString();
                    sistema.Ejecutable = row["Ejecutable"]?.ToString();
                    sistema.Tipo = row["Tipo"]?.ToString();
                    sistema.IniciarEn = row["IniciarEn"]?.ToString();
                    sistema.CarpetaSistema = row["CarpetaSistema"]?.ToString();
                }

                return sistema;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar sistema", ex);
            }
        }

        public static DataTable ConsultaSistemas()
        {
            try
            {
                string consulta = "SELECT * FROM tb_sistemas";
                return DAOS.ConsultaDatos(consulta);
            }
            catch (Exception ex)
            {               
                throw new Exception("Error al consultar sistemas", ex);
            }
        }

        public DataTable ConsultaTipoSistemas(string tipoSistema)
        {
            try
            {
                string consulta = @"SELECT * FROM tb_sistemas WHERE Tipo = @Tipo";

                var parametros = new Dictionary<string, object>
                {
                    { "@Tipo", tipoSistema }
                };

                return DAOS.ConsultaDatos(consulta, parametros);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar sistemas por tipo", ex);
            }
        }

        public static bool InsertarSistema(SistemaDTO sistema)
        {
            bool respuesta = false;

            string consulta = "INSERT INTO tb_sistemas (Nombre, Parametros, Ejecutable, Tipo, IniciarEn, CarpetaSistema, Icono) VALUES (@nombre, @parametros, @ejecutable, @tipo, @iniciarEn, @carpetaSistema, @icono)";
            var parametros = new Dictionary<string, object>
            {
                { "@nombre", sistema.NombreSistema },
                { "@parametros", sistema.Parametros },
                { "@ejecutable", sistema.Ejecutable },
                { "@tipo",  sistema.Tipo },
                { "@iniciarEn", sistema.IniciarEn },
                { "@icono", sistema.Icono },
                { "@carpetaSistema",  sistema.CarpetaSistema }
            };

            try
            {
                respuesta = DAOS.EjecutaSQL(consulta, parametros);

            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el sistema", ex);

            }

            return respuesta;
        }

        public static bool ActualizarSistema(SistemaDTO sistema)
        {
            bool respuesta = false;

            string consulta = "UPDATE tb_sistemas SET Nombre = @nombre, Parametros = @parametros, Ejecutable = @ejecutable, Tipo = @tipo, IniciarEn = @iniciarEn, CarpetaSistema = @carpetaSistema, Icono = @icono WHERE ID = @id;";
            var parametros = new Dictionary<string, object>
            {
                { "@id", sistema.Id },
                { "@nombre", sistema.NombreSistema },
                { "@parametros", sistema.Parametros },
                { "@ejecutable", sistema.Ejecutable },
                { "@tipo",  sistema.Tipo },
                { "@iniciarEn", sistema.IniciarEn },
                { "@icono", sistema.Icono },
                { "@carpetaSistema",  sistema.CarpetaSistema }
            };

            try
            {
                respuesta = DAOS.EjecutaSQL(consulta, parametros);

            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el sistema", ex);

            }

            return respuesta;
        }

        public static bool EliminarSistema(int id)
        {
            bool respuesta = false;
            string consulta = "DELETE FROM tb_sistemas WHERE ID = @id";
            var parametros = new Dictionary<string, object>
            {
                { "@id", id }
            };

            try
            {
                respuesta = DAOS.EjecutaSQL(consulta, parametros);

            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el sistema", ex);

            }

            return respuesta;
        }






    }
}
