namespace GymTrainerGuide.Shared.Entities
{
    public class Objetivo
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;

        // Relaciones
        public List<Usuario> Usuarios { get; set; } = new();
    }
}
