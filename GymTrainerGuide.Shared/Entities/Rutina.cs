using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GymTrainerGuide.Shared.Entities
{
    public class Rutina
    {
        public int Id { get; set; }

        [Display(Name = "Nombre Rutina")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no debe exceder los 100 caracteres.")]
        public string Nombre { get; set; } = string.Empty;

        // Músculo principal trabajado
        [Display(Name = "Músculo Principal")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo {0} no debe exceder los 50 caracteres.")]
        public string Musculo { get; set; } = string.Empty;

        // Dificultad de la rutina
        [Display(Name = "Dificultad")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(20, ErrorMessage = "El campo {0} no debe exceder los 20 caracteres.")]
        public string Dificultad { get; set; } = string.Empty;

        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        // Relación con Usuario (solo ID, opcional)
        [Display(Name = "Usuario")]
        public int? UsuarioId { get; set; }

        // Evita bucles en JSON y validaciones innecesarias
        [JsonIgnore]
        public Usuario? Usuario { get; set; }

        // Relación con RutinaEjercicios
        [JsonIgnore]
        public List<RutinaEjercicio> RutinaEjercicios { get; set; } = new();
    }
}


