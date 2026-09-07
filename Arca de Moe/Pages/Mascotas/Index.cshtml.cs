using ArcadeMoe.Data;
using ArcaDeMoe.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace ArcaDeMoe.Pages.Mascotas
{
    public class IndexModel : PageModel
    {
        private readonly AppDbConext _context;

        public IndexModel(AppDbConext context)
        {
            _context = context;
        }
        public List<Mascota> Mascotas { get; set; } = new();

        public async Task OnGetAsync()
        {
            Mascotas = await _context.Mascotas.ToListAsync();
        }
    }
}
