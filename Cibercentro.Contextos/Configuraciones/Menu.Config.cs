using Cibercentro.Entidades.Seguridad;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cibercentro.Seguridad.Configuraciones;

public partial class MenuConfig
{
    public static void Configure(EntityTypeBuilder<Menu> entityType)
    {
        entityType.ToTable("menu", "seguridad");

        entityType.Property(e => e.Id).HasColumnName("id").UseIdentityAlwaysColumn();
        entityType.Property(e => e.PadreId).HasColumnName("padreid");
        entityType.Property(e => e.Tipo).HasColumnName("tipo");
        entityType.Property(e => e.Nombre).HasColumnName("nombre");
        entityType.Property(e => e.Icono).HasColumnName("icono");
        entityType.Property(e => e.Ruta).HasColumnName("ruta");

        entityType.HasKey(e => e.Id);
    }
}
