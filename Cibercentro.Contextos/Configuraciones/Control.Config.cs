using Cibercentro.Entidades.Seguridad;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cibercentro.Seguridad.Configuraciones;

public partial class ControlConfig
{
    public static void Configure(EntityTypeBuilder<Control> entityType)
    {
        entityType.ToTable("control", "seguridad");

        entityType.Property(e => e.Id).HasColumnName("id").UseIdentityAlwaysColumn();
        entityType.Property(e => e.PaginaId).HasColumnName("paginaid");
        entityType.Property(e => e.Nombre).HasColumnName("nombre");

        entityType.HasKey(e => e.Id);

        entityType.HasOne(e => e.Pagina).WithMany(e => e.Controles)
            .HasForeignKey(e => e.PaginaId).HasPrincipalKey(e => e.Id).IsRequired();

        entityType.Ignore(e => e.Eliminado);
    }
}
