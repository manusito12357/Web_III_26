using ArcaDeMoe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ArcaDeMoe.Pages.Propietarios
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Propietario Propietario { get; set; } = new();

        public IActionResult OnGet(int id)
        {
            // TODO: cargar desde base de datos por id
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
            // TODO: eliminar de base de datos
            return RedirectToPage("Index");
        }
    }
}
