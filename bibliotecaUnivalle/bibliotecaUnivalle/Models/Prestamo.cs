using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bibliotecaUnivalle.Models
{
    public enum EstadoPrestamo
    {
        Activo,
        Devuelto,
        Atrasado
    }

    public class Prestamo
    {
        public int Id { get; set; }


        [Required]
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario? Usuario { get; set; }


        [Required]
        [Display(Name = "Libro")]
        public int LibroId { get; set; }
        [ForeignKey("LibroId")]
        public Libro? Libro { get; set; }


        [Required]
        [Display(Name = "Fecha de Préstamo")]
        public DateTime FechaPrestamo { get; set; } = DateTime.Now;


        [Required]
        [Display(Name = "Fecha de Plazo")]
        public DateTime FechaPlazo { get; set; }


        [Display(Name = "Fecha de Devolución")]
        public DateTime? FechaDevolucion { get; set; }

        [Required]
        [Display(Name = "Estado")]
        public EstadoPrestamo Estado { get; set; } = EstadoPrestamo.Activo;
    }
}
