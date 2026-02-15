namespace MyMotorTimeline.Models
{
    public class Vehiculo
    {
        public int Id { get; set; }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }

        public int KilometrajeActual { get; set; }

        // Dueño del vehículo
        public string UsuarioId { get; set; }
        public Usuario Duenio { get; set; }
        public string? UrlImagen { get; set; }



        public List<MantenimientoRealizado>? MantenimientosRealizados { get; set; } 
        public List<MantenimientoProgramado>? MantenimientosProgramados { get; set; } 
    }

}
