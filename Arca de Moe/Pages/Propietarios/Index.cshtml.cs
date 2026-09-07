using ArcaDeMoe.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ArcaDeMoe.Pages.Propietarios
{
    public class IndexModel : PageModel
    {
        public List<Propietario> Propietarios { get; set; } = new();

        public void OnGet()
        {
            
        }
    }
}
