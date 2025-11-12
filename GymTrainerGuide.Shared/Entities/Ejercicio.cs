using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GymTrainerGuide.Shared.Entities
{
    public class Ejercicio
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no debe exceder los 100 caracteres.")]

        public string Nombre { get; set; } = string.Empty;

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(500, ErrorMessage = "El campo {0} no debe exceder los 500 caracteres.")]

        public string Descripcion { get; set; } = string.Empty;

        [Display(Name = "Grupo Muscular")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no debe exceder los 100 caracteres.")]

        public string GrupoMuscular { get; set; } = string.Empty;

        public int EquipoId { get; set; }

        [JsonIgnore]
        public Equipo? Equipo { get; set; }

        [JsonIgnore]
        public List<RutinaEjercicio> RutinaEjercicios { get; set; } = new();
    }
}
