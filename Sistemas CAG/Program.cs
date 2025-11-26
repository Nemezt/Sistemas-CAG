using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Sistemas_CAG
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        //Windows API para buscar la ventana y mostrarla
        [DllImport("user32.dll")]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_RESTORE = 9;

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            //Nombre de la aplicación
            string applicationName = Process.GetCurrentProcess().ProcessName;
            //Revisa si se esta ejecutando el proceso
            bool nuevaInstancia;
            using (Mutex mutex = new Mutex(true, applicationName, out nuevaInstancia))
            {
                //Sino se esta ejecutando, se abre.
                if (nuevaInstancia)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new LanzadorFrm());
                    mutex.ReleaseMutex();

                }
                //Si se esta ejecuntando, se muestra si esta en segundo plano
                else {
                    IntPtr hWnd = FindWindow(null, "Lanzador de sistemas");
                    if (hWnd != IntPtr.Zero)
                    {
                        ShowWindow(hWnd, SW_RESTORE);
                    }
                }
                //File.WriteAllText("C:\\temp\\logErrorLanzador.txt", $"StartupPath: {Application.StartupPath}\nCurrentDir: {Environment.CurrentDirectory}");

            }



        }
    }
}