using Sistemas_CAG.Logica;
using System.Data;


namespace Sistemas_CAG.Entidad
{
    internal class NegocioPos
    {
        DAOSistemaParam DAOSP = new DAOSistemaParam();

        #region Atributos y Propiedades
        //Se usa para almacenar el nombre del negocio
        private string negocio;
        //Se usa para almacenar el negocio de destino en sistemas Oracle
        private string configKinf;

        //Se usa para almacenar el inventario al que ingresará el negocio Oracle
        private string inventario;

        //Se usa para almacenar un usuario
        private string usuario;

        //Se usa para almacenar una contraseña
        private string palpaso;

        //Se usa para almacenar el servidor
        private string servidor;

        private DataTable datosNegocios;
        
        private string estacion;

      
        public string Negocio { get => negocio; set => negocio = value; }
        public string Inventario { get => inventario; set => inventario = value; }
        public string PalPaso { get => palpaso; set => palpaso = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Servidor { get => servidor; set => servidor = value; }
        public string ConfigKinf { get => configKinf; set => configKinf = value; }
        public string Estacion { get => estacion; set => estacion = value; }
        public DataTable DatosNegocios { get { return datosNegocios; } set { datosNegocios = value; } }


        #endregion

        #region Metodos
        /// <summary>
        /// Consulta negocio en la tabla de negocios
        /// </summary>
        /// <param name="negocio"></param>
        /// <returns></returns>
        public NegocioPos consultaNegocio(NegocioPos negocio)
        {
            try
            {
                string consulta = @"SELECT * FROM tb_negocios_pos WHERE Negocio = " + "'" + negocio.Negocio + "'";

                negocio.DatosNegocios = DAOSP.consultaDatos(consulta);
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
            NegocioPos negocioPos = new NegocioPos();
            try
            {
                
                string consulta = @"SELECT ConfigKinf FROM tb_negocios_pos WHERE Negocio = " + "'" + negocio + "'";

                negocioPos.DatosNegocios = DAOSP.consultaDatos(consulta);
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
            NegocioPos negocioPos = new NegocioPos();
            try
            {

                string consulta = @"SELECT Usuario, PalPaso, Servidor FROM tb_negocios_pos WHERE Negocio = " + "'" + negocio + "'";

                negocioPos.DatosNegocios = DAOSP.consultaDatos(consulta);
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

            return negocioPos.Usuario + @"/" + negocioPos.PalPaso +@"@"+ negocioPos.Servidor;
        }
        /// <summary>
        /// Consuta de todos los negocios de la tabla de negocios
        /// </summary>
        /// <returns></returns>
        public DataTable consultaNegocios()
        {
            string consulta = null;

            consulta = "SELECT * FROM tb_negocios_pos";
            try
            {
                DatosNegocios = DAOSP.consultaDatos(consulta);

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
        #endregion





    }











}
