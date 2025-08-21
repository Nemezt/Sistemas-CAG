using Sistemas_CAG.Modelos.Entidad;
using Sistemas_CAG.Utils;
using Sistemas_CAG.Modelos.Servicios;

namespace Sistemas_CAG.Controlador
{
    internal class LanzadorControl
    {
        private static FuncionesDirectorios funcDir = new FuncionesDirectorios();
        private static ParametrosDTO parametros = new ParametrosDTO();

        public LanzadorControl()
        {
            try
            {
                parametros = ParametroRepository.ConsultaParametros();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }

        //private string logSistema = Directory.GetCurrentDirectory() + "\\logLanzador.txt";



        const string configKInf = @"C:\OpenPos60\pos\";
        const string configVen = @"C:\OpenPos60\pos\";
        const string configCaj = @"C:\OpenPos60\pos\";
        // const string dirHuella = @"C:\Integracion Huella\";
        // const string dirBac = @"C:\Integracion Bac";

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
        /// 
        /// </summary>
        /// <param name="sistema"></param>
        /// <param name="negocioPos"></param>
        public void lanzarAplicacion(SistemaDTO sistema, NegocioDTO negocioPos)
        {
            try
            {
                parametros = ParametroRepository.ConsultaParametros();
                funcDir.EliminarArchivo(parametros.LogSistema);

                if (!(sistema.NombreSistema == null))
                {
                    
                    
                    //sistema = sistemaRepository.ConsultaSistema(sistema.NombreSistema);


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
                        if (parametros.DefJava == "S")
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
                        funcDir.EliminarArchivo(webutil32);
                        funcDir.EliminarArchivo(webutil64);

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
                    if (sistema.NombreSistema == "Kiosco")
                    {

                        sistema.Parametro2 = negocioPos.ConfigKinf;
                        crearConfigKInf(negocioPos);
                    }

                    //Se carga parametro para facturacion de OpenPos
                    if (sistema.NombreSistema == "Facturacion")
                    {

                        sistema.Parametro2 = $"{negocioPos.Usuario}/{negocioPos.PalPaso}@{negocioPos.Servidor}";
                        crearConfigCaj(negocioPos);
                    }

                    //Se carga parametro para preventa de OpenPos
                    if (sistema.NombreSistema == "Preventa")
                    {

                        sistema.Parametro2 = $"{negocioPos.Usuario}/{negocioPos.PalPaso}@{negocioPos.Servidor}";
                        crearConfigVen(negocioPos);
                    }

                    //Se verifica el tipo de sistema
                    if (funcDir.VerificaArchivo(sistema.Destino) == true)
                    {
                        if (sistema.Tipo == "web")
                        {
                            if (!ejecutarSistemaWeb(sistema))
                            {
                                MessageBox.Show("No se puede ejecutar el sistema ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (sistema.Tipo == "Servidor")
                        {
                            if (!ejecutarSistemaWeb(sistema))
                            {
                                MessageBox.Show("No se puede ejecutar el sistema ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            if (!ejecutarAplicacion(sistema))
                            {
                                MessageBox.Show("No se puede ejecutar el sistema ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }


        }


        private bool ejecutarSistemaWeb(SistemaDTO sistema)
        {
            try
            {
                if (!funcDir.EjecutarAplicacion(sistema.Destino, sistema.Parametro1, ""))
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private bool ejecutarAplicacion(SistemaDTO sistema)
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
                if (!funcDir.EjecutarAplicacion(sistema.Destino, parametros, sistema.IniciarEn))
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private SistemaDTO actualizaAplicacion(SistemaDTO sistema, ParametrosDTO parametros)
        {
            
            try
            {
                funcDir.CrearDirectorio(@"C:\Temp");
                if (funcDir.ActualizarDirectorio(sistema.CarpetaSistema, parametros.ServidorActualizacion + sistema.NombreSistema, parametros.LogSistema))
                {


                    if (sistema.NombreSistema == "openpos60" || sistema.NombreSistema == "facturacion" || sistema.NombreSistema == "preventa" || sistema.NombreSistema == "kiosco")
                    {
                        actualizaPosFu(sistema.IniciarEn);
                    }

                }
                else
                {
                    MessageBox.Show("No se puede actualizar " + sistema.CarpetaSistema, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                if (!funcDir.ActualizarDirectorio(complemento, parametros.ServidorActualizacion + nombre, parametros.LogSistema))
                {
                    MessageBox.Show("No se puede actualizar el complemento " + complemento, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void actualizaPosFu(string rSistema)
        {
            try
            {
                foreach (string archivo in openPosFU)
                {
                    if (!funcDir.ActualizarDirectorio(rSistema, parametros.ServidorActualizacion + archivo, parametros.LogSistema))
                    {
                        MessageBox.Show("No se puede actualizar el archivo " + archivo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


  
        private void crearConfigKInf(NegocioDTO negocio)
        {
            try
            {
                var file = new IniFile(configKInf + "ConfigKInf-" + negocio.Inventario + ".acc");
                file.Write("COD_CIA", "CAG", "Compañia");
                file.Write("COD_INV", negocio.Inventario, "Negocio");
                file.Write("VER_EXISTENCIA", "S", "Negocio");
                file.Write("VER_RETENIBLE", "S", "Negocio");
                file.Write("USUARIO", negocio.Usuario, "Conexion");
                file.Write("PALPASO", negocio.PalPaso, "Conexion");
                file.Write("CONEXION", negocio.Servidor, "Conexion");
                file.Write("TIMEOUT", "1", "Conexion");
                file.Write("TIEMPO_ERROR", "5", "Mensajes");
                file.Write("TIEMPO_MENSAJE", "2", "Mensajes");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void crearConfigVen(NegocioDTO negocio)
        {
            try
            {
                var file = new IniFile(configVen + "ConfigVen.acc");
                file.Write("COD_CIA", "CAG", "Compañia");
                file.Write("COD_INV", negocio.Inventario, "Negocio");
                file.Write("ID_ESTACION", negocio.Estacion, "Negocio");
                file.Write("COD_COO", "COOPEAGRI", "Negocio");
                file.Write("USUARIO", negocio.Usuario, "Conexion");
                file.Write("PALPASO", negocio.PalPaso, "Conexion");
                file.Write("CONEXION", negocio.Servidor, "Conexion");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void crearConfigCaj(NegocioDTO negocio)
        {
            try
            {
                var file = new IniFile(configCaj + "ConfigCaj.acc");
                file.Write("COD_CIA", "CAG", "Compañia");
                file.Write("COD_INV", negocio.Inventario, "Negocio");
                file.Write("ID_CAJA", negocio.Estacion, "Negocio");
                file.Write("ESTACION", negocio.TipoEstacion, "Negocio");
                file.Write("USUARIO", negocio.Usuario, "Conexion");
                file.Write("PALPASO", negocio.PalPaso, "Conexion");
                file.Write("CONEXION", negocio.Servidor, "Conexion");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }


  

}
