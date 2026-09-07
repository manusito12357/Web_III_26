using ArcaDeMoe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace ArcaDeMoe.Pages.Mascotas
{
    public class DetailsModel : PageModel
    {
        public Mascota Mascota { get; set; } = new();

        public IActionResult OnGet(int id)
        {
            return Page();
        }
    }
}
