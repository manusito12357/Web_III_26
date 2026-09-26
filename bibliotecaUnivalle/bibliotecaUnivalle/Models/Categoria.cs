using System.ComponentModel.DataAnnotations;

namespace bibliotecaUnivalle.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        [StringLength(50)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        public ICollection<Libro> Libros { get; set; }
    }
}
