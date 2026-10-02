using clinica.Models;
using System.ComponentModel.DataAnnotations;

namespace clinica.Models
{
    public class Cita
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public Paciente? Paciente { get; set; }
        public int MedicoId { get; set; }
        public Medico? Medico { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime FechaHora { get; set; }

        [StringLength(200)]
        [Display(Name = "Motivo")]
        public string? Motivo { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Estado")]
        public string Estado { get; set; } = "Programada";

    }
}