using Microsoft.EntityFrameworkCore;
using wa_registroestudiantes.Models;

namespace wa_registroestudiantes.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Inscripcion> Inscripciones { get; set; }
    }
}
