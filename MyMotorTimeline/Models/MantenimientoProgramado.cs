using System.ComponentModel.DataAnnotations;

namespace MyMotorTimeline.Models
{
    public class MantenimientoProgramado
    {
        public int Id { get; set; }

        public int VehiculoId { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }

        public int TipoMantenimientoId { get; set; } = 0;
        public  TipoMantenimiento TipoMantenimiento { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "El kilometraje objetivo debe ser un número positivo")]
        public int KilometrajeObjetivo { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaEstimada { get; set; }

        public bool Completado { get; set; } = false;
    }

}
