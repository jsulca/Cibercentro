namespace Cibercentro.Entidades.Seguridad;

public partial class Pagina
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string? Area { get; set; }
    public string? Controlador { get; set; }
    public string? Accion { get; set; }

    public List<Control> Controles { get; set; } = new();
    public List<RolPagina> RolPagina { get; set; } = new();
}
