namespace MyMotorTimeline.Models
{
    public class MantenimientoProgramado
    {
        public int Id { get; set; }

        public int VehiculoId { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }

        public int TipoMantenimientoId { get; set; }
        public  TipoMantenimiento TipoMantenimiento { get; set; }

        public int KilometrajeObjetivo { get; set; }

        public DateTime? FechaEstimada { get; set; }

        public bool Completado { get; set; } = false;
    }

}
