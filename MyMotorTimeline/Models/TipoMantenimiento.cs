using System.ComponentModel.DataAnnotations;

namespace MyMotorTimeline.Models
{
    public class TipoMantenimiento
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="Campo requerido")]
        [StringLength(150, ErrorMessage = "El nombre no puede exceder los 100 caracteres")]
        public string Nombre { get; set; } // Ej: Cambio de aceite, Frenos

        // Intervalos sugeridos (opcionales)
        [Range(0, int.MaxValue, ErrorMessage = "El intervalo de kilómetros debe ser un número positivo")]
        public int? IntervaloKm { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "El intervalo de meses debe ser un número positivo")]
        public int? IntervaloMeses { get; set; }
    }  

       
}
