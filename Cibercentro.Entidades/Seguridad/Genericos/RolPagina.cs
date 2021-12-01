namespace Cibercentro.Entidades.Seguridad;

public partial class RolPagina
{
    public int RolId { get; set; }
    public int PaginaId { get; set; }

    public Rol Rol { get; set; } = new();
    public Pagina Pagina { get; set; } = new();
}
