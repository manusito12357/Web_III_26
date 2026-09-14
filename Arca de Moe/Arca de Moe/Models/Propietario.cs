using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ArcaDeMoe.Models
{
    public class Propietario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "Los apellidos son obligatorios.")]
        [StringLength(150)]
        [Display(Name = "Apellidos")]
        public string Apellidos { get; set; } = string.Empty;

        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        [Phone(ErrorMessage = "Formato de teléfono inválido.")]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; } = string.Empty;

        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "Formato de correo inválido.")]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Estado")]
        public bool Estado { get; set; } = true;

        public ICollection<Mascota> Mascotas { get; set; } = new List<Mascota>();
    }
}
