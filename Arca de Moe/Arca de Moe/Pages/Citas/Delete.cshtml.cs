using ArcadeMoe.Data;
using ArcaDeMoe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ArcaDeMoe.Pages.Citas
{
    public class DeleteModel : PageModel
    {
        private readonly AppDbConext _context;

        public DeleteModel(AppDbConext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cita? Cita { get; set; } = new();

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Cita = await _context.Citas
                .Include(c => c.Mascota)
                .Include(c => c.Veterinario)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (Cita == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            Cita = await _context.Citas.FindAsync(id);

            if (Cita != null)
            {
                _context.Citas.Remove(Cita);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("Index");
        }
    }
}
