using Cibercentro.Entidades.General;
using Cibercentro.Entidades.Seguridad;
using Cibercentro.Seguridad.Configuraciones;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibercentro.Contextos;

public class CibercentroContext : DbContext
{

    #region General

    public DbSet<Empleado> Empleado { get; set; }

    #endregion

    #region Seguridad

    public DbSet<Control> Control { get; set; }
    public DbSet<Menu> Menu { get; set; }
    public DbSet<Pagina> Pagina { get; set; }
    public DbSet<Rol> Rol { get; set; }
    public DbSet<RolControl> RolControl { get; set; }
    public DbSet<RolMenu> RolMenu { get; set; }
    public DbSet<RolPagina> RolPagina { get; set; }
    public DbSet<Usuario> Usuario { get; set; }

    #endregion

    public CibercentroContext(DbContextOptions<CibercentroContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region General

        //EmpleadoConfig.Configure(modelBuilder.Entity<Empleado>());

        #endregion

        #region Seguridad

        ControlConfig.Configure(modelBuilder.Entity<Control>());
        MenuConfig.Configure(modelBuilder.Entity<Menu>());
        PaginaConfig.Configure(modelBuilder.Entity<Pagina>());
        RolConfig.Configure(modelBuilder.Entity<Rol>());
        RolControlConfig.Configure(modelBuilder.Entity<RolControl>());
        RolMenuConfig.Configure(modelBuilder.Entity<RolMenu>());
        RolPaginaConfig.Configure(modelBuilder.Entity<RolPagina>());
        UsuarioConfig.Configure(modelBuilder.Entity<Usuario>());

        #endregion
    }
}
