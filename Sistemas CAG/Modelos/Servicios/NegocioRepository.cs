using Sistemas_CAG.Modelos.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistemas_CAG.Modelos.DataAccess;

namespace Sistemas_CAG.Modelos.Servicios
{
    internal class NegocioRepository
    {
        private static DAOSistema DAOSP = DAOSistema.GetInstancia();


        /// <summary>
        /// Consulta negocio en la tabla de negocios
        /// </summary>
        /// <param name="negocio"></param>
        /// <returns></returns>
        public NegocioDTO consultaNegocio(NegocioDTO negocio)
        {
            try
            {
                string consulta = @"SELECT * FROM tb_negocios_pos WHERE Negocio = " + "'" + negocio.Negocio + "'";

                negocio.DatosNegocios = DAOSP.ConsultaDatos(consulta);
                foreach (DataRow row in negocio.DatosNegocios.Rows)
                {
                    negocio.ConfigKinf = row["ConfigKinf"].ToString();
                    negocio.Usuario = row["Usuario"].ToString();
                    negocio.PalPaso = row["PalPaso"].ToString();
                    negocio.Servidor = row["Servidor"].ToString();
                    negocio.Inventario = row["Inventario"].ToString();
                    negocio.Estacion = row["Estacion"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar negocio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }

            return negocio;
        }

        /// <summary>
        /// Select para cargar el nombte del archivo de Kiosco
        /// </summary>
        /// <param name="negocio"></param>
        /// <returns></returns>
        public string consultaConfigKinf(string negocio)
        {
            NegocioDTO negocioPos = new NegocioDTO();
            try
            {

                string consulta = @"SELECT ConfigKinf FROM tb_negocios_pos WHERE Negocio = " + "'" + negocio + "'";

                negocioPos.DatosNegocios = DAOSP.ConsultaDatos(consulta);
                foreach (DataRow row in negocioPos.DatosNegocios.Rows)
                {
                    negocioPos.ConfigKinf = row["ConfigKinf"].ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar archivo de configuraciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }

            return negocioPos.ConfigKinf;
        }

        /// <summary>
        /// Select para cargar el nombte del archivo de Kiosco
        /// </summary>
        /// <param name="negocio"></param>
        /// <returns></returns>
        public string consultaConfig(string negocio)
        {
            NegocioDTO negocioPos = new NegocioDTO();
            try
            {

                string consulta = @"SELECT Usuario, PalPaso, Servidor FROM tb_negocios_pos WHERE Negocio = " + "'" + negocio + "'";

                negocioPos.DatosNegocios = DAOSP.ConsultaDatos(consulta);
                foreach (DataRow row in negocioPos.DatosNegocios.Rows)
                {
                    negocioPos.Usuario = row["Usuario"].ToString();
                    negocioPos.PalPaso = row["PalPaso"].ToString();
                    negocioPos.Servidor = row["Servidor"].ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar archivo de configuraciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }

            return negocioPos.Usuario + @"/" + negocioPos.PalPaso + @"@" + negocioPos.Servidor;
        }
        /// <summary>
        /// Consuta de todos los negocios de la tabla de negocios
        /// </summary>
        /// <returns></returns>
        public DataTable consultaNegocios()
        {
            string consulta = null;
            DataTable DatosNegocios = new DataTable();

            consulta = "SELECT * FROM tb_negocios_pos";
            try
            {
                DatosNegocios = DAOSP.ConsultaDatos(consulta);

            }
            catch (Exception ex)
            {
                DatosNegocios = null;
                MessageBox.Show("Error al cargar los negocios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
            return DatosNegocios;
        }

    }
}
