using MyMotorTimeline.Models;

namespace MyMotorTimeline.Data
{
    public static class DbSeeder
    {
        public static void Seed(MyMotorDbContext context)
        {
            context.Database.EnsureCreated();
            // Verificar si ya hay datos en la base de datos
            if (context.Vehiculos.Any())
            {
                return; // La base de datos ya ha sido sembrada
            }
            // Crear algunos tipos de mantenimiento
            var tipos = new List<TipoMantenimiento>
            {
                new TipoMantenimiento { Nombre = "Cambio de aceite y filtro de aceite", IntervaloKm = 10000, IntervaloMeses = 6 },
                new TipoMantenimiento { Nombre = "Cambio de filtro de aire", IntervaloKm = 15000, IntervaloMeses = 12 },
                new TipoMantenimiento { Nombre = "Cambio de filtro de combustible", IntervaloKm = 30000, IntervaloMeses = 24 },
                new TipoMantenimiento { Nombre = "Cambio de filtro de cabina", IntervaloKm = 15000, IntervaloMeses = 12 },
                new TipoMantenimiento { Nombre = "Cambio de bujías", IntervaloKm =   40000, IntervaloMeses = 36 },
                new TipoMantenimiento { Nombre = "Cambio de batería", IntervaloKm = 0, IntervaloMeses = 48 },
                new TipoMantenimiento { Nombre = "Cambio de pastillas de freno", IntervaloKm = 30000, IntervaloMeses = 0 },
                new TipoMantenimiento { Nombre = "Cambio de discos de freno", IntervaloKm = 60000, IntervaloMeses = 0 },
                new TipoMantenimiento { Nombre = "Cambio de líquido de frenos", IntervaloKm = 0, IntervaloMeses = 24 },
                new TipoMantenimiento { Nombre = "Rotación de neumáticos", IntervaloKm = 10000, IntervaloMeses = 12 },
                new TipoMantenimiento { Nombre = "Balanceo de neumáticos", IntervaloKm = 10000, IntervaloMeses = 12 },
                new TipoMantenimiento { Nombre = "Alineación de dirección", IntervaloKm = 20000, IntervaloMeses = 24 },
                new TipoMantenimiento { Nombre = "Cambio de neumáticos", IntervaloKm = 45000, IntervaloMeses = 0 },
                new TipoMantenimiento { Nombre = "Cambio de amortiguadores", IntervaloKm = 80000, IntervaloMeses = 0 },
                new TipoMantenimiento { Nombre = "Cambio de correa de distribución", IntervaloKm = 100000, IntervaloMeses = 60 },
                new TipoMantenimiento { Nombre = "Cambio de correas auxiliares", IntervaloKm = 60000, IntervaloMeses = 48 },
                new TipoMantenimiento { Nombre = "Cambio de refrigerante", IntervaloKm = 60000, IntervaloMeses = 36 },
                new TipoMantenimiento { Nombre = "Cambio de líquido de dirección hidráulica", IntervaloKm = 60000, IntervaloMeses = 36 },
                new TipoMantenimiento { Nombre = "Cambio de aceite de transmisión manual", IntervaloKm = 60000, IntervaloMeses = 48 },
                new TipoMantenimiento { Nombre = "Cambio de aceite de transmisión automática", IntervaloKm = 60000, IntervaloMeses = 48 },
                new TipoMantenimiento { Nombre = "Cambio de silenciador", IntervaloKm = 80000, IntervaloMeses = 0 },
                new TipoMantenimiento { Nombre = "Cambio de catalizador", IntervaloKm = 120000, IntervaloMeses = 0 },
                new TipoMantenimiento { Nombre = "Recarga y mantenimiento de aire acondicionado", IntervaloKm = 0, IntervaloMeses = 24 }
            };

            context.TiposMantenimientos.AddRange(tipos);
            context.SaveChanges();


        }
    }
}
