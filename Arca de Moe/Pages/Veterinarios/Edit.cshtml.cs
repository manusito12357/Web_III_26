using ArcaDeMoe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ArcaDeMoe.Pages.Veterinarios
{
    public class EditModel : PageModel
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
            if (!ModelState.IsValid)
                return Page();

            // TODO: actualizar en base de datos
            return RedirectToPage("Index");
        }
    }
}
