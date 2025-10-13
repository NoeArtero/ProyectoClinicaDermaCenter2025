using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Models.Agenda_Atencion
{
    public class Atencion
    {
        public int Id { get; set; }
        public int CitaId { get; set; } 

        public DateTime FechaHoraInicio { get; set; }
        public DateTime FechaHoraFin { get; set; }

        [MaxLength(300)] public string? Diagnostico { get; set; }
        [MaxLength(300)] public string? TratamientoRecomendado { get; set; }
        [MaxLength(300)] public string? Observaciones { get; set; }

    }
}
