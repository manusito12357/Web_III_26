using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wa_registroestudiantes.Models
{
    public class Inscripcion
    {
        public int Id { get; set; }

        public int EstudianteId { get; set; }
        public int MateriaId { get; set; }  

        [DataType(DataType.Date)]
        public DateTime FechaInscripcion { get; set; } = DateTime.Now;

        public bool Estado { get; set; } = true;

        [ForeignKey("EstudianteId")]
        public Estudiante? Estudiante { get; set; }

        [ForeignKey("MateriaId")]
        public Materia? Materia { get; set; }
    }
}