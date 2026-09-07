using ArcadeMoe.Data;
using ArcaDeMoe.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ArcaDeMoe.Pages.Citas
{
    public class IndexModel : PageModel
    {
        private readonly AppDbConext _context;

        public IndexModel(AppDbConext context)
        {
            _context = context;
        }
        public List<Cita> Citas { get; set; } = new();

        public List<Propietario> Propietarios { get; set; } = new();

        public async Task OnGetAsync()
        {
            Citas = await _context.Citas.ToListAsync();
        }
    }
}
