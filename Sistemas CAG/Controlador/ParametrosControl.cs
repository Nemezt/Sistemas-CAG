using Sistemas_CAG.Modelos.Entidad;
using Sistemas_CAG.Modelos.Servicios;
using System.Data;


namespace Sistemas_CAG.Controlador
{
    internal class ParametrosControl
    {

        public DataTable CargaTablaSistema()
        {

            DataTable respuesta = new DataTable();
            respuesta = SistemaRepository.ConsultaSistemas();

            return respuesta;

        }
        public bool ActualizaSistema(SistemaDTO sistema)
        {
            bool respuesta = SistemaRepository.ActualizarSistema(sistema);

            return respuesta;
        }


        public bool InsertaSistema(SistemaDTO sistema)
        {

            bool respuesta = SistemaRepository.InsertarSistema(sistema);

            return respuesta;
        }


        public bool BorrarSistema(int id)
        {
            bool respuesta = SistemaRepository.EliminarSistema(id);

            return respuesta;
        }

        public ParametrosDTO ConsultaParametros()
        {
            ParametrosDTO respuesta = new ParametrosDTO();
            respuesta =  ParametroRepository.ConsultaParametros();

            return respuesta;
        }

        public bool ActualizaParametros(ParametrosDTO parametros)
        {
            bool respuesta = ParametroRepository.ActualizaParametros(parametros);

            return respuesta;
        }



    }
}
