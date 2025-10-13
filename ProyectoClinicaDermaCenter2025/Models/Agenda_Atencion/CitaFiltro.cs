using ProyectoClinicaDermaCenter2025.Models.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Models.Agenda_Atencion
{
    public  class CitaFiltro
    {
        public int? PacienteId { get; set; }
        public int? EmpleadoId { get; set; }
        public DateTime? Desde { get; set; }
        public DateTime? Hasta { get; set; }
        public EstadoCita? Estado { get; set; }
    }
}
