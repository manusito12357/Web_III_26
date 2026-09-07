using ArcaDeMoe.Models;
using ArcaDeMoe.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace ArcaDeMoe.Pages.Citas
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Cita Cita { get; set; } = new();

        public List<SelectListItem> Mascotas { get; set; } = new();
        public List<SelectListItem> Veterinarios { get; set; } = new();
        public List<SelectListItem> EstadosCita { get; set; } = new();

        public IActionResult OnGet(int id)
        {
            // TODO: cargar desde base de datos por id
            Cita = new Cita
            {
                Id = id, MascotaId = 1, VeterinarioId = 1,
                FechaHora = new DateTime(2026, 7, 10, 9, 0, 0),
                Motivo = "Revisión general anual",
                EstadoCita = EstadoCita.Pendiente,
                Diagnostico = null
            };

            if (Cita == null)
                return NotFound();

            CargarListasDesplegables();
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                CargarListasDesplegables();
                return Page();
            }

            // TODO: actualizar en base de datos
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
