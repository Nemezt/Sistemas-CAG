using Sistemas_CAG.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemas_CAG.Entidad
{
    internal class ParametroGen
    {
        #region Propiedades y atributos

        DAOSistemaParam DAOSP = new DAOSistemaParam();

        private string oracleForms;

        private string javaHome;

        private string servidorActualizacion;

        private string navegadorWeb;

        private string cod_cia;

        private string logSistema; 

        private string sistema;

        private string actualiza;

        private string defOracle;

        private string defJava;

        private string defNavegador;

        private DataTable datosParametros;
        public string OracleForms { get => oracleForms; set => oracleForms = value; }
        public string JavaHome { get => javaHome; set => javaHome = value; }
        public string ServidorActualizacion { get => servidorActualizacion; set => servidorActualizacion = value; }
        public string NavegadorWeb { get => navegadorWeb; set => navegadorWeb = value; }
        public string COD_CIA { get => cod_cia; set => cod_cia = value; }
        public DataTable DatosParametros { get => datosParametros; set => datosParametros = value; }
        public string LogSistema { get => logSistema; set => logSistema = value; }
        public string Sistema { get => sistema; set => sistema = value; }
        public string Actualiza { get => actualiza; set => actualiza = value; }
        public string DefOracle { get => defOracle; set => defOracle = value; }
        public string DefJava { get => defJava; set => defJava = value; }
        public string DefNavegador { get => defNavegador; set => defNavegador = value; }

        #endregion

        #region Metodos

        /// <summary>
        /// Consulta de todos los parametros para el sistema lanzador
        /// </summary>
        /// <returns></returns>
        public ParametroGen consultaParametros()
        {
            string consulta = null;

            ParametroGen param= new ParametroGen();

            consulta = "SELECT * FROM tb_parametros WHERE Sistema = 'Lanzador';";
            try
            {
                param.DatosParametros = DAOSP.consultaDatos(consulta);

                foreach (DataRow row in param.DatosParametros.Rows)
                {
                    param.OracleForms = @row["Oracle"].ToString();
                    param.JavaHome = @row["Java"].ToString();
                    param.ServidorActualizacion = @row["Servidor"].ToString();
                    param.NavegadorWeb = @row["Navegador"].ToString();
                    param.COD_CIA = @row["COD_CIA"].ToString();
                    param.LogSistema = @row["Log"].ToString();
                    param.Sistema = @row["Sistema"].ToString();
                    param.Actualiza = @row["Actualiza"].ToString();
                    param.DefOracle = @row["DefOracle"].ToString();
                    param.DefJava = @row["DefJava"].ToString();
                    param.DefNavegador = @row["DefNavegador"].ToString();
                }

            }
            catch (Exception ex)
            {
                DatosParametros = null;
                MessageBox.Show("Error al cargar los parametros genreales: " + ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            finally
            {

            }
            return param;
        }

        /// <summary>
        /// Update de parametros actualizables.
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public bool actualizaParametros(ParametroGen param)
        {
            string consulta = "UPDATE tb_parametros SET " +
                "Oracle=" + "'" + param.OracleForms + "' ," +
                "Java=" + "'" + param.JavaHome + "' ," +
                "Servidor=" + "'" + param.ServidorActualizacion + "' ," +
                "Navegador=" + "'" + param.NavegadorWeb + "' ," +
                "Log=" + "'" + param.LogSistema + "' ," +
                "Actualiza=" + "'" + param.Actualiza + "' ," +
                "DefOracle=" + "'" + param.DefOracle + "' ," +
                "DefJava=" + "'" + param.DefJava + "' ," +
                "DefNavegador=" + "'" + param.DefNavegador + "'" +                
                "WHERE Sistema = 'Lanzador'";

            bool respuesta;
            try {
                if(DAOSP.ejecutaConsulta(consulta))
                {
                    respuesta = true;
                }
                else
                {
                    respuesta = false;
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la información: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return respuesta;
        }


        #endregion
    }
}
