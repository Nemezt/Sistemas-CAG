using System.Reflection;

namespace Sistemas_CAG.Modelos.Entidad
{
    /// <summary>
    /// 
    /// </summary>
    public class SistemaDTO
    {

        #region Atributos y Propiedades
        private int id;
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

        private string icono;

             
        public string NombreSistema { get => nombreSistema; set => nombreSistema = value; }
        public string Destino { get => destino; set => destino = value; }
        public string Parametro1 { get => parametro1; set => parametro1 = value; }
        public string Parametro2 { get => parametro2; set => parametro2 = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string IniciarEn { get => iniciarEn; set => iniciarEn = value; }
        public string CarpetaSistema { get => carpetaSistema; set => carpetaSistema = value; }
        public int Id { get => id; set => id = value; }
        public string Icono { get => icono; set => icono = value; }

        #endregion


    }



}



