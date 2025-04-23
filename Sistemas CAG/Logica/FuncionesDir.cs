using System.Diagnostics;

namespace Sistemas_CAG.Logica
{
    internal class FuncionesDir
    {

        /// <summary>
        /// Crea el directorio del sistema de destino en caso de no existir.
        /// </summary>
        /// <param name="directorio"></param>
        /// <returns></returns>
        public bool crearDirectorio(string directorio)
        {
            try
            {
                // Verifica si el directorio existe.
                if (Directory.Exists(directorio))
                {
                    //Retorna si ya existe el directorio
                    return true;
                }

                // Se intenta crear el directorio
                DirectoryInfo di = Directory.CreateDirectory(directorio);

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

        }

        /// <summary>
        /// Copia los archivos de un directorio de origen a uno de destino
        /// </summary>
        /// <param name="dirDestino"></param>
        /// <param name="dirOrigen"></param>
        /// <returns></returns>
        public bool copiarDirectorio(string dirDestino, string dirOrigen)
        {

            try
            {
                if (!Directory.Exists(dirDestino))
                {
                    Directory.CreateDirectory(dirDestino);
                }

                foreach (var file in Directory.GetFiles(dirOrigen))
                {
                    File.Copy(file, Path.Combine(dirDestino, Path.GetFileName(file)), true);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        /// <summary>
        /// Actualiza un directorio de destino con respecto a un directorio de origen usando XCOPY
        /// </summary>
        /// <param name="dirDestino"></param>
        /// <param name="dirOrigen"></param>
        /// <returns></returns>
        public bool actualizarDirectorio(string dirDestino, string dirOrigen, string logActu)
        {

            if (!Directory.Exists(dirDestino))
            {
                Directory.CreateDirectory(dirDestino);
            }

            Process process = new Process();

            StreamReader outputReader = null;
            StreamReader errorReader = null;

            try
            {
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.FileName = "xcopy";
                process.StartInfo.Arguments = dirOrigen + " " + dirDestino + " " + @"/S /V /D /Y";
                bool processStarted = process.Start();
                if (processStarted)
                {
                    //Se obtiene strem de salida
                    outputReader = process.StandardOutput;
                    errorReader = process.StandardError;
                    

                    //Se escribe en el log
                    string salidaTexto = "SISTEMA: " + dirDestino + Environment.NewLine;
                    salidaTexto += "==============" + "SALIDA" + "==============" + Environment.NewLine;
                    salidaTexto += outputReader.ReadToEnd();
                    salidaTexto += Environment.NewLine + "==============" + "ERROR" + "==============" + Environment.NewLine;
                    salidaTexto += errorReader.ReadToEnd();
                    salidaTexto += Environment.NewLine;
                    escribirArchivo(@logActu, salidaTexto);

                    process.WaitForExit();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (outputReader != null)
                {
                    outputReader.Close();
                }
                if (errorReader != null)
                {
                    errorReader.Close();
                }
                process.Close();
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aplicacionDir"></param>
        /// <param name="aplicacionParam"></param>
        /// <param name="aplicacionIni"></param>
        /// <returns></returns>
        public bool ejecutarAplicacion(string aplicacionDir, string aplicacionParam = null, string aplicacionIni = null)
        {
            try
            {             
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = aplicacionDir;
                if (aplicacionParam == null)
                {
                    //En el caso de no requerir 1 parametro
                    startInfo.Arguments = "";
                }
                else
                {
                    //En el caso de requerir 1 parametros
                    startInfo.Arguments = " " + aplicacionParam;

                }

                if (aplicacionIni == null)
                {
                    startInfo.WorkingDirectory = aplicacionDir;
                }
                else
                {
                    startInfo.WorkingDirectory = aplicacionIni;
                }

                //Se inicia el proceso
                Process.Start(startInfo);
                return true;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
        }
        /// <summary>
        /// Verifica que un archivo especifico se encuentre en un diretorio.
        /// </summary>
        /// <param name="archivo"></param>
        /// <returns></returns>
        public bool verificaArchivo(string archivo)
        {
            try
            {
                if (File.Exists(archivo))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

        }
        /// <summary>
        /// Elimina un archivo indicado dentro de un directorio
        /// </summary>
        /// <param name="archivo"></param>
        /// <returns></returns>
        public bool eliminarArchivo(string archivo)
        {
            try
            {
                if (File.Exists(archivo))
                {
                    File.Delete(archivo);
                }
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public void escribirArchivo(string archivo, string texto)
        {

            File.AppendAllLines(archivo, new string[] { texto });

        }


        /// <summary>
        /// Se Obtiene el directorio de instalación de java JRE
        /// </summary>
        /// <returns></returns>
        public string GetJavaInstallationPath()
        {
            try
            {
                string environmentPath = Environment.GetEnvironmentVariable("JAVA_HOME");
                if (!string.IsNullOrEmpty(environmentPath))
                {
                    return environmentPath;
                }

                string javaKey = "SOFTWARE\\JavaSoft\\Java Runtime Environment\\";
                using (Microsoft.Win32.RegistryKey rk = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(javaKey))
                {
                    string currentVersion = rk.GetValue("CurrentVersion").ToString();
                    using (Microsoft.Win32.RegistryKey key = rk.OpenSubKey(currentVersion))
                    {
                        return key.GetValue("JavaHome").ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Java: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return "";

            }


        }






    }
}
