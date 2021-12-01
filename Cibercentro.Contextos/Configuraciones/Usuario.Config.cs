using Cibercentro.Entidades.Seguridad;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cibercentro.Seguridad.Configuraciones;

public partial class UsuarioConfig
{
    public static void Configure(EntityTypeBuilder<Usuario> entityType)
    {
        entityType.ToTable("usuario", "seguridad");

        entityType.Property(e => e.Id).HasColumnName("id").UseIdentityAlwaysColumn();
        entityType.Property(e => e.EmpleadoId).HasColumnName("empleadoid");
        entityType.Property(e => e.RolId).HasColumnName("rolid");

        entityType.Property(e => e.Nombre).HasColumnName("nombre");
        entityType.Property(e => e.Clave).HasColumnName("clave");
        entityType.Property(e => e.Correo).HasColumnName("correo");
        entityType.Property(e => e.Activo).HasColumnName("activo");
        entityType.Property(e => e.Vencimiento).HasColumnName("vencimiento");
        entityType.Property(e => e.Token).HasColumnName("token");

        entityType.HasKey(e => e.Id);

        entityType.HasOne(e => e.Rol).WithMany(e => e.Usuarios)
            .HasForeignKey(e => e.RolId).HasPrincipalKey(e => e.Id).IsRequired();

        entityType.HasOne(e => e.Empleado).WithMany(e => e.Usuarios)
            .HasForeignKey(e => e.EmpleadoId).HasPrincipalKey(e => e.Id).IsRequired();
    }
}
