using Microsoft.Win32;


namespace Sistemas_CAG.Utils
{
    public class InicioAutomatico
    {
        public bool RegistrarInicioAutomatico()
        {
            try
            {
                RegistryKey clave = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                clave.SetValue(Application.ProductName, $"\"{Application.ExecutablePath}\"");

                return true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool EliminarInicioAutomatico()
        {
            try
            {
                RegistryKey clave = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);

                if (clave.GetValue(Application.ProductName) != null)
                {
                    clave.DeleteValue(Application.ProductName);
                }
                return true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool ExisteInicioAutomatico()
        {

            using (RegistryKey clave = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", false))
            {

                return clave?.GetValue(Application.ProductName) != null;
            }
        }


    }
}
