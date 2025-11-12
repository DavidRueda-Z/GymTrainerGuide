using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GymTrainerGuide.Shared.Entities
{
    public class RutinaEjercicio
    {
        public int Id { get; set; }

        public int RutinaId { get; set; }
        [JsonIgnore]
        public Rutina? Rutina { get; set; }

        public int EjercicioId { get; set; }
        [JsonIgnore]
        public Ejercicio? Ejercicio { get; set; }

        [Display(Name = "Series")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Range(1, 100, ErrorMessage = "El número de {0} debe estar entre {1} y {2}.")]
        public int Series { get; set; }

        [Display(Name = "Repeticiones")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Range(1, 100, ErrorMessage = "El número de {0} debe estar entre {1} y {2}.")]
        public int Repeticiones { get; set; }
    }
}
