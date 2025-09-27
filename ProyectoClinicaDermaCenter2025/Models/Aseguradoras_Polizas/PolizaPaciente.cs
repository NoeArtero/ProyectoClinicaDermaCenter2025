using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Models.Aseguradoras_Polizas
{
    public class PolizaPaciente
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public int AseguradoraId { get; set; }

        [Required, MaxLength(60)] public string NumeroPoliza { get; set; } = "";
        [MaxLength(80)] public string? Plan { get; set; }

        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public bool Activa { get; set; } = true;

    }
}
