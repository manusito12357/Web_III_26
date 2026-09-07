using ArcaDeMoe.Models;
using ArcaDeMoe.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace ArcaDeMoe.Pages.Citas
{
    public class DetailsModel : PageModel
    {
        public Cita Cita { get; set; } = new();

        public IActionResult OnGet(int id)
        {
            return Page();
        }
    }
}
