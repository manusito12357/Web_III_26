using ArcaDeMoe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ArcaDeMoe.Pages.Mascotas
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Mascota Mascota { get; set; } = new();

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            // TODO: persistir en base de datos
            return RedirectToPage("Index");
        }
    }
}
