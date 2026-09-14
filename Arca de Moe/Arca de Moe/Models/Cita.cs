using System;
using System.ComponentModel.DataAnnotations;
using ArcaDeMoe.Models.Enums;

namespace ArcaDeMoe.Models
{
    public class Cita
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La mascota es obligatoria.")]
        [Display(Name = "Mascota")]
        public int MascotaId { get; set; }

        public Mascota? Mascota { get; set; }

        [Required(ErrorMessage = "El veterinario es obligatorio.")]
        [Display(Name = "Veterinario")]
        public int VeterinarioId { get; set; }

        public Veterinario? Veterinario { get; set; }

        [Required(ErrorMessage = "La fecha y hora son obligatorias.")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha y hora")]
        public DateTime FechaHora { get; set; }

        [Required(ErrorMessage = "El motivo es obligatorio.")]
        [StringLength(300)]
        [Display(Name = "Motivo")]
        public string Motivo { get; set; } = string.Empty;

        [Display(Name = "Estado de la cita")]
        public EstadoCita EstadoCita { get; set; } = EstadoCita.Pendiente;

        [StringLength(500)]
        [Display(Name = "Diagnóstico")]
        public string? Diagnostico { get; set; }
    }
}
