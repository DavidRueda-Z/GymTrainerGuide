using System.ComponentModel.DataAnnotations;

namespace GymTrainerGuide.Shared.DTOs
{
    public class LoginDTO
    {
        [Display(Name = "Correo Electrónico")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del {0} no es válido.")]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MinLength(6, ErrorMessage = "El campo {0} debe tener al menos {1} caracteres.")]
        public string Password { get; set; } = string.Empty;
    }
}
