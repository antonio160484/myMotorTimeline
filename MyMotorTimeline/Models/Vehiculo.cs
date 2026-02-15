using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyMotorTimeline.Models
{
    public class Vehiculo
    {
        public int Id { get; set; }
        [Required (ErrorMessage="Debe Ingresar una Marca de automóvil")]
        [StringLength(50)]
        public string Marca { get; set; }
        [Required (ErrorMessage="Debe Ingresar un Modelo de automóvil")]
        [StringLength(50)]
        public string Modelo { get; set; }
        [Required (ErrorMessage="Debe Ingresar un Año de fabricación del automóvil")]
        [Range(1886, 2100, ErrorMessage = "El año debe ser entre 1886 y 2100")]
        public int Anio { get; set; }
        [Required (ErrorMessage="Debe Ingresar un Kilometraje actual del automóvil")]
        [StringLength(50)]
        [Range(0, int.MaxValue, ErrorMessage = "El kilometraje debe ser un número positivo")]
        public int KilometrajeActual { get; set; }
        public string? UrlImagen { get; set; }

        // Dueño del vehículo
        public string UsuarioId { get; set; }
        [DisplayName("Dueño")]
        public Usuario Duenio { get; set; }



        public List<MantenimientoRealizado>? MantenimientosRealizados { get; set; } 
        public List<MantenimientoProgramado>? MantenimientosProgramados { get; set; } 
    }

}
