namespace Cibercentro.Entidades.Seguridad;

public partial class RolMenu
{
    public int RolId { get; set; }
    public int MenuId { get; set; }

    public Rol Rol { get; set; } = new();
    public Menu Menu { get; set; } = new();
}
