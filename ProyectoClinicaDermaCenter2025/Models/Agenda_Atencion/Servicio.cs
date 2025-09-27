using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.Models.Agenda_Atencion
{
    public class Servicio
    {
        public int Id { get; set; }
        [Required, MaxLength(120)] public string Nombre { get; set; } = "";
        [MaxLength(300)] public string? Descripcion { get; set; }

        [Range(0, 999999)] public decimal CostoBase { get; set; }
        [Range(0, 1440)] public int DuracionEstimadaMin { get; set; } = 30;
        public bool Activo { get; set; } = true;

    }
}
