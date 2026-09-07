using ArcaDeMoe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ArcaDeMoe.Pages.Propietarios
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Propietario Propietario { get; set; } = new();

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            // TODO: persistir en base de datos
            // Por ahora solo redirige al índice
            return RedirectToPage("Index");
        }
    }
}
