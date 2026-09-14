using System.ComponentModel.DataAnnotations;

namespace wa_registroestudiantes.Models
{
    public class Estudiante
    {
        public int Id { get; set; }
        public int InscripcionId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(50)]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "El apellido materno es obligatorio.")]
        [StringLength(40)]
        [Display(Name = "Apellido Materno")]
        public string apellidoMaterno { get; set; }
        [Required(ErrorMessage = "El apellido paterno es obligatorio.")]
        [StringLength(40)]
        [Display(Name = "Apellido Paterno")]
        public string apellidoPaterno { get; set; }
        [Required(ErrorMessage = "El correo es obligatorio.")]
        [StringLength(100)]
        [Display(Name = "Correo")]
        public string correo { get; set; }
        [Required(ErrorMessage = "La edad es obligatoria.")]
        [StringLength(3)]
        [Display(Name = "Edad")]
        public int edad { get; set; }
        [Required(ErrorMessage = "El telefono es obligatorio.")]
        [StringLength(10)]
        [Display(Name = "Telefono")]
        public string telefono { get; set; }
        [Required(ErrorMessage = "La direccion es obligatorio.")]
        [StringLength(100)]
        [Display(Name = "Direccion")]
        public string direccion { get; set; }
    }
}
