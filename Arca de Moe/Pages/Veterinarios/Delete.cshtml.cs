using ArcaDeMoe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ArcaDeMoe.Pages.Veterinarios
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Veterinario Veterinario { get; set; } = new();

        public IActionResult OnGet(int id)
        {
            // TODO: cargar desde base de datos por id
            Veterinario = new Veterinario
            {
                Id = id, Nombre = "María", Apellidos = "Torres Paz",
                Especialidad = "General", Telefono = "555-3001", Estado = true
            };

            if (Veterinario == null)
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
