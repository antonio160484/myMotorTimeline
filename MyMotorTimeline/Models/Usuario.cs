namespace MyMotorTimeline.Models
{
    public class Usuario
    {
        public string Nombre{ get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public List<Vehiculo>? Vehiculos { get; set; }
    }
}
