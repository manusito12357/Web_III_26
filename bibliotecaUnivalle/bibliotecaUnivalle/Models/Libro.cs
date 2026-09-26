using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bibliotecaUnivalle.Models
{
    public class Libro
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "El campo título es obligatorio")]
        [StringLength(100)]
        [Display(Name = "Titulo")]
        public string Titulo { get; set; }


        [Required(ErrorMessage = "El campo autor es obligatorio")]
        [StringLength(100)]
        [Display(Name = "Autor")]
        public string Autor { get; set; }


        [Required(ErrorMessage = "El campo editorial es obligatorio")]
        [StringLength(100)]
        [Display(Name = "Editorial")]
        public string Editorial { get; set; }


        [Required(ErrorMessage = "El campo año de publicación es obligatorio")]
        [Range(1900, 2100, ErrorMessage = "El año de publicación debe estar entre 1900 y 2100")]
        [Display(Name = "Año de Publicación")]
        public int AnioPublicacion { get; set; }


        [Required(ErrorMessage = "El campo género es obligatorio")]
        [StringLength(50)]
        [Display(Name = "Genero")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "La cantidad total es obligatoria")]
        [Display(Name = "Cantidad")]
        public int Cantidad { get; set; }


        [Display(Name = "Imagen")]
        public string? ImagenUrl { get; set; }


        [Required(ErrorMessage = "La categoría es obligatoria")]
        [Display(Name = "Categoría")]
        public int CategoriaId { get; set; }


        [ForeignKey("CategoriaId")]
        public Categoria? Categoria { get; set; }

        public ICollection<Prestamo>? Prestamos { get; set; }
    }
}
