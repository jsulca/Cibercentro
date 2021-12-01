using Cibercentro.Entidades.Seguridad;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cibercentro.Seguridad.Configuraciones;

public partial class RolMenuConfig
{
    public static void Configure(EntityTypeBuilder<RolMenu> entityType)
    {
        entityType.ToTable("rolmenu", "seguridad");

        entityType.Property(e => e.RolId).HasColumnName("rolid");
        entityType.Property(e => e.MenuId).HasColumnName("menuid");

        entityType.HasKey(e => new { e.RolId, e.MenuId });

        entityType.HasOne(e => e.Rol).WithMany(e => e.Menus)
            .HasForeignKey(e => e.RolId).HasPrincipalKey(e => e.Id).IsRequired();

        entityType.HasOne(e => e.Menu).WithMany(e => e.RolMenu)
            .HasForeignKey(e => e.MenuId).HasPrincipalKey(e => e.Id).IsRequired();
    }
}

