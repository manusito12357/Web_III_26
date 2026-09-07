using ArcadeMoe.Data;
using ArcaDeMoe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ArcaDeMoe.Pages.Veterinarios
{
    public class CreateModel : PageModel
    {
        private readonly AppDbConext _context;

        public CreateModel(AppDbConext context)
        {
            _context = context;
        }
        [BindProperty]
        public Veterinario Veterinario { get; set; } = new();

        public void OnGet() { }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Veterinarios.Add(Veterinario);
            return RedirectToPage("Index");
        }
    }
}
