namespace MyMotorTimeline.Models
{
    public class TipoMantenimiento
    {
        public int Id { get; set; }

        public string Nombre { get; set; } // Ej: Cambio de aceite, Frenos

        // Intervalos sugeridos (opcionales)
        public int? IntervaloKm { get; set; }
        public int? IntervaloMeses { get; set; }
    }  

       
}
