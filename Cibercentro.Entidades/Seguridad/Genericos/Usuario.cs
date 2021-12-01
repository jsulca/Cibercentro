using Cibercentro.Entidades.General;

namespace Cibercentro.Entidades.Seguridad;

public partial class Usuario
{
    public int Id { get; set; }
    public int EmpleadoId { get; set; }
    public int RolId { get; set; }

    public string Nombre { get; set; } = string.Empty;
    public string Clave { get; set; } = string.Empty;
    public string Correo { get; set; } = string.Empty;
    public bool Activo { get; set; }
    public DateTime? Vencimiento { get; set; }
    public string Token { get; set; } = string.Empty;

    public Rol Rol { get; set; } = new();
    public Empleado Empleado { get; set; } = new();
}