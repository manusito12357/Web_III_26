using System.ComponentModel.DataAnnotations;

namespace wa_registroestudiantes.Models
{
    public class Inscripcion
    { 
        public int Id { get; set; }
        public int EstudianteId { get; set; }

        public string MateriaId { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaInscripcion { get; set; }

        public bool Estado { get; set; } = true;

        public Estudiante? Estudiante { get; set; }

        public Materia? Materia { get; set; }

        public ICollection<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();

    }
}
