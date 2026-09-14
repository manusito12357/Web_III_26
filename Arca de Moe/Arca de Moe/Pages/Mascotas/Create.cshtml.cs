using ArcadeMoe.Data;
using ArcaDeMoe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ArcaDeMoe.Pages.Mascotas
{
    public class CreateModel : PageModel
    {
        private readonly AppDbConext _context;

        public CreateModel(AppDbConext context)
        {
            _context = context;
        }
        [BindProperty]
        public Mascota Mascota { get; set; } = new();

        public void OnGet() { }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Mascotas.Add(Mascota);
            return RedirectToPage("Index");
        }
    }
}
