namespace Cibercentro.Entidades.Seguridad;

public partial class RolControl
{
    public int RolId { get; set; }
    public int ControlId { get; set; }

    public Rol Rol { get; set; } = new();
    public Control Control { get; set; } = new();
}
