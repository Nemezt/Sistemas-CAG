
using System.Reflection;

namespace Sistemas_CAG.Modelos.Entidad
{
    internal class ParametrosDTO
    {
        #region Propiedades y atributos


        private string oracleForms;

        private string javaHome;

        private string servidorActualizacion;

        private string navegadorWeb;

        private string cod_cia;

        private string logSistema; 

        private string sistema = "Lanzador";

        private string actualiza;

        private string defOracle;

        private string defJava;

        private string defNavegador;

        private static string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();


        public string OracleForms { get => oracleForms; set => oracleForms = value; }
        public string JavaHome { get => javaHome; set => javaHome = value; }
        public string ServidorActualizacion { get => servidorActualizacion; set => servidorActualizacion = value; }
        public string NavegadorWeb { get => navegadorWeb; set => navegadorWeb = value; }
        public string COD_CIA { get => cod_cia; set => cod_cia = value; }
        public string LogSistema { get => logSistema; set => logSistema = value; }
        public string Sistema { get => sistema; set => sistema = value; }
        public string Actualiza { get => actualiza; set => actualiza = value; }
        public string DefOracle { get => defOracle; set => defOracle = value; }
        public string DefJava { get => defJava; set => defJava = value; }
        public string DefNavegador { get => defNavegador; set => defNavegador = value; }
        public string Version { get => version; }



        #endregion

    }
}
