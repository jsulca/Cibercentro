using Cibercentro.Entidades.Seguridad;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cibercentro.Seguridad.Configuraciones;

public partial class RolConfig
{
    public static void Configure(EntityTypeBuilder<Rol> entityType)
    {
        entityType.ToTable("rol", "seguridad");

        entityType.Property(e => e.Id).HasColumnName("id").UseIdentityAlwaysColumn();
        entityType.Property(e => e.Nombre).HasColumnName("nombre");
        entityType.Property(e => e.Activo).HasColumnName("activo");

        entityType.HasKey(e => e.Id);
    }
}

