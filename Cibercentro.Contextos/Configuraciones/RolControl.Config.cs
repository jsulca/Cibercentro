using Cibercentro.Entidades.Seguridad;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cibercentro.Seguridad.Configuraciones;

public partial class RolControlConfig
{
    public static void Configure(EntityTypeBuilder<RolControl> entityType)
    {
        entityType.ToTable("rolcontrol", "seguridad");

        entityType.Property(e => e.RolId).HasColumnName("rolid");
        entityType.Property(e => e.ControlId).HasColumnName("controlid");

        entityType.HasKey(e => new { e.RolId, e.ControlId });

        entityType.HasOne(e => e.Rol).WithMany(e => e.Controles)
            .HasForeignKey(e => e.RolId).HasPrincipalKey(e => e.Id).IsRequired();

        entityType.HasOne(e => e.Control).WithMany(e => e.RolControl)
            .HasForeignKey(e => e.ControlId).HasPrincipalKey(e => e.Id).IsRequired();
    }
}

