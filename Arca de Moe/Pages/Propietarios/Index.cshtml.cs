using ArcadeMoe.Data;
using ArcaDeMoe.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ArcaDeMoe.Pages.Propietarios
{
    public class IndexModel : PageModel
    {
        private readonly AppDbConext _context;

        public IndexModel(AppDbConext context)
        {
            _context = context;
        }
        public List<Propietario> Propietarios { get; set; } = new();

        public async Task OnGetAsync()
        {
            Propietarios = await _context.Propietarios.ToListAsync();
        }
    }
}
