using Cibercentro.Entidades.Seguridad;

namespace Cibercentro.Entidades.General;

public class Empleado
{
    public int Id { get; set; }
    public List<Usuario> Usuarios { get; set; } = new();
}