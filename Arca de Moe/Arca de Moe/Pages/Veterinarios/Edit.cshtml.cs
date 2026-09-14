using ArcadeMoe.Data;
using ArcaDeMoe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ArcaDeMoe.Pages.Veterinarios
{
    public class EditModel : PageModel
    {
        private readonly AppDbConext _context;

        public EditModel(AppDbConext context)
        {
            _context = context;
        }
        [BindProperty]
        public Veterinario Veterinario { get; set; } = new();

        public IActionResult OnGet(int id)
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Veterinarios.Update(Veterinario);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
