using ArcadeMoe.Data;
using ArcaDeMoe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ArcaDeMoe.Pages.Propietarios
{
    public class EditModel : PageModel
    {
        private readonly AppDbConext _context;

        public EditModel(AppDbConext context)
        {
            _context = context;
        }
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Propietarios.Update(Propietario);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
