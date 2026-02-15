namespace MyMotorTimeline.Models
{
    public class MantenimientoRealizado
    {
        public int Id { get; set; }

        public int VehiculoId { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }

        public int TipoMantenimientoId { get; set; }
        public  TipoMantenimiento TipoMantenimiento { get; set; }

        // Detalle específico de lo que se hizo
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }

        public int KilometrajeServicio { get; set; }


        public decimal Costo { get; set; }
    }

}
