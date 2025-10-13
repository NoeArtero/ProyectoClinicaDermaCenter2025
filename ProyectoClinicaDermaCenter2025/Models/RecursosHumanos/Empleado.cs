using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Models.RecursosHumanos
{
    public class Empleado
    {
        public int Id { get; set; }

        [Required, MaxLength(100)] public string Nombres { get; set; } = "";
        [Required, MaxLength(100)] public string Apellidos { get; set; } = "";
        [Required, MaxLength(10)] public string? DUI { get; set; }

        [Required, MaxLength(60)] public string? Cargo { get; set; }       
        [ MaxLength(80)] public string? Especialidad { get; set; } // solo por si aplica al médico
        [ MaxLength(20)] public string? CodigoDoctor { get; set; } 

        [Required, MaxLength(30)] public string? Telefono { get; set; }
        [Required, MaxLength(120)] public string? Email { get; set; }

        public bool Activo { get; set; } = true;

    }
}
