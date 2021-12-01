namespace Cibercentro.Entidades.Seguridad;

public partial class Control
{
    public int Id { get; set; }
    public int PaginaId { get; set; }
    public string Nombre { get; set; } = string.Empty;

    public Pagina Pagina { get; set; } = new();
    public List<RolControl> RolControl { get; set; } = new();
}
