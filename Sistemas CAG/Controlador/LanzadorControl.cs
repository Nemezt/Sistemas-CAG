using Sistemas_CAG.Modelos.Entidad;
using Sistemas_CAG.Utils;
using Sistemas_CAG.Modelos.Servicios;

namespace Sistemas_CAG.Controlador
{
    internal class LanzadorControl
    {
        FuncionesDir funcDir = new FuncionesDir();
        ParametroGen parametros = new ParametroGen();
        NegocioDTO negocioParam = new NegocioDTO();
        NegocioRepository negocioRepository = new NegocioRepository();
        public LanzadorControl()
        {
            parametros = parametros.consultaParametros();


        }

        //private string logSistema = Directory.GetCurrentDirectory() + "\\logLanzador.txt";



        const string configKInf = @"C:\OpenPos60\pos\";
        const string configVen = @"C:\OpenPos60\pos\";
        const string configCaj = @"C:\OpenPos60\pos\";
        // const string dirHuella = @"C:\Integracion Huella\";
        // const string dirBac = @"C:\Integracion Bac";
        public string error = "";

        /// <summary>
        /// Lista que contiene los archivos fuente de openpos requeridos para que funcione.
        /// </summary>
        private List<string> openPosFU = new List<string>()
        {
            @"OpenposFu\base\D2kwutil.pll",
            @"OpenposFu\base\repo1.pll",
            @"OpenposFu\base\Repo1_b.pll",
            @"OpenposFu\base\Repo_Com.pll",
            @"OpenposFu\base\repo_cre.pll",
            @"OpenposFu\base\Repo_inv.pll",
            @"OpenposFu\base\side1.pll",
            @"OpenposFu\base\side2.pll",
            @"OpenposFu\base\side3.pll",
            @"OpenposFu\base\side4.pll",
            @"OpenposFu\base\Sidemenu.pll",
            @"OpenposFu\base\side_fac.pll",
            @"OpenposFu\base\SIDE_INV.pll",
            @"OpenposFu\base\side_po2.pll",
            @"OpenposFu\base\side_pof.pll",
            @"OpenposFu\base\Side_Poi.pll",
            @"OpenposFu\base\SIDE_POV.pll",
            @"OpenposFu\base\side_vfa.pll",
            @"OpenposFu\base\side_vip.pll",
            @"OpenposFu\base\vop1.pll",
            @"OpenposFu\base\side_con.pll"
        };
        

        /// <summary>
        /// Logica principal para determinar la aplicación a actualizar y ejecutar, asigna los parametros necesarios.
        /// </summary>
        /// <param name="sistema"></param>
        public void lanzarAplicacion(SistemaParam sistema )
        {
            parametros = parametros.consultaParametros();
            funcDir.eliminarArchivo(parametros.LogSistema);
            if (!(sistema.NombreSistema == null))
            {
                negocioParam = conexionNegocioOpenPos(sistema.Negocio);
                if (sistema.Estacion != "" || sistema.Estacion == null)
                {
                    negocioParam.Estacion = sistema.Estacion;
                }

                sistema = sistema.consultaSistema(sistema.NombreSistema);


                if (sistema.Tipo == "web")
                {
                    if (parametros.DefNavegador == "S")
                    {
                        sistema.Destino = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";
                    }
                    else
                    {
                        sistema.Destino = parametros.NavegadorWeb;
                    }
                    
                }
                if (sistema.Tipo == "servidor")
                {
                    if (parametros.DefNavegador == "S")
                    {
                        sistema.Destino = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";
                    }
                    else
                    {
                        sistema.Destino = parametros.NavegadorWeb;
                    }

                }
                if (sistema.Tipo == "java")
                {
                    if(parametros.DefJava=="S")
                    {
                        sistema.Destino = funcDir.GetJavaInstallationPath() + @"\bin\javaw.exe";
                    }
                    else
                    {
                        sistema.Destino = parametros.JavaHome + @"\bin\javaw.exe";
                    }
                    
                }
                if (sistema.Tipo == "javaws")
                {
                    if (parametros.DefJava == "S")
                    {
                        sistema.Destino = funcDir.GetJavaInstallationPath() + @"\bin\javaws.exe";
                    }
                    else
                    {
                        sistema.Destino = parametros.JavaHome + @"\bin\javaws.exe";
                    }

                    //Se borra el webutil.properties si existe

                    string webutil32 = @"C:\\users\\" + Environment.UserName + "\\webutil.32.properties";
                    string webutil64 = @"C:\\users\\" + Environment.UserName + "\\webutil.64.properties";
                    funcDir.eliminarArchivo(webutil32);
                    funcDir.eliminarArchivo(webutil64);

                }
                if (sistema.Tipo == "oracle")
                {
                    if (parametros.DefOracle == "S")
                    {
                        sistema.Destino = @"C:\orant\BIN\ifrun60.EXE";
                    }
                    else
                    {
                        sistema.Destino = parametros.OracleForms;
                    }
                    
                }
                if (sistema.Tipo == "exe")
                {
                    sistema.Destino = sistema.CarpetaSistema + sistema.NombreSistema + ".exe";
                }

                if (sistema.Tipo == "exe" || sistema.Tipo == "java" || sistema.Tipo == "oracle")
                {
                    //Se actualiza el sistema?
                    if (parametros.Actualiza == "S")
                    {
                        sistema = actualizaAplicacion(sistema, parametros);
                    }
                   
                }
                //Se carga parametro para kisco de OpenPos
                if (sistema.NombreSistema == "kiosco")
                {
                    sistema.Parametro2 = negocioRepository.consultaConfigKinf(negocioParam.Negocio);
                    crearConfigKInf(negocioParam);
                }

                //Se carga parametro para facturacion de OpenPos
                if (sistema.NombreSistema == "facturacion")
                {
                    sistema.Parametro2 = negocioRepository.consultaConfig(negocioParam.Negocio);
                    crearConfigCaj(negocioParam);
                }

                //Se carga parametro para preventa de OpenPos
                if (sistema.NombreSistema == "preventa")
                {
                    sistema.Parametro2 = negocioRepository.consultaConfig(negocioParam.Negocio);
                    crearConfigVen(negocioParam);
                }

                //Se verifica el tipo de sistema
                if (funcDir.verificaArchivo(sistema.Destino) == true)
                {
                    if (sistema.Tipo == "web")
                    {
                        if (!ejecutarSistemaWeb(sistema))
                        {
                            MessageBox.Show("No se puede ejecutar el sistema " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (sistema.Tipo == "Servidor")
                    {
                        if (!ejecutarSistemaWeb(sistema))
                        {
                            MessageBox.Show("No se puede ejecutar el sistema " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (!ejecutarAplicacion(sistema))
                        {
                            MessageBox.Show("No se puede ejecutar el sistema " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                   
                }
                else
                {
                    MessageBox.Show("No se puede tener acceso a " + sistema.Destino, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                sistema = null;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un sistema o parámetro válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sistema = null;
            }



        }


        /// <summary>
        /// Se ejecuta la aplicación web llamando al navegador web, puede soportar parametros de navegador.
        /// </summary>
        /// <param name="sistema"></param>
        /// <returns></returns>
        private bool ejecutarSistemaWeb(SistemaParam sistema)
        {
            try
            {
                if (!funcDir.ejecutarAplicacion(sistema.Destino, sistema.Parametro1, ""))
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                error = ex.ToString();
                return false;
            }

        }
        /// <summary>
        /// Ejecutar una aplicación de escritorio
        /// </summary>
        /// <param name="sistema"></param>
        /// <returns></returns>
        private bool ejecutarAplicacion(SistemaParam sistema)
        {
            string parametros = "";

            if (sistema.Parametro2 == null)
            {
                //En el caso de solo requerir 1 parametro
                parametros = sistema.Parametro1;
            }
            else
            {
                //En el caso de requerir 2 parametros
                parametros = sistema.Parametro1 + " " + sistema.Parametro2;
               
            }
            try
            {
                if (!funcDir.ejecutarAplicacion(sistema.Destino, parametros, sistema.IniciarEn))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                error = ex.ToString();
                return false;
            }
        }

        /// <summary>
        /// Actualización de aplicación 
        /// </summary>
        /// <param name="sistema"></param>
        /// <param name="parametros"></param>
        /// <returns></returns>
        private SistemaParam actualizaAplicacion(SistemaParam sistema, ParametroGen parametros)
        {
            funcDir.crearDirectorio(@"C:\Temp");

            if (funcDir.actualizarDirectorio(sistema.CarpetaSistema, parametros.ServidorActualizacion + sistema.NombreSistema, parametros.LogSistema))
            {
                
                
                if(sistema.NombreSistema == "openpos60" || sistema.NombreSistema == "facturacion"  || sistema.NombreSistema ==  "preventa" || sistema.NombreSistema == "kiosco")
                {
                    actualizaPosFu(sistema.IniciarEn);
                }
                
            }
            else
            {
                MessageBox.Show("No se puede actualizar " + sistema.CarpetaSistema, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return sistema;
        }

       

        /// <summary>
        /// Actualizacion de algun complemento para un sistema
        /// </summary>
        /// <param name="complemento"></param>
        /// <param name="nombre"></param>
        // No funciona si las rutas contienen espacios en blanco
        private void actualizaComplemento(string complemento, string nombre)
        {
            if (!funcDir.actualizarDirectorio(complemento, parametros.ServidorActualizacion + nombre, parametros.LogSistema))
            {
                MessageBox.Show("No se puede actualizar el complemento " + complemento, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        /// <summary>
        /// Actualización de archivos fuentes necesarios para openpos
        /// </summary>
        /// <param name="rSistema"></param>
        private void actualizaPosFu(string rSistema)
        {
            foreach (string archivo in openPosFU)
            {
                if (!funcDir.actualizarDirectorio(rSistema, parametros.ServidorActualizacion + archivo, parametros.LogSistema))
                {
                    MessageBox.Show("No se puede actualizar el archivo " + archivo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Consulta los negocios y parametros
        /// </summary>
        /// <param name="nNegocio"></param>
        /// <returns></returns>
        private NegocioDTO conexionNegocioOpenPos(string nNegocio)
        {

            negocioParam.Negocio = nNegocio;

            negocioParam = negocioRepository.consultaNegocio(negocioParam);
            return negocioParam;
        }


        /// <summary>
        /// Crea el archivo de configuraciones para el kiosco del OpenPos
        /// </summary>
        /// <param name="sistema"></param>        
        private void crearConfigKInf(NegocioDTO negocio)
        {

            var file = new IniFile(configKInf + "ConfigKInf-" + negocioParam.Inventario + ".acc");
            file.Write("COD_CIA", "CAG", "Compañia");
            file.Write("COD_INV", negocioParam.Inventario, "Negocio");
            file.Write("VER_EXISTENCIA", "S", "Negocio");
            file.Write("VER_RETENIBLE", "S", "Negocio");
            file.Write("USUARIO", negocioParam.Usuario, "Conexion");
            file.Write("PALPASO", negocioParam.PalPaso, "Conexion");
            file.Write("CONEXION", negocioParam.Servidor, "Conexion");
            file.Write("TIMEOUT", "1", "Conexion");
            file.Write("TIEMPO_ERROR", "5", "Mensajes");
            file.Write("TIEMPO_MENSAJE", "2", "Mensajes");
        }

        private void crearConfigVen(NegocioDTO negocio)
        {
            
            var file = new IniFile(configVen + "ConfigVen.acc");
            file.Write("COD_CIA", "CAG", "Compañia");
            file.Write("COD_INV", negocioParam.Inventario, "Negocio");
            file.Write("ID_ESTACION", negocioParam.Estacion, "Negocio");
            file.Write("COD_COO", "COOPEAGRI", "Negocio");
            file.Write("USUARIO", negocioParam.Usuario, "Conexion");
            file.Write("PALPASO", negocioParam.PalPaso, "Conexion");
            file.Write("CONEXION", negocioParam.Servidor, "Conexion");

        }

        private void crearConfigCaj(NegocioDTO negocio)
        {
                         
            var file = new IniFile(configCaj + "ConfigCaj.acc");
            file.Write("COD_CIA", "CAG", "Compañia");
            file.Write("COD_INV", negocioParam.Inventario, "Negocio");
            file.Write("ID_CAJA", negocioParam.Estacion, "Negocio");
            file.Write("USUARIO", negocioParam.Usuario, "Conexion");
            file.Write("PALPASO", negocioParam.PalPaso, "Conexion");
            file.Write("CONEXION", negocioParam.Servidor, "Conexion");

        }
    }


}
