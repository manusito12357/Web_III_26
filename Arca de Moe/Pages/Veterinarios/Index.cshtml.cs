using ArcadeMoe.Data;
using ArcaDeMoe.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ArcaDeMoe.Pages.Veterinarios
{
    public class IndexModel : PageModel
    {
        private readonly AppDbConext _context;

        public IndexModel(AppDbConext context)
        {
            _context = context;
        }
        public List<Veterinario> Veterinarios { get; set; } = new();

        public async Task OnGetAsync()
        {
            Veterinarios = await _context.Veterinarios.ToListAsync();
        }
    }
}
