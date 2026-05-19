
namespace Sistemas_CAG.Modelos.Entidad.Convertidores
{
    public static class SistemaConverter
    {
        public static SistemaDTO ToDTO(this SistemaButton button)
        {
            return new SistemaDTO
            {
                Id = button.Id,
                NombreSistema = button.NombreSistema,
                Tipo = button.Tipo,
                Destino = button.Destino,
                IniciarEn = button.IniciarEn,
                CarpetaSistema = button.CarpetaSistema,
                Parametros = button.Parametros,
                Ejecutable = button.Ejecutable,

            };
        }
    }
}
