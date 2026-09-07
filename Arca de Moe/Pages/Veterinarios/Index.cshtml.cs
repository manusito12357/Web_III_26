using ArcaDeMoe.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ArcaDeMoe.Pages.Veterinarios
{
    public class IndexModel : PageModel
    {
        public List<Veterinario> Veterinarios { get; set; } = new();

        public void OnGet()
        {
            
        }
    }
}
