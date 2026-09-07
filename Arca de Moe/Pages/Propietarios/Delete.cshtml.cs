using ArcadeMoe.Data;
using ArcaDeMoe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ArcaDeMoe.Pages.Propietarios
{
    public class DeleteModel : PageModel
    {
        private readonly AppDbConext _context;

        public DeleteModel(AppDbConext context)
        {
            _context = context;
        }
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

        public async Task<IActionResult> OnPostAsync()
        {
            var propietario = await _context.Propietarios.FindAsync(Propietario.Id);
            if (propietario != null)
            {
                _context.Propietarios.Remove(propietario);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("Index");
        }
    }
}
