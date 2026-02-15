using System.ComponentModel.DataAnnotations;

namespace MyMotorTimeline.Models
{
    public class MantenimientoRealizado
    {
        public int Id { get; set; }

        public int VehiculoId { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
        public int TipoMantenimientoId { get; set; }
        [Required(ErrorMessage ="Debe seleccionar un tipo de mantenimiento")]
        public  TipoMantenimiento TipoMantenimiento { get; set; }

        // Detalle específico de lo que se hizo
        [StringLength(500)]
        public string? Descripcion { get; set; }
        [Required(ErrorMessage ="Debe ingresar la fecha del mantenimiento")]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage ="Debe ingresar el kilometraje al momento del mantenimiento")]
        public int KilometrajeServicio { get; set; }

        public decimal? Costo { get; set; }
    }

}
