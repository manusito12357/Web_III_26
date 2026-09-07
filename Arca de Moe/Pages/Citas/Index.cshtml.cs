using ArcaDeMoe.Models;
using ArcaDeMoe.Models.Enums;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace ArcaDeMoe.Pages.Citas
{
    public class IndexModel : PageModel
    {
        public List<Cita> Citas { get; set; } = new();

        public void OnGet()
        {
            
        }
    }
}
