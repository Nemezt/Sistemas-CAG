using Sistemas_CAG.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sistemas_CAG.Entidad
{
    /// <summary>
    /// 
    /// </summary>
    internal class SistemaParam
    {
        DAOSistemaParam DAOSP = new DAOSistemaParam();

        #region Atributos y Propiedades
        //Nombre de sistema
        private string nombreSistema;

        //Tipo de sistema
        private string tipo;

        //Aplicación de inicio del sistema del sistema
        private string destino;

        //Ruta o paht de inicio para la aplicación
        private string iniciarEn;

        //Carpeta donde esa instalado el sistema
        private string carpetaSistema;

        //Parametro1, contiene la ruta de arranque donde se encuntra el sistema o forma a lanzar
        private string parametro1;

        //Parametro2, en caso de sistemas Java se envia el un parametro para el inicio de la aplicaicon, en sistemas Oracle, se envia contraseña/usuario@servidor del negocio de destino.
        private string parametro2;

        //Se usa para almacenar el nombre del negocio
        private string negocio;

        //Se usa para almacernar en una tabla los datos del sistema
        private DataTable datosSistemas;
        
        private string estacion;


        //Se usa para guardar la versión de la aplicación
        private static string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

     
        public string NombreSistema { get => nombreSistema; set => nombreSistema = value; }
        public string Destino { get => destino; set => destino = value; }
        public string Parametro1 { get => parametro1; set => parametro1 = value; }
        public string Parametro2 { get => parametro2; set => parametro2 = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string IniciarEn { get => iniciarEn; set => iniciarEn = value; }
        public string CarpetaSistema { get => carpetaSistema; set => carpetaSistema = value; }
        public string Negocio { get => negocio; set => negocio = value; }
        public string Estacion { get => estacion; set => estacion = value; }
        public DataTable DatosSistemas { get { return datosSistemas; } set { datosSistemas = value; } }

        public string Version { get => version; }
        #endregion

        #region Metodos

        /// <summary>
        /// Consulta de parametros de sistema
        /// </summary>
        /// <param name="sistema"></param>
        /// <returns></returns>
        public SistemaParam consultaSistema(string nombreSistema)
        {
            SistemaParam sistema = new SistemaParam();
            try
            {              
                string consulta = @"SELECT * FROM tb_sistemas WHERE Nombre = " + "'" + nombreSistema + "'";

                sistema.DatosSistemas = DAOSP.consultaDatos(consulta);
                foreach (DataRow row in sistema.DatosSistemas.Rows)
                {
                    sistema.NombreSistema = row["Nombre"].ToString();
                    sistema.Parametro1 = row["Parametro1"].ToString();
                    sistema.Parametro2 = row["Parametro2"].ToString();
                    sistema.Tipo = row["Tipo"].ToString();
                    sistema.IniciarEn = row["IniciarEn"].ToString();
                    sistema.CarpetaSistema = row["CarpetaSistema"].ToString();

                }

              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar sistema: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                
            }

            return sistema;
        }

        /// <summary>
        /// Consutal de todos los sistemas 
        /// </summary>
        /// <returns></returns>
        public DataTable consultaSistemas()
        {
            string consulta = null;

            consulta = "SELECT * FROM tb_sistemas";
            try
            {
                datosSistemas = DAOSP.consultaDatos(consulta);

            }
            catch (Exception ex)
            {
                datosSistemas = null;
                MessageBox.Show("Error al cargar los sistemas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
            return datosSistemas;
        }

        public DataTable consultaTipoSistemas(string tipoSistema)
        {
            string consulta = @"SELECT * FROM tb_sistemas WHERE Tipo = " + "'" + tipoSistema + "'";
            try
            {
                datosSistemas = DAOSP.consultaDatos(consulta);

            }
            catch (Exception ex)
            {
                datosSistemas = null;
                MessageBox.Show("Error al cargar los sistemas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
            return datosSistemas;
        }

        #endregion

    }



}



