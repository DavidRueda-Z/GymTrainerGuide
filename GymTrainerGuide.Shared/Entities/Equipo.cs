using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GymTrainerGuide.Shared.Entities
{
    public class Equipo
    {
        public int Id { get; set; }
        [Display(Name = "Nombre Ejercicio")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no debe exceder los 100 caracteres.")]
        public string Nombre { get; set; } = string.Empty;

        [Display(Name = "Descripción Ejercicio")]
        [MaxLength(500, ErrorMessage = "El campo {0} no debe exceder los 500 caracteres.")]
        public string Descripcion { get; set; } = string.Empty;

        // Relaciones
        [JsonIgnore]
        public List<Ejercicio> Ejercicios { get; set; } = new();
    }
}
