using ArcaDeMoe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ArcaDeMoe.Pages.Propietarios
{
    public class DetailsModel : PageModel
    {
        public Propietario Propietario { get; set; } = new();

        public IActionResult OnGet(int id)
        {

            return Page();
        }
    }
}
