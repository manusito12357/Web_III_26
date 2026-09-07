using ArcaDeMoe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ArcaDeMoe.Pages.Propietarios
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Propietario Propietario { get; set; } = new();

        public IActionResult OnGet(int id)
        {
            // TODO: cargar desde base de datos por id
            // Datos de ejemplo para mostrar el formulario precargado
            Propietario = new Propietario
            {
                Id = id,
                Nombre = "Carlos",
                Apellidos = "Ramírez López",
                Telefono = "555-1234",
                Email = "carlos@email.com",
                Estado = true
            };

            if (Propietario == null)
                return NotFound();

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            // TODO: actualizar en base de datos
            return RedirectToPage("Index");
        }
    }
}
