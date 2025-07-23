using System.Diagnostics;

namespace Sistemas_CAG.Utils
{
    internal class FuncionesDirectorios
    {
        public bool CrearDirectorio(string directorio)
        {
            try
            {
                if (!Directory.Exists(directorio))
                {
                    Directory.CreateDirectory(directorio);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al crear el directorio: {directorio}", ex);
            }
        }

        public bool CopiarDirectorio(string origen, string destino)
        {
            try
            {
                if (!Directory.Exists(destino))
                {
                    Directory.CreateDirectory(destino);
                }

                foreach (var archivo in Directory.GetFiles(origen))
                {
                    var destinoArchivo = Path.Combine(destino, Path.GetFileName(archivo));
                    File.Copy(archivo, destinoArchivo, true);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al copiar archivos de '{origen}' a '{destino}'", ex);
            }
        }

        public bool ActualizarDirectorio(string destino, string origen, string logPath)
        {
            try
            {
                if (!Directory.Exists(destino))
                {
                    Directory.CreateDirectory(destino);
                }

                using (var process = new Process())
                {
                    process.StartInfo = new ProcessStartInfo
                    {
                        FileName = "xcopy",
                        Arguments = $"\"{origen}\" \"{destino}\" /S /V /D /Y",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };

                    process.Start();

                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    process.WaitForExit();

                    string log = $"SISTEMA: {destino}\n==============SALIDA==============\n{output}\n==============ERROR==============\n{error}\n";
                    EscribirArchivo(logPath, log);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar directorio con XCOPY", ex);
            }
        }

        public bool EjecutarAplicacion(string ejecutable, string parametros = "", string directorioTrabajo = "")
        {
            try
            {
                var startInfo = new ProcessStartInfo
                {
                    FileName = ejecutable,
                    Arguments = parametros ?? "",
                    WorkingDirectory = string.IsNullOrEmpty(directorioTrabajo) ? Path.GetDirectoryName(ejecutable) : directorioTrabajo
                };

                Process.Start(startInfo);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al ejecutar la aplicación: {ejecutable}", ex);
            }
        }

        public bool VerificaArchivo(string rutaArchivo)
        {
            try
            {
                return File.Exists(rutaArchivo);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al verificar archivo: {rutaArchivo}", ex);
            }
        }

        public bool EliminarArchivo(string rutaArchivo)
        {
            try
            {
                if (File.Exists(rutaArchivo))
                {
                    File.Delete(rutaArchivo);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar archivo: {rutaArchivo}", ex);
            }
        }

        public void EscribirArchivo(string ruta, string texto)
        {
            try
            {
                File.AppendAllText(ruta, texto + Environment.NewLine);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al escribir en archivo: {ruta}", ex);
            }
        }

        public string GetJavaInstallationPath()
        {
            try
            {
                string javaHome = Environment.GetEnvironmentVariable("JAVA_HOME");
                if (!string.IsNullOrEmpty(javaHome))
                    return javaHome;

                const string keyPath = @"SOFTWARE\JavaSoft\Java Runtime Environment\";
                using (var rk = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(keyPath))
                {
                    string version = rk?.GetValue("CurrentVersion")?.ToString();
                    if (!string.IsNullOrEmpty(version))
                    {
                        using (var subKey = rk.OpenSubKey(version))
                        {
                            return subKey?.GetValue("JavaHome")?.ToString() ?? "";
                        }
                    }
                }

                return "";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la instalación de Java", ex);
            }
        }
    }







}

