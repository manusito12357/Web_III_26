using ArcaDeMoe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ArcaDeMoe.Pages.Veterinarios
{
    public class DetailsModel : PageModel
    {
        public Veterinario Veterinario { get; set; } = new();

        public IActionResult OnGet(int id)
        {
            return Page();
        }
    }
}
