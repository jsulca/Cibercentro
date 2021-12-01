namespace Cibercentro.Entidades.Seguridad;

public partial class Rol
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public bool Activo { get; set; }

    public List<RolControl> Controles { get; set; } = new();
    public List<RolMenu> Menus { get; set; } = new();
    public List<RolPagina> Paginas { get; set; } = new();
    public List<Usuario> Usuarios { get; set; } = new();
}
