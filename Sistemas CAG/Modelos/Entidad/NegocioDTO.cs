using System.Data;



namespace Sistemas_CAG.Modelos.Entidad
{
    internal class NegocioDTO
    {


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

                        

    }











}