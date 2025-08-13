

namespace Sistemas_CAG.Modelos.Entidad
{
    public class NegocioDTO
    {


        private string negocio;

        private string configKinf;

        private string configCaj;

        private string configVen;

        private string inventario;

        private string usuario;

        private string palpaso;

        private string servidor;
       
        private string estacion;

        private string tipoEstacion;

      
        public string Negocio { get => negocio; set => negocio = value; }
        public string Inventario { get => inventario; set => inventario = value; }
        public string PalPaso { get => palpaso; set => palpaso = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Servidor { get => servidor; set => servidor = value; }
        public string ConfigKinf { get => configKinf; set => configKinf = value; }
        public string Estacion { get => estacion; set => estacion = value; }
        public string TipoEstacion { get => tipoEstacion; set => tipoEstacion = value; }
        public string ConfigCaj { get => configCaj; set => configCaj = value; }
        public string ConfigVen { get => configVen; set => configVen = value; }
    }











}