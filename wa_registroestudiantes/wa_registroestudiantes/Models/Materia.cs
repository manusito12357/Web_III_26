using System.ComponentModel.DataAnnotations;

namespace wa_registroestudiantes.Models
{
    public class Materia
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100)]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "La aula es obligatorio")]
        [StringLength(100)]
        [Display(Name = "Aula")]
        public string aula { get; set; }
        [Required(ErrorMessage = "El grado es obligatorios")]
        [StringLength(100)]
        [Display(Name = "Grado")]
        public string grado { get; set; }
        [Required(ErrorMessage = "Los créditos son obligatorios")]
        [Range(1, 10, ErrorMessage = "Los créditos deben estar entre 1 y 10")]
        [Display(Name = "Créditos")]
        public int Creditos { get; set; }
        public ICollection<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();
    }
}
