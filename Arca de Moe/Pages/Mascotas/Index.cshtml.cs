using ArcaDeMoe.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace ArcaDeMoe.Pages.Mascotas
{
    public class IndexModel : PageModel
    {
        public List<Mascota> Mascotas { get; set; } = new();

        public void OnGet()
        {
           
        }
    }
}
