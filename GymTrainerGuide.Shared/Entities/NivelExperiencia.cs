using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GymTrainerGuide.Shared.Entities
{
    public class NivelExperiencia
    {
        public int Id { get; set; }

        [Display(Name = "Nivel de experiencia")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(10, ErrorMessage = "El campo {0} no debe exceder los {1} caracteres.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El campo {0} solo debe contener letras.")]

        public string Nivel { get; set; } = string.Empty;

        // Relaciones
        public List<Usuario> Usuarios { get; set; } = new();
    }
}
