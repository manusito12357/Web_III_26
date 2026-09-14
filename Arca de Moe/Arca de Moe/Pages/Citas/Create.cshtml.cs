using ArcadeMoe.Data;
using ArcaDeMoe.Models;
using ArcaDeMoe.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ArcaDeMoe.Pages.Citas
{
    public class CreateModel : PageModel
    {
        private readonly AppDbConext _context;

        public CreateModel(AppDbConext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cita? Cita { get; set; } = new();

        public List<SelectListItem> Mascotas { get; set; } = new();
        public List<SelectListItem> Veterinarios { get; set; } = new();
        public List<SelectListItem> EstadosCita { get; set; } = new();

        public void OnGet()
        {
            CargarListasDesplegables();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                CargarListasDesplegables();
                return Page();
            }

            if (Cita == null)
            {
                return BadRequest();
            }

            _context.Citas.Add(Cita);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }

        private void CargarListasDesplegables()
        {
            Mascotas = new List<SelectListItem>
            {
                new SelectListItem { Value = "1", Text = "Firulais (Labrador)" },
                new SelectListItem { Value = "2", Text = "Misu (Persa)" },
                new SelectListItem { Value = "3", Text = "Rocky (Bulldog)" }
            };

            Veterinarios = new List<SelectListItem>
            {
                new SelectListItem { Value = "1", Text = "María Torres — General" },
                new SelectListItem { Value = "2", Text = "Pedro Núñez — Cirugía" },
                new SelectListItem { Value = "3", Text = "Laura Vidal — Dermatología" }
            };

            EstadosCita = new List<SelectListItem>
            {
                new SelectListItem { Value = nameof(EstadoCita.Pendiente),  Text = "Pendiente" },
                new SelectListItem { Value = nameof(EstadoCita.Completada), Text = "Completada" },
                new SelectListItem { Value = nameof(EstadoCita.Cancelada),  Text = "Cancelada" }
            };
        }
    }
}
