using GymTrainerGuide.Shared.Enums;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace GymTrainerGuide.Shared.Entities
{
    public class Usuario : IdentityUser
    {

        public new int Id { get; set; }

        [Display(Name = "Nombre completo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no debe exceder los {1} caracteres.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El campo {0} solo debe contener letras y espacios.")]
        public string Nombre { get; set; } = string.Empty;

        [Display(Name = "Edad")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Range(14, 100, ErrorMessage = "El valor para {0} debe estar entre {1} y {2}.")]
        public int Edad { get; set; }

        [Display(Name = "Género")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public Genero Genero { get; set; }

        [Display(Name = "Correo Electrónico")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no debe exceder los 100 caracteres.")]
        [EmailAddress(ErrorMessage = "El formato del {0} no es válido.")]
        public string Correo { get; set; } = string.Empty;

        [Display(Name = "Tipo de usuario")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public TipoUsuario TipoUsuario { get; set; }

        [Display(Name = "Nivel de experiencia")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un {0}.")]

        public int NivelExperienciaId { get; set; }
        [JsonIgnore]
        public NivelExperiencia? NivelExperiencia { get; set; }

        public int ObjetivoId { get; set; }
        [JsonIgnore]
        public Objetivo? Objetivo { get; set; }

        [JsonIgnore]
        public List<Rutina> Rutinas { get; set; } = new();
    }
}
