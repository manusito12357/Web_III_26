using ArcadeMoe.Data;
using ArcaDeMoe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ArcaDeMoe.Pages.Veterinarios
{
    public class DeleteModel : PageModel
    {
        private readonly AppDbConext _context;

        public DeleteModel(AppDbConext context)
        {
            _context = context;
        }
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

        public async Task<IActionResult> OnPostAsync()
        {
            var veterinario = await _context.Veterinarios.FindAsync(Veterinario.Id);
            if (veterinario != null)
            {
                _context.Veterinarios.Remove(veterinario);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("Index");
        }
    }
}
