using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ArcaDeMoe.Models
{
    public class Mascota
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El propietario es obligatorio.")]
        [Display(Name = "Propietario")]
        public int PropietarioId { get; set; }

        public Propietario? Propietario { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "La especie es obligatoria.")]
        [StringLength(50)]
        [Display(Name = "Especie")]
        public string Especie { get; set; } = string.Empty;

        [Required(ErrorMessage = "La raza es obligatoria.")]
        [StringLength(100)]
        [Display(Name = "Raza")]
        public string Raza { get; set; } = string.Empty;

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria.")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Display(Name = "Estado")]
        public bool Estado { get; set; } = true;

        public ICollection<Cita> Citas { get; set; } = new List<Cita>();
    }
}
