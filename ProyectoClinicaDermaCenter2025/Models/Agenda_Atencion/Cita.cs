using ProyectoClinicaDermaCenter2025.Models.Comun;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Models.Agenda_Atencion
{
    public class Cita
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public int EmpleadoId { get; set; } 

        public DateTime FechaHoraInicio { get; set; }
        public DateTime FechaHoraFin { get; set; }

        [MaxLength(300)] public string? NotasPrevias { get; set; }

        public EstadoCita Estado { get; set; } = EstadoCita.Programada;
        public DateTime FechaRegistro { get; set; } = DateTime.Now;

    }
}
