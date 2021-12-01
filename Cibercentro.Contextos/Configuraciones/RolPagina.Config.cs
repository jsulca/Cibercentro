using Cibercentro.Entidades.Seguridad;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cibercentro.Seguridad.Configuraciones;

public partial class RolPaginaConfig
{
    public static void Configure(EntityTypeBuilder<RolPagina> entityType)
    {
        entityType.ToTable("rolpagina", "seguridad");

        entityType.Property(e => e.RolId).HasColumnName("rolid");
        entityType.Property(e => e.PaginaId).HasColumnName("paginaid");

        entityType.HasKey(e => new { e.RolId, e.PaginaId });

        entityType.HasOne(e => e.Rol).WithMany(e => e.Paginas)
            .HasForeignKey(e => e.RolId).HasPrincipalKey(e => e.Id).IsRequired();

        entityType.HasOne(e => e.Pagina).WithMany(e => e.RolPagina)
            .HasForeignKey(e => e.PaginaId).HasPrincipalKey(e => e.Id).IsRequired();
    }
}
