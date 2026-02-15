using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MyMotorTimeline.Models;

namespace MyMotorTimeline.Data
{
    public class MyMotorDbContext : IdentityDbContext<Usuario>
    {
        public MyMotorDbContext(DbContextOptions<MyMotorDbContext> options) : base(options) { }

        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<TipoMantenimiento> TiposMantenimientos { get; set;}
        public DbSet<MantenimientoProgramado> MantenimientosProgramados { get; set; }
        public DbSet<MantenimientoRealizado> MantenimientosRealizados { get; set; }

        // Configuración adicional de la propiedad costo en MantenimientoRealizado
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configuración de la propiedad costo en MantenimientoRealizado
            modelBuilder.Entity<MantenimientoRealizado>()
                .Property(m => m.Costo)
                .HasPrecision(10,2); // Configura el tipo de datos para el costo
        }

    }
}
