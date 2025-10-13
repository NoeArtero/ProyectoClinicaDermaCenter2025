using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Models.Pacientes
{
    public class Paciente
    {
        public int Id { get; set; }

        [Required, MaxLength(100)] public string Nombres { get; set; } = "";
        [Required, MaxLength(100)] public string Apellidos { get; set; } = "";
        [MaxLength(10)] public string? DUI { get; set; }

        public DateTime? FechaNacimiento { get; set; }
        [MaxLength(200)] public string? Direccion { get; set; }
        [Required, MaxLength(30)] public string? Telefono { get; set; }
        [MaxLength(120), EmailAddress] public string? Email { get; set; }

        // Clínico 
        [MaxLength(300)] public string? Alergias { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
        public bool Activo { get; set; } = true;

        public string NombreCompleto => $"{Nombres} {Apellidos}".Trim();

    }
}
