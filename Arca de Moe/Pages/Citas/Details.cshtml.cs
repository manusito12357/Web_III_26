using ArcaDeMoe.Models;
using ArcaDeMoe.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace ArcaDeMoe.Pages.Citas
{
    public class DetailsModel : PageModel
    {
        public Cita Cita { get; set; } = new();

        public IActionResult OnGet(int id)
        {
            // TODO: cargar desde base de datos por id
            Cita = new Cita
            {
                Id = id,
                MascotaId = 1,
                Mascota = new Mascota { Id = 1, Nombre = "Firulais" },
                VeterinarioId = 1,
                Veterinario = new Veterinario { Id = 1, Nombre = "María", Apellidos = "Torres Paz" },
                FechaHora = new DateTime(2026, 7, 10, 9, 0, 0),
                Motivo = "Revisión general anual",
                EstadoCita = EstadoCita.Pendiente,
                Diagnostico = null
            };

            if (Cita == null)
                return NotFound();

            return Page();
        }
    }
}
