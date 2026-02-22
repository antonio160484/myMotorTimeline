using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace MyMotorTimeline.Models
{
    public class Usuario : IdentityUser 
    {
        [Required(ErrorMessage ="Debe ingresar su nombre")]
        [StringLength(50)]
        public string Nombre{ get; set; }
        [Required(ErrorMessage ="Debe ingresar su apellido")]
        [StringLength(100)]
        public string Apellido { get; set; }
        [StringLength(20)]
        public string? Dni { get; set; }
        
        public string? UrlFotoPerfil { get; set; }
        public List<Vehiculo>? Vehiculos { get; set; }
    }

    public class UsuarioViewModel
    {
        [Required(ErrorMessage = "Debe ingresar su nombre")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe ingresar su nombre")]
        [StringLength(50)]
        public string Apellido { get; set; }
        [EmailAddress(ErrorMessage = "Debe ingresar un correo electrónico válido")]
        public string Email { get; set; }
        [PasswordPropertyText]
        public string Clave { get; set; }
        [PasswordPropertyText]
        public string ConfirmarClave { get; set; }

    }

    public class LoginViewModel
    {
        [Required(ErrorMessage = "Debe ingresar su correo electrónico")]
        [EmailAddress(ErrorMessage = "Debe ingresar un correo electrónico válido")]
        public string Email { get; set; }
        [PasswordPropertyText]
        [Required(ErrorMessage = "Debe ingresar su contraseña")]
        public string Clave { get; set; }
        public bool Recordarme { get; set; }
    }
}
