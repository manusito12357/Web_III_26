using Microsoft.EntityFrameworkCore;
using bibliotecaUnivalle.Models;

namespace bibliotecaUnivalle.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
