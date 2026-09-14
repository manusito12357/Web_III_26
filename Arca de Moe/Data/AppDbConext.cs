using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ArcaDeMoe.Models;
namespace ArcadeMoe.Data
{
    public class AppDbConext : IdentityDbContext<ApplicationUser>
    {
        public AppDbConext(DbContextOptions<AppDbConext> options) : base(options)
        {
        }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Propietario> Propietarios { get; set; }
        public DbSet<Veterinario> Veterinarios
        {
            get; set;
        }
    }
}
