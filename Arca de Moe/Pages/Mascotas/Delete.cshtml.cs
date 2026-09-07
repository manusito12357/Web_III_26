using ArcadeMoe.Data;
using ArcaDeMoe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace ArcaDeMoe.Pages.Mascotas
{
    public class DeleteModel : PageModel
    {
        private readonly AppDbConext _context;

        public DeleteModel(AppDbConext context)
        {
            _context = context;
        }
        [BindProperty]
        public Mascota Mascota { get; set; } = new();

        public IActionResult OnGet(int id)
        {
            // TODO: cargar desde base de datos por id
            Mascota = new Mascota
            {
                Id = id, PropietarioId = 1, Nombre = "Firulais",
                Especie = "Perro", Raza = "Labrador",
                FechaNacimiento = new DateTime(2020, 3, 15), Estado = true
            };

            if (Mascota == null)
                return NotFound();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var mascota = await _context.Mascotas.FindAsync(Mascota.Id);
            if (mascota != null)
            {
                _context.Mascotas.Remove(mascota);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("Index");
        }
    }
}
