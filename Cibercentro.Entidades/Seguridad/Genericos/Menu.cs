namespace Cibercentro.Entidades.Seguridad;

public partial class Menu
{
    public int Id { get; set; }
    public int? PadreId { get; set; }
    public int Tipo { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string? Icono { get; set; }
    public string? Ruta { get; set; }

    public List<RolMenu> RolMenu { get; set; } = new();
}
