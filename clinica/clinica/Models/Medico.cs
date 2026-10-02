using System.ComponentModel.DataAnnotations;

namespace clinica.Models
{
    public class Medico
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo ci es obligatorio")]
        [StringLength(8, ErrorMessage = "Un ci no puede superar los 8 caracteres")]
        [Display(Name = "ci")]
        public string ci { get; set; }


        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        [StringLength(50)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }


        [Required(ErrorMessage = "El campo Apellido Materno es obligatorio")]
        [StringLength(25)]
        [Display(Name = "Apellido Materno")]
        public string ApellidoMaterno { get; set; }


        [Required(ErrorMessage = "El campo Apellido Paterno es obligatorio")]
        [StringLength(25)]
        [Display(Name = "Apellido Paterno")]
        public string ApellidoPaterno { get; set; }


        [Required(ErrorMessage = "El campo Telefono es obligatorio")]
        [StringLength(15)]
        [Display(Name = "Telefono")]
        public string Telefono { get; set; }


        [StringLength(100)]
        [Display(Name = "Correo")]
        public string? Correo { get; set; }


        [Required(ErrorMessage = "El campo Especialidad es obligatorio")]
        [StringLength(50)]
        [Display(Name = "Especialidad")]
        public string Especialidad { get; set; }


        [StringLength(100)]
        [Display(Name = "Direccion")]
        public string? Direccion { get; set; }
        
        public ICollection<Cita>? Citas { get; set; }
    }
}
