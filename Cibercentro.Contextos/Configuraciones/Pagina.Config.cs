using Cibercentro.Entidades.Seguridad;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cibercentro.Seguridad.Configuraciones;

public partial class PaginaConfig
{
    public static void Configure(EntityTypeBuilder<Pagina> entityType)
    {
        entityType.ToTable("pagina", "seguridad");

        entityType.Property(e => e.Id).HasColumnName("id").UseIdentityAlwaysColumn();
        entityType.Property(e => e.Nombre).HasColumnName("nombre");
        entityType.Property(e => e.Area).HasColumnName("area");
        entityType.Property(e => e.Controlador).HasColumnName("controlador");
        entityType.Property(e => e.Accion).HasColumnName("accion");

        entityType.HasKey(e => e.Id);
    }
}
