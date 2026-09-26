using System.ComponentModel.DataAnnotations;

namespace bibliotecaUnivalle.Models
{
    public enum RolUsuario
    {
        Administrador,
        Bibliotecario,
        Usuario
    }
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo CI es obligatorio")]
        [StringLength(8, ErrorMessage = "El campo CI debe tener exactamente 8 caracteres")]
        public string ci { get; set; }


        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        [StringLength(50)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }


        [Required(ErrorMessage = "El campo apellido materno es obligatorio")]
        [StringLength(25)]
        [Display(Name = "Apellido Materno")]
        public string ApellidoMaterno { get; set; }


        [Required(ErrorMessage = "El campo apellido paterno es obligatorio")]
        [StringLength(25)]
        [Display(Name = "Apellido Paterno")]
        public string ApellidoPaterno { get; set; }


        [EmailAddress(ErrorMessage = "El campo correo no tiene un formato válido")]
        [StringLength(100)]
        [Display(Name = "Correo")]
        public string Correo { get; set; }


        [Required(ErrorMessage = "El campo contraseña es obligatorio")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "El campo contraseña debe tener " +
            "al menos 8 caracteres y un simbolo")]
        [Display(Name = "Password")]
        public string Password { get; set; }


        [Required(ErrorMessage = "El campo telefono es obligatorio")]
        [StringLength(15)]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }


        [Required(ErrorMessage = "El campo dirección es obligatorio")]
        [StringLength(100)]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        public ICollection<Prestamo> Prestamos { get; set; }
    }
}
