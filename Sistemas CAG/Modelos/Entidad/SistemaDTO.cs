

namespace Sistemas_CAG.Modelos.Entidad
{
    public class SistemaDTO
    {

        private int id;

        private string nombreSistema;

        private string tipo;

        private string destino;

        private string iniciarEn;

        private string carpetaSistema;

        private string parametro1;
     
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




    }



}



