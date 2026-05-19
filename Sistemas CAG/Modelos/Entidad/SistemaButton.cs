
public class SistemaButton : Button
{

    private int id;

    private string nombreSistema;

    private string tipo;

    private string destino;

    private string iniciarEn;

    private string carpetaSistema;

    private string parametros;

    private string ejecutable;


    public int Id { get => id; set => id = value; }
    public string NombreSistema { get => nombreSistema; set => nombreSistema = value; }
    public string Tipo { get => tipo; set => tipo = value; }
    public string Destino { get => destino; set => destino = value; }
    public string IniciarEn { get => iniciarEn; set => iniciarEn = value; }
    public string CarpetaSistema { get => carpetaSistema; set => carpetaSistema = value; }
    public string Parametros { get => parametros; set => parametros = value; }
    public string Ejecutable { get => ejecutable; set => ejecutable = value; }
    public string ToolTipText { get; set; }
    
}
